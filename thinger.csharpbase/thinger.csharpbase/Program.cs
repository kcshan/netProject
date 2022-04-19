﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.csharpbase
{
    /// <summary>
    /// 这个是控制台核心类
    /// 主要是供我们练习使用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Test1();

            int result = Add(10,20);

            Console.Read();
        }

        static void Test1()
        {
            int score; // 变量类型 变量名称

            score = 98; // 给变量赋值

            string subject = "C#基础语法"; // 声明变量同时赋值

            // 使用变量
            Console.WriteLine("科目：" + subject + " 分数：" + score);

            Console.ReadLine();
        }

        /// <summary>
        /// 实现俩个数相加
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns>返回俩个数的和</returns>
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
