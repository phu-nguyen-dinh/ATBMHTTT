CREATE TABLE audit_log (
    id            NUMBER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    admin_user    VARCHAR2(100),
    action_type   VARCHAR2(50),
    target_object VARCHAR2(100),
    object_type   VARCHAR2(50),
    privilege     VARCHAR2(50),
    timestamp     TIMESTAMP DEFAULT SYSTIMESTAMP
);

-- =====================================
CREATE OR REPLACE PROCEDURE create_user_proc(
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY "' || p_password || '"';
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || p_username;

    -- ✅ Ghi log người tạo
    INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
    VALUES (USER, 'CREATE', p_username, 'USER', 'CREATE SESSION');

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/



-- =====================================
CREATE OR REPLACE PROCEDURE create_role_proc(
    p_rolename IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'CREATE ROLE ' || p_rolename;

    -- ✅ Ghi log
    INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
    VALUES (USER, 'CREATE', p_rolename, 'ROLE', 'CREATE ROLE');

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


--- ==========================================
CREATE OR REPLACE PROCEDURE drop_user_proc(
    p_username IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';

    -- ✅ Ghi log
    INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
    VALUES (USER, 'DROP', p_username, 'USER', 'DROP USER');

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


-- =======================================
CREATE OR REPLACE PROCEDURE drop_role_proc(
    p_rolename IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_rolename;

    -- ✅ Ghi log
    INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
    VALUES (USER, 'DROP', p_rolename, 'ROLE', 'DROP ROLE');

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/



-- ===================================
CREATE OR REPLACE PROCEDURE alter_user_password_proc(
    p_username      IN VARCHAR2,
    p_new_password  IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' IDENTIFIED BY "' || p_new_password || '"';

    INSERT INTO audit_log VALUES (DEFAULT, USER, 'ALTER', p_username, 'USER', 'CHANGE PASSWORD', SYSTIMESTAMP);

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


-- ===========================================
-- Xóa procedure grant_privilege_proc nếu đã tồn tại
BEGIN
    EXECUTE IMMEDIATE 'DROP PROCEDURE grant_privilege_proc';
EXCEPTION
    WHEN OTHERS THEN NULL;
END;
/

CREATE OR REPLACE PROCEDURE grant_privilege_proc (
    p_grantee        IN VARCHAR2,
    p_table_name     IN VARCHAR2,
    p_select_cols    IN VARCHAR2 DEFAULT NULL,
    p_update_cols    IN VARCHAR2 DEFAULT NULL,
    p_grant_select   IN BOOLEAN DEFAULT FALSE,
    p_grant_insert   IN BOOLEAN DEFAULT FALSE,
    p_grant_delete   IN BOOLEAN DEFAULT FALSE,
    p_grant_update   IN BOOLEAN DEFAULT FALSE
)
AUTHID CURRENT_USER
AS
BEGIN
    -- Kiểm tra quyền SELECT
    IF p_grant_select THEN
        IF p_select_cols IS NOT NULL THEN
            EXECUTE IMMEDIATE 'GRANT SELECT (' || p_select_cols || ') ON ' || p_table_name || ' TO ' || p_grantee;
        ELSE
            EXECUTE IMMEDIATE 'GRANT SELECT ON ' || p_table_name || ' TO ' || p_grantee;
        END IF;

        INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
        VALUES (USER, 'GRANT', p_grantee, 'TABLE', 'SELECT');
    END IF;

    -- Kiểm tra quyền INSERT
    IF p_grant_insert THEN
        EXECUTE IMMEDIATE 'GRANT INSERT ON ' || p_table_name || ' TO ' || p_grantee;
        INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
        VALUES (USER, 'GRANT', p_grantee, 'TABLE', 'INSERT');
    END IF;

    -- Kiểm tra quyền DELETE
    IF p_grant_delete THEN
        EXECUTE IMMEDIATE 'GRANT DELETE ON ' || p_table_name || ' TO ' || p_grantee;
        INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
        VALUES (USER, 'GRANT', p_grantee, 'TABLE', 'DELETE');
    END IF;

    -- Kiểm tra quyền UPDATE
    IF p_grant_update THEN
        IF p_update_cols IS NOT NULL THEN
            EXECUTE IMMEDIATE 'GRANT UPDATE (' || p_update_cols || ') ON ' || p_table_name || ' TO ' || p_grantee;
        ELSE
            EXECUTE IMMEDIATE 'GRANT UPDATE ON ' || p_table_name || ' TO ' || p_grantee;
        END IF;

        INSERT INTO audit_log(admin_user, action_type, target_object, object_type, privilege)
        VALUES (USER, 'GRANT', p_grantee, 'TABLE', 'UPDATE');
    END IF;

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/



-- ==================================
CREATE OR REPLACE PROCEDURE revoke_privilege_proc(
    p_grant_select   IN BOOLEAN DEFAULT FALSE,
    p_grant_insert   IN BOOLEAN DEFAULT FALSE,
    p_grant_delete   IN BOOLEAN DEFAULT FALSE,
    p_grant_update   IN BOOLEAN DEFAULT FALSE,
    p_grantee        IN VARCHAR2,
    p_object_name    IN VARCHAR2 DEFAULT NULL
)
AUTHID CURRENT_USER
AS
BEGIN
    IF p_grant_select THEN
        EXECUTE IMMEDIATE 'REVOKE SELECT ON ' || p_object_name || ' FROM ' || p_grantee;
        INSERT INTO audit_log VALUES (DEFAULT, USER, 'REVOKE', p_grantee, 'TABLE', 'SELECT', SYSTIMESTAMP);
    END IF;

    IF p_grant_insert THEN
        EXECUTE IMMEDIATE 'REVOKE INSERT ON ' || p_object_name || ' FROM ' || p_grantee;
        INSERT INTO audit_log VALUES (DEFAULT, USER, 'REVOKE', p_grantee, 'TABLE', 'INSERT', SYSTIMESTAMP);
    END IF;

    IF p_grant_delete THEN
        EXECUTE IMMEDIATE 'REVOKE DELETE ON ' || p_object_name || ' FROM ' || p_grantee;
        INSERT INTO audit_log VALUES (DEFAULT, USER, 'REVOKE', p_grantee, 'TABLE', 'DELETE', SYSTIMESTAMP);
    END IF;

    IF p_grant_update THEN
        EXECUTE IMMEDIATE 'REVOKE UPDATE ON ' || p_object_name || ' FROM ' || p_grantee;
        INSERT INTO audit_log VALUES (DEFAULT, USER, 'REVOKE', p_grantee, 'TABLE', 'UPDATE', SYSTIMESTAMP);
    END IF;

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/



-- ====================================
CREATE OR REPLACE PROCEDURE create_tablespace_proc(
    p_tablespace_name IN VARCHAR2,
    p_size IN NUMBER
)
AUTHID CURRENT_USER
AS
    v_sql VARCHAR2(4000);
BEGIN
    v_sql := 'CREATE TABLESPACE ' || p_tablespace_name || 
             ' DATAFILE ''' || p_tablespace_name || '.dbf'' SIZE ' || p_size || 'M ' ||
             'AUTOEXTEND ON NEXT 10M MAXSIZE UNLIMITED';

    EXECUTE IMMEDIATE v_sql;

    INSERT INTO audit_log VALUES (DEFAULT, USER, 'CREATE', p_tablespace_name, 'TABLESPACE', 'CREATE TABLESPACE', SYSTIMESTAMP);

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


-- ========================================
CREATE OR REPLACE PROCEDURE drop_tablespace_proc(
    p_tablespace_name IN VARCHAR2
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP TABLESPACE ' || p_tablespace_name || ' INCLUDING CONTENTS AND DATAFILES';

    INSERT INTO audit_log VALUES (DEFAULT, USER, 'DROP', p_tablespace_name, 'TABLESPACE', 'DROP TABLESPACE', SYSTIMESTAMP);

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


-- ======================================
CREATE OR REPLACE PROCEDURE resize_tablespace_proc(
    p_tablespace_name IN VARCHAR2,
    p_size IN NUMBER
)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE 'ALTER DATABASE DATAFILE ''' || p_tablespace_name || '.dbf'' RESIZE ' || p_size || 'M';

    INSERT INTO audit_log VALUES (DEFAULT, USER, 'ALTER', p_tablespace_name, 'TABLESPACE', 'RESIZE', SYSTIMESTAMP);

    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/


-- ===================================
CREATE OR REPLACE PROCEDURE get_users_roles_list(
    p_filter IN VARCHAR2,
    p_cursor OUT SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    IF p_filter = 'Users' THEN
        OPEN p_cursor FOR
            SELECT username AS name,
                   created,
                   'OPEN' AS status,
                   'USER' AS type
            FROM all_users
            WHERE username IN (
                SELECT target_object FROM audit_log
                WHERE admin_user = USER AND object_type = 'USER'
            )
            ORDER BY username;

    ELSIF p_filter = 'Roles' THEN
        OPEN p_cursor FOR
            SELECT role AS name,
                   NULL AS created,
                   'NORMAL' AS status,
                   'ROLE' AS type
            FROM dba_roles
            WHERE role IN (
                SELECT target_object FROM audit_log
                WHERE admin_user = USER AND object_type = 'ROLE'
            )
            ORDER BY role;

    ELSE
        OPEN p_cursor FOR
            SELECT username AS name,
                   created,
                   'OPEN' AS status,
                   'USER' AS type
            FROM all_users
            WHERE username IN (
                SELECT target_object FROM audit_log
                WHERE admin_user = USER AND object_type = 'USER'
            )

            UNION ALL

            SELECT role AS name,
                   NULL,
                   'NORMAL',
                   'ROLE'
            FROM dba_roles
            WHERE role IN (
                SELECT target_object FROM audit_log
                WHERE admin_user = USER AND object_type = 'ROLE'
            )
            ORDER BY name;
    END IF;
END;
/



-- ===============================
-- Xóa procedure get_privileges_list nếu đã tồn tại
BEGIN
    EXECUTE IMMEDIATE 'DROP PROCEDURE get_privileges_list';
EXCEPTION
    WHEN OTHERS THEN NULL;
END;
/

CREATE OR REPLACE PROCEDURE get_privileges_list(
    p_cursor OUT SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    OPEN p_cursor FOR
        WITH privilege_counts AS (
            SELECT 
                target_object,
                privilege,
                object_type,
                COUNT(CASE WHEN action_type = 'GRANT' THEN 1 END) as grant_count,
                COUNT(CASE WHEN action_type = 'REVOKE' THEN 1 END) as revoke_count
            FROM audit_log
            WHERE admin_user = USER
                AND object_type = 'TABLE'
                AND action_type IN ('GRANT', 'REVOKE')
            GROUP BY target_object, privilege, object_type
        )
        SELECT 
            target_object AS grantee,
            privilege,
            object_type AS table_name,
            'Có thể cấp' AS grantable
        FROM privilege_counts
        WHERE grant_count > revoke_count
        ORDER BY target_object, privilege;
END;
/



-- ==============================
CREATE OR REPLACE PROCEDURE get_tablespaces_list(
    p_cursor OUT SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    OPEN p_cursor FOR
        SELECT tablespace_name,
               ROUND(bytes / 1024 / 1024, 2) as size_mb,
               status,
               CASE WHEN autoextensible = 'YES' THEN 'Có' ELSE 'Không' END as autoextensible
        FROM dba_data_files
        WHERE tablespace_name IN (
            SELECT target_object FROM audit_log
            WHERE admin_user = USER
              AND object_type = 'TABLESPACE'
        )
        ORDER BY tablespace_name;
END;
/

-- ==============================
CREATE OR REPLACE PROCEDURE get_audit_log_list(
    p_cursor OUT SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    OPEN p_cursor FOR
        SELECT admin_user,
               action_type,
               target_object,
               object_type,
               privilege,
               timestamp
        FROM audit_log
        WHERE admin_user = USER  
        ORDER BY timestamp DESC;
END;
/



-- Test cases for User Management
BEGIN
    -- Create multiple test users with different names
    create_user_proc('C##USER_MANAGER', 'password123');
    create_user_proc('C##USER_AUDITOR', 'password456');
    create_user_proc('C##USER_REPORTER', 'password789');
END;
/

BEGIN
    -- Create multiple test roles with different names
    create_role_proc('C##ROLE_ADMIN');
    create_role_proc('C##ROLE_VIEWER');
    create_role_proc('C##ROLE_EDITOR');
END;
/

BEGIN
    -- Test changing passwords for some users
    alter_user_password_proc('C##USER_MANAGER', 'newpassword123');
    alter_user_password_proc('C##USER_AUDITOR', 'newpassword456');
END;
/

-- Test cases for Privilege Management
BEGIN
    -- Grant various privileges to users
    grant_privilege_proc(
        p_grantee => 'C##USER_MANAGER',
        p_table_name => 'AUDIT_LOG',
        p_grant_select => TRUE,
        p_grant_insert => TRUE
    );
    
    grant_privilege_proc(
        p_grantee => 'C##USER_AUDITOR',
        p_table_name => 'AUDIT_LOG',
        p_grant_select => TRUE,
        p_grant_update => TRUE
    );
    
    grant_privilege_proc(
        p_grantee => 'C##ROLE_ADMIN',
        p_table_name => 'AUDIT_LOG',
        p_grant_select => TRUE,
        p_grant_delete => TRUE
    );
END;
/

-- Test revoking privileges (only revoke privileges that were granted)
BEGIN
    revoke_privilege_proc(
        p_grantee => 'C##USER_MANAGER',
        p_object_name => 'AUDIT_LOG',
        p_grant_insert => TRUE
    );
    
    revoke_privilege_proc(
        p_grantee => 'C##USER_AUDITOR',
        p_object_name => 'AUDIT_LOG',
        p_grant_update => TRUE
    );
END;
/

-- Minimal deletion tests (keeping most objects for data)
BEGIN
    -- Delete only one user and one role
    drop_user_proc('C##USER_REPORTER');
    drop_role_proc('C##ROLE_EDITOR');
END;
/


