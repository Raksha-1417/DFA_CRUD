create database DFA_Data
USE DFA_Data


create table Products(
Pid int primary key Identity(1,1),
PName varchar(20),
PBrand varchar(20),
PDescription varchar(25),
Price int
)
drop table Products
