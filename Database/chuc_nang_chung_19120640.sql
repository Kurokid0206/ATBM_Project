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
grant CSYT_ROLE_QUANLIDULIEU to CSYT_NV001;

GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ADMIN WITH GRANT OPTION;
/
-- tu dong tao ma HSBA
create or replace function CSYT_ADMIN.func_auto_MaHSBA
return varchar
is
numberpart number;
number_id number;
temp varchar2(10);
begin
    select count(MAHSBA) into numberpart from CSYT_ADMIN.HSBA;
    temp:= 'HS'|| TO_CHAR(numberpart+1, 'FM000');
    Loop
        select count(MAHSBA) into number_id  from CSYT_ADMIN.HSBA where trim(MAHSBA) = trim(temp);
        --DBMS_OUTPUT.put_line(trim(temp));
        --DBMS_OUTPUT.put_line(number_id);
        --DBMS_OUTPUT.put_line(numberpart);
        if number_id != 0
        then
        begin 
        numberpart := numberpart +1;
        temp:= 'HS'|| TO_CHAR(numberpart+1, 'FM000');
        
        end;
        end if;
        exit when number_id = 0;
    end loop;
    return trim(temp);
end;

/
create or replace function CSYT_ADMIN.func_auto_MaNV
return varchar
is
numberpart number;
number_id number;
temp varchar2(10);
begin
    select count(MANV) into numberpart from CSYT_ADMIN.NHANVIEN;
    temp:= 'NV'|| TO_CHAR(numberpart+1, 'FM000');
    Loop
        select count(MANV) into number_id  from CSYT_ADMIN.NHANVIEN where trim(MANV) = trim(temp);
        --DBMS_OUTPUT.put_line(trim(temp));
        --DBMS_OUTPUT.put_line(number_id);
        --DBMS_OUTPUT.put_line(numberpart);
        if number_id != 0
        then
        begin 
        numberpart := numberpart +1;
        temp:= 'NV'|| TO_CHAR(numberpart+1, 'FM000');
        
        end;
        end if;
        exit when number_id = 0;
    end loop;
    return trim(temp);
end;
/
create or replace function CSYT_ADMIN.func_auto_MaBN
return varchar
is
numberpart number;
number_id number;
temp varchar2(10);
begin
    select count(MABN) into numberpart from CSYT_ADMIN.BEnhNhan;
    temp:= 'BN'|| TO_CHAR(numberpart+1, 'FM000');
    Loop
        select count(MABN) into number_id  from CSYT_ADMIN.BenhNhan where trim(MABN) = trim(temp);
        --DBMS_OUTPUT.put_line(trim(temp));
        --DBMS_OUTPUT.put_line(number_id);
        --DBMS_OUTPUT.put_line(numberpart);
        if number_id != 0
        then
        begin 
        numberpart := numberpart +1;
        temp:= 'BN'|| TO_CHAR(numberpart+1, 'FM000');
        
        end;
        end if;
        exit when number_id = 0;
    end loop;
    return trim(temp);
end;
/