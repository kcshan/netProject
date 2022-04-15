-- ����ѧԱ��Ϣ���ݱ�
use StudentManageDB
go
if exists(select * from sysobjects where name='Students')
drop table Students
go
create table Students
(
	StudentId int identity(10000,1), -- ѧ��
	StudentName varchar(20) not null, -- ����
	Gender char(2) not null, -- �Ա�
	Birthday datetime not null, -- ��������
	StudentIdNo numeric(18,0) not null, -- ���֤��
	Age int not null, -- ����
	PhoneNumber varchar(50),
	StudentAddress varchar(500),
	ClassId int not null, -- �༶���
)
go
-- select * from Students
-- �����༶��
if exists(select * from sysobjects where name='StudentClass')
drop table StudentClass
go
create table StudentClass
(
	ClassId int primary key, -- �༶���
	ClassName varchar(20) not null,
)
go
-- �����ɼ���
if exists(select * from sysobjects where name='ScoreList')
drop table ScoreList
go
create table ScoreList
(
	Id int identity(1,1) primary key,
	StudentId int not null, -- ѧ�����
	CSharp int null,
	SQLServer int null,
	UpdateTime datetime not null -- ����ʱ��
)
go
go
-- ��������Ա��
if exists(select * from sysobjects where name='Admins')
drop table Admins
go
create table Admins
(
	LoginId int identity(1000,1) primary key,
	LoginPwd varchar(20) not null, -- ��¼����
	AdminName varchar(20) not null
)
go
