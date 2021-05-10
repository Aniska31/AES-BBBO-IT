--create database Supermarket

use Supermarket

--create table Departments
--(
--DName text,
--DCount_bars int,
--DCount_salers int,
--DNumber int
--)
--go

--alter table Departments --текстовый ключ сложен, поэтому просто добавим по айди
--add DID int not null identity(1,1) primary key
--go

--create table Clients
--(
--CID int not null identity(1,1) primary key,
--CName text,
--CAddress text,
--CPayment_type text
--)
--go

--create table Providers
--(
--PID int not null identity(1,1) primary key,
--PName text,
--PAddress text,
--PCountry text,
--PTransport_type text,
--PPayment_type text
--)
--go

--create table Goods
--(
--GID int not null identity(1,1) primary key,
--GName text,
--Department int,
--Provider int,
--GConditions text,
--GPeriod date
--)
--go

--create table Selling
--(
--SID int not null identity(1,1) primary key,
--Client int,
--Goods int,
--SDate date,
--STime date,
--SCount int,
--SPrice float,
--SSum float
--)
--go

--alter table Goods
--add foreign key(Department) references Departments(DID),
--foreign key(Provider) references Providers(PID)
--go

--alter table Selling
--add foreign key(Client) references Clients(CID),
--foreign key(Goods) references Goods(GID)
--go

--insert into Departments(DName, DCount_bars,DCount_salers,DNumber)
--values('Milk',20,2,7)
--go

--insert into Departments(DName, DCount_bars,DCount_salers,DNumber)
--values('Bread',52,1,1)
--go

--select * from Departments