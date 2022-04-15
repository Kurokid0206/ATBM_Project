DROP USER C##CSYT_Admin CASCADE;

DROP TABLE C##CSYT_Admin.HSBA     CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.HSBA_DV  CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.BenhNhan CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.CSYT     CASCADE CONSTRAINTS;
DROP TABLE C##CSYT_Admin.NhanVien CASCADE CONSTRAINTS;

CREATE USER C##CSYT_Admin IDENTIFIED BY a;
GRANT CONNECT TO C##CSYT_Admin;

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

ALTER TABLE C##CSYT_Admin.HSBA        ADD CONSTRAINT FK_BN_HSBA_N04 FOREIGN KEY (MaBN)    REFERENCES C##CSYT_Admin.BenhNhan(MaBN);
ALTER TABLE C##CSYT_Admin.HSBA_DV     ADD CONSTRAINT FK_DV_HSBA_N04 FOREIGN KEY (MaHSBA)  REFERENCES C##CSYT_Admin.HSBA(MaHSBA);
ALTER TABLE C##CSYT_Admin.BenhNhan    ADD CONSTRAINT FK_BN_CSYT_N04 FOREIGN KEY (MaCSYT)  REFERENCES C##CSYT_Admin.CSYT(MaCSYT);
ALTER TABLE C##CSYT_Admin.NhanVien    ADD CONSTRAINT FK_NV_CSYT_N04 FOREIGN KEY (CSYT)    REFERENCES C##CSYT_Admin.CSYT(MaCSYT);

GRANT UNLIMITED TABLESPACE TO C##CSYT_Admin;

GRANT CONNECT TO C##CSYT_Admin WITH ADMIN OPTION;



--GRANT ALL PRIVILEGES TO C##CSYT_DBA;

GRANT CREATE USER TO C##CSYT_Admin CONTAINER=ALL;
GRANT DROP USER TO C##CSYT_Admin CONTAINER=ALL;
GRANT ALTER USER TO C##CSYT_Admin Container=All;

GRANT SELECT ON dba_users TO C##CSYT_Admin;
GRANT SELECT ON dba_roles TO C##CSYT_Admin;
GRANT CREATE ROLE TO C##CSYT_Admin CONTAINER=ALL;
GRANT CREATE TABLE TO C##CSYT_Admin;
grant select on all_users to C##CSYT_Admin;/
grant select on DBA_TAB_PRIVS to C##CSYT_Admin;/

--insert data
INSERT INTO C##CSYT_Admin.CSYT VALUES ('CS001','Benh vien Mat trung uong','TP.HCM','0123456789');
INSERT INTO C##CSYT_Admin.CSYT VALUES ('CS002','Benh vien Quan Y','Ha Noi','0123456789');
INSERT INTO C##CSYT_Admin.CSYT VALUES ('CS003','Benh vien Y duoc TPHCM','TP.HCM','0123456789');


INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN001','CS001','Pham Tan Ti','112233445',to_date('19/04/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN002','CS001','Tran Minh Son','118833445',to_date('19/05/2002','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN003','CS001','Lam Quoc Binh','662233445',to_date('19/08/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN004','CS002','Kamisato Ayaka','112233775',to_date('08/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN005','CS002','Le Ngoc Tai','112299445',to_date('19/11/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN006','CS002','Nguyen Quang Quy','332233445',to_date('19/09/2001','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN007','CS003','Le Nam Thai Son','112233885',to_date('19/05/2003','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN008','CS003','Doc Co Cau Bai','662233445',to_date('19/04/2004','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);
INSERT INTO C##CSYT_Admin.BenhNhan VALUES ('BN009','CS003','Dong Phuong Bat Bai','112255445',to_date('19/10/2005','dd/mm/yyyy'),'15','Phan Van Tri','Go Vap','TP.HCM',Null,Null,Null);

INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV001','Akira Mierashai','Nam',to_date('19/04/2001','dd/mm/yyyy'),'114477223','Inazuma','0123456789','CS001','Thanh tra',null);
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV002','Yae Miko','Nu',to_date('19/06/2002','dd/mm/yyyy'),'114488223','Inazuma','0123456789','CS001','Y/ bac si','Da khoa');
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV003','Xuan Hoang','Nam',to_date('12/08/2000','dd/mm/yyyy'),'334477223','Lam Dong','0123456789','CS001','Nghien cuu','Chinh hinh');
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV004','Ningguang','Nu',to_date('02/06/2000','dd/mm/yyyy'),'114477993','Trung Quoc','0123456789','CS002','Thanh tra',null);
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV005','Ganyu','Nu',to_date('03/08/2001','dd/mm/yyyy'),'114454223','Liyue','0123456789','CS002','Y/ bac si','Rang ham mat');
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV006','Cong Minh Hang','Nu',to_date('08/04/2001','dd/mm/yyyy'),'178477223','Tp.HCM','0123456789','CS002','Y/ bac si','Chinh hinh');
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV007','Maria Ozirawa','Nu',to_date('12/02/2002','dd/mm/yyyy'),'114967223','Nhat Ban','0123456789','CS003','Thanh tra',null);
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV008','Raiden Shogun','Nu',to_date('19/09/2001','dd/mm/yyyy'),'114197223','Inazuma','0123456789','CS003','Y/ bac si','Rang ham mat');
INSERT INTO C##CSYT_Admin.NhanVien VALUES ('NV009','Signora','Nu',to_date('18/03/2000','dd/mm/yyyy'),'113217223','Nga','0123456789','CS003','Nghien cuu','Than kinh');


    
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS001','BN001',to_date('19/04/2022','dd/mm/yyyy'),'Dau da day','NV002','KH001','CS001','Ung thu da day');
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS002','BN002',to_date('29/06/2022','dd/mm/yyyy'),'Gay tay','NV002','KH001','CS001','Gay xuong tay');
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS003','BN004',to_date('12/05/2022','dd/mm/yyyy'),'Gay chan','NV005','KH002','CS002','Gay xuong chau');
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS004','BN005',to_date('15/07/2022','dd/mm/yyyy'),'Xuat huyet nao','NV005','KH001','CS002','Chan thuong so nao');
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS005','BN007',to_date('02/08/2022','dd/mm/yyyy'),'Thoat vi dia dem','NV008','KH003','CS003','Gay cot song');
INSERT INTO C##CSYT_Admin.HSBA VALUES ('HS006','BN008',to_date('08/03/2022','dd/mm/yyyy'),'Dau mat','NV008','KH002','CS003','Duc thuy tinh the');

    
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS001','DV001',to_date('19/04/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS001','DV003',to_date('19/04/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS002','DV001',to_date('29/06/2022','dd/mm/yyyy'),'NV003','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS003','DV001',to_date('12/05/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS004','DV001',to_date('15/07/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS004','DV002',to_date('15/07/2022','dd/mm/yyyy'),'NV006','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS005','DV001',to_date('02/08/2022','dd/mm/yyyy'),'NV009','Co benh');
INSERT INTO C##CSYT_Admin.HSBA_DV VALUES ('HS006','DV001',to_date('08/03/2022','dd/mm/yyyy'),'NV009','Co benh');


