use master
go
-- 判断当前数据库是否存在
if exists (select * from sysdatabases where name='StudentManageDB')
drop database StudentManageDB
-- 创建数据库
create database StudentManageDB
on primary
(
	name='StudentManageDB_data', -- 数据库文件的逻辑名
	filename='D:\DB\StudentManageDB_data.mdf', -- 数据库物理文件名（绝对路径）
	size=10MB, -- 数据库文件初始大小
	filegrowth=5MB -- 数据文件增长量
),
(
	name='StudentManageDB_data1',
	filename='D:\DB\StudentManageDB_data1.ndf',
	size=10MB, 
	filegrowth=5MB
)
-- 创建日志文件
log on
(
	name='StudentManageDB_log',
	filename='D:\DB\StudentManageDB_log.ldf',
	size=5MB,
	filegrowth=2MB
),
(
	name='StudentManageDB_log1',
	filename='D:\DB\StudentManageDB_log1.ldf',
	size=5MB,
	filegrowth=2MB
)
go