grant select on dba_users to CSYT_Admin;
create or replace procedure CSYT_Admin.ShowAllUser (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT USERNAME FROM dba_users where USERNAME like 'C##CSYT%';

    END;
    /
grant select on dba_roles to CSYT_Admin;
/
create or replace procedure CSYT_Admin.ShowAllRole (CUR out SYS_REFCURSOR)
as

    BEGIN
        Open CUR for SELECT ROLE FROM dba_roles where ROLE like 'C##CSYT_ROLE_%';

    END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_TENBN(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TENBN=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_CMND(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET CMND=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_NGAYSINH(input IN DATE DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET ngaysinh=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_SONHA(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TENBN=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_TENDUONG(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TENDUONG=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_QUANHUYEN(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET QUANHUYEN=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_TINHTP(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TINHTP=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENH(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TIENSUBENH=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENHGD(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET TIENSUBENHGD=input;
END;
/
create or replace procedure CSYT_ADMIN.BENHNHAN_UPDATE_DIUNGTHUOC(input IN NVARCHAR2 DEFAULT NULL)
AS 
BEGIN
    UPDATE CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
    SET DIUNGTHUOC=input;
END;
/
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_TENBN to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_CMND to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_NGAYSINH to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_SONHA to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_TENDUONG to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_QUANHUYEN to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_TINHTP to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENH to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_TIENSUBENHGD to CSYT_ROLE_BENHNHAN;
grant execute on CSYT_ADMIN.BENHNHAN_UPDATE_DIUNGTHUOC to CSYT_ROLE_BENHNHAN;
/



















/
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