-- ===========================================================
--                     Tự động sao lưu bằng RMAN
-- ===========================================================

-- Cấp quyền thực thi cho script backup_rman.sh
-- chmod +x /Users/matt/Documents/Năm 3/HKII/ATBMHTTT/Đồ án/ATBMHTTT/atbmcq-02/Scripts/YC4/backup_rman.sh

-- Mã này tạo một thư mục để chứa các tệp sao lưu và cấp quyền cho người dùng Oracle để ghi vào thư mục này.
-- mkdir -p /opt/oracle/backups/rman/
-- chmod 777 /opt/oracle/backups/rman/

-- Tạo job tự động sao lưu Oracle DB bằng RMAN 2 giờ sáng mỗi ngày.(+7 giờ UTC)
BEGIN
  DBMS_SCHEDULER.create_job (
    job_name        => 'RMAN_BACKUP_JOB',
    job_type        => 'EXECUTABLE',
    job_action      => '/Users/matt/Documents/Năm 3/HKII/ATBMHTTT/Đồ án/ATBMHTTT/atbmcq-02/Scripts/YC4/backup_rman.sh', -- Đường dẫn đến script sao lưu RMAN
    start_date      => SYSTIMESTAMP,
    repeat_interval => 'FREQ=DAILY;BYHOUR=19;BYMINUTE=0;BYSECOND=0',
    enabled         => TRUE,
    auto_drop       => FALSE,
    comments        => 'Tự động sao lưu Oracle DB mỗi ngày bằng RMAN'
  );
END;
/

-- ============================================================
--                   Tự động sao lưu bằng Data Pump
-- ============================================================

-- Cấp quyền thực thi cho script backup_rman.sh
-- chmod +x /Users/matt/Documents/Năm 3/HKII/ATBMHTTT/Đồ án/ATBMHTTT/atbmcq-02/Scripts/YC4/backup_dp.sh

-- Mã này tạo một thư mục để chứa các tệp sao lưu và cấp quyền cho người dùng Oracle để ghi vào thư mục này.
-- mkdir -p /opt/oracle/backups/dpump/
-- chmod 777 /opt/oracle/backups/dpump/

-- Cấp quyền cho Oracle user để có thể ghi vào thư mục này
-- Kết nối vào sqlplus với quyền SYSDBA: sqlplus / C##ADMIN/123456@localhost:1521/<service_name>
-- Chạy sql: 
/*
CREATE OR REPLACE DIRECTORY dpump_dir AS '/opt/oracle/backups/dpump';
GRANT READ, WRITE ON DIRECTORY dpump_dir TO C##ADMIN;
exit;
*/

-- Tạo job tự động sao lưu schema bằng Data Pump 3 giờ sáng chủ nhật mỗi tuần.(+7 giờ UTC)
BEGIN
  DBMS_SCHEDULER.create_job (
    job_name        => 'DPUMP_BACKUP_JOB',
    job_type        => 'EXECUTABLE',
    job_action      => '/Users/matt/Documents/Năm 3/HKII/ATBMHTTT/Đồ án/ATBMHTTT/atbmcq-02/Scripts/YC4/backup_dp.sh', -- Đường dẫn đến script sao lưu Data Pump
    start_date      => SYSTIMESTAMP,
    repeat_interval => 'FREQ=WEEKLY;BYDAY=SUN;BYHOUR=20',
    enabled         => TRUE,
    auto_drop       => FALSE,
    comments        => 'Tự động sao lưu Oracle DB mỗi tuần bằng Data Pump'
  );
END;

-- ============================================================
--                   Kiểm tra các job đã tạo
-- ============================================================

-- Xem danh sách các job đã tạo
SELECT job_name, status, repeat_interval FROM dba_scheduler_jobs;

-- Xem lịch sử thực thi của job
SELECT job_name, log_date, status, additional_info
FROM dba_scheduler_job_run_details
ORDER BY log_date DESC;
