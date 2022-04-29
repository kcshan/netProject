-- 在这里我们可以编写任何操作数据库的代码
-- 首先要指向操作的数据库

use master
go
--select * from sysdatabases
if exists(select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB
go

-- 创建数据库
create database CourseManageDB
on primary
(
	-- 数据库的逻辑文件名（就是系统用的，必须唯一）
	name='CourseManageDB_data',
	-- 数据库物理文件名（绝对路径）
	-- 主数据文件名
	filename='D:\workspace\DB\CourseManageDB_data.mdf',
	-- 数据库初始文件大小(一定要根据你的实际生产需求来定)
	size=10MB,
	-- 数据文件增值量（也要参考文件本身大小）
	filegrowth=1MB
)
,
(
	name='CourseManageDB_data1',
	-- 次要数据文件名
	filename='D:\workspace\DB\CourseManageDB_data1.ndf',
	size=10MB,
	filegrowth=1MB
)
log on
(
	name='CourseManageDB_log',
	-- 日志文件名
	filename='D:\workspace\DB\CourseManageDB_log.ldf',
	size=10MB,
	filegrowth=1MB
)
go

-- 指向要操作的数据库
use CourseManageDB
go
-- 创建讲师表
if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go
create table Teacher
(
	TeacherId int identity(1000,1) primary key, -- 讲师编号，主键
	LoginAccount varchar(50) not null, -- 登录账号
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18)  not null,
	TeacherName varchar(20) not null,
	PhoneNumber char(11) not null, -- 电话
	NowAddress nvarchar(100) default('地址不详')-- 住址
)
go
-- 课程分类表
if exists(select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
	CategoryId int identity(10,1) primary key,
	CategoryName varchar(20) not null,
)
go
-- 课程表
if exists(select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
	CourseId int identity(1000,1) primary key,
	CourseName varchar(50) not null,
	CourseContent nvarchar(500) not null,
	ClassHour int not null, -- 课时
	Credit int check(Credit>=1 and Credit<=30) not null, -- 学分
	CategoryId int references CourseCategory(CategoryId) not null,
	TeacherId int references Teacher(TeacherId)
)
go
-- 其他的数据表，可以根据需要添加...
-- 可以在这个地方编写约束，但是这种方式，后面维护比较麻烦，我们不讲
use CourseManageDB
go

-- 添加测试数据（必须要学会自己写测试数据）
--insert into Teacher(TeacherId,LoginAccount,LoginPwd,TeacherName,PhoneNumber)
--values(10001,'xiketang01','1234567', '常老师', '13600001234'),
--(10002,'xiketang02','123456', '付老师', '13600001235'),
--(10003,'xiketang03','123457', '张老师', '13600001236')

-- 当我们启用标识列的时候，不能显示的插入值，应该改成下面的方法

insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)
values('xiketang01','1234567', '常老师', '13600001234'),
('xiketang02','123456', '付老师', '13600001235'),
('xiketang03','123457', '张老师', '13600001236')

insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber,NowAddress)
values('xiketang03','1234567', '常老师', '13600001234','海宁长安镇')

delete from Teacher where TeacherId=1002

-- 修改数据
update Teacher set LoginPwd='1222222',TeacherName='Carter老师' where TeacherId=1004

-- 添加课程分类
insert into CourseCategory(CategoryName)
values('上位机开发'),('运动控制开发'),('机器视觉开发')

-- 添加课程信息
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)
values('.Net/C#上位机开发VIP课程','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1004)

insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)
values('运动控制开发VIP课程','雷赛固高Zmotion运动控制卡',200,10,11,1005)

-- 查询(内连接)
select CourseName,CourseContent,ClassHour,Credit,Course.CategoryId from Course
inner join CourseCategory on Course.CategoryId=CourseCategory.CategoryId

select CourseName,CourseContent,ClassHour,Credit,Course.CategoryId from Course
inner join Teacher on Course.TeacherId=Teacher.TeacherId

select * from Teacher

select * from CourseCategory

select * from Course

-- 其他测试数据
insert into CourseCategory(CategoryName)values('.Net开发'),('Java开发'),('微信小程序')
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)values
('.Net/C#上位机开发VIP课程09','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#上位机开发VIP课程06','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net/C#上位机开发VIP课程01','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#上位机开发VIP课程11','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',566,10,10,1002),
('.Net/C#上位机开发VIP课程14','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',380,10,10,1000),
('.Net/C#全栈开发VIP课程02','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',450,10,10,1001),
('.Net/C#全栈开发VIP课程05','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#全栈开发VIP课程03','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#全栈开发VIP课程07','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#全栈开发VIP课程08','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#全栈开发VIP课程10','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net/C#全栈开发VIP课程16','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#全栈开发VIP课程17','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',550,10,10,1002),
('.Net/C#高级进阶VIP课程20','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net/C#高级进阶VIP课程15','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),
('.Net/C#高级进阶VIP课程12','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',505,10,10,1000),
('.Net/C#高级进阶VIP课程13','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',480,10,10,1000),
('.Net/C#高级进阶VIP课程18','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net/C#高级进阶VIP课程13','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',520,10,10,1000),
('.Net/C#高级进阶VIP课程19','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),

('Java全栈开发VIP课程20','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程15','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000),
('Java全栈开发课程13','OOP/JSP/HTML/Servlet/MVC/SSH',480,12,11,1000),
('Java全栈开发课程12','OOP/JSP/HTML/Servlet/MVC/SSH',505,12,11,1000),
('Java全栈开发课程09','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程06','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Java全栈开发课程01','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程11','OOP/JSP/HTML/Servlet/MVC/SSH',566,12,11,1002),
('Java全栈开发课程14','OOP/JSP/HTML/Servlet/MVC/SSH',380,12,11,1000),
('Java全栈开发课程02','OOP/JSP/HTML/Servlet/MVC/SSH',450,12,11,1001),
('Java全栈开发课程05','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程03','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程07','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程08','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程10','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程16','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程17','OOP/JSP/HTML/Servlet/MVC/SSH',550,12,11,1002),
('Java全栈开发课程18','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Java全栈开发课程13','OOP/JSP/HTML/Servlet/MVC/SSH',520,12,11,1000),
('Java全栈开发课程19','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000)
