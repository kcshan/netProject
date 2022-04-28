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
	NowAddress nvarchar(100) -- 住址
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
	CourseId int primary key,
	CourseName varchar(20) not null,
	CourseContent nvarchar(500) not null,
	ClassHour int not null, -- 课时
	Credit int not null -- 学分
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

insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)
values('xiketang03','1234567', '常老师', '13600001234')

select * from Teacher

delete from Teacher where TeacherId=1002

-- 修改数据
update Teacher set LoginPwd='1222222',TeacherName='Carter老师' where TeacherId=1004