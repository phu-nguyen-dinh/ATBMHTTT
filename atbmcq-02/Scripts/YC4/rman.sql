-- Điều kiện bắt buộc: database phải ở chế độ ARCHIVELOG
-- Chạy trong SQL*Plus với quyền SYSDBA để bật chế độ ARCHIVELOG
/* 
SHUTDOWN IMMEDIATE;
STARTUP MOUNT;
ALTER DATABASE ARCHIVELOG;
ALTER DATABASE OPEN;
ARCHIVE LOG LIST;
*/

-- Tạo thư mục để chứa các tệp sao lưu
-- mkdir -p /opt/oracle/rman_bk/tests

-- ===========================================================
--                   Sao lưu bằng RMAN
-- ===========================================================

-- Bước 1: Mở cmd và chạy RMAN: rman target /
-- Bước 2: Thực hiện sao lưu toàn bộ database:
-- RMAN> BACKUP DATABASE FORMAT '/opt/oracle/rman_bk/tests/db_%U.bkp';
-- RAMN> BACKUP ARCHIVELOG ALL FORMAT '/opt/oracle/rman_bk/tests/arch_%U.bkp';
-- Bước 3: Kiểm tra danh sách các bản sao lưu:
-- RMAN> LIST BACKUP OF DATABASE;
 
-- Tạo tình huống mất dữ liệu
ALTER TABLESPACE USERS OFFLINE IMMEDIATE;
ALTER DATABASE DATAFILE '/opt/oracle/oradata/FREE/users01.dbf' OFFLINE DROP;

-- Thử truy vấn bảng trong USERS(C##ADMIN) sẽ báo lỗi
SELECT * FROM C##ADMIN.DONVI;

-- Tắt database và đưa về chế độ MOUNT
SHUTDOWN IMMEDIATE;
STARTUP MOUNT;
 
-- ============================================================
--                   Phục hồi bằng RMAN
-- ============================================================
-- Bước 1: Mở cmd và chạy RMAN: rman target /
-- Bước 2: Chạy lệnh phục hồi:
RMAN> RUN {
    RESTORE DATABASE;
    RECOVER DATABASE;
    ALTER DATABASE OPEN;
    ALTER TABLESPACE USERS ONLINE;
}
--    SET UNTIL TIME "TO_DATE('2025-05-31 10:00:00','YYYY-MM-DD HH24:MI:SS')"; 
-- Dòng này để khôi phục đến thời điểm cụ thể(có thể dựa vào audit) và có thể bỏ qua nếu muốn phục hồi đến bản sao lưu mới nhất.
-- Thêm dòng này vào khối RUN nếu muốn phục hồi đến thời điểm cụ thể:
-- RMAN> RUN {
--    SET UNTIL TIME "TO_DATE('2025-05-31 10:00:00','YYYY-MM-DD HH24:MI:SS')";
--    RESTORE DATABASE;
--    RECOVER DATABASE;
--    ALTER DATABASE OPEN;
--    ALTER TABLESPACE USERS ONLINE;
-- }
-- Bước 3: Kiểm tra dữ liệu sau phục hồi
SELECT * FROM C##ADMIN.DONVI;
