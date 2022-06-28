create or replace procedure CSYT_ADMIN.getUserRoles(cur out SYS_REFCURSOR)
as
begin
    OPEN cur FOR SELECT GRANTED_ROLE from dba_role_PRIVS where grantee like user AND GRANTED_ROLE LIKE 'CSYT_%';
    --open cur for Select user from dual;
    --DBMS_SQL.return_result(cur);
end;
/
grant CSYT_ROLE_BACSI to CSYT_NV001;
grant CSYT_ROLE_THANHTRA to CSYT_NV001;

GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ADMIN WITH GRANT OPTION;
/
-- tu dong tao ma HSBA
create or replace function CSYT_ADMIN.func_auto_MaHSBA
return varchar
is
numberpart number;
temp varchar2(10);
begin
    select count(MAHSBA) into numberpart from CSYT_ADMIN.HSBA;
    temp:= 'HS'|| TO_CHAR(numberpart, 'FM000');
    return temp;
end;

/
create or replace function CSYT_ADMIN.func_auto_MaNV
return varchar
is
numberpart number;
temp varchar2(10);
begin
    select count(MANV) into numberpart from CSYT_ADMIN.NhanVien;
    temp:= 'NV'|| TO_CHAR(numberpart, 'FM000');
    return temp;
end;
/
create or replace function CSYT_ADMIN.func_auto_MaBN
return varchar
is
numberpart number;
temp varchar2(10);
begin
    select count(MABN) into numberpart from CSYT_ADMIN.BenhNhan;
    temp:= 'BN'|| TO_CHAR(numberpart, 'FM000');
    return temp;
end;
/