-- Xoá các objects đã có
BEGIN
     EXECUTE IMMEDIATE 'DROP ROLE R_NV_PKT';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

BEGIN
    EXECUTE IMMEDIATE 'DROP TRIGGER TRG_DANGKY_REGISTRATION_PERIOD';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

BEGIN
    EXECUTE IMMEDIATE 'DROP TRIGGER TRG_DANGKY_SET_NULL_SCORES';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

BEGIN
  DBMS_RLS.DROP_POLICY (
    object_schema   => 'C##ADMIN',
    object_name     => 'DANGKY',
    policy_name     => 'dangky_access_policy'
  );
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

BEGIN
    EXECUTE IMMEDIATE 'DROP FUNCTION IS_REGISTRATION_PERIOD_OPEN_FUNC';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

BEGIN
    EXECUTE IMMEDIATE 'DROP FUNCTION GET_HOCKY_START_DATE';
EXCEPTION WHEN OTHERS THEN NULL;
END;
/

-- 1. Tạo Role cho Nhân viên Phòng Khảo Thí
CREATE ROLE R_NV_PKT;

-- 2. Các hàm hỗ trợ
-- Hàm xác định ngày bắt đầu học kỳ
CREATE OR REPLACE FUNCTION GET_HOCKY_START_DATE(
    p_hk IN VARCHAR2,
    p_nam IN VARCHAR2 -- Format 'YYYY-YYYY', ví dụ '2023-2024'
) RETURN DATE
IS
    v_start_year VARCHAR2(4);
    v_end_year VARCHAR2(4);
    v_start_date DATE;
BEGIN
    IF p_nam IS NULL OR p_hk IS NULL THEN
        RETURN NULL;
    END IF;

    v_start_year := SUBSTR(p_nam, 1, 4);
    v_end_year   := SUBSTR(p_nam, 6, 4);

    IF p_hk = '1' THEN -- Học kỳ 1 bắt đầu tháng 9
        v_start_date := TO_DATE('01-09-' || v_start_year, 'DD-MM-YYYY');
    ELSIF p_hk = '2' THEN -- Học kỳ 2 bắt đầu tháng 1 năm kế tiếp của năm học
        v_start_date := TO_DATE('01-01-' || v_end_year, 'DD-MM-YYYY');
    ELSIF p_hk = '3' THEN -- Học kỳ 3 bắt đầu tháng 5 năm kế tiếp của năm học
        v_start_date := TO_DATE('01-05-' || v_end_year, 'DD-MM-YYYY');
    ELSE
        v_start_date := NULL; -- Học kỳ không hợp lệ
    END IF;
    RETURN v_start_date;
END;
/

-- Hàm kiểm tra thời gian đăng ký học phần (14 ngày đầu)
CREATE OR REPLACE FUNCTION IS_REGISTRATION_PERIOD_OPEN_FUNC(
    p_mamm IN DANGKY.MAMM%TYPE
) RETURN INTEGER -- 1 for open, 0 for closed
IS
    v_hk MOMON.HK%TYPE;
    v_nam MOMON.NAM%TYPE;
    v_hocky_start_date DATE;
    v_registration_end_date DATE;
BEGIN
    IF p_mamm IS NULL THEN RETURN 0; END IF;
    
    BEGIN
        SELECT HK, NAM INTO v_hk, v_nam
        FROM C##ADMIN.MOMON
        WHERE MAMM = p_mamm;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN 0; -- Không tìm thấy thông tin môn mở
    END;

    v_hocky_start_date := GET_HOCKY_START_DATE(v_hk, v_nam);

    IF v_hocky_start_date IS NULL THEN
        RETURN 0; -- Ngày bắt đầu học kỳ không xác định được
    END IF;

    -- 14 ngày đầu là từ ngày bắt đầu đến ngày bắt đầu + 13 ngày
    v_registration_end_date := v_hocky_start_date + 13; 

    IF TRUNC(SYSDATE) >= TRUNC(v_hocky_start_date) AND TRUNC(SYSDATE) <= TRUNC(v_registration_end_date) THEN
        RETURN 1; -- Trong thời gian đăng ký
    ELSE
        RETURN 0; -- Ngoài thời gian đăng ký
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        RETURN 0; -- Lỗi thì coi như đóng
END;
/

-- Cấp quyền thực thi cho các hàm này (cho PUBLIC hoặc các role cụ thể)
GRANT EXECUTE ON GET_HOCKY_START_DATE TO PUBLIC;
GRANT EXECUTE ON IS_REGISTRATION_PERIOD_OPEN_FUNC TO PUBLIC;
GRANT EXECUTE ON get_vaitro TO PUBLIC;


-- 3. Policy Function cho bảng ĐANGKY
CREATE OR REPLACE FUNCTION dangky_policy_fn (
  p_schema_name IN VARCHAR2,
  p_object_name IN VARCHAR2
)
RETURN VARCHAR2
AS
    v_predicate VARCHAR2(4000);
    v_user VARCHAR2(100) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_role NVARCHAR2(50);
BEGIN
    -- Admin có toàn quyền
    IF v_user = 'C##ADMIN' THEN
        RETURN '1=1';
    END IF;

    -- Lấy vai trò của user. Hàm get_vaitro phải tồn tại và trả về đúng vai trò
    -- như 'SINHVIEN', 'GV', N'NV PĐT', N'NV PKT'
    v_role := get_vaitro(v_user); 

    IF v_role = 'SINHVIEN' THEN
        -- Sinh viên chỉ thấy đăng ký của chính mình
        v_predicate := 'MASV = ''' || v_user || '''';
    ELSIF v_role = 'GV' THEN
        -- Giảng viên thấy đăng ký của các lớp học phần mình dạy
        v_predicate := 'MAMM IN (SELECT MAMM FROM MOMON WHERE MAGV = ''' || v_user || ''')';
    ELSIF v_role = N'NV PĐT' THEN -- Nhân viên Phòng Đào tạo
        -- NV PĐT thấy tất cả, việc giới hạn thao tác sẽ do trigger đảm nhiệm
        v_predicate := '1=1'; 
    ELSIF v_role = N'NV PKT' THEN -- Nhân viên Phòng Khảo thí
        -- NV PKT thấy tất cả, quyền cập nhật điểm sẽ do GRANT cột đảm nhiệm
        v_predicate := '1=1';
    ELSE
        -- Các trường hợp khác không thấy gì
        v_predicate := '1=0'; 
    END IF;

    RETURN v_predicate;
END;
/

-- 4. Triggers
-- Trigger kiểm tra thời gian đăng ký/điều chỉnh (14 ngày) cho SV và NV PĐT
CREATE OR REPLACE TRIGGER TRG_DANGKY_REGISTRATION_PERIOD
BEFORE INSERT OR UPDATE OR DELETE ON DANGKY
FOR EACH ROW
DECLARE
    v_user VARCHAR2(100) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_role NVARCHAR2(50);
    v_mamm_to_check DANGKY.MAMM%TYPE;
BEGIN
    v_role := get_vaitro(v_user);

    IF v_role = 'SINHVIEN' OR v_role = N'NV PĐT' THEN
        IF INSERTING THEN
            v_mamm_to_check := :NEW.MAMM;
        ELSIF UPDATING OR DELETING THEN
            v_mamm_to_check := :OLD.MAMM;
        END IF;

        -- Kiểm tra nếu đang trong thời gian cho phép
        IF IS_REGISTRATION_PERIOD_OPEN_FUNC(v_mamm_to_check) = 0 THEN -- 0 là đóng
            RAISE_APPLICATION_ERROR(-20001, 'Hết thời gian đăng ký/điều chỉnh học phần hoặc thông tin học kỳ không hợp lệ.');
        END IF;
    END IF;
END;
/

-- Trigger đặt điểm thành NULL cho SV và NV PĐT khi họ INSERT/UPDATE
CREATE OR REPLACE TRIGGER TRG_DANGKY_SET_NULL_SCORES
BEFORE INSERT OR UPDATE ON DANGKY
FOR EACH ROW
DECLARE
    v_user VARCHAR2(100) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_role NVARCHAR2(50);
BEGIN
    v_role := get_vaitro(v_user);

    IF v_role = 'SINHVIEN' OR v_role = N'NV PĐT' THEN
        -- Nếu là SV hoặc NV PĐT thao tác, các cột điểm phải là NULL
        -- Điều này áp dụng cho cả INSERT và UPDATE
        :NEW.DIEMTH := NULL;
        :NEW.DIEMQT := NULL;
        :NEW.DIEMCK := NULL;
        :NEW.DIEMTK := NULL;
    END IF;
END;
/

-- 5. Cấp quyền trên bảng ĐANGKY cho các role
-- SV (Role SINHVIEN đã tạo ở Câu 2)
GRANT SELECT, INSERT, UPDATE, DELETE ON C##ADMIN.DANGKY TO SINHVIEN;

-- NV PĐT (Role NVPDT đã tạo ở Câu 2)
GRANT SELECT, INSERT, UPDATE, DELETE ON C##ADMIN.DANGKY TO NVPDT;

-- NV PKT (Role R_NV_PKT vừa tạo)
GRANT SELECT ON C##ADMIN.DANGKY TO R_NV_PKT;
GRANT UPDATE (DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON C##ADMIN.DANGKY TO R_NV_PKT;

-- GV (Role GV đã tạo ở Câu 2)
GRANT SELECT ON C##ADMIN.DANGKY TO GV;


-- 6. Áp dụng Policy vào bảng ĐANGKY
BEGIN
  DBMS_RLS.ADD_POLICY (
    object_schema     => 'C##ADMIN',
    object_name       => 'DANGKY',
    policy_name       => 'dangky_access_policy',
    function_schema   => 'C##ADMIN',
    policy_function   => 'dangky_policy_fn',
    statement_types   => 'SELECT, INSERT, UPDATE, DELETE', -- Áp dụng cho các thao tác này
    update_check      => TRUE,  -- Kiểm tra policy sau khi update
    enable            => TRUE
  );
END;
/

COMMIT;