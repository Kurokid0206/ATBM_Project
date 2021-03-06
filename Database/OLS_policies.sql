--select * from DBA_SA_Policies;

GRANT EXECUTE ON SA_COMPONENTS TO CSYT_ADMIN;

GRANT EXECUTE ON SA_LABEL_ADMIN TO CSYT_ADMIN;

GRANT EXECUTE ON SA_POLICY_ADMIN TO CSYT_ADMIN;

GRANT EXECUTE ON SA_USER_ADMIN TO CSYT_ADMIN;

GRANT EXECUTE ON CHAR_TO_LABEL TO CSYT_ADMIN;

EXECUTE SA_SYSDBA.DROP_POLICY('ACCESS_THONGBAO');

EXECUTE SA_SYSDBA.CREATE_POLICY('ACCESS_THONGBAO','OLS_THONGBAO');






--level: Giám đốc
--compartment: ngoại trú
--group: trung/cận trung/ ngoại

EXEC SA_COMPONENTS.CREATE_LEVEL('ACCESS_THONGBAO',150,'GDS','GIAM_DOC_SO');
EXEC SA_COMPONENTS.CREATE_LEVEL('ACCESS_THONGBAO',100,'GDCS','GIAM_DOC_CSYT');
EXEC SA_COMPONENTS.CREATE_LEVEL('ACCESS_THONGBAO',50,'YBS','Y_BSI');


EXEC SA_COMPONENTS.CREATE_COMPARTMENT('ACCESS_THONGBAO',80,'CS','CHUYEN_SAU');
EXEC SA_COMPONENTS.CREATE_COMPARTMENT('ACCESS_THONGBAO',70,'NT','NOI_TRU');
EXEC SA_COMPONENTS.CREATE_COMPARTMENT('ACCESS_THONGBAO',60,'NGT','NGOAI_TRU');


EXEC SA_COMPONENTS.CREATE_GROUP('ACCESS_THONGBAO',120,'TT','TRUNG_TAM');
EXEC SA_COMPONENTS.CREATE_GROUP('ACCESS_THONGBAO',200,'CTT','CAN_TRUNG_TAM','TT');
EXEC SA_COMPONENTS.CREATE_GROUP('ACCESS_THONGBAO',300,'NTH','NGOAI_THANH','TT');


EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 100,label_value => 'GDS:CS,NT,NGT:TT');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 200,label_value => 'GDCS:CS:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 210,label_value => 'GDCS:CS:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 220,label_value => 'GDCS:CS:NTH');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 230,label_value => 'GDCS:NT:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 240,label_value => 'GDCS:NT:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 250,label_value => 'GDCS:NT:NTH');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 260,label_value => 'GDCS:NGT:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 270,label_value => 'GDCS:NGT:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 280,label_value => 'GDCS:NGT:NTH');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 300,label_value => 'YBS:CS:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 310,label_value => 'YBS:CS:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 320,label_value => 'YBS:CS:NTH');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 330,label_value => 'YBS:NT:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 340,label_value => 'YBS:NT:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 350,label_value => 'YBS:NT:NTH');

EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 360,label_value => 'YBS:NGT:TT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 370,label_value => 'YBS:NGT:CTT');
EXEC SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ACCESS_THONGBAO',label_tag => 380,label_value => 'YBS:NGT:NTH');



EXEC SA_POLICY_ADMIN.APPLY_TABLE_POLICY(policy_name=>'ACCESS_THONGBAO',schema_name => 'CSYT_ADMIN',table_name => 'THONGBAO',table_options=>'READ_CONTROL,WRITE_CONTROL');



EXEC SA_USER_ADMIN.SET_USER_LABELS (policy_name=>'ACCESS_THONGBAO',user_name=>'CSYT_GDS',max_read_label=>'GDS:CS,NT,NGT:TT',max_write_label=>'GDS:CS,NT,NGT:TT',def_label=>'GDS:CS,NT,NGT:TT');
EXEC SA_USER_ADMIN.SET_USER_LABELS (policy_name=>'ACCESS_THONGBAO',user_name=>'CSYT_GDCS',max_read_label=>'GDCS:NT:TT',max_write_label=>'GDCS:NT:TT',def_label=>'GDCS:NT:TT');
EXEC SA_USER_ADMIN.SET_USER_LABELS (policy_name=>'ACCESS_THONGBAO',user_name=>'CSYT_YBS',max_read_label=>'YBS:NT:TT',max_write_label=>'YBS:NT:TT',def_label=>'YBS:NT:TT');
EXEC SA_USER_ADMIN.SET_USER_LABELS (policy_name=>'ACCESS_THONGBAO',user_name=>'CSYT_YBS_CTT',max_read_label=>'YBS:NGT:CTT',max_write_label=>'YBS:NGT:CTT',def_label=>'YBS:NGT:CTT');
