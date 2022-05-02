use CourseManageDB
go

select * from Course
select * from Teacher
select * from CourseCategory

select * from Course where CategoryId=10

select Count(*) as ¿Î³Ì×ÜÊý from Course

select CourseName from Course where CourseId=1039

select CourseName,CourseContent,ClassHour from Course where CourseId<1020

select TeacherName,TeacherId from Teacher where LoginAccount='xiketang01' and LoginPwd='1234567'