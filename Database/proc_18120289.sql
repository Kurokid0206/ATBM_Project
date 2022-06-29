ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;

DROP USER CSYT_ThanhTra CASCADE;
DROP USER CSYT_NghienCuu CASCADE;

CREATE USER CSYT_TTQB IDENTIFIED BY a;
CREATE USER CSYT_NCQB IDENTIFIED BY a;

GRANT CONNECT TO CSYT_TTQB;
GRANT CONNECT TO CSYT_NCQB;

GRANT CSYT_ROLE_THANHTRA TO CSYT_TTQB;
GRANT CSYT_ROLE_NGHIENCUU TO CSYT_NCQB;

create or replace procedure CSYT_Admin.TT_Select_HSBA (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from CSYT_ADMIN.HSBA;
    END;
/

create or replace procedure CSYT_Admin.TT_Select_HSBA_DV (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from CSYT_ADMIN.HSBA_DV;
    END;
/

create or replace procedure CSYT_Admin.TT_Select_BenhNhan (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from CSYT_ADMIN.BenhNhan;
    END;
/

create or replace procedure CSYT_Admin.TT_Select_CSYT (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from CSYT_ADMIN.CSYT;
    END;
/

create or replace procedure CSYT_Admin.TT_Select_NhanVien (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR select * from CSYT_ADMIN.NhanVien;
    END;
/

GRANT EXECUTE ON CSYT_Admin.TT_Select_HSBA      TO CSYT_TTQB; 
GRANT EXECUTE ON CSYT_Admin.TT_Select_HSBA_DV   TO CSYT_TTQB; 
GRANT EXECUTE ON CSYT_Admin.TT_Select_BenhNhan  TO CSYT_TTQB; 
GRANT EXECUTE ON CSYT_Admin.TT_Select_CSYT      TO CSYT_TTQB; 
GRANT EXECUTE ON CSYT_Admin.TT_Select_NhanVien  TO CSYT_TTQB; 

create or replace procedure CSYT_Admin.NC_View_HSBA (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR SELECT * FROM CSYT_ADMIN.HSBA
                      WHERE CSYT_ADMIN.HSBA.MACSYT IN (SELECT MACSYT FROM CSYT_ADMIN.NHANVIEN WHERE 'CSYT_'||MaNV = user)
                      AND CSYT_ADMIN.HSBA.MAKHOA IN (SELECT CHUYENKHOA FROM CSYT_ADMIN.NHANVIEN WHERE 'CSYT_'||MaNV = user);
    END;
/

create or replace procedure CSYT_Admin.NC_View_HSBA_DV (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR SELECT * FROM CSYT_ADMIN.HSBA_DV
WHERE CSYT_ADMIN.HSBA_DV.MAHSBA IN (SELECT CSYT_ADMIN.HSBA.MAHSBA FROM CSYT_ADMIN.NHANVIEN,CSYT_ADMIN.HSBA
                                WHERE 'CSYT_'||CSYT_ADMIN.NHANVIEN.MaNV = user
                                AND CSYT_ADMIN.NHANVIEN.CSYT = CSYT_ADMIN.HSBA.MACSYT
                                AND CSYT_ADMIN.NHANVIEN.CHUYENKHOA =  CSYT_ADMIN.HSBA.MAKHOA);
    END;
/

GRANT EXECUTE ON CSYT_Admin.NC_View_HSBA      TO CSYT_NCQB; 
GRANT EXECUTE ON CSYT_Admin.NC_View_HSBA_DV   TO CSYT_NCQB; 

ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;