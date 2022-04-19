using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.csharpbase
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
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
    }
}
