-- ===========================================================
-- Tạo một thư mục để chứa các tệp sao lưu:
-- ============================================================

-- Bước 1: Tạo thư mục để chứa các tệp sao lưu
-- mkdir -p /opt/oracle/backup_dp/dpump
-- Bước 2: Cấp quyền cho Oracle user để có thể ghi vào thư mục này
-- Kết nối vào sqlplus với quyền SYSDBA: sqlplus / as sysdba
-- Chạy sql: 
-- CREATE OR REPLACE DIRECTORY dpump_dir AS '/opt/oracle/backup_dp/dpump';
-- GRANT READ, WRITE ON DIRECTORY dpump_dir TO C##ADMIN;


-- Chuẩn bị dữ liệu đã test
-- CREATE USER C##dptest IDENTIFIED BY 123456;
-- GRANT CONNECT, RESOURCE TO C##dptest;

-- Kết nối vào sqlplus với user C##dptest: sqlplus C##dptest/123@localhost:1521/<service_name>
-- Sau đó tạo bảng 
-- CREATE TABLE employees ( id NUMBER PRIMARY KEY, name VARCHAR2(100), salary NUMBER);

-- ============================================================
--                   Sao lưu bằng Data Pump
-- ============================================================

-- Bước 1: Mở cmd và chạy Data Pump Export
-- expdp C##ADMIN/123456@localhost:1521/<service_name> DIRECTORY=dpump_dir DUMPFILE=schema_test.dmp LOGFILE=export_test.log SCHEMAS=C##dptest
-- Bước 2: Kiểm tra tệp sao lưu đã được tạo: ls /opt/oracle/backup_dp/dpump 

-- Kết nối vào sqlplus với quyền SYSDBA: sqlplus C##ADMIN/123456@localhost:1521/<service_name>\
-- Tạo tình huống mất dữ liệu
DROP USER C##dptest CASCADE;

-- Thử truy vấn bảng trong C##dptest sẽ báo lỗi
SELECT * FROM C##dptest.employees;

-- ============================================================
--                   Phục hồi bằng Data Pump
-- ============================================================

-- Bước 1: Mở cmd và chạy Data Pump Import
-- impdp C##ADMIN/123456@localhost:1521/<service_name> DIRECTORY=dpump_dir DUMPFILE=schema_test.dmp LOGFILE=export_test.log SCHEMAS=C##dptest
-- Bước 2: Kiểm tra dữ liệu sau phục hồi
SELECT * FROM C##dptest.employees;