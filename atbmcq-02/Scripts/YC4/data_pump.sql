-- ===========================================================
-- Tạo một thư mục để chứa các tệp sao lưu:
-- ============================================================

-- Bước 1: Tạo thư mục để chứa các tệp sao lưu
-- mkdir -p /opt/oracle/backups_test/dpump
-- Bước 2: Cấp quyền cho Oracle user để có thể ghi vào thư mục này
-- Kết nối vào sqlplus với quyền SYSDBA: sqlplus / C##ADMIN/123456@localhost:1521/<service_name>
-- Chạy sql: 
/*
CREATE OR REPLACE DIRECTORY dpump_dir AS '/opt/oracle/backups_test/dpump';
GRANT READ, WRITE ON DIRECTORY dpump_dir TO C##ADMIN;
exit;
*/

-- ============================================================
--                   Sao lưu bằng Data Pump
-- ============================================================

-- Bước 1: Mở cmd và chạy Data Pump Export
-- expdp C##ADMIN/123456@localhost:1521/<service_name> DIRECTORY=dpump_dir DUMPFILE=schema_backup.dmp LOGFILE=export.log SCHEMAS=C##ADMIN
-- Bước 2: Kiểm tra tệp sao lưu đã được tạo: ls /opt/oracle/backups_test/dpump/schema_backup.dmp 

-- Tạo tình huống mất dữ liệu
-- Tâm chưa nghĩ ra tình huống mất dữ liệu để test Data Pump

-- ============================================================
--                   Phục hồi bằng Data Pump
-- ============================================================

-- Bước 1: Mở cmd và chạy Data Pump Import
-- impdp C##ADMIN/123456@localhost:1521/<service_name> DIRECTORY=dpump_dir DUMPFILE=schema_backup.dmp LOGFILE=import.log SCHEMAS=C##ADMIN
-- Bước 2: Kiểm tra dữ liệu sau phục hồi
