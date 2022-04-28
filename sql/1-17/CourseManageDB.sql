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