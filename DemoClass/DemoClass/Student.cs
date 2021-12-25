using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    /// <summary>
    /// 学员
    /// </summary>
    class Student
    {
        // 字段：学员
        private int studentId;
        // 字段：学员姓名
        private string studentName = string.Empty;
        // 字段：年龄
        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        //private int age;

        //// 属性：年龄
        //public int age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (value < 18)
        //        {
        //            age = 18;
        //        }
        //        else
        //        {
        //            age = value;
        //        }
        //    }

        // 没有私有字段的属性
        public int Age
        {
            get { return DateTime.Now.Year - birthday.Year; }
        }

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
        // 方法：获取学员信息
        public string GetStudent()
        {
            string info = string.Format("姓名：{0} 学号：{1}", studentName, studentId);
            return info;
        }

    }
}
