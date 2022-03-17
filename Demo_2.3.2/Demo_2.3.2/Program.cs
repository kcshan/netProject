﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent1 = new Student();
            objStudent1.StudentId = 10003;
            objStudent1.StudentName = "小李";
            objStudent1.Birthday = Convert.ToDateTime("1990-09-10");

            Student objStudent2 = new Student(1001, "小王", Convert.ToDateTime("1990-10-10"));

            Student objStudent3 = new Student()
            {
                StudentId = 10004,
                StudentName = "小青",
                Birthday = Convert.ToDateTime("1994-12-10")
            };

            Console.WriteLine("姓名={0} 学号={1} 年龄={2}", objStudent1.StudentName, objStudent1.StudentId, objStudent1.Birthday);
            Console.WriteLine("姓名={0} 学号={1} 年龄={2}", objStudent2.StudentName, objStudent2.StudentId, objStudent2.Birthday);
            Console.WriteLine("姓名={0} 学号={1} 年龄={2}", objStudent3.StudentName, objStudent3.StudentId, objStudent3.Birthday);

            Console.ReadLine();
        }
    }
}
