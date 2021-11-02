using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这个是我的第一个C#程序！.NET神奇的编程世界从现在正式开始进入");
            Console.WriteLine("请输入您的年龄：");
            string age = Console.ReadLine(); // 获取用户的输入
            Console.WriteLine("您刚才输入的年龄是："+age);
            Console.ReadLine(); // 这个是让程序等待用户输入，暂停
            Console.Read();
        }
    }
}
