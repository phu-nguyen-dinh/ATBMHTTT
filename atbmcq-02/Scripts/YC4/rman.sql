-- Điều kiện bắt buộc: database phải ở chế độ ARCHIVELOG
-- Chạy trong SQL*Plus với quyền SYSDBA để bật chế độ ARCHIVELOG
/* 
SHUTDOWN IMMEDIATE;
STARTUP MOUNT;
ALTER DATABASE ARCHIVELOG;
ALTER DATABASE OPEN;
ARCHIVE LOG LIST;
*/

-- ===========================================================
--                   Sao lưu bằng RMAN
-- ===========================================================

-- Bước 1: Mở cmd và chạy RMAN: rman target C##ADMIN/123456@localhost:1521/<service_name>
-- Bước 2: Thực hiện sao lưu toàn bộ database:
-- RMAN> BACKUP DATABASE PLUS ARCHIVELOG;
-- Bước 3: Kiểm tra danh sách các bản sao lưu:
-- RMAN> LIST BACKUP OF DATABASE;
 
-- Tạo tình huống mất dữ liệu
ALTER TABLESPACE USERS OFFLINE IMMEDIATE;
ALTER DATABASE DATAFILE '/opt/oracle/oradata/FREE/users01.dbf' OFFLINE DROP;

-- thử truy vấn bảng trong USERS(C##ADMIN) sẽ báo lỗi
SELECT * FROM C##ADMIN.DONVI;
 
 -- ============================================================
--                   Phục hồi bằng RMAN
-- ============================================================
-- Bước 1: Mở cmd và chạy RMAN: rman target C##ADMIN/123456@localhost:1521/<service_name>
-- Bước 2: Chạy lệnh phục hồi:
-- RMAN> RUN {
--    SET UNTIL TIME "TO_DATE('2025-05-31 10:00:00','YYYY-MM-DD HH24:MI:SS')"; -- Dòng này để khôi phục đến thời điểm cụ thể(có thể dựa vào audit) và có thể bỏ qua nếu muốn phục hồi đến bản sao lưu mới nhất
--    RESTORE DATABASE;
--    RECOVER DATABASE;
--    ALTER TABLESPACE USERS ONLINE;
-- }
-- Bước 3: Kiểm tra dữ liệu sau phục hồi
SELECT * FROM C##ADMIN.DONVI;
