create database RentalCar;
create Table Cars(
ID int not null,
BrandId int not null,
ColorId int not null,
Model varchar(100) not null,
Years int not null,
DailaryPrice decimal not null,
Discription varchar(250) null default null
PRIMARY KEY (ID) );

create table Customers(
ID int not null,
Name varchar not null,
Lastname varchar not null,
[E-mail] varchar not null,
PRIMARY key(ID));

create table Rentals(
ID int Not null,
CustomersId int not null,
CarId int not null,
RentDate datetime not null,
ReturnDate datetime null default null,
PRIMARY KEY (ID));

create table Colors (
ID int not null,
ColorName varchar(250) not null,
PRIMARY KEY (ID));
create table Brands(
ID int not null,
[BrandName] varchar(250) not null,
PRIMARY KEY (ID));

create table Users (
ID int not null,
CustomerID int not null,
CompanyName Varchar(250) not null,
PRIMARY KEY (ID));

Insert into Cars  (ID,BrandId,ColorId,Model,Years,DailaryPrice,Discription) 
values (1,2,2,"SUV",2021,500.00,"Yeni geldi");


