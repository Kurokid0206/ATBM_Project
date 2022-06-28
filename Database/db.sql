aALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
DROP USER CSYT_Admin CASCADE;

--DROP TABLE CSYT_Admin.HSBA     CASCADE CONSTRAINTS;
--DROP TABLE CSYT_Admin.HSBA_DV  CASCADE CONSTRAINTS;
--DROP TABLE CSYT_Admin.BenhNhan CASCADE CONSTRAINTS;
--DROP TABLE CSYT_Admin.CSYT     CASCADE CONSTRAINTS;
--DROP TABLE CSYT_Admin.NhanVien CASCADE CONSTRAINTS;

CREATE USER CSYT_Admin IDENTIFIED BY a;


GRANT CONNECT TO CSYT_Admin;

GRANT CONNECT TO CSYT_Admin WITH ADMIN OPTION;
GRANT UNLIMITED TABLESPACE TO CSYT_Admin;
GRANT CREATE USER TO CSYT_Admin CONTAINER=ALL;
GRANT DROP USER TO CSYT_Admin CONTAINER=ALL;
GRANT ALTER USER TO CSYT_Admin Container=All;

GRANT SELECT ON dba_users TO CSYT_Admin;
GRANT SELECT ON dba_roles TO CSYT_Admin;
GRANT SELECT ON dba_role_PRIVS TO CSYT_Admin;
GRANT CREATE ROLE TO CSYT_Admin CONTAINER=ALL;
GRANT CREATE TABLE TO CSYT_Admin;
grant select on all_users to CSYT_Admin;
grant select on DBA_TAB_PRIVS to CSYT_Admin;
grant create view to CSYT_ADMIN CONTAINER=ALL;
GRANT EXECUTE ON SYS.DBMS_CRYPTO TO CSYT_ADMIN;

CREATE TABLE CSYT_Admin.HSBA (
    MaHSBA      CHAR(10), 
    MaBN        CHAR(10), 
    Ngay        DATE, 
    ChanDoan    NVARCHAR2(100), 
    MaBS        CHAR(10), 
    MaKHOA      CHAR(10), 
    MaCSYT      CHAR(10),
    KetLuan     NVARCHAR2(100),
    CONSTRAINT PK_MaHSBA_N04 PRIMARY KEY(MaHSBA)
);

CREATE TABLE CSYT_Admin.HSBA_DV (
    MaHSBA      CHAR(10), 
    MaDV        CHAR(10), 
    Ngay        DATE, 
    MaKTV       CHAR(10), 
    KetQua      NVARCHAR2(50),
    CONSTRAINT PK_HSBA_DV_N04 PRIMARY KEY(MaHSBA,MaDV,Ngay)
);

CREATE TABLE CSYT_Admin.BenhNhan (
    MaBN            CHAR(10), 
    MaCSYT          CHAR(10), 
    TenBN           NVARCHAR2(50), 
    CMND            varchar2(2000), 
    NgaySinh        DATE, 
    SoNha           varchar2(2000),
    TenDuong        varchar2(2000), 
    QuanHuyen       varchar2(2000), 
    TinhTP          varchar2(2000), 
    TienSuBenh      NVARCHAR2(50), 
    TienSuBenhGD    NVARCHAR2(50),
    DiUngThuoc      NVARCHAR2(50),
    Username        CHAR(15),
    CONSTRAINT PK_BenhNhan_N04 PRIMARY KEY(MaBN)
);

CREATE TABLE CSYT_Admin.CSYT (
    MaCSYT  CHAR(10), 
    TenCSYT NVARCHAR2(30), 
    DCCSYT  NVARCHAR2(100), 
    SDTCSYT NVARCHAR2(11),
    CONSTRAINT PK_CSYT_N04 PRIMARY KEY(MaCSYT)
);

CREATE TABLE CSYT_Admin.NhanVien (
    MaNV        CHAR(10), 
    HoTen       NVARCHAR2(50), 
    Phai        NVARCHAR2(3), 
    NgaySinh    DATE, 
    CMND        varchar2(2000), 
    QueQuan     varchar2(2000), 
    SDT         varchar2(11),
    CSYT        CHAR(10), 
    VaiTro      NVARCHAR2(20),--???? 
    ChuyenKhoa  CHAR(10),--???TRIGGER?
    Username        CHAR(15),
    CONSTRAINT PK_NhanVien_N04 PRIMARY KEY(MaNV)
);

ALTER TABLE CSYT_Admin.HSBA        ADD CONSTRAINT FK_BN_HSBA_N04 FOREIGN KEY (MaBN)    REFERENCES CSYT_Admin.BenhNhan(MaBN);
ALTER TABLE CSYT_Admin.HSBA        ADD CONSTRAINT FK_BS_HSBA_N04 FOREIGN KEY (MaBS)    REFERENCES CSYT_Admin.NhanVien(MaNV);
ALTER TABLE CSYT_Admin.HSBA_DV     ADD CONSTRAINT FK_DV_HSBA_N04 FOREIGN KEY (MaHSBA)  REFERENCES CSYT_Admin.HSBA(MaHSBA);
ALTER TABLE CSYT_Admin.BenhNhan    ADD CONSTRAINT FK_BN_CSYT_N04 FOREIGN KEY (MaCSYT)  REFERENCES CSYT_Admin.CSYT(MaCSYT);
ALTER TABLE CSYT_Admin.NhanVien    ADD CONSTRAINT FK_NV_CSYT_N04 FOREIGN KEY (CSYT)    REFERENCES CSYT_Admin.CSYT(MaCSYT);



GRANT CONNECT TO CSYT_Admin WITH ADMIN OPTION;




------------------------------------
--Chuc nang phan he 1
CREATE OR REPLACE PROCEDURE CSYT_Admin.createUser(
	pi_username IN NVARCHAR2,
	pi_password IN NVARCHAR2) IS
	
	user_name NVARCHAR2(20)  	:= pi_username;
	pwd NVARCHAR2(20) 		:= pi_password;
    li_count       INTEGER	:= 0;
    lv_stmt   VARCHAR2 (1000);
BEGIN
    
        lv_stmt := 'CREATE USER CSYT_' || user_name || ' IDENTIFIED BY ' || pwd || ' DEFAULT TABLESPACE SYSTEM';
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
    
        --lv_stmt := 'DROP USER CSYT_' || user_name || ' CASCADE ';
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
        lv_stmt := 'CREATE ROLE CSYT_ROLE_' || role_name;
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
        EXECUTE IMMEDIATE ('REVOKE INSERT ON CSYT_ADMIN.'||obj||' FROM '||user_name);
    ELSIF priType<2 THEN
        EXECUTE IMMEDIATE ( 'drop view CSYT_ADMIN.'||obj ); 

        
    ELSIF priType<3 THEN
        EXECUTE IMMEDIATE ('REVOKE UPDATE ON CSYT_ADMIN.'||obj||' FROM '||user_name);
    ELSE
        EXECUTE IMMEDIATE ('REVOKE DELETE ON CSYT_ADMIN.'||obj||' FROM '||user_name);        
    END IF;
	
                                                
	COMMIT;
END;
/
--exec CSYT_Admin.revokePrivilege('CSYT_MEANSUN',1,'VIEW_CSYT_MEANSUN_HSBA');

create or replace procedure CSYT_ADMIN.ShowTables (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR SELECT table_name FROM user_tables;
    
    END;
/



create or replace procedure CSYT_ADMIN.ShowPriviledge (username NVARCHAR2, mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from all_tab_privs where grantee like '%CSYT_'||USERNAME||'%';
    
    END;
/

create or replace procedure CSYT_ADMIN.ShowTable (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from user_tables;
    
    END;
/
create or replace procedure CSYT_ADMIN.ShowTableCol (tblname nvarchar2,mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR
SELECT column_name
FROM user_tab_cols
WHERE table_name = tblname;
   END;
/

create or replace procedure CSYT_ADMIN.ShowRolePriv (roleName nvarchar2,mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR
SELECT role,table_name,privilege FROM role_TAB_PRIVS
WHERE role = roleName and privilege != 'UPDATE';
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
        Open CUR for SELECT USERNAME FROM dba_users where USERNAME like 'CSYT%' and USERNAME !='CSYT_ADMIN';

    END;
    /

create or replace procedure CSYT_Admin.ShowAllRole (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT ROLE FROM dba_roles where ROLE like 'CSYT_ROLE_%';

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
    
    sqlstmt:='create or replace view CSYT_ADMIN.VIEW_'||username||'_'||tab_priv||' as select ';
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
    sqlstmt:=concat(RTRIM(sqlstmt,','),' from CSYT_ADMIN.'||tab_priv);
    DBMS_OUTPUT.PUT_LINE(sqlstmt);
	EXECUTE IMMEDIATE ( sqlstmt ); 
    if opt = 'true' then
            execute IMMEDIATE ('grant select on CSYT_ADMIN.VIEW_'||username||'_'||tab_priv|| ' to ' || username || ' with grant option');
        else
            execute IMMEDIATE ('grant select on CSYT_ADMIN.VIEW_'||username||'_'||tab_priv|| ' to ' || username );
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
GrantUpdate('CSYT_MEANSUN','MAHSBA','HSBA','False');
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



-----------------------------------------------------------
--Chuc nang phan he 2


create or replace procedure CSYT_ADMIN.getUserRoles(cur out SYS_REFCURSOR)
as
begin
    OPEN cur FOR SELECT GRANTED_ROLE from dba_role_PRIVS where grantee like user AND GRANTED_ROLE LIKE 'CSYT_%';
    --open cur for Select user from dual;
    --DBMS_SQL.return_result(cur);
end;
/
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
-- tu dong tao ma nhan vien
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
--tu dong tao ma benh nhan
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
DROP ROLE CSYT_ROLE_THANHTRA;
DROP ROLE CSYT_ROLE_QUANLIDULIEU;
DROP ROLE CSYT_ROLE_BACSI;
DROP ROLE CSYT_ROLE_NGHIENCUU;
DROP ROLE CSYT_ROLE_NHANVIEN;
DROP ROLE CSYT_ROLE_BENHNHAN;
/


/
------------------------------
--Cau 2
create role CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.HSBA TO CSYT_ROLE_THANHTRA; 
GRANT SELECT ON CSYT_Admin.HSBA_DV TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.BenhNhan TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.CSYT TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.NhanVien TO CSYT_ROLE_THANHTRA;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_THANHTRA;
/

-----------------------------
--Cau 3:
create role CSYT_ROLE_QUANLIDULIEU;
/
create or replace view CSYT_Admin.View_QuanLiDuLieu_HSBA as 
select CSYT_Admin.HSBA.* from CSYT_Admin.HSBA
where CSYT_Admin.HSBA.MaCSYT in  ( select CSYT_Admin.NhanVien.CSYT from CSYT_Admin.NhanVien
    where 'CSYT_'||CSYT_Admin.NhanVien.MaNV = user)
    and to_number(to_char(sysdate, 'dd')) >= to_number(to_char(to_date('2022-01-05','yyyy-mm-dd'), 'dd'))
    and to_number(to_char(sysdate, 'dd')) <= to_number(to_char(to_date('2022-01-27','yyyy-mm-dd'), 'dd'));

/    
create or replace view CSYT_Admin.View_QuanLiDuLieu_HSBA_DV as 
select CSYT_Admin.HSBA_DV.* from CSYT_Admin.HSBA_DV
where CSYT_Admin.HSBA_DV.MaHSBA in  (SELECT CSYT_Admin.HSBA.MaHSBA FROM CSYT_Admin.HSBA, CSYT_Admin.NhanVien
                                    WHERE CSYT_Admin.HSBA.MaCSYT =  CSYT_Admin.NhanVien.CSYT
                                    and 'CSYT_'||CSYT_Admin.NhanVien.MaNV = user )
    
    and to_number(to_char(sysdate, 'dd')) >= to_number(to_char(to_date('2022-01-05','yyyy-mm-dd'), 'dd'))
    and to_number(to_char(sysdate, 'dd')) <= to_number(to_char(to_date('2022-01-27','yyyy-mm-dd'), 'dd'));

/
grant select on CSYT_Admin.View_QuanLiDuLieu_HSBA to CSYT_ROLE_QUANLIDULIEU;
grant select on CSYT_Admin.View_QuanLiDuLieu_HSBA_DV to CSYT_ROLE_QUANLIDULIEU;

/
create or replace procedure CSYT_Admin.QLDL_Insert_HSBA(
    MaBN  in      CHAR, 
    Ngay     in   DATE, 
    ChanDoan  in  NVARCHAR2, 
    MaBS    in    CHAR, 
    MaKHOA   in   CHAR, 
    KetLuan  in   NVARCHAR2)
is
MaHSBA  CHAR(10); 
user_CSYT char(10);

Begin
    select CSYT_Admin.NhanVien.CSYT into user_CSYT  from CSYT_Admin.NhanVien
    where 'CSYT_'||CSYT_Admin.NhanVien.MaNV = user;
    MaHSBA := CSYT_ADMIN.func_auto_MaHSBA;
    insert into CSYT_Admin.View_QuanLiDuLieu_HSBA 
    values(MaHSBA   , 
    CSYT_Admin.QLDL_Insert_HSBA.MaBN  , 
    CSYT_Admin.QLDL_Insert_HSBA.Ngay    , 
    CSYT_Admin.QLDL_Insert_HSBA.ChanDoan , 
    CSYT_Admin.QLDL_Insert_HSBA.MaBS    , 
    CSYT_Admin.QLDL_Insert_HSBA.MaKHOA  , 
    user_CSYT  ,
    CSYT_Admin.QLDL_Insert_HSBA.KetLuan );
    commit;
end;

/

create or replace procedure CSYT_Admin.QLDL_Insert_HSBA_DV(
   MaHSBA      CHAR, 
    MaDV        CHAR, 
    Ngay        DATE, 
    MaKTV       CHAR, 
    KetQua      NVARCHAR2)
is
user_MaHSBA char(10);

Begin
    SELECT CSYT_Admin.HSBA.MaHSBA into user_MaHSBA FROM CSYT_Admin.HSBA, CSYT_Admin.NhanVien
                                    WHERE CSYT_Admin.HSBA.MaCSYT =  CSYT_Admin.NhanVien.CSYT
                                    and 'CSYT_'||CSYT_Admin.NhanVien.MaNV = user 
                                    and CSYT_Admin.QLDL_Insert_HSBA_DV.MaHSBA = csyt_admin.hsba.mahsba;
    if CSYT_Admin.QLDL_Insert_HSBA_DV.MaHSBA = user_MaHSBA
    then 
    insert into CSYT_Admin.View_QuanLiDuLieu_HSBA_DV 
    values(
    CSYT_Admin.QLDL_Insert_HSBA_DV.MaHSBA  , 
    CSYT_Admin.QLDL_Insert_HSBA_DV.MaDV  , 
    CSYT_Admin.QLDL_Insert_HSBA_DV.Ngay  , 
    CSYT_Admin.QLDL_Insert_HSBA_DV.MaKTV  , 
    CSYT_Admin.QLDL_Insert_HSBA_DV.KetQua );
    end if;
    commit;
end;
/
create or replace procedure CSYT_ADMIN.QLDL_Delete_HSBA(
MAHSBA char)
as
lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'Delete CSYT_ADMIN.HSBA_DV where MaHSBA = '''|| trim(MAHSBA)||'''';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'Delete CSYT_ADMIN.HSBA where MaHSBA = '''|| trim(MAHSBA)||'''';
    EXECUTE IMMEDIATE ( lv_stmt );
end;
/
create or replace procedure CSYT_ADMIN.QLDL_Delete_HSBA_DV(
MAHSBA char,
MADV char)
as
lv_stmt   VARCHAR2 (1000);
begin
    lv_stmt := 'Delete CSYT_ADMIN.HSBA_DV where MaHSBA = '''|| trim(MAHSBA)||''''
    ||' and MaDV = '''||trim(MADV)||'''';
    EXECUTE IMMEDIATE ( lv_stmt ); 
end;


/
grant execute on CSYT_Admin.QLDL_Insert_HSBA to CSYT_ROLE_QUANLIDULIEU;
grant execute on CSYT_Admin.QLDL_Insert_HSBA_DV to CSYT_ROLE_QUANLIDULIEU;
grant execute on CSYT_ADMIN.QLDL_Delete_HSBA to CSYT_ROLE_QUANLIDULIEU;
grant execute on CSYT_ADMIN.QLDL_Delete_HSBA_DV to CSYT_ROLE_QUANLIDULIEU;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_QUANLIDULIEU;

/

-----------------------------------
--Cau 4:
create role CSYT_ROLE_BACSI;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_BACSI_HSBA
as SELECT * FROM CSYT_ADMIN.HSBA
WHERE CSYT_ADMIN.HSBA.MAHSBA IN (SELECT MAHSBA FROM CSYT_ADMIN.HSBA 
                                WHERE 'CSYT_'||MaBS = user);
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_BACSI_HSBA_DV
as SELECT * FROM CSYT_ADMIN.HSBA_DV
WHERE CSYT_ADMIN.HSBA_DV.MAHSBA IN (SELECT MAHSBA FROM CSYT_ADMIN.HSBA 
                                WHERE 'CSYT_'||MaBS = user);
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_BACSI_BENHNHAN
as select MaBN,MaCSYT,TenBN,CSYT_ADMIN.DECRYPT(CMND,MABN||MACSYT) as CMND,  
CSYT_ADMIN.DECRYPT(SONHA,MABN||MACSYT) as SONHA,
CSYT_ADMIN.DECRYPT(TENDUONG,MABN||MACSYT) as TENDUONG,
CSYT_ADMIN.DECRYPT(QUANHUYEN,MABN||MACSYT) as QUANHUYEN,
CSYT_ADMIN.DECRYPT(TINHTP,MABN||MACSYT) as TINHTP,
tiensubenh,tiensubenhgd,diungthuoc
FROM CSYT_Admin.BenhNhan
/
CREATE OR REPLACE PROCEDURE CSYT_ADMIN.BACSI_SELECT_BENHNHAN(
MABN IN CHAR DEFAULT NULL,
CMND IN CHAR DEFAULT NULL,
BENHNHAN OUT SYS_REFCURSOR)
AS 
BEGIN
    OPEN CSYT_ADMIN.BACSI_SELECT_BENHNHAN.BENHNHAN FOR 
    SELECT * FROM CSYT_ADMIN.VIEW_BACSI_BENHNHAN
    WHERE MABN = CSYT_ADMIN.BACSI_SELECT_BENHNHAN.MABN 
    OR CMND = CSYT_ADMIN.BACSI_SELECT_BENHNHAN.CMND;
END;
/
GRANT SELECT ON CSYT_ADMIN.VIEW_BACSI_HSBA TO CSYT_ROLE_BACSI;
GRANT SELECT ON CSYT_ADMIN.VIEW_BACSI_HSBA_DV TO CSYT_ROLE_BACSI;
GRANT SELECT ON CSYT_ADMIN.VIEW_BACSI_BENHNHAN TO CSYT_ROLE_BACSI;
GRANT EXECUTE ON CSYT_ADMIN.BACSI_SELECT_BENHNHAN TO CSYT_ROLE_BACSI;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_BACSI;
/
------------------------------------
--Cau 5:
CREATE ROLE CSYT_ROLE_NGHIENCUU;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_NGHIENCUU_HSBA
AS
SELECT * FROM CSYT_ADMIN.HSBA
WHERE CSYT_ADMIN.HSBA.MACSYT IN (SELECT MACSYT FROM CSYT_ADMIN.NHANVIEN
                                WHERE 'CSYT_'||MaNV = user)
AND CSYT_ADMIN.HSBA.MAKHOA IN (SELECT CHUYENKHOA FROM CSYT_ADMIN.NHANVIEN
                                WHERE 'CSYT_'||MaNV = user);
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_NGHIENCUU_HSBA_DV
AS
SELECT * FROM CSYT_ADMIN.HSBA_DV
WHERE CSYT_ADMIN.HSBA_DV.MAHSBA IN (SELECT CSYT_ADMIN.HSBA.MAHSBA FROM CSYT_ADMIN.NHANVIEN,CSYT_ADMIN.HSBA
                                WHERE 'CSYT_'||CSYT_ADMIN.NHANVIEN.MaNV = user
                                AND CSYT_ADMIN.NHANVIEN.CSYT = CSYT_ADMIN.HSBA.MACSYT
                                AND CSYT_ADMIN.NHANVIEN.CHUYENKHOA =  CSYT_ADMIN.HSBA.MAKHOA)
/
GRANT SELECT ON CSYT_ADMIN.VIEW_NGHIENCUU_HSBA TO CSYT_ROLE_NGHIENCUU;
GRANT SELECT ON CSYT_ADMIN.VIEW_NGHIENCUU_HSBA_DV TO CSYT_ROLE_NGHIENCUU;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_NGHIENCUU;
/




CREATE OR REPLACE FUNCTION CSYT_ADMIN.ENCRYPT(pi_input VARCHAR2,pi_key VARCHAR2)
RETURN RAW
AS
    input_string VARCHAR2(100) := pi_input;
    raw_input RAW(128) := utl_raw.cast_to_raw(CONVERT(input_string,'AL32UTF8','US7ASCII'));
    key_string VARCHAR2(100) := pi_key;
    raw_key RAW(128) :=utl_raw.cast_to_raw(CONVERT(key_string,'AL32UTF8','US7ASCII'));
    encrypted_raw varchar2(2000);
    encrypted_string VARCHAR2(2000);
BEGIN
    dbms_output.put_line('key:'||raw_key);
    encrypted_raw := dbms_crypto.ENCRYPT(src => raw_input,
    typ => dbms_crypto.des_cbc_pkcs5,
    KEY => raw_key);

    RETURN encrypted_raw;
END;
/



CREATE OR REPLACE FUNCTION csyt_admin.DECRYPT(pi_input RAW,pi_key VARCHAR2)
RETURN VARCHAR2
AS
    key_string VARCHAR2(100) := pi_key;
    raw_key RAW(1280) :=utl_raw.cast_to_raw(CONVERT(key_string,'AL32UTF8','US7ASCII'));

    decrypted_raw varchar2(2000);
    decrypted_string VARCHAR2(2000);
BEGIN
dbms_output.put_line('key:'||raw_key);
    BEGIN 
    decrypted_raw := dbms_crypto.DECRYPT(src => pi_input,
    typ => dbms_crypto.des_cbc_pkcs5,
    KEY => raw_key);
    decrypted_string:=CONVERT(utl_raw.cast_to_varchar2(decrypted_raw),'US7ASCII','AL32UTF8');
    RETURN decrypted_string;
        EXCEPTION 
        WHEN OTHERS THEN
        RETURN NULL;
    END;    
END;
/


CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_I_BN 
    BEFORE 
    INSERT 
    ON CSYT_ADMIN.BenhNhan
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW
BEGIN
    dbms_output.put_line('key:'||:NEW.MaBN||:New.MaCSYT);


:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaBN||:New.MaCSYT);

:NEW.SoNha      := CSYT_ADMIN.encrypt(:NEW.SoNha,:NEW.MaBN||:New.MaCSYT);

:NEW.TenDuong   := CSYT_ADMIN.encrypt(:NEW.TenDuong,:NEW.MaBN||:New.MaCSYT);

:NEW.QuanHuyen  := CSYT_ADMIN.encrypt(:NEW.QuanHuyen,:NEW.MaBN||:New.MaCSYT);

:NEW.TinhTP     := CSYT_ADMIN.encrypt(:NEW.TinhTP,:NEW.MaBN||:New.MaCSYT);

END;
/


CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_U_BN 
    BEFORE 
    UPDATE 
    ON CSYT_ADMIN.BenhNhan
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW
BEGIN
    dbms_output.put_line('key:'||:NEW.MaBN||:New.MaCSYT);

IF(:NEW.CMND!=:OLD.CMND)
THEN
:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaBN||:New.MaCSYT);
END IF;
IF(:NEW.SoNha!=:OLD.SoNha)
THEN
:NEW.SoNha      := CSYT_ADMIN.encrypt(:NEW.SoNha,:NEW.MaBN||:New.MaCSYT);
END IF;
IF(:NEW.TenDuong!=:OLD.TenDuong)
THEN
:NEW.TenDuong   := CSYT_ADMIN.encrypt(:NEW.TenDuong,:NEW.MaBN||:New.MaCSYT);
END IF;
IF(:NEW.QuanHuyen!=:OLD.QuanHuyen)
THEN
:NEW.QuanHuyen  := CSYT_ADMIN.encrypt(:NEW.QuanHuyen,:NEW.MaBN||:New.MaCSYT);
END IF;
IF(:NEW.TinhTP!=:OLD.TinhTP)
THEN
:NEW.TinhTP     := CSYT_ADMIN.encrypt(:NEW.TinhTP,:NEW.MaBN||:New.MaCSYT);
END IF;
END;
/

CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_I_NV 
    BEFORE 
    INSERT
    ON CSYT_ADMIN.NhanVien
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW

BEGIN

:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaNV||:New.CSYT);

:NEW.QueQuan    := CSYT_ADMIN.encrypt(:NEW.QueQuan,:NEW.MaNV||:New.CSYT);

END;
/


CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_U_NV 
    BEFORE 
    UPDATE 
    ON CSYT_ADMIN.NhanVien
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW

BEGIN
IF(:NEW.CMND!=:OLD.CMND)
THEN
:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaNV||:New.CSYT);
END IF;
IF(:NEW.QueQuan!=:OLD.QueQuan)
THEN
:NEW.QueQuan    := CSYT_ADMIN.encrypt(:NEW.QueQuan,:NEW.MaNV||:New.CSYT);
END IF;
END;
/


-------------------------------
--CAU 6: 
CREATE ROLE CSYT_ROLE_BENHNHAN;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
AS
select MaBN,MaCSYT,TenBN,CSYT_ADMIN.DECRYPT(CMND,MABN||MACSYT) as CMND,  
CSYT_ADMIN.DECRYPT(SONHA,MABN||MACSYT) as SONHA,
CSYT_ADMIN.DECRYPT(TENDUONG,MABN||MACSYT) as TENDUONG,
CSYT_ADMIN.DECRYPT(QUANHUYEN,MABN||MACSYT) as QUANHUYEN,
CSYT_ADMIN.DECRYPT(TINHTP,MABN||MACSYT) as TINHTP,
NgaySinh,tiensubenh,tiensubenhgd,diungthuoc
FROM CSYT_Admin.BenhNhan
WHERE 'CSYT_'||MaBN = user
/

GRANT SELECT ON CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW TO CSYT_ROLE_BENHNHAN;
GRANT UPDATE ON CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW TO CSYT_ROLE_BENHNHAN;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_BENHNHAN;
/

CREATE ROLE CSYT_ROLE_NHANVIEN;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW
AS
SELECT  MANV,HOTEN,PHAI,NGAYSINH,
CSYT_ADMIN.DECRYPT(CMND,MaNV||CSYT) as CMND,
CSYT_ADMIN.DECRYPT(QUEQUAN,MaNV||CSYT) AS QUEQUAN, SDT
FROM CSYT_Admin.NhanVien

WHERE 'CSYT_'||MaNV = user
/
GRANT SELECT ON CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW TO CSYT_ROLE_NHANVIEN;
GRANT UPDATE ON CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW TO CSYT_ROLE_NHANVIEN;
GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_ROLE_NHANVIEN;
/







--SELECT * FROM DBA_COL_PRIVS where grantee like 'CSYT_MEANSUN';
--SELECT * FROM DBA_TAB_PRIVS where grantee like 'CSYT_MEANSUN';
--grant update (MAHSBA) on CSYT_ADMIN.HSBA to CSYT_MEANSUN;
--SELECT PRIVILEGE FROM DBA_SYS_PRIVS where grantee like 'CSYT_ADMIN';







--insert data
INSERT INTO CSYT_Admin.CSYT VALUES ('CS001','Benh vien Mat trung uong','TP.HCM','0123456789');
INSERT INTO CSYT_Admin.CSYT VALUES ('CS002','Benh vien Quan Y','Ha Noi','0123456789');
INSERT INTO CSYT_Admin.CSYT VALUES ('CS003','Benh vien Y duoc TPHCM','TP.HCM','0123456789');


INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN001','CS001','Pham Tan Ti', '112233445',to_date('19/04/2001','dd/mm/yyyy'), '15', 'Phan Van Tri', 'Go Vap', 'TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN002','CS001','Tran Minh Son','118833445',to_date('19/05/2002','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN003','CS001','Lam Quoc Binh','662233445',to_date('19/08/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN004','CS002','Kamisato Ayaka','112233775',to_date('08/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN005','CS002','Le Ngoc Tai','112299445',to_date('19/11/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN006','CS002','Nguyen Quang Quy','332233445',to_date('19/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN007','CS003','Le Nam Thai Son','112233885',to_date('19/05/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN008','CS003','Doc Co Cau Bai','662233445',to_date('19/04/2004','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN009','CS003','Dong Phuong Bat Bai','112255445',to_date('19/10/2005','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null,Null);

INSERT INTO CSYT_Admin.NhanVien VALUES ('NV001','Akira Mierashai','Nam',to_date('19/04/2001','dd/mm/yyyy'),'114477223','Inazuma','0123456789','CS001','Thanh tra',null,Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV002','Yae Miko','Nu',to_date('19/06/2002','dd/mm/yyyy'),'114488223','Inazuma','0123456789','CS001','Y/ bac si','KH001',Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV003','Xuan Hoang','Nam',to_date('12/08/2000','dd/mm/yyyy'),'334477223','Lam Dong','0123456789','CS001','Nghien cuu','KH002',Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV004','Ningguang','Nu',to_date('02/06/2000','dd/mm/yyyy'),'114477993','Trung Quoc','0123456789','CS002','Thanh tra',null,Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV005','Ganyu','Nu',to_date('03/08/2001','dd/mm/yyyy'),'114454223','Liyue','0123456789','CS002','Y/ bac si','KH003',Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV006','Cong Minh Hang','Nu',to_date('08/04/2001','dd/mm/yyyy'),'178477223','Tp.HCM','0123456789','CS002','Y/ bac si','KH002',Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV007','Ly Mac Sau','Nu',to_date('12/02/2002','dd/mm/yyyy'),'114967223','Nhat Ban','0123456789','CS003','Thanh tra',null,Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV008','Raiden Shogun','Nu',to_date('19/09/2001','dd/mm/yyyy'),'114197223','Inazuma','0123456789','CS003','Y/ bac si','KH001',Null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV009','Signora','Nu',to_date('18/03/2000','dd/mm/yyyy'),'113217223','Nga','0123456789','CS003','Nghien cuu','KH003',Null);

    
INSERT INTO CSYT_Admin.HSBA VALUES ('HS001','BN001',to_date('19/04/2022','dd/mm/yyyy'),'Dau da day','NV002','KH001','CS001','Ung thu da day');
INSERT INTO CSYT_Admin.HSBA VALUES ('HS002','BN002',to_date('29/06/2022','dd/mm/yyyy'),'Gay tay','NV002','KH001','CS001','Gay xuong tay');
INSERT INTO CSYT_Admin.HSBA VALUES ('HS003','BN004',to_date('12/05/2022','dd/mm/yyyy'),'Gay chan','NV005','KH002','CS002','Gay xuong chau');
INSERT INTO CSYT_Admin.HSBA VALUES ('HS004','BN005',to_date('15/07/2022','dd/mm/yyyy'),'Xuat huyet nao','NV005','KH001','CS002','Chan thuong so nao');
INSERT INTO CSYT_Admin.HSBA VALUES ('HS005','BN007',to_date('02/08/2022','dd/mm/yyyy'),'Thoat vi dia dem','NV008','KH003','CS003','Gay cot song');
INSERT INTO CSYT_Admin.HSBA VALUES ('HS006','BN008',to_date('08/03/2022','dd/mm/yyyy'),'Dau mat','NV008','KH002','CS003','Duc thuy tinh the');

    
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS001','DV001',to_date('19/04/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS001','DV003',to_date('19/04/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS002','DV001',to_date('29/06/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS003','DV001',to_date('12/05/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS004','DV001',to_date('15/07/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS004','DV002',to_date('15/07/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS005','DV001',to_date('02/08/2022','dd/mm/yyyy'),'NV009','Co benh');
INSERT INTO CSYT_Admin.HSBA_DV VALUES ('HS006','DV001',to_date('08/03/2022','dd/mm/yyyy'),'NV009','Co benh');

--cau 1

--Xoa tai khoan cua toan bo nhan vien va benh nhan
declare
cur SYS_refcursor;
manv dba_users.username%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select username from dba_users where username like 'CSYT_%' and username != 'CSYT_ADMIN';
    loop
    
        fetch cur into manv;
        exit when cur%NOTFOUND;
        lv_stmt := 'drop user ' || trim(manv) || ' Cascade';
        EXECUTE IMMEDIATE ( lv_stmt );

    end loop;
    close cur;
end;
        
/
--Them tai khoan cho toan bo nhan vien

declare
cur SYS_refcursor;
manv csyt_admin.nhanvien.manv%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.nhanvien.manv from CSYT_Admin.NhanVien where Username is null;
    loop
    
        fetch cur into manv;
        exit when cur%NOTFOUND;
        lv_stmt := 'CREATE USER CSYT_' || trim(manv) || ' IDENTIFIED BY ' || 'a' || ' DEFAULT TABLESPACE SYSTEM';

        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'GRANT CONNECT TO CSYT_' || trim(manv);
        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_' || trim(manv);

        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt := 'update CSYT_Admin.NhanVien set Username = ''CSYT_'||trim(manv)||''' where MaNV = '''||trim(manv)||'''';
        --DBMS_OUTPUT.put_line(lv_stmt);
        EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;
/
--them tai khoan cho toan bo benh nhan
declare
cur SYS_refcursor;
mabn csyt_admin.BenhNhan.MaBN%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.BenhNhan.mabn from CSYT_Admin.BenhNhan where Username is null;
    loop
    
        fetch cur into mabn;
        exit when cur%NOTFOUND;
        lv_stmt := 'CREATE USER CSYT_' || trim(mabn) || ' IDENTIFIED BY ' || 'a' || ' DEFAULT TABLESPACE SYSTEM';

        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'update CSYT_Admin.BenhNhan set Username = ''CSYT_'||trim(mabn)||''' where MaBN = '''||trim(mabn)||'''';
        --DBMS_OUTPUT.put_line(lv_stmt);
        EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;


/





ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;
/