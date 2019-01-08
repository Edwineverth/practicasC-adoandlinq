insert into Autor values ('Lucas Grey', 'www.google.com','luc_es@gmail.com')

insert into Autor values ('Lucas Grey1', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey2', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey3', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey4', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey5', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey6', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey7', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey8', 'www.google.com','luc_es@gmail.com')
insert into Autor values ('Lucas Grey9', 'www.google.com','luc_es@gmail.com')


insert into Cliente values ('Person1', 'Villaflora1', '0986574921')
insert into Cliente values ('Person2', 'Villaflora2', '0986574922')
insert into Cliente values ('Person3', 'Villaflora3', '0986574923')
insert into Cliente values ('Person4', 'Villaflora4', '0986574924')
insert into Cliente values ('Person5', 'Villaflora5', '0986574925')
insert into Cliente values ('Person6', 'Villaflora6', '0986574926')
insert into Cliente values ('Person7', 'Villaflora7', '0986574927')
insert into Cliente values ('Person8', 'Villaflora8', '0986574928')

insert into Libro values ('ISB1', 'Miranda1', 'La cula es de la vaca1', 1)
insert into Libro values ('ISB2', 'Mirandaa', 'La cula es de la vaca21', 2)
insert into Libro values ('ISB3', 'Mirandab', 'La cula es de la vaca23', 3)
insert into Libro values ('ISB4', 'Mirandac', 'La cula es de la vaca13', 4)
insert into Libro values ('ISB5', 'Mirandad', 'La cula es de la vaca65', 5)



insert into Ejemplar values ('MICA', 'VVOS', 20.25, 1,2,1)
insert into Ejemplar values ('LOZA', 'META', 14.25, 2,1,1)
insert into Ejemplar values ('MEASDAS', 'CCASDFASD', 14.25, 2,4,3)


select * from Autor

select * from Cliente
update Autor set Nombre = 'Edwin Sander' where AutorId=1;

select * from Ejemplar 
select * from Libro


select a.Nombre, l.Isbn, e.Precio
from Autor a inner join Libro l
on a.AutorId = l.AutorId inner join Ejemplar e
on l.LibroId = e.LibroId

select a.Nombre, SUM(e.Precio)
from Autor a inner join Libro l
on a.AutorId = l.AutorId inner join Ejemplar e 
on e.AutorId = l.AutorId 
group by a.Nombre

CREATE PROCEDURE sp_insertarAutor (
@Nombre varchar(50),
@Web varchar(100),
@Email varchar(200)
)
as
begin
set NOCOUNT ON; 
insert into Autor (Nombre,Web,Email) 
values (@Nombre, @Web,@Email)
end


Create procedure sp_actualizarAutor(
@Autorid integer,
@Nombre varchar(50),
@Web varchar(100),
@Email varchar(200)
)
as
begin
set NOCOUNT ON;
update Autor  set 
Nombre = @Nombre,
Web = @Web,
Email = @Email
where AutorId = @AutorId
end

create procedure sp_eliminarAutor(
@AutorId integer
)
as
begin
set nocount on;
delete from Autor
where AutorId = @Autorid
end

create procedure sp_listarAutor
as
begin
set nocount on;
select * from Autor
end


create procedure sp_listarAutorP
(
@parametro varchar (50)
)
as 
begin
set nocount on;
select * from Autor
where Nombre = @parametro
end