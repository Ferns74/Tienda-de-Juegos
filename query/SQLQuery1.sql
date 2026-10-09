create database inicio_sesion 
use inicio_sesion 

create table usuarios(
id int primary key,
usuario varchar(100),
password varchar(100)
)

insert into usuarios values ('01', 'admin', '12345')
insert into usuarios values ('02', 'cliente', '18002224')

SELECT * FROM usuarios	 

