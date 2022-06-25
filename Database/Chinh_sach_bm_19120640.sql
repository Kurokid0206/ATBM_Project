 ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;


/
DROP ROLE CSYT_ROLE_THANHTRA;
DROP ROLE CSYT_ROLE_QUANLIDULIEU;
DROP ROLE CSYT_ROLE_BACSI;
DROP ROLE CSYT_ROLE_NGHIENCUU;
DROP ROLE CSYT_ROLE_NHANVIEN;
DROP ROLE CSYT_ROLE_BENHNHAN;


/
------------------------------
--Cau 2
create role CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.HSBA TO CSYT_ROLE_THANHTRA; 
GRANT SELECT ON CSYT_Admin.HSBA_DV TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.BenhNhan TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.CSYT TO CSYT_ROLE_THANHTRA;
GRANT SELECT ON CSYT_Admin.NhanVien TO CSYT_ROLE_THANHTRA;
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
    MaHSBA   in   CHAR, 
    MaBN  in      CHAR, 
    Ngay     in   DATE, 
    ChanDoan  in  NVARCHAR2, 
    MaBS    in    CHAR, 
    MaKHOA   in   CHAR, 
    MaCSYT   in   CHAR,
    KetLuan  in   NVARCHAR2)
is
user_CSYT char(5);

Begin
    select CSYT_Admin.NhanVien.CSYT into user_CSYT  from CSYT_Admin.NhanVien
    where 'CSYT_'||CSYT_Admin.NhanVien.MaNV = user;
    if CSYT_Admin.QLDL_Insert_HSBA.MaCSYT = user_CSYT
    then 
    insert into CSYT_Admin.View_QuanLiDuLieu_HSBA 
    values( CSYT_Admin.QLDL_Insert_HSBA.MaHSBA   , 
    CSYT_Admin.QLDL_Insert_HSBA.MaBN  , 
    CSYT_Admin.QLDL_Insert_HSBA.Ngay    , 
    CSYT_Admin.QLDL_Insert_HSBA.ChanDoan , 
    CSYT_Admin.QLDL_Insert_HSBA.MaBS    , 
    CSYT_Admin.QLDL_Insert_HSBA.MaKHOA  , 
    CSYT_Admin.QLDL_Insert_HSBA.MaCSYT  ,
    CSYT_Admin.QLDL_Insert_HSBA.KetLuan );
    end if;
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
grant execute on CSYT_Admin.QLDL_Insert_HSBA to CSYT_ROLE_QUANLIDULIEU;
grant execute on CSYT_Admin.QLDL_Insert_HSBA_DV to CSYT_ROLE_QUANLIDULIEU;


grant DELETE on CSYT_Admin.View_QuanLiDuLieu_HSBA to CSYT_ROLE_QUANLIDULIEU;
grant DELETE on CSYT_Admin.View_QuanLiDuLieu_HSBA_DV to CSYT_ROLE_QUANLIDULIEU;
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
CREATE OR REPLACE PROCEDURE CSYT_ADMIN.BACSI_SELECT_BENHNHAN(
MABN IN CHAR DEFAULT NULL,
CMND IN CHAR DEFAULT NULL,
BENHNHAN OUT SYS_REFCURSOR)
AS 
BEGIN
    OPEN CSYT_ADMIN.BACSI_SELECT_BENHNHAN.BENHNHAN FOR 
    SELECT * FROM CSYT_ADMIN.BENHNHAN
    WHERE MABN = CSYT_ADMIN.BACSI_SELECT_BENHNHAN.MABN 
    OR CMND = CSYT_ADMIN.BACSI_SELECT_BENHNHAN.CMND;
END;
/
GRANT SELECT ON CSYT_ADMIN.VIEW_BACSI_HSBA TO CSYT_ROLE_BACSI;
GRANT SELECT ON CSYT_ADMIN.VIEW_BACSI_HSBA_DV TO CSYT_ROLE_BACSI;
GRANT EXECUTE ON CSYT_ADMIN.BACSI_SELECT_BENHNHAN TO CSYT_ROLE_BACSI;
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
/

-------------------------------
--CAU 6: 
CREATE ROLE CSYT_ROLE_BENHNHAN;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW
AS
SELECT * FROM CSYT_ADMIN.BENHNHAN
WHERE 'CSYT_'||MaBN = user
/
GRANT SELECT ON CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW TO CSYT_ROLE_BENHNHAN;
GRANT UPDATE ON CSYT_ADMIN.VIEW_BENHNHAN_SELFVIEW TO CSYT_ROLE_BENHNHAN;
/

CREATE ROLE CSYT_ROLE_NHANVIEN;
/
CREATE OR REPLACE VIEW CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW
AS
SELECT * FROM CSYT_ADMIN.NHANVIEN
WHERE 'CSYT_'||MaNV = user
/
GRANT SELECT ON CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW TO CSYT_ROLE_NHANVIEN;
GRANT UPDATE ON CSYT_ADMIN.VIEW_NHANVIEN_SELFVIEW TO CSYT_ROLE_NHANVIEN;
/


--test
DROP USER CSYT_NV002 cascade;
create user CSYT_NV002 identified by a;
grant connect to CSYT_NV002;
GRANT CSYT_ROLE_BACSI TO CSYT_NV002;


/


ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;
--SELECT * FROM dba_ROLE_privs WHERE GRANTEE LIKE '%DBA%';
--SELECT * FROM dba_TAB_privs WHERE GRANTEE LIKE 'CSYT_%';




