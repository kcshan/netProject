﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSQ
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Calculator objCal = new Calculator();
        //    int result1 = objCal.Add(1, 1);
        //    double result2 = objCal.Add(1, 1.0);
        //    int result3 = Calculator.Add(1, 2, 3);
        //    Console.WriteLine("result1={0}", result1);
        //    Console.WriteLine("result2={0}", result2);
        //    Console.WriteLine("result3={0}", result3);
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            Student objStu1 = new Student();
            objStu1.StudentId = 1004;
            objStu1.StudentName = "你好";

            Student objStu2 = new Student(1005, "李明");

            Student objStu3 = new Student(1006, "王五", 18);

            Console.WriteLine("学生姓名：{0} 学号：{1}", objStu1.StudentName, objStu1.StudentId);
            Console.WriteLine("学生姓名：{0} 学号：{1}", objStu2.StudentName, objStu2.StudentId);
            Console.WriteLine("学生姓名：{0} 学号：{1} 年龄：{2}", objStu3.StudentName, objStu3.StudentId, objStu3.Age);
            Console.ReadLine();
        }
    }
}
