ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;

CREATE USER CSYT_Admin IDENTIFIED BY a;
CREATE USER CSYT_GDS IDENTIFIED BY a;
CREATE USER CSYT_GDCS IDENTIFIED BY a;
CREATE USER CSYT_YBS IDENTIFIED BY a;

GRANT CONNECT TO CSYT_GDS,CSYT_GDCS,CSYT_YBS;

GRANT SELECT ON CSYT_Admin.THONGBAO TO CSYT_GDS;
GRANT SELECT ON CSYT_Admin.THONGBAO TO CSYT_GDCS;
GRANT SELECT ON CSYT_Admin.THONGBAO TO CSYT_YBS;

DROP TABLE CSYT_Admin.ThongBao;
CREATE TABLE CSYT_Admin.ThongBao (
    MaTB       INTEGER GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    NoiDung    NVARCHAR2(1000), 
    NgayGio    TIMESTAMP, 
    DiaDiem    NVARCHAR2(1000), 
    CONSTRAINT PK_ThongBao_N04 PRIMARY KEY(MaTB)
);

insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Giam doc so',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Co so y te',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Y bac sy',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');


UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','GDS:CS,NT,NGT') WHERE NoiDung like '%Giam doc so%';
UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','GDCS:CS,NT:TT') WHERE NoiDung like '%Co so y te%';
UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','YBS:CS:TT') WHERE NoiDung like '%Y bac sy%' AND DiaDiem='Trung tam';

--
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Thanh tra',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Ngoai Thanh');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Thanh tra',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Ngoai Thanh');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Thanh tra',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Ngoai Thanh');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Thanh tra',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Ngoai Thanh');
