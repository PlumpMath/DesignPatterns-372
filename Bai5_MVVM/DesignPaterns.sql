create database DesignPatterns
use DesignPatterns
create table Student
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name Nvarchar (100),
	Phone varchar(20),
	Address nvarchar(250)
)
create table Product
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Name Nvarchar (100),
	Price decimal(18,0),
	Description nvarchar(250)
)