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