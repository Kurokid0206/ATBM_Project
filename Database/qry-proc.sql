SELECT table_name as DanhSachBang
FROM user_tables
ORDER BY table_name;

DROP procedure ShowTables;
create or replace procedure ShowTables (mycursor OUT SYS_REFCURSOR)
as

    BEGIN
    OPEN mycursor FOR SELECT table_name FROM user_tables;
    
    END;
/
select * from dba_roles;
/*variable rc refcursor;
exec showtables(:rc);
print rc;*/