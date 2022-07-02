ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
DROP USER CSYT_GDS CASCADE;
DROP USER CSYT_GDCS CASCADE;
DROP USER CSYT_YBS CASCADE;
DROP USER CSYT_YBS_CTT CASCADE;

CREATE USER CSYT_GDS IDENTIFIED BY a Quota 10M on users CONTAINER = CURRENT;
CREATE USER CSYT_GDCS IDENTIFIED BY a Quota 10M on users CONTAINER = CURRENT;
CREATE USER CSYT_YBS IDENTIFIED BY a Quota 10M on users CONTAINER = CURRENT;
CREATE USER CSYT_YBS_CTT IDENTIFIED BY a Quota 10M on users CONTAINER = CURRENT;

GRANT CONNECT TO CSYT_GDS,CSYT_GDCS,CSYT_YBS,CSYT_YBS_CTT;

ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

CREATE TABLE CSYT_Admin.ThongBao (
    MaTB       INTEGER GENERATED ALWAYS AS IDENTITY (START WITH 1 INCREMENT BY 1) NOT NULL,
    NoiDung    NVARCHAR2(1000), 
    NgayGio    TIMESTAMP, 
    DiaDiem    NVARCHAR2(1000), 
    CONSTRAINT PK_ThongBao_N04 PRIMARY KEY(MaTB)
);

insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Giam doc so',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Co so y te',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Y bac sy noi tru',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Trung tam');
insert into CSYT_Admin.ThongBao(NoiDung,NgayGio,DiaDiem) values('Y bac sy ngoai tru',to_timestamp('10-Sep-02 14:10:10.123000', 'DD-Mon-RR HH24:MI:SS.FF'),'Can trung tam');


UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','GDS:NGT,NT,CS:TT') WHERE NoiDung like '%Giam doc so%';
UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','GDCS:NT:TT') WHERE NoiDung like '%Co so y te%';
UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','YBS:NT:TT') WHERE NoiDung like '%Y bac sy noi tru%';
UPDATE CSYT_Admin.ThongBao SET OLS_THONGBAO = CHAR_TO_LABEL('ACCESS_THONGBAO','YBS:NGT:CTT') WHERE NoiDung like '%Y bac sy ngoai tru%' AND DiaDiem='Can trung tam';


GRANT INSERT,SELECT ON CSYT_Admin.THONGBAO TO CSYT_GDS;
GRANT INSERT,SELECT ON CSYT_Admin.THONGBAO TO CSYT_GDCS;
GRANT INSERT,SELECT ON CSYT_Admin.THONGBAO TO CSYT_YBS;
GRANT INSERT,SELECT ON CSYT_Admin.THONGBAO TO  CSYT_YBS_CTT;

GRANT INSERT,SELECT ON CSYT_Admin.THONGBAO TO CSYT_GDS;
GRANT CSYT_ROLE_THANHTRA TO CSYT_GDS;
SELECT * FROM CSYT_ADMIN.THONGBAO;
ALTER SYSTEM CHECKPOINT;