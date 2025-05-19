GRANT SELECT, INSERT, UPDATE, DELETE ON C##ADMIN.SINHVIEN TO PUBLIC;

CREATE OR REPLACE FUNCTION POLICY_SINHVIEN (
    schema_name IN VARCHAR2,
    table_name  IN VARCHAR2
)
RETURN VARCHAR2
AS
    v_user   VARCHAR2(30);
    v_vaitro VARCHAR2(30);
    v_madv   VARCHAR2(30);
BEGIN
    v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Lấy vai trò và mã đơn vị nếu có
    BEGIN
        SELECT VAITRO, MADV
        INTO v_vaitro, v_madv
        FROM NHANVIEN
        WHERE MANLD = v_user;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            v_vaitro := NULL;
    END;
    
    -- Nếu là C##ADMIN
    IF v_user = 'C##ADMIN' THEN
        RETURN '1=1';
    
    -- Nếu là sinh viên
    ELSIF v_user LIKE 'SV%' THEN
        RETURN 'MASV = ''' || v_user || '''';

    -- Nếu là giảng viên
    ELSIF v_vaitro LIKE 'GV%' THEN
        RETURN 'KHOA = ''' || v_madv || '''';

    -- Nếu là nhân viên phòng CTSV
    ELSIF v_vaitro LIKE 'NV CTSV%' THEN
        RETURN '1=1';

    -- Nếu là nhân viên PĐT
    ELSIF v_vaitro LIKE 'NV PĐT%' THEN
        RETURN '1=1';
    END IF;

    RETURN '1=0'; -- các vai trò khác bị chặn
END;
/

CREATE OR REPLACE TRIGGER TRG_TINHTRANG_PCTSV -- Trigger để khi NV CTSV insert, update dữ liệu vào thì cột TinhTrang luôn NULL
BEFORE INSERT OR UPDATE ON SINHVIEN
FOR EACH ROW
DECLARE
    v_role VARCHAR2(20);
BEGIN
    SELECT VAITRO INTO v_role
    FROM NHANVIEN
    WHERE MANLD = SYS_CONTEXT('USERENV', 'SESSION_USER');

    IF v_role = 'NV CTSV' THEN
        :NEW.TINHTRANG := NULL;
    END IF;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        NULL; -- Không làm gì nếu không tìm thấy user trong NHANVIEN
END;
/

BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'C##ADMIN',
        object_name     => 'SINHVIEN',
        policy_name     => 'VPD_POLICY_SINHVIEN',
        function_schema => 'C##ADMIN',
        policy_function => 'POLICY_SINHVIEN',
        statement_types => 'SELECT, INSERT, UPDATE, DELETE',
        update_check    => TRUE
    );
END;
/


/*BEGIN -- Xóa policy
    DBMS_RLS.DROP_POLICY(
        object_schema => 'C##ADMIN',
        object_name   => 'SINHVIEN',
        policy_name   => 'VPD_POLICY_SINHVIEN'
    );
END;
*/
