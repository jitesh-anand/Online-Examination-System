create database questions
use questions
create table qtabel1
(
qid int identity(1,1) primary key,
qno varchar(5),
que varchar(500),
opA varchar (50),
opB varchar (50),
opC varchar (50),
opD varchar (50),
correct varchar(50)
);
select * from qtabel1

create table qtabel2
(
qid int identity(1,1) primary key,
qno varchar(5),
que varchar(500),
opA varchar (100),
opB varchar (100),
opC varchar (100),
opD varchar (100),
correct varchar(10)
);
select * from qtabel2



