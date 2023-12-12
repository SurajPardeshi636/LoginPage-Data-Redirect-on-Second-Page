Create Table UserMasterData
(
UserId int Primary key identity(1,1) ,
UserName varchar(Max) not null,
Passwords Varchar(max)not null
)

Create table EmployeeMasterData
(
UserId int FOREIGN KEY REFERENCES UserMasterData(UserId),
EmpId int identity (1,1) not null,
FirstName Varchar(255) not null,
LastName varchar(255) not null,
Department varchar(255) not null,
City varchar(255)
)



insert into UserMasterData
(UserName,Passwords)
values
('TataTech','Tata101')

insert into UserMasterData
(UserName,Passwords)
values
('LG','LG102')

insert into UserMasterData
(UserName,Passwords)
values
('HCL','HCL103')

select * from UserMasterData


--same fill data eployee master data table 
--we cann fee dirctly ssms through

select * from EmployeeMasterData


alter proc LogInProc
@UserName varchar(255),
@Passwords Varchar(255)
as
begin
select UserId from UserMasterData where UserName=@UserName and Passwords=@Passwords
End

exec LogInProc 'TataTech','Tata101'

select * from UserMasterData

create proc DetailEmp
@UserId int
as
begin
select * from EmployeeMasterData  where  UserId=@UserId 
End

exec DetailEmp 1

sp_helptext DetailEmp

select *from UserMasterData

Create proc LogInProc01
@UserId int,
@Passwords Varchar(255)
as
begin
select UserId from UserMasterData where UserId=@UserId and Passwords=@Passwords
End