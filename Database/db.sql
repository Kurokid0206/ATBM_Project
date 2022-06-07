ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
DROP USER CSYT_Admin CASCADE;

DROP TABLE CSYT_Admin.HSBA     CASCADE CONSTRAINTS;
DROP TABLE CSYT_Admin.HSBA_DV  CASCADE CONSTRAINTS;
DROP TABLE CSYT_Admin.BenhNhan CASCADE CONSTRAINTS;
DROP TABLE CSYT_Admin.CSYT     CASCADE CONSTRAINTS;
DROP TABLE CSYT_Admin.NhanVien CASCADE CONSTRAINTS;

CREATE USER CSYT_Admin IDENTIFIED BY a;
GRANT CONNECT TO CSYT_Admin;

CREATE TABLE CSYT_Admin.HSBA (
    MaHSBA      CHAR(10), 
    MaBN        CHAR(10), 
    Ngay        DATE, 
    ChanDoan    NVARCHAR2(100), 
    MaBS        CHAR(10), 
    MaKHOA      CHAR(5), 
    MaCSYT      CHAR(5),
    KetLuan     NVARCHAR2(100),
    CONSTRAINT PK_MaHSBA_N04 PRIMARY KEY(MaHSBA)
);

CREATE TABLE CSYT_Admin.HSBA_DV (
    MaHSBA      CHAR(10), 
    MaDV        CHAR(5), 
    Ngay        DATE, 
    MaKTV       CHAR(10), 
    KetQua      NVARCHAR2(50),
    CONSTRAINT PK_HSBA_DV_N04 PRIMARY KEY(MaHSBA,MaDV,Ngay)
);

CREATE TABLE CSYT_Admin.BenhNhan (
    MaBN            CHAR(10), 
    MaCSYT          CHAR(5), 
    TenBN           NVARCHAR2(50), 
    CMND            CHAR(9), 
    NgaySinh        DATE, 
    SoNha           NVARCHAR2(10),
    TenDuong        NVARCHAR2(20), 
    QuanHuyen       NVARCHAR2(20), 
    TinhTP          NVARCHAR2(20), 
    TienSuBenh      NVARCHAR2(50), 
    TienSuBenhGD    NVARCHAR2(50),
    DiUngThuoc      NVARCHAR2(50),
    CONSTRAINT PK_BenhNhan_N04 PRIMARY KEY(MaBN)
);

CREATE TABLE CSYT_Admin.CSYT (
    MaCSYT  CHAR(5), 
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
    CMND        CHAR(10), 
    QueQuan     NVARCHAR2(50), 
    SDT         CHAR(11),
    CSYT        CHAR(5), 
    VaiTro      NVARCHAR2(20),--???? 
    ChuyenKhoa  NVARCHAR2(20),--???TRIGGER?
    CONSTRAINT PK_NhanVien_N04 PRIMARY KEY(MaNV)
);

ALTER TABLE CSYT_Admin.HSBA        ADD CONSTRAINT FK_BN_HSBA_N04 FOREIGN KEY (MaBN)    REFERENCES CSYT_Admin.BenhNhan(MaBN);
ALTER TABLE CSYT_Admin.HSBA_DV     ADD CONSTRAINT FK_DV_HSBA_N04 FOREIGN KEY (MaHSBA)  REFERENCES CSYT_Admin.HSBA(MaHSBA);
ALTER TABLE CSYT_Admin.BenhNhan    ADD CONSTRAINT FK_BN_CSYT_N04 FOREIGN KEY (MaCSYT)  REFERENCES CSYT_Admin.CSYT(MaCSYT);
ALTER TABLE CSYT_Admin.NhanVien    ADD CONSTRAINT FK_NV_CSYT_N04 FOREIGN KEY (CSYT)    REFERENCES CSYT_Admin.CSYT(MaCSYT);

GRANT UNLIMITED TABLESPACE TO CSYT_Admin;

GRANT CONNECT TO CSYT_Admin WITH ADMIN OPTION;



--GRANT ALL PRIVILEGES TO CSYT_DBA;

GRANT CREATE USER TO CSYT_Admin CONTAINER=ALL;
GRANT DROP USER TO CSYT_Admin CONTAINER=ALL;
GRANT ALTER USER TO CSYT_Admin Container=All;

GRANT SELECT ON dba_users TO CSYT_Admin;
GRANT SELECT ON dba_roles TO CSYT_Admin;
GRANT CREATE ROLE TO CSYT_Admin CONTAINER=ALL;
GRANT CREATE TABLE TO CSYT_Admin;
grant select on all_users to CSYT_Admin;/
grant select on DBA_TAB_PRIVS to CSYT_Admin;/
grant create view to CSYT_ADMIN CONTAINER=ALL;

--insert data
INSERT INTO CSYT_Admin.CSYT VALUES ('CS001','Benh vien Mat trung uong','TP.HCM','0123456789');
INSERT INTO CSYT_Admin.CSYT VALUES ('CS002','Benh vien Quan Y','Ha Noi','0123456789');
INSERT INTO CSYT_Admin.CSYT VALUES ('CS003','Benh vien Y duoc TPHCM','TP.HCM','0123456789');


INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN001','CS001','Pham Tan Ti','112233445',to_date('19/04/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN002','CS001','Tran Minh Son','118833445',to_date('19/05/2002','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN003','CS001','Lam Quoc Binh','662233445',to_date('19/08/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN004','CS002','Kamisato Ayaka','112233775',to_date('08/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN005','CS002','Le Ngoc Tai','112299445',to_date('19/11/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN006','CS002','Nguyen Quang Quy','332233445',to_date('19/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN007','CS003','Le Nam Thai Son','112233885',to_date('19/05/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN008','CS003','Doc Co Cau Bai','662233445',to_date('19/04/2004','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO CSYT_Admin.BenhNhan VALUES ('BN009','CS003','Dong Phuong Bat Bai','112255445',to_date('19/10/2005','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);

INSERT INTO CSYT_Admin.NhanVien VALUES ('NV001','Akira Mierashai','Nam',to_date('19/04/2001','dd/mm/yyyy'),'114477223','Inazuma','0123456789','CS001','Thanh tra',null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV002','Yae Miko','Nu',to_date('19/06/2002','dd/mm/yyyy'),'114488223','Inazuma','0123456789','CS001','Y/ bac si','Da khoa');
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV003','Xuan Hoang','Nam',to_date('12/08/2000','dd/mm/yyyy'),'334477223','Lam Dong','0123456789','CS001','Nghien cuu','Chinh hinh');
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV004','Ningguang','Nu',to_date('02/06/2000','dd/mm/yyyy'),'114477993','Trung Quoc','0123456789','CS002','Thanh tra',null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV005','Ganyu','Nu',to_date('03/08/2001','dd/mm/yyyy'),'114454223','Liyue','0123456789','CS002','Y/ bac si','Rang ham mat');
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV006','Cong Minh Hang','Nu',to_date('08/04/2001','dd/mm/yyyy'),'178477223','Tp.HCM','0123456789','CS002','Y/ bac si','Chinh hinh');
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV007','Maria Ozirawa','Nu',to_date('12/02/2002','dd/mm/yyyy'),'114967223','Nhat Ban','0123456789','CS003','Thanh tra',null);
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV008','Raiden Shogun','Nu',to_date('19/09/2001','dd/mm/yyyy'),'114197223','Inazuma','0123456789','CS003','Y/ bac si','Rang ham mat');
INSERT INTO CSYT_Admin.NhanVien VALUES ('NV009','Signora','Nu',to_date('18/03/2000','dd/mm/yyyy'),'113217223','Nga','0123456789','CS003','Nghien cuu','Than kinh');


    
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

CREATE USER CSYT_MeanSun IDENTIFIED by a;/
grant connect to CSYT_MeanSun; /
grant UNLIMITED TABLESPACE to CSYT_MeanSun;/
grant select on all_users to CSYT_Admin;/
grant select on DBA_TAB_PRIVS to CSYT_Admin;/

ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

--SELECT * FROM DBA_COL_PRIVS where grantee like 'CSYT_MEANSUN';
--SELECT * FROM DBA_TAB_PRIVS where grantee like 'CSYT_MEANSUN';
--grant update (MAHSBA) on CSYT_ADMIN.HSBA to CSYT_MEANSUN;
--SELECT PRIVILEGE FROM DBA_SYS_PRIVS where grantee like 'CSYT_ADMIN';
