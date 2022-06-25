CREATE OR REPLACE PROCEDURE CSYT_Admin.createUser(
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

CREATE OR REPLACE PROCEDURE CSYT_Admin.dropUser(
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


CREATE OR REPLACE PROCEDURE CSYT_Admin.createRole(
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

CREATE OR REPLACE PROCEDURE CSYT_Admin.dropRole(
	pi_roleName IN NVARCHAR2) IS    
	
	role_name NVARCHAR2(50)  	:= pi_roleName;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        lv_stmt := 'DROP ROLE ' || role_name;
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
	COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE CSYT_Admin.revokePrivilege(
	pi_username IN VARCHAR2,
	pi_priType IN INTEGER,
    pi_obj IN VARCHAR2) IS
	
	user_name VARCHAR(100)  	:= pi_username;
	priType   INTEGER 		:= pi_priType;
    obj       VARCHAR(100)   := pi_obj;

BEGIN
    IF priType<1 then
        EXECUTE IMMEDIATE ('REVOKE INSERT ON C##CSYT_ADMIN.'||obj||' FROM '||user_name);
    ELSIF priType<2 THEN
        EXECUTE IMMEDIATE ( 'drop view C##CSYT_ADMIN.'||obj ); 

        
    ELSIF priType<3 THEN
        EXECUTE IMMEDIATE ('REVOKE UPDATE ON C##CSYT_ADMIN.'||obj||' FROM '||user_name);
    ELSE
        EXECUTE IMMEDIATE ('REVOKE DELETE ON C##CSYT_ADMIN.'||obj||' FROM '||user_name);        
    END IF;
	
                                                
	COMMIT;
END;
/
--exec CSYT_Admin.revokePrivilege('C##CSYT_MEANSUN',1,'VIEW_C##CSYT_MEANSUN_HSBA');

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
WHERE role = roleName and privilege != 'UPDATE';
   END;
/

--cap quyen connect cho mot user hoac role
create or replace procedure CSYT_Admin.GrantConnect (user_role VARCHAR2)
as

    BEGIN
        execute IMMEDIATE ('grant connect to ' || user_role || ' with admin option');
    END;
    /


--cap quyen select cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantSelect (user_role VARCHAR2, cols VARCHAR2, tbl_view VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant select '|| cols || ' on CSYT_Admin.' || tbl_view || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant select '|| cols || ' on CSYT_Admin.' || tbl_view || ' to ' || user_role );
        end if;
    END;
    /

--cap quyen insert cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantInsert(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
as

    BEGIN
        if opt = 'True' then
            execute IMMEDIATE ('grant insert on ' || table_priv || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant insert on ' || table_priv || ' to ' || user_role );
        end if;
    END;
/
  
--cap quyen update cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, tbl VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant update '|| cols || ' on CSYT_Admin.' || tbl || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant update '|| cols || ' on CSYT_Admin.' || tbl || ' to ' || user_role );
        end if;
    END;
/


--cap quyen insert cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, tbl VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant insert on CSYT_Admin.' || tbl || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant insert on CSYT_Admin.' || tbl || ' to ' || user_role );
        end if;
    END;
/
   --cap quyen delete cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantDelete(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
as

    BEGIN
        if opt = 'True' then
            execute IMMEDIATE ('grant delete on ' || table_priv || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant delete on ' || table_priv || ' to ' || user_role );
        end if;
    END;
/
--Lay tat ca quyen cho mot user
create or replace procedure CSYT_Admin.ShowPrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT grantee,table_name,privilege FROM USER_TAB_PRIVS where grantee like user_name;

    END;
/
create or replace procedure CSYT_Admin.ShowAllUser (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT USERNAME FROM dba_users where USERNAME like 'C##CSYT%' and USERNAME !='C##CSYT_ADMIN';

    END;
    /

create or replace procedure CSYT_Admin.ShowAllRole (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT ROLE FROM dba_roles where ROLE like 'C##CSYT_ROLE_%';

    END;
    /
    
CREATE OR REPLACE PROCEDURE CSYT_Admin.alterUser(
	pi_username IN NVARCHAR2,
	pi_password IN NVARCHAR2) IS
	
	user_name NVARCHAR2(20)  	:= pi_username;
	pwd NVARCHAR2(20) 		:= pi_password;
    li_count       INTEGER	:= 0;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        lv_stmt := 'ALTER USER ' || user_name || ' IDENTIFIED BY ' || pwd || ' DEFAULT TABLESPACE SYSTEM';
	DBMS_OUTPUT.put_line(lv_stmt);

	EXECUTE IMMEDIATE ( lv_stmt ); 
                                                
	COMMIT;
END;
    /
    
--MeanSun segment

--cap quyen connect cho mot user hoac role
create or replace procedure CSYT_Admin.GrantConnect (user_role in VARCHAR2)
as

    BEGIN
        execute IMMEDIATE ('grant connect to ' || user_role || ' with admin option');
    END;



/
--cap quyen select cho user/role, neu la role thi opt = false
CREATE OR REPLACE PROCEDURE CSYT_Admin.GrantSelect(tab_priv in VARCHAR2,username in varchar2,cols in varchar2, opt in VARCHAR2) IS
sqlstmt varchar(1000):='';
vcol varchar(50);
cursor cur is select COLUMN_NAME from user_tab_columns where TABLE_NAME = 'VIEW_'||username||'_'||tab_priv;
BEGIN
    
    sqlstmt:='create or replace view C##CSYT_ADMIN.VIEW_'||username||'_'||tab_priv||' as select ';
    open cur;
    LOOP
    FETCH cur INTO vcol;
    EXIT WHEN cur%NOTFOUND;
    IF vcol != cols then
    DBMS_OUTPUT.PUT_LINE(vcol);
    sqlstmt:=concat(sqlstmt,vcol||',');
    end if;
    END LOOP;
     
    sqlstmt:=concat(sqlstmt,cols||',');
    sqlstmt:=concat(RTRIM(sqlstmt,','),' from C##CSYT_ADMIN.'||tab_priv);
    DBMS_OUTPUT.PUT_LINE(sqlstmt);
	EXECUTE IMMEDIATE ( sqlstmt ); 
    if opt = 'true' then
            execute IMMEDIATE ('grant select on C##CSYT_ADMIN.VIEW_'||username||'_'||tab_priv|| ' to ' || username || ' with grant option');
        else
            execute IMMEDIATE ('grant select on C##CSYT_ADMIN.VIEW_'||username||'_'||tab_priv|| ' to ' || username );
        end if;
                                                
	COMMIT;
END;
    /

create or replace procedure CSYT_Admin.GrantUpdate (user_role in VARCHAR2, cols in VARCHAR2, table_priv in VARCHAR2, opt in VARCHAR2)
as

    BEGIN
        if opt = 'True' then
            execute IMMEDIATE ('grant update ('|| cols || ') on ' || table_priv || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant update ('|| cols || ') on ' || table_priv || ' to ' || user_role );
        end if;
    END;
/
/* begin
GrantUpdate('C##CSYT_MEANSUN','MAHSBA','HSBA','False');
end; */


--cap quyen insert cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantInsert(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
as

    BEGIN
        if opt = 'True' then
            execute IMMEDIATE ('grant insert on ' || table_priv || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant insert on ' || table_priv || ' to ' || user_role );
        end if;
    END;
/

--cap quyen delete cho user/role, neu la role thi opt = false
create or replace procedure CSYT_Admin.GrantDelete(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
as

    BEGIN
        if opt = 'True' then
            execute IMMEDIATE ('grant delete on ' || table_priv || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant delete on ' || table_priv || ' to ' || user_role );
        end if;
    END;
/

--Lay tat ca quyen cho mot user
create or replace procedure CSYT_Admin.ShowPrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT grantee,table_name,privilege FROM USER_TAB_PRIVS where grantee like user_name;

    END;
/
--Lay tat ca quyen update cho mot user
create or replace procedure CSYT_Admin.ShowUpdatePrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT grantee,table_name,privilege,column_name FROM USER_COL_PRIVS where grantee like user_name;

    END;
/

CREATE USER C##CSYT_MeanSun IDENTIFIED by a;/
grant connect to C##CSYT_MeanSun; /
grant UNLIMITED TABLESPACE to C##CSYT_MeanSun;/
grant select on all_users to CSYT_Admin;/
grant select on DBA_TAB_PRIVS to CSYT_Admin;/

--SELECT * FROM DBA_COL_PRIVS where grantee like 'C##CSYT_MEANSUN';
--SELECT * FROM DBA_TAB_PRIVS where grantee like 'C##CSYT_MEANSUN';
--grant update (MAHSBA) on C##CSYT_ADMIN.HSBA to C##CSYT_MEANSUN;
--SELECT PRIVILEGE FROM DBA_SYS_PRIVS where grantee like 'C##CSYT_ADMIN';
