using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.Property
{
    class Course2
    {
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
            set {
                if (value < 0)
                    courseId = 1000;
                else
                    courseId = value;
            }
        }
        public string CourseName { get; set; }

        public int UnitPrice { get; set; } = 4000;

        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
        }
    }

    class TestClass2
    {
        public void Dowork1()
        {
            Course2 course = new Course2();
            course.CourseId = -10001;
            course.CourseName = ".NET全栈开发课程 + 上位机开发课程";
            string info = course.ShowCourseInfo();
            Console.WriteLine(info);
        }
        
    }
}
