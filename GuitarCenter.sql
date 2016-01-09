use master;

create database GuitarCenterDB;
GO

use GuitarCenterDB;
GO

create table Guitars
(
	Id int primary key identity(1,1),  
	Name nvarchar(512), 
	Description nvarchar(2056)
)
GO

create table Reviews
(
	Id int primary key identity(1,1),  
	Comment nvarchar(2056), 
	Score int , 
	GuitarId int references  Guitars(Id)
)
go 

create procedure usp_guitars_count
as 
select count(*)  from Guitars 
go

create procedure usp_guitar_get
as 
select *  from Guitars 
go
create procedure usp_guitar_get_one
@Id int
as 
select *  from Guitars where Id = @Id