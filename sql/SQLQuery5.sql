use StudentManageDB
go
-- 添加相关约束
-- 创建主键约束
if exists(select * from sysobjects where name='pk_StudentId')
alter table Students drop constraint pk_StudentId

alter table Students add constraint pk_StudentId primary key(StudentId)
-- 创建唯一约束
if exists(select * from sysobjects where name='uq_StudentIdNo')
alter table Students drop constraint uq_StudentIdNo

alter table Students add constraint uq_StudentIdNo unique(StudentIdNo)

-- 创建检查约束
if exists(select * from sysobjects where name='ck_Age')
alter table Students drop constraint ck_Age
alter table Students add constraint ck_Age check(Age between 18 and 25)

if exists(select * from sysobjects where name='ck_PhoneNumber')
alter table Students drop constraint ck_PhoneNumber
alter table Students add constraint ck_PhoneNumber check(len(PhoneNumber)=11)

--update Students set PhoneNumber='13099012876' where StudentId=10000

-- 默认约束
if exists(select * from sysobjects where name='df_StudentAddress')
alter table Students drop constraint df_StudentAddress
alter table Students add constraint df_StudentAddress default('地址不详') for StudentAddress

insert into Students (StudentName, Gender, BirthDay, Age,
  StudentIdNo, PhoneNumber, StudentAddress, ClassId) 
  values('刘玲玲', '女', '1989-08-19', 26, 130223198908192237, '13854689745', default, 4)

if exists(select * from sysobjects where name='fk_ClassId')
alter table Students drop constraint fk_ClassId
alter table Students add constraint fk_ClassId foreign key(ClassId) references StudentClass(ClassId)

insert into StudentClass (ClassId,ClassName) values(4,'软件4班')

select * from Students
select * from StudentClass