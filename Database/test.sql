SELECT * FROM user_SYS_PRIVS;
SELECT * FROM user_ROLE_PRIVS;
SELECT USERNAME 
FROM all_users join user_tables on USERNAME like table_name ;

select table_name
from user_tables;

SELECT USERNAME
FROM all_users
where USERNAME like 'C##CSYT%';

SELECT table_name as DanhSachBang
FROM user_tables
ORDER BY table_name;

SELECT USERNAME
FROM all_users
where USERNAME like 'C##CSYT%'

select * from dba_roles;
SELECT * FROM DBA_SYS_PRIVS;
SELECT * FROM DBA_ROLE_PRIVS;
SELECT * FROM user_ROLE_PRIVS;

select * from all_user_privs;
SELECT * FROM dba_users;

SELECT * FROM USER_SYS_PRIVS;