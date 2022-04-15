grant select on dba_users to C##CSYT_Admin;
create or replace procedure C##CSYT_Admin.ShowAllUser (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT USERNAME FROM dba_users where USERNAME like 'C##CSYT%';

    END;
    
