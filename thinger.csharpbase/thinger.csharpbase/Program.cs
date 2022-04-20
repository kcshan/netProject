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

            //Test3();

            //Test4();

            Test5();

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

            Console.WriteLine("**********下面是新特性的格式化方法***********");
            // 使用新特性简化字符串格式化
            string info3 = $"姓名: {name} 成绩: {score} 班级：{className}";
            Console.WriteLine(info3);
            Console.WriteLine($"姓名: {name} 成绩: {score} 班级：{className}");
        }
        #endregion

        #region 03.赋值和算数运算符的使用

        static void Test4()
        {
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine($"a + b = {result}");

            result = a - b;
            Console.WriteLine($"a - b = {result}");

            result = a * b;
            Console.WriteLine($"a * b = {result}");

            result = a / b;
            Console.WriteLine($"a / b = {result}");

            result = b / a;
            Console.WriteLine($"b / a = {result}");

            int c = 12;
            result = c % a;
            Console.WriteLine($"c % a = {result}");

            result = a * (b - c) / 2;
            Console.WriteLine($"a * (b - c) / 2 = {result}");

            a = a + b;
            Console.WriteLine("a=" + a);
            a = a - b;
            Console.WriteLine("a=" + a);

            a += b;
            Console.WriteLine($"a += b -> {a}");

            a -= b;
            Console.WriteLine($"a -= b -> {a}");

            a *= b;
            Console.WriteLine($"a *= b -> {a}");

            int d = 100;
            d++;
            Console.WriteLine($"d = {d}");

            d--;
            Console.WriteLine($"d = {d}");

            ++d;
            Console.WriteLine($"d = {d}");

            --d;
            Console.WriteLine($"d = {d}");

            int i = 200;
            Console.WriteLine($"i++后的值：{i++}");
            Console.WriteLine($"i的值：{i}");

            int e = 300;
            Console.WriteLine($"++e后的值：{++e}");

            int f = 400;
            Console.WriteLine($"f++后的值：{f--}");
            Console.WriteLine($"f的值：{f}");

            int h = 500;
            Console.WriteLine($"--h后的值：{--h}");
        }

        #endregion

        #region 04.本阶段练习

        static void Test5()
        {
            Console.Write("请输入第1位学员的成绩：");
            int stuScore1 = int.Parse(Console.ReadLine());
            Console.Write("请输入第2位学员的成绩：");
            int stuScore2 = int.Parse(Console.ReadLine());
            Console.Write("请输入第3位学员的成绩：");
            int stuScore3 = int.Parse(Console.ReadLine());
            Console.Write("请输入第4位学员的成绩：");
            int stuScore4 = int.Parse(Console.ReadLine());
            Console.Write("请输入第5位学员的成绩：");
            int stuScore5 = int.Parse(Console.ReadLine());

            int avgScore = (stuScore1 + stuScore2 + stuScore3 + stuScore4 + stuScore5) / 5;
            // 计算平均成绩
            Console.WriteLine($"5位学员的平均成绩：{avgScore}");
        }

        #endregion
    }
}
