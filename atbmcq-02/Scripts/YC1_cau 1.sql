-- -- Xóa tất cả objects hiện có
-- BEGIN
    -- -- Drop các triggers
    -- EXECUTE IMMEDIATE 'DROP TRIGGER TRG_UPDATE_DT' ;
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP VIEW VW_NHANVIEN_NO_SALARY';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP VIEW VW_NHANVIEN_SELF';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP PROCEDURE PROC_GRANT_ALL_PERMISSIONS';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP ROLE R_NHANVIEN_BASIC';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP ROLE R_TRGDV';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- BEGIN
    -- EXECUTE IMMEDIATE 'DROP ROLE R_NT_TCHC';
-- EXCEPTION WHEN OTHERS THEN NULL;
-- END;
-- /

-- 1. Tạo các Role cần thiết
CREATE ROLE R_NHANVIEN_BASIC;
CREATE ROLE R_TRGDV;
CREATE ROLE R_NT_TCHC;

-- 2. Tạo view để lấy thông tin của nhân viên không có lương
CREATE OR REPLACE VIEW VW_NHANVIEN_NO_SALARY AS
SELECT nv.MANLD, nv.HOTEN, nv.PHAI, nv.NGSINH, nv.DT, nv.VAITRO, nv.MADV
FROM "C##ADMIN"."NHANVIEN" nv
WHERE nv.MADV = (
    SELECT MADV 
    FROM "C##ADMIN"."NHANVIEN" 
    WHERE MANLD = SYS_CONTEXT('USERENV', 'SESSION_USER')
);

-- 3. Tạo view cho phép nhân viên xem thông tin của chính mình
CREATE OR REPLACE VIEW VW_NHANVIEN_SELF AS
SELECT *
FROM "C##ADMIN"."NHANVIEN"
WHERE MANLD = SYS_CONTEXT('USERENV', 'SESSION_USER');

-- 4. Thu hồi tất cả quyền trực tiếp trên bảng NHANVIEN từ PUBLIC
REVOKE ALL ON "C##ADMIN"."NHANVIEN" FROM PUBLIC;

-- 5. Cấp quyền cho role cơ bản (quyền của NTCB)
GRANT SELECT, UPDATE(DT) ON "C##ADMIN".VW_NHANVIEN_SELF TO R_NHANVIEN_BASIC;

-- 6. Cấp quyền cho trưởng đơn vị
GRANT SELECT ON "C##ADMIN".VW_NHANVIEN_NO_SALARY TO R_TRGDV;

-- 7. Cấp quyền cho nhân viên tổ chức hành chính
GRANT SELECT, INSERT, UPDATE, DELETE ON "C##ADMIN"."NHANVIEN" TO R_NT_TCHC;

-- 8. Tạo procedure để cấp quyền cho người dùng dựa trên VAITRO trong bảng NHANVIEN
CREATE OR REPLACE PROCEDURE PROC_GRANT_ALL_PERMISSIONS AS
    CURSOR c_nhanvien IS
        SELECT MANLD, VAITRO
        FROM "C##ADMIN"."NHANVIEN";
BEGIN
    -- Thu hồi tất cả quyền trực tiếp trên bảng NHANVIEN từ tất cả users
    FOR r_nv IN c_nhanvien LOOP
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE ALL ON "C##ADMIN"."NHANVIEN" FROM ' || r_nv.MANLD;
        EXCEPTION WHEN OTHERS THEN NULL;
        END;
    END LOOP;

    -- Cấp quyền cho từng user theo vai trò
    FOR r_nv IN c_nhanvien LOOP
        -- Thu hồi các role cũ (bỏ qua lỗi nếu role chưa được cấp)
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE R_NHANVIEN_BASIC FROM ' || r_nv.MANLD;
        EXCEPTION WHEN OTHERS THEN NULL;
        END;
        
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE R_TRGDV FROM ' || r_nv.MANLD;
        EXCEPTION WHEN OTHERS THEN NULL;
        END;
        
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE R_NT_TCHC FROM ' || r_nv.MANLD;
        EXCEPTION WHEN OTHERS THEN NULL;
        END;
        
        -- Cấp quyền connect và role cơ bản cho tất cả nhân viên
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || r_nv.MANLD;
        EXECUTE IMMEDIATE 'GRANT R_NHANVIEN_BASIC TO ' || r_nv.MANLD;
        
        -- Cấp thêm quyền cho các vai trò đặc biệt
        IF r_nv.VAITRO = 'TRGĐV' THEN
            EXECUTE IMMEDIATE 'GRANT R_TRGDV TO ' || r_nv.MANLD;
        ELSIF r_nv.VAITRO = 'NV TCHC' THEN
            EXECUTE IMMEDIATE 'GRANT R_NT_TCHC TO ' || r_nv.MANLD;
            -- Cấp quyền trực tiếp trên bảng NHANVIEN cho NV TCHC
            EXECUTE IMMEDIATE 'GRANT SELECT, INSERT, UPDATE, DELETE ON "C##ADMIN"."NHANVIEN" TO ' || r_nv.MANLD;
        END IF;
    END LOOP;
END;
/

-- 9. Thực thi procedure để cấp quyền cho tất cả nhân viên
EXEC PROC_GRANT_ALL_PERMISSIONS;
