using System;
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
            //Test1();

            int result = Add(10,20);

            //Test2();

            Test3();

            Console.ReadLine();
        }

        #region 01.变量的基本使用
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
        #endregion

        #region 02.控制台的使用技巧

        static void Test2()
        {
            //int score = 90;
            //string name = "jack";

            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine()); // 90

            //Console.WriteLine(90);
            //Console.WriteLine("C#编程");

            Console.WriteLine("姓名：" + name + " 成绩：" + score);

        }

        // 字符串格式化方法和控制台输出格式化
        static void Test3()
        {
            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine()); // 90
            Console.Write("请输入班级：");
            string className = Console.ReadLine();

            // 使用 + 拼接字符串
            string info1 = "姓名：" + name + " 成绩：" + score;

            // 使用占位符拼接字符串
            string info2 = string.Format("姓名：{0} 成绩：{1} 班级：{2}", name, score, className);

            Console.WriteLine(info2);
            Console.WriteLine();

            // WriteLine方法支持直接的格式化方法
            Console.WriteLine("姓名：{0} 成绩：{1} 班级：{2}", name, score, className);
        }
        #endregion


    }
}
