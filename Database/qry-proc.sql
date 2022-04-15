CREATE OR REPLACE PROCEDURE C##CSYT_Admin.createUser(
	pi_username IN NVARCHAR2,
	pi_password IN NVARCHAR2) IS
	
	user_name NVARCHAR2(20)  	:= pi_username;
	pwd NVARCHAR2(20) 		:= pi_password;
    li_count       INTEGER	:= 0;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        lv_stmt := 'CREATE USER C##CSYT_' || user_name || ' IDENTIFIED BY ' || pwd || ' DEFAULT TABLESPACE SYSTEM';
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
	COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE C##CSYT_Admin.dropUser(
	pi_username IN NVARCHAR2) IS
	
	user_name NVARCHAR2(20)  	:= pi_username;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        --lv_stmt := 'DROP USER C##CSYT_' || user_name || ' CASCADE ';
        lv_stmt := 'DROP USER ' || user_name || ' CASCADE ';
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
END;
/


CREATE OR REPLACE PROCEDURE C##CSYT_Admin.createRole(
	pi_roleName IN NVARCHAR2) IS
	
	role_name NVARCHAR2(20)  	:= pi_roleName;
    lv_stmt   VARCHAR2 (1000);
BEGIN
        lv_stmt := 'CREATE ROLE C##CSYT_ROLE_' || role_name;
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
	COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE C##CSYT_Admin.dropRole(
	pi_roleName IN NVARCHAR2) IS    
	
	role_name NVARCHAR2(20)  	:= pi_roleName;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        lv_stmt := 'DROP ROLE C##CSYT_ROLE_' || role_name;
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
	COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE C##CSYT_Admin.revokePrivilege(
	pi_username IN VARCHAR2,
	pi_priType IN INTEGER,
    pi_obj IN VARCHAR2) IS
	
	user_name VARCHAR(20)  	:= pi_username;
	priType   INTEGER 		:= pi_priType;
    obj       VARCHAR(20)   := pi_obj;
    sqlstmt   VARCHAR2 (1000);
BEGIN
    IF priType<1 then
        sqlstmt := 'REVOKE INSERT ON ';
    ELSIF priType<2 THEN
        sqlstmt := 'REVOKE SELECT ON '; 
    ELSIF priType<3 THEN
        sqlstmt := 'REVOKE UPDATE ON ';
    ELSE
        sqlstmt := 'REVOKE DELETE ON ';        
    END IF;
    sqlstmt :=sqlstmt||obj||' FROM '||user_name;
	EXECUTE IMMEDIATE ( sqlstmt ); 
                                                
	COMMIT;
END;
/


create or replace procedure C##CSYT_ADMIN.ShowTables (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR SELECT table_name FROM user_tables;
    
    END;
/



create or replace procedure C##CSYT_ADMIN.ShowPriviledge (username NVARCHAR2, mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from all_tab_privs where grantee like '%C##CSYT_'||USERNAME||'%';
    
    END;
/

create or replace procedure C##CSYT_ADMIN.ShowTable (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from user_tables;
    
    END;
/
create or replace procedure C##CSYT_ADMIN.ShowTableCol (tblname nvarchar2,mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR
SELECT column_name
FROM user_tab_cols
WHERE table_name = tblname;
   END;
/

create or replace procedure C##CSYT_ADMIN.ShowRolePriv (roleName nvarchar2,mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR
SELECT role,table_name,privilege FROM role_TAB_PRIVS
WHERE role = roleName;
   END;
/

--cap quyen connect cho mot user hoac role
create or replace procedure C##CSYT_Admin.GrantConnect (user_role VARCHAR2)
as

    BEGIN
        execute IMMEDIATE ('grant connect to ' || user_role || ' with admin option');
    END;
    /


--cap quyen select cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantSelect (user_role VARCHAR2, cols VARCHAR2, tbl_view VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant select '|| cols || ' on C##CSYT_Admin.' || tbl_view || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant select '|| cols || ' on C##CSYT_Admin.' || tbl_view || ' to ' || user_role );
        end if;
    END;
    /

  
--cap quyen update cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, tbl VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant update '|| cols || ' on C##CSYT_Admin.' || tbl || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant update '|| cols || ' on C##CSYT_Admin.' || tbl || ' to ' || user_role );
        end if;
    END;
/


--cap quyen insert cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, tbl VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant insert on C##CSYT_Admin.' || tbl || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant insert on C##CSYT_Admin.' || tbl || ' to ' || user_role );
        end if;
    END;
/
   
--Lay tat ca quyen cho mot user
create or replace procedure C##CSYT_Admin.ShowPrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT grantee,table_name,privilege FROM USER_TAB_PRIVS where grantee like user_name;

    END;
/
create or replace procedure C##CSYT_Admin.ShowAllUser (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT USERNAME FROM dba_users where USERNAME like 'C##CSYT%';

    END;
    /

create or replace procedure C##CSYT_Admin.ShowAllRole (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT ROLE FROM dba_roles where ROLE like 'C##CSYT_ROLE_%';

    END;
    /
