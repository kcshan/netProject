use StudentManageDB
go
insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,PhoneNumber,StudentAddress,ClassId)
values('��С�','Ů','1989-01-12',26,120229198901121314,'022-88997766','���ӱ���',1)

--use SMDB
--go
--select StudentName,Gender,Age where age >= 22
--select StudentName,Gender,Age where age != 22

use StudentManageDB
go
update Students set Gender='��',Age=25 where StudentId=10000

--use SMDB
--go
--insert into Students (StudentName,Gender,Birthday,Age,StudentIdNo,PhoneNumber,StudentAddress,ClassId)
--values('��С�','Ů','1989-01-12',26,120229198901121314,'022-88997766','���ӱ���',1)
--select * from Students
--delete from Students where StudentId=100000
--delete from ScoreList where StudentId=100000

select * from Students