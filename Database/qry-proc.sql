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


create or replace procedure ShowTables (mycursor OUT SYS_REFCURSOR)
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
