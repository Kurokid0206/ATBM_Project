create or replace procedure CSYT_ADMIN.getUserRoles(cur out SYS_REFCURSOR)
as
begin
    OPEN cur FOR SELECT GRANTED_ROLE from dba_role_PRIVS where grantee like user AND GRANTED_ROLE LIKE 'CSYT_%';
    --DBMS_SQL.return_result(cur);
end;

grant CSYT_ROLE_BACSI to CSYT_NV001;
grant CSYT_ROLE_THANHTRA to CSYT_NV001;

GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ADMIN WITH GRANT OPTION;

