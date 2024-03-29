﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.Property
{
    /// <summary>
    /// 课程类
    /// </summary>
    class Course
    {
        // 在这个地方，请自己断点调试，观察执行顺序
        private int courseId = 0;
        private string courseName = string.Empty;
        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public Course()
        {
            CourseId = 10001;
            CourseName = ".NET全栈开发、上位机开发";
            Type = ".NET系列";
            // 在这里还可以编写读取相关文件或者从其他数据源读取的方法或逻辑...
        }

        public Course(int courseId, string courseName)
        {
            this.CourseId = courseId;
            this.CourseName = courseName;
            this.CourseName = this.courseName; // 也就是说成员变量和局部变量同名的时候，一般是就近原则取变量
            // 如果我们需要舍近求远，则必须添加this
        }

        public Course(int courseId, string courseName, string type)
            : this(courseId, courseName)
        {
            //this.CourseId = courseId;
            //this.CourseName = courseName;
            this.Type = type;
        }

        // 公有的成员变量（存储数据，或对外提供数据）
        public int CourseId;

        public string CourseName;

        public int UnitPrice = 4000;

        public string Type = ".NET系列";

        public DateTime FirstDate; // 首发时间

        // 公有方法
        public string ShowCourseInfo()
        {
            // 局部变量
            string info = $"课程名称：{CourseName} 课程编号：{CourseId} 课程价格：{UnitPrice}";
            // 方法返回值
            return info;
        }

        //public void Test()
        //{
        //    CourseId = 100;
        //}

        // 析构函数
        ~Course()
        {
            Console.WriteLine("对象被释放，析构函数被调用...");
        }

    }

    class TestClass
    {
        public void Dowork1()
        {
            // 创建一个对象
            Course course = new Course();
            // 给对象的字段赋值
            course.CourseId = 10001;
            course.CourseName = ".NET全栈开发课程";

            // 获取对象的数据
            Console.WriteLine(course.Type);

            // 调用对象的方法
            string info = course.ShowCourseInfo();

            Console.WriteLine(info);
        }

        public void Dowork2()
        {
            // 创建一个对象
            Course course = new Course();
            // 给对象的字段赋值
            course.CourseId = -10001; // 出现了不安全的数据
            course.CourseName = ".NET全栈开发课程";

            // 获取对象的数据
            Console.WriteLine(course.Type);

            // 调用对象的方法
            string info = course.ShowCourseInfo();

            Console.WriteLine(info);
        }

        public void Dowork3()
        {
            Course course1 = new Course();
            Console.WriteLine("[无参数构造方法]" + course1.ShowCourseInfo());

            Course course2 = new Course(10002, "C#面向对象编程");
            Console.WriteLine("[2个参数构造方法]" + course2.ShowCourseInfo());

            Course course3 = new Course(10003, "C#面向对象", ".NET开发系列");
            Console.WriteLine("[3个参数构造方法]" + course3.ShowCourseInfo());

            string info = $"课程名称：{course3.CourseName} 课程编号：{course3.CourseId} 课程价格：{course3.UnitPrice}";
            Console.WriteLine(info);

            Course course4 = new Course();
            course4.CourseId = 100005;
            course4.CourseName = "新课程";
        }

        public void Dowork4()
        {
            Course course1 = new Course()
            {
                CourseId = 2000,
                CourseName = "C#上位机课程"
            };

            //Course course2 = new Course(10002, "C#面向对象编程")
            //{
            //    Type = ""
            //};

            course1 = null; // 显式的清除对象的引用，也就是course1只是一个变量名，没有具体对象指向
            //GC.Collect(); // 这个其实是由虚拟机帮我们完成，不需要再设置，这里只是学习原理
        }
    }

}
