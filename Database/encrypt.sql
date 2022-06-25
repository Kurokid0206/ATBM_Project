CREATE OR REPLACE FUNCTION CSYT_ADMIN.ENCRYPT(pi_input VARCHAR2,pi_key VARCHAR2)
RETURN RAW
AS
    input_string VARCHAR2(16) := pi_input;
    raw_input RAW(128) := utl_raw.cast_to_raw(CONVERT(input_string,'AL32UTF8','US7ASCII'));
    key_string VARCHAR2(100) := pi_key;
    raw_key RAW(128) :=utl_raw.cast_to_raw(CONVERT(key_string,'AL32UTF8','US7ASCII'));
    encrypted_raw RAW(2048);
    encrypted_string VARCHAR2(2048);
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
    raw_key RAW(128) :=utl_raw.cast_to_raw(CONVERT(key_string,'AL32UTF8','US7ASCII'));

    decrypted_raw RAW(2048);
    decrypted_string VARCHAR2(2048);
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



CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_BN 
    BEFORE 
    INSERT OR UPDATE 
    ON CSYT_ADMIN.BenhNhan
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW
BEGIN
:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaBN||:New.MaCSYT);
:NEW.SoNha      := CSYT_ADMIN.encrypt(:NEW.SoNha,:NEW.MaBN||:New.MaCSYT);
:NEW.TenDuong   := CSYT_ADMIN.encrypt(:NEW.TenDuong,:NEW.MaBN||:New.MaCSYT);
:NEW.QuanHuyen  := CSYT_ADMIN.encrypt(:NEW.QuanHuyen,:NEW.MaBN||:New.MaCSYT);
:NEW.TinhTP     := CSYT_ADMIN.encrypt(:NEW.TinhTP,:NEW.MaBN||:New.MaCSYT);
END;
/



CREATE OR REPLACE TRIGGER CSYT_ADMIN.ENCRYPT_NV 
    BEFORE 
    INSERT OR UPDATE 
    ON CSYT_ADMIN.NhanVien
    REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW

BEGIN
:NEW.CMND       := CSYT_ADMIN.encrypt(:NEW.CMND,:NEW.MaNV||:New.CSYT);
:NEW.QueQuan    := CSYT_ADMIN.encrypt(:NEW.QueQuan,:NEW.MaNV||:New.CSYT);
:NEW.SDT        := CSYT_ADMIN.encrypt(:NEW.SDT,:NEW.MaNV||:New.CSYT);
END;
/



--audit
ALTER SYSTEM SET audit_sys_operations=TRUE SCOPE=SPFILE;
BEGIN
    DBMS_FGA.ADD_POLICY (
        object_schema      =>  'CSYT_ADMIN', 
        object_name        =>  'ACCOUNTS', 
        policy_name        =>  'accounts_access', 
        audit_condition    =>  'BAL >= 20000',
        statement_types    =>  'SELECT'
    ); 
END;
/


--DELETE FROM DBA_FGA_AUDIT_TRAIL where object_schema='ACCMASTER';
--Check audit query
--SELECT db_user,timestamp,object_schema,object_name,statement_type,sql_text from DBA_FGA_AUDIT_TRAIL;
