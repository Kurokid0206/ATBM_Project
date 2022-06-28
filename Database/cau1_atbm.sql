    
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
/
--Them tai khoan cho toan bo nhan vien
declare
cur SYS_refcursor;
manv csyt_admin.nhanvien.manv%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.nhanvien.manv from CSYT_Admin.NhanVien where Username is null;
    loop
    
        fetch cur into manv;
        exit when cur%NOTFOUND;
        lv_stmt := 'CREATE USER CSYT_' || trim(manv) || ' IDENTIFIED BY ' || 'a' || ' DEFAULT TABLESPACE SYSTEM';

        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'GRANT CONNECT TO CSYT_' || trim(manv);
        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'GRANT EXECUTE ON CSYT_ADMIN.getUserRoles TO CSYT_' || trim(manv);

        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt := 'update CSYT_Admin.NhanVien set Username = ''CSYT_'||trim(manv)||''' where MaNV = '''||trim(manv)||'''';
        --DBMS_OUTPUT.put_line(lv_stmt);
        EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;
/
--xoa tai khoan cua toan bo nhan vien
declare
cur SYS_refcursor;
manv char(15);
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.nhanvien.manv from CSYT_Admin.NhanVien where Username is not null;
    loop
    
        fetch cur into manv;
        exit when cur%NOTFOUND;
        lv_stmt := 'DROP USER CSYT_' || trim(manv);

        EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'update CSYT_Admin.NhanVien set Username = Null where MaNV = '''||trim(manv)||'''';
      EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;
/
---------------
--them tai khoan cho toan bo benh nhan

declare
cur SYS_refcursor;
mabn csyt_admin.BenhNhan.MaBN%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.BenhNhan.mabn from CSYT_Admin.BenhNhan where Username is null;
    loop
    
        fetch cur into mabn;
        exit when cur%NOTFOUND;
        lv_stmt := 'CREATE USER CSYT_' || trim(mabn) || ' IDENTIFIED BY ' || 'a' || ' DEFAULT TABLESPACE SYSTEM';

        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'update CSYT_Admin.BenhNhan set Username = ''CSYT_'||trim(mabn)||''' where MaBN = '''||trim(mabn)||'''';
        --DBMS_OUTPUT.put_line(lv_stmt);
        EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;
/
--xoa tai khoan cho toan bo benh nhan
declare
cur SYS_refcursor;
mabn csyt_admin.BenhNhan.MaBN%type;
lv_stmt   VARCHAR2 (1000);
begin
    
    open cur for select csyt_admin.BenhNhan.MaBN from CSYT_Admin.BenhNhan;
    loop
    
        fetch cur into mabn;
        exit when cur%NOTFOUND;
        lv_stmt := 'DROP USER CSYT_' || trim(mabn) ;

        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt := 'update CSYT_Admin.NhanVien set Username = Null where MaNV = '''||trim(mabn)||'''';
        EXECUTE IMMEDIATE ( lv_stmt ); 

    end loop;
    close cur;
end;
/
ALTER SESSION SET "_ORACLE_SCRIPT"=false;

