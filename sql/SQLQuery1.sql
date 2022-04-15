use master
go
-- 创建数据库
create databases StudentManageDB
on primary
(
	name='StudentManageDB', -- 数据库文件的逻辑名
	filename='D:\DB\StudentManageDB_data.mdf', -- 数据库物理文件名（绝对路径）
	size=10MB, -- 数据库文件初始大小
	filegrowth=5M -- 数据文件增长量
)
-- 创建日志文件
log on
(
	name='StudentManageDB_log',
	filename='D:\DB\StudentManageDB_log.ldf',
	size=5MB,
	filegrowth=2MB
)
go