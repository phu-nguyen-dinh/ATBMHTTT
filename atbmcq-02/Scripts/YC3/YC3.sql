-- 1
SHOW PARAMETER audit_trail;

--2 Audit theo đối tượng (bảng DANGKY) – áp dụng cho tất cả user
AUDIT SELECT, INSERT, UPDATE, DELETE
ON C##ADMIN.DANGKY
BY ACCESS
WHENEVER SUCCESSFUL;

--3 a
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'DANGKY',
    policy_name     => 'FGA_DIEM_NOT_PKT',
    audit_column    => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',
    audit_condition => 'SYS_CONTEXT(''USERENV'',''SESSION_USER'') NOT IN (
                          SELECT MANLD FROM NHANVIEN WHERE VAITRO = ''NV PKT'')',
    audit_column_opts => DBMS_FGA.ANY_COLUMNS,
    statement_types => 'UPDATE',
    enable          => TRUE
  );
END;
/
--3 b
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'NHANVIEN',
    policy_name     => 'FGA_LUONG_PHUCAP_NOT_TCHC',
    audit_column    => 'LUONG,PHUCAP',
    audit_condition => 'SYS_CONTEXT(''USERENV'',''SESSION_USER'') NOT IN (
                          SELECT MANLD FROM NHANVIEN WHERE VAITRO = ''NV TCHC'')',
    statement_types => 'SELECT, UPDATE',
    enable          => TRUE
  );
END;
/
-- 3c
-- Function kiểm tra thời gian đăng ký/hiệu chỉnh học phần
CREATE OR REPLACE FUNCTION IS_REG_PERIOD_OPEN(
    p_mamm IN VARCHAR2
) RETURN NUMBER
IS
    v_hk_start_date DATE;
    v_reg_end_date DATE;
    v_hk NUMBER;
    v_nam_hoc_start_year NUMBER;
BEGIN
    -- Lấy thông tin HK, NAM từ MAMM (trong bảng MOMON)
    BEGIN
        SELECT HK, NAM
        INTO v_hk, v_nam_hoc_start_year
        FROM MOMON
        WHERE MAMM = p_mamm;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN 0; -- MAMM không tồn tại, coi như ngoài thời gian
    END;

    -- Xác định ngày bắt đầu học kỳ
    IF v_hk = 1 THEN
        v_hk_start_date := TO_DATE('01-SEP-' || TO_CHAR(v_nam_hoc_start_year), 'DD-MON-YYYY');
    ELSIF v_hk = 2 THEN
        v_hk_start_date := TO_DATE('01-JAN-' || TO_CHAR(v_nam_hoc_start_year + 1), 'DD-MON-YYYY');
    ELSIF v_hk = 3 THEN
        v_hk_start_date := TO_DATE('01-MAY-' || TO_CHAR(v_nam_hoc_start_year + 1), 'DD-MON-YYYY');
    ELSE
        RETURN 0; -- Học kỳ không hợp lệ
    END IF;

    -- Thời gian cho phép đăng ký là 14 ngày kể từ ngày bắt đầu học kỳ
    -- (tức là ngày cuối cùng là start_date + 13 ngày)
    v_reg_end_date := v_hk_start_date + 13;

    IF TRUNC(SYSDATE) BETWEEN TRUNC(v_hk_start_date) AND TRUNC(v_reg_end_date) THEN
        RETURN 1;
    ELSE
        RETURN 0;
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        RETURN 0;
END;
/

BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'DANGKY',
    policy_name     => 'FGA_DANGKY_SV_OTHER_OR_INVALIDTIME',
    audit_condition => '(MASV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')) OR ' ||
                       '(IS_REG_PERIOD_OPEN(MAMM) = 0)',
    statement_types => 'INSERT, UPDATE, DELETE',
    enable          => TRUE
  );
END;
/
-- 4
SELECT * FROM DBA_AUDIT_TRAIL WHERE OBJ_NAME = 'DANGKY';
SELECT * FROM DBA_AUDIT_TRAIL WHERE USERNAME = 'SV0001';