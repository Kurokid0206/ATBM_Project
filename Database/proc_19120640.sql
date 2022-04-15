SELECT username, user_id, created FROM all_users where oracle_maintained = 'N';



--cap quyen connect cho mot user hoac role
create or replace procedure C##CSYT_Admin.GrantConnect (user_role VARCHAR2)
as

    BEGIN
        execute IMMEDIATE ('grant connect to ' || user_role || ' with admin option');
    END;


--cap quyen select cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantSelect (user_role VARCHAR2, cols VARCHAR2, _view VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant select '|| cols || ' on C##CSYT_Admin.' || _view || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant select '|| cols || ' on C##CSYT_Admin.' || _view || ' to ' || user_role );
        end if;
    END;
    

  
--cap quyen update cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, _table VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant update '|| cols || ' on C##CSYT_Admin.' || _table || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant update '|| cols || ' on C##CSYT_Admin.' || _table || ' to ' || user_role );
        end if;
    END;



--cap quyen insert cho user/role, neu la role thi opt = false
create or replace procedure C##CSYT_Admin.GrantUpdate (user_role VARCHAR2, cols VARCHAR2, _table VARCHAR2, opt boolean)
as

    BEGIN
        if opt then
            execute IMMEDIATE ('grant insert on C##CSYT_Admin.' || _table || ' to ' || user_role || ' with grant option');
        else
            execute IMMEDIATE ('grant insert on C##CSYT_Admin.' || _table || ' to ' || user_role );
        end if;
    END;

   
--Lay tat ca quyen cho mot user
create or replace procedure C##CSYT_Admin.ShowPrivilegesForUser (user_name VARCHAR2, CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT PRIVILEGE FROM DBA_SYS_PRIVS where grantee like user_name;

    END;




CREATE USER C##CSYT_MeanSun IDENTIFIED by a;
grant connect to C##CSYT_MeanSun; 
grant UNLIMITED TABLESPACE to C##CSYT_MeanSun;
grant select on all_users to C##CSYT_Admin;
grant select on DBA_SYS_PRIVS to C##CSYT_Admin;


SELECT * FROM DBA_SYS_PRIVS where grantee like 'C##CSYT_ADMIN';
