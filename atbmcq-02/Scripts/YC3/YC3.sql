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
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'C##ADMIN',
    object_name     => 'DANGKY',
    policy_name     => 'FGA_DANGKY_SV_OTHER_OR_INVALIDTIME',
    audit_condition => 'MASV != SYS_CONTEXT(''USERENV'',''SESSION_USER'')',
    statement_types => 'INSERT, UPDATE, DELETE',
    enable          => TRUE
  );
END;
/
-- 4
SELECT * FROM DBA_AUDIT_TRAIL WHERE OBJ_NAME = 'DANGKY';
SELECT * FROM DBA_AUDIT_TRAIL WHERE USERNAME = 'SV0001';