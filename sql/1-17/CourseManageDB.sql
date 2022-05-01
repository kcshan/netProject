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
	-- �����ļ���ֵ����ҲҪ�ο��ļ�������С��
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
	TeacherId int identity(1000,1) primary key, -- ��ʦ��ţ�����
	LoginAccount varchar(50) not null, -- ��¼�˺�
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18)  not null,
	TeacherName varchar(20) not null,
	PhoneNumber char(11) not null, -- �绰
	NowAddress nvarchar(100) default('��ַ����')-- סַ
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
	CourseId int identity(1000,1) primary key,
	CourseName varchar(50) not null,
	CourseContent nvarchar(500) not null,
	ClassHour int not null, -- ��ʱ
	Credit int check(Credit>=1 and Credit<=30) not null, -- ѧ��
	CategoryId int references CourseCategory(CategoryId) not null,
	TeacherId int references Teacher(TeacherId)
)
go
-- ���������ݱ������Ը�����Ҫ����...
-- ����������ط���дԼ�����������ַ�ʽ������ά���Ƚ��鷳�����ǲ���
use CourseManageDB
go

-- ���Ӳ������ݣ�����Ҫѧ���Լ�д�������ݣ�
--insert into Teacher(TeacherId,LoginAccount,LoginPwd,TeacherName,PhoneNumber)
--values(10001,'xiketang01','1234567', '����ʦ', '13600001234'),
--(10002,'xiketang02','123456', '����ʦ', '13600001235'),
--(10003,'xiketang03','123457', '����ʦ', '13600001236')

-- ���������ñ�ʶ�е�ʱ�򣬲�����ʾ�Ĳ���ֵ��Ӧ�øĳ�����ķ���

insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)
values('xiketang01','1234567', '����ʦ', '13600001234'),
('xiketang02','123456', '����ʦ', '13600001235'),
('xiketang03','123457', '����ʦ', '13600001236')

insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber,NowAddress)
values('xiketang03','1234567', '����ʦ', '13600001234','����������')

delete from Teacher where TeacherId=1002

-- �޸�����
update Teacher set LoginPwd='1222222',TeacherName='Carter��ʦ' where TeacherId=1004

-- ���ӿγ̷���
insert into CourseCategory(CategoryName)
values('��λ������'),('�˶����ƿ���'),('�����Ӿ�����')

-- ���ӿγ���Ϣ
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)
values('.Net/C#��λ������VIP�γ�','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1004)

insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)
values('�˶����ƿ���VIP�γ�','�����̸�Zmotion�˶����ƿ�',200,10,11,1005)

-- ��ѯ(������)
select CourseName,CourseContent,ClassHour,Credit,Course.CategoryId from Course
inner join CourseCategory on Course.CategoryId=CourseCategory.CategoryId

select CourseName,CourseContent,ClassHour,Credit,Course.CategoryId from Course
inner join Teacher on Course.TeacherId=Teacher.TeacherId

select * from Teacher

select * from CourseCategory

select * from Course

-- ������������
insert into CourseCategory(CategoryName)values('.Net����'),('Java����'),('΢��С����')
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)values
('.Net/C#��λ������VIP�γ�09','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#��λ������VIP�γ�06','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net/C#��λ������VIP�γ�01','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#��λ������VIP�γ�11','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',566,10,10,1002),
('.Net/C#��λ������VIP�γ�14','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',380,10,10,1000),
('.Net/C#ȫջ����VIP�γ�02','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',450,10,10,1001),
('.Net/C#ȫջ����VIP�γ�05','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#ȫջ����VIP�γ�03','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#ȫջ����VIP�γ�07','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#ȫջ����VIP�γ�08','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#ȫջ����VIP�γ�10','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#ȫջ����VIP�γ�16','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#ȫջ����VIP�γ�17','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',550,10,10,1002),
('.Net/C#�߼�����VIP�γ�20','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#�߼�����VIP�γ�15','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),
('.Net/C#�߼�����VIP�γ�12','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',505,10,10,1000),
('.Net/C#�߼�����VIP�γ�13','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',480,10,10,1000),
('.Net/C#�߼�����VIP�γ�18','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net/C#�߼�����VIP�γ�13','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',520,10,10,1000),
('.Net/C#�߼�����VIP�γ�19','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),

('Javaȫջ����VIP�γ�20','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�15','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000),
('Javaȫջ�����γ�13','OOP/JSP/HTML/Servlet/MVC/SSH',480,12,11,1000),
('Javaȫջ�����γ�12','OOP/JSP/HTML/Servlet/MVC/SSH',505,12,11,1000),
('Javaȫջ�����γ�09','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�06','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Javaȫջ�����γ�01','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�11','OOP/JSP/HTML/Servlet/MVC/SSH',566,12,11,1002),
('Javaȫջ�����γ�14','OOP/JSP/HTML/Servlet/MVC/SSH',380,12,11,1000),
('Javaȫջ�����γ�02','OOP/JSP/HTML/Servlet/MVC/SSH',450,12,11,1001),
('Javaȫջ�����γ�05','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�03','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�07','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�08','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�10','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�16','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�17','OOP/JSP/HTML/Servlet/MVC/SSH',550,12,11,1002),
('Javaȫջ�����γ�18','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Javaȫջ�����γ�13','OOP/JSP/HTML/Servlet/MVC/SSH',520,12,11,1000),
('Javaȫջ�����γ�19','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000)