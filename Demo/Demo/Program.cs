using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 【声明变量】，即“根据数据类型在内存申请空间”
            int age;

            // 【给变量赋值】，即“将数据存储至对应的内存空间”
            age = 20;

            // 【也可以同时声明和赋值】
            string name = "小王";

            // 【使用变量】，即取出数据使用
            Console.WriteLine("我叫" + name + " 今年" + age + "岁");
            Console.ReadLine();

        }
    }
}
