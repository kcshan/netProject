use master
go
-- �������ݿ�
create databases StudentManageDB
on primary
(
	name='StudentManageDB', -- ���ݿ��ļ����߼���
	filename='D:\DB\StudentManageDB_data.mdf', -- ���ݿ������ļ���������·����
	size=10MB, -- ���ݿ��ļ���ʼ��С
	filegrowth=5M -- �����ļ�������
)
-- ������־�ļ�
log on
(
	name='StudentManageDB_log',
	filename='D:\DB\StudentManageDB_log.ldf',
	size=5MB,
	filegrowth=2MB
)
go