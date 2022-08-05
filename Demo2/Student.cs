using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Student
    {
        // 字段
        private int studentId;
        // 字段: 学员姓名
        private string studentName = string.Empty;
        // 字段: 年龄
        //private int age;
        private DateTime birthday;
        //public int Age
        //{
        //    get { return age; }
        //    set {
        //        if (value < 18)
        //        {
        //            age = 18;
        //        }
        //        else {
        //            age = value;
        //        }
        //    }
        //}
        // 属性：学号
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        // 属性：学生姓名
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public DateTime Birthday { get => birthday; set => birthday = value; }
        // 没有私有字段的属性
        public int Age
        {
            get { return DateTime.Now.Year - birthday.Year; }
        }

        // 方法：获取学员信息
        public string GetStudent()
        {
            string info = string.Format("姓名: {0} 学号: {1}", studentName, studentId);
            return info;
        }
    }
}
