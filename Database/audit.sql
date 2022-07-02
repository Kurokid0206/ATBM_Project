ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
drop user test cascade;
drop user test2 cascade;

Create user test identified by test;
Create user test2 identified by test;
grant connect to test,test2;
ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;


ALTER SYSTEM SET audit_sys_operations=TRUE SCOPE=SPFILE;

--Ghi lai cac hanh vi xem thong tin benh nhan/nhan vien bat hop phap
AUDIT SELECT on CSYT_ADMIN.BenhNhan BY ACCESS WHENEVER NOT SUCCESSFUL;
AUDIT SELECT on CSYT_ADMIN.NhanVien BY ACCESS WHENEVER NOT SUCCESSFUL;


SELECT * from DBA_AUDIT_POLICIES;
delete from DBA_FGA_AUDIT_TRAIL;
SELECT * FROM DBA_FGA_AUDIT_TRAIL;
delete from aud$;
select * from aud$;

select distinct USERID,obj$name AS tbl,TO_char(Ntimestamp#,'dd-mon-yyyy hh:mi:ss') AS TIME from aud$ where obj$creator='CSYT_ADMIN';

begin DBMS_FGA.DROP_POLICY (  object_schema      =>  'CSYT_ADMIN', 
        object_name        =>  'BENHNHAN',       policy_name        =>  'ACCESS_BenhNhan'); end;
/
BEGIN
    DBMS_FGA.ADD_POLICY (
        object_schema      =>  'CSYT_ADMIN', 
        object_name        =>  'BenhNhan', 
        policy_name        =>  'ACCESS_BenhNhan', 
        audit_condition    =>  'USERNAME != USER',
        statement_types    =>  'SELECT,UPDATE,DELETE'
    ); 
END;
/

BEGIN
    DBMS_FGA.ADD_POLICY (
        object_schema      =>  'CSYT_ADMIN', 
        object_name        =>  'NhanVien', 
        policy_name        =>  'ACCESS_NhanVien', 
        audit_condition    =>  'USERNAME != USER',
        statement_types    =>  'SELECT,UPDATE,DELETE'
    ); 
END;
/
grant select on sys.aud$ to CSYT_ADMIN with grant option;

create or replace procedure CSYT_ADMIN.InvalidAccessAudit(cur out SYS_REFCURSOR)
as
begin
    OPEN cur FOR 
    select distinct USERID,obj$name AS tbl,TO_char(Ntimestamp#,'dd-mon-yyyy hh:mi:ss') AS TIME 
    from sys.aud$ where obj$creator='CSYT_ADMIN';

    --DBMS_SQL.return_result(cur);
end;
/

create or replace procedure CSYT_ADMIN.IllegalAccessAudit(cur out SYS_REFCURSOR)
as
begin
    OPEN cur FOR 
    select distinct DB_USER,OBJECT_NAME AS tbl,TO_char(timestamp,'dd-mon-yyyy hh:mi:ss') AS TIME,SQL_TEXT as ViecLam 
    from sys.DBA_FGA_AUDIT_TRAIL where OBJECT_SCHEMA='CSYT_ADMIN';

    --DBMS_SQL.return_result(cur);
end;