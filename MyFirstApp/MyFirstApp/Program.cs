using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    /*
     * 这个是包含程序入口点的类
     * 这个类里面的入口方法，不要随意修改
     * 方法要求都是静态的
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这个是我的第一个C#程序！.NET神奇的编程世界从现在正式开始进入");
            Console.WriteLine("请输入您的年龄：");
            string age = Console.ReadLine(); // 获取用户的输入
            Console.WriteLine("您刚才输入的年龄是："+age);

            int result = add(10, 20);
            Console.WriteLine("result: " + result);
            Console.ReadLine(); // 这个是让程序等待用户输入，暂停
            Console.Read();
        }

        /// <summary>
        /// 俩个整数相加
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns></returns>
        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
