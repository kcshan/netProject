using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.Property
{
    class Course1
    {
        // C#2.0时代标准属性
        private int courseId; // 当我们想断点观察字段的初始化过程，请务必显示的赋值
        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        // C#3.0时代，对标准属性做了简化（以后，标准属性，都可以这样用）
        public string CourseName { get; set; } // 我们没有显示写出对应私有字段的，编译器都会帮我们自动生成，IL DASM中可以查看
        
        // C#4.0时代，增加属性表达式（下面的写法，不是我们常用的写法）
        private int unitPrice = 4000;
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }

        // C#4.0时代以后，可以直接赋值
        public string Type { get; set; } = ".NET开发系列";

        private DateTime FirstDate { get; set; } // 首发时间

        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
        }

    }

    class TestClass1
    {
        public void Dowork1()
        {
            Course1 course = new Course1();
            course.CourseId = 1001;
            course.CourseName = ".NET全栈开发课程/上位机开发课程";

            string info = course.ShowCourseInfo();
            Console.WriteLine(info);
        }
    }
}
