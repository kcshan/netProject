-- ���������ǿ��Ա�д�κβ������ݿ�Ĵ���
-- ����Ҫָ����������ݿ�

use master
go
--select * from sysdatabases
if exists(select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB
go

-- �������ݿ�
create database CourseManageDB
on primary
(
	-- ���ݿ���߼��ļ���������ϵͳ�õģ�����Ψһ��
	name='CourseManageDB_data',
	-- ���ݿ������ļ���������·����
	-- �������ļ���
	filename='D:\workspace\DB\CourseManageDB_data.mdf',
	-- ���ݿ��ʼ�ļ���С(һ��Ҫ�������ʵ��������������)
	size=10MB,
	-- �����ļ���ֵ����ҲҪ�ο��ļ������С��
	filegrowth=1MB
)
,
(
	name='CourseManageDB_data1',
	-- ��Ҫ�����ļ���
	filename='D:\workspace\DB\CourseManageDB_data1.ndf',
	size=10MB,
	filegrowth=1MB
)
log on
(
	name='CourseManageDB_log',
	-- ��־�ļ���
	filename='D:\workspace\DB\CourseManageDB_log.ldf',
	size=10MB,
	filegrowth=1MB
)
go
-- ָ��Ҫ���������ݿ�
use CourseManageDB
go
-- ������ʦ��
if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go
create table Teacher
(
	TeacherId int primary key, -- ��ʦ��ţ�����
	LoginAccount varchar(50) not null, -- ��¼�˺�
	LoginPwd varchar(18) not null,
	TeacherName varchar(20) not null,
	Phonenumber char(11) not null, -- �绰
	NowAddress nvarchar(100) not null -- סַ
)
go
-- �γ̷����
if exists(select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
	CategoryId int identity(10,1) primary key,
	CategoryName varchar(20) not null,
)
go
-- �γ̱�
if exists(select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
	CourseId int primary key,
	CourseName varchar(20) not null,
	CourseContent nvarchar(500) not null,
	ClassHour int not null, -- ��ʱ
	Credit int not null -- ѧ��
)
go



