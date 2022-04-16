
--cap quyen connect cho mot user hoac role
create or replace procedure C##CSYT_Admin.GrantConnect (user_role in VARCHAR2)
as

    BEGIN
        execute IMMEDIATE ('grant connect to ' || user_role || ' with admin option');
    END;
    /


--cap quyen select cho user/role, neu la role thi opt = false
CREATE OR REPLACE PROCEDURE C##CSYT_Admin.GrantSelect(user_role in VARCHAR2, cols in VARCHAR2, tab_priv in VARCHAR2, opt in VARCHAR2) IS
    lv_stmt   VARCHAR2 (1000);
BEGIN
        lv_stmt := 'CREATE view C##CSYT_Admin.View_' || user_role||'_'||tab_priv||'_'||cols||' as select '||cols||' from '||tab_priv;


	EXECUTE IMMEDIATE ( lv_stmt ); 
    if opt = 'True' then
            execute IMMEDIATE ('grant select on C##CSYT_Admin.View_' || user_role||'_'||tab_priv||'_'||cols|| ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant select on C##CSYT_Admin.View_' || user_role||'_'||tab_priv||'_'||cols|| ' to ' || user_role );
        end if;
                                                
	COMMIT;
END;
    /

--cap quyen update cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantUpdate (user_role in VARCHAR2, cols in VARCHAR2, table_priv in VARCHAR2, opt in VARCHAR2)
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
create or replace procedure C##CSYT_Admin.GrantInsert(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
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
create or replace procedure C##CSYT_Admin.GrantDelete(user_role in VARCHAR2, table_priv VARCHAR2, opt VARCHAR2)
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
create or replace procedure C##CSYT_Admin.ShowPrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT grantee,table_name,privilege FROM USER_TAB_PRIVS where grantee like user_name;

    END;
/


CREATE USER C##CSYT_MeanSun IDENTIFIED by a;/
grant connect to C##CSYT_MeanSun; /
grant UNLIMITED TABLESPACE to C##CSYT_MeanSun;/
grant select on all_users to C##CSYT_Admin;/
grant select on DBA_TAB_PRIVS to C##CSYT_Admin;/


--SELECT * FROM DBA_COL_PRIVS where grantee like 'C##CSYT_MEANSUN';
--SELECT * FROM DBA_TAB_PRIVS where grantee like 'C##CSYT_MEANSUN';
--grant update (MAHSBA) on C##CSYT_ADMIN.HSBA to C##CSYT_MEANSUN;
--SELECT PRIVILEGE FROM DBA_SYS_PRIVS where grantee like 'C##CSYT_ADMIN';
