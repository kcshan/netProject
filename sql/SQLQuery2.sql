use master
go
-- �жϵ�ǰ���ݿ��Ƿ����
if exists (select * from sysdatabases where name='StudentManageDB')
drop database StudentManageDB
-- �������ݿ�
create database StudentManageDB
on primary
(
	name='StudentManageDB_data', -- ���ݿ��ļ����߼���
	filename='D:\DB\StudentManageDB_data.mdf', -- ���ݿ������ļ���������·����
	size=10MB, -- ���ݿ��ļ���ʼ��С
	filegrowth=5MB -- �����ļ�������
),
(
	name='StudentManageDB_data1',
	filename='D:\DB\StudentManageDB_data1.ndf',
	size=10MB, 
	filegrowth=5MB
)
-- ������־�ļ�
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