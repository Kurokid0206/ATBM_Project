DROP USER C##CSYT_Admin CASCADE;



DROP TABLE C##CSYT_Admin.HSBA     CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.HSBA_DV  CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.BenhNhan CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.CSYT     CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.NhanVien CASCADE CONSTRAINTS;

CREATE USER C##CSYT_Admin IDENTIFIED BY a;

CREATE TABLE C##CSYT_Admin.HSBA (
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

CREATE TABLE C##CSYT_Admin.HSBA_DV (
    MaHSBA      CHAR(10), 
    MaDV        CHAR(5), 
    Ngay        DATE, 
    MaKTV       CHAR(10), 
    KetQua      NVARCHAR2(50),
    CONSTRAINT PK_HSBA_DV_N04 PRIMARY KEY(MaHSBA,MaDV,Ngay)
);

CREATE TABLE C##CSYT_Admin.BenhNhan (
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

CREATE TABLE C##CSYT_Admin.CSYT (
    MaCSYT  CHAR(5), 
    TenCSYT NVARCHAR2(30), 
    DCCSYT  NVARCHAR2(100), 
    SDTCSYT NVARCHAR2(11),
    CONSTRAINT PK_CSYT_N04 PRIMARY KEY(MaCSYT)
);

CREATE TABLE C##CSYT_Admin.NhanVien (
    MaNV        CHAR(10), 
    HoTen       NVARCHAR2(50), 
    CMND        CHAR(10), 
    NgaySinh    DATE, 
    Phai        NVARCHAR2(3),
    QueQuan     NVARCHAR2(50), 
    SDT         CHAR(11),
    CSYT        CHAR(5), 
    VaiTro      NVARCHAR2(10),--???? 
    ChuyenKhoa  NVARCHAR2(20),--???TRIGGER?
    CONSTRAINT PK_NhanVien_N04 PRIMARY KEY(MaNV)
);

ALTER TABLE C##CSYT_Admin.HSBA        ADD CONSTRAINT FK_BN_HSBA_N04 FOREIGN KEY (MaBN)    REFERENCES C##CSYT_Admin.BenhNhan(MaBN);
ALTER TABLE C##CSYT_Admin.HSBA_DV     ADD CONSTRAINT FK_DV_HSBA_N04 FOREIGN KEY (MaHSBA)  REFERENCES C##CSYT_Admin.HSBA(MaHSBA);
ALTER TABLE C##CSYT_Admin.BenhNhan    ADD CONSTRAINT FK_BN_CSYT_N04 FOREIGN KEY (MaCSYT)  REFERENCES C##CSYT_Admin.CSYT(MaCSYT);
ALTER TABLE C##CSYT_Admin.NhanVien    ADD CONSTRAINT FK_NV_CSYT_N04 FOREIGN KEY (CSYT)    REFERENCES C##CSYT_Admin.CSYT(MaCSYT);




GRANT CONNECT TO C##CSYT_Admin WITH ADMIN OPTION;


--GRANT ALL PRIVILEGES TO C##CSYT_DBA;

GRANT CREATE USER TO C##CSYT_Admin CONTAINER=ALL;
GRANT DROP USER TO C##CSYT_Admin CONTAINER=ALL;
GRANT ALTER USER TO C##CSYT_Admin Container=All;

GRANT SELECT ON dba_users TO C##CSYT_Admin;
GRANT SELECT ON dba_roles TO C##CSYT_Admin;
GRANT CREATE ROLE TO C##CSYT_Admin CONTAINER=ALL;
GRANT CREATE TABLE TO C##CSYT_Admin;

