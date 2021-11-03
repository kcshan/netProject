using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPK
{
    class Program
    {
        #region 基于面向过程的写法
        //static void Main(string[] args)
        //{
        //    //int a = 10;
        //    //int b = 20;
        //    Console.WriteLine("请输入第一个操作数：");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.WriteLine("请输入第二个操作数：");
        //    int b = int.Parse(Console.ReadLine());

        //    int result = a + b;

        //    Console.WriteLine(result);
        //    Console.Read();
        //}

        //static void Main(string[] args)
        //{
        //    //int a = 10;
        //    //int b = 20;
        //    Console.WriteLine("请输入第一个操作数：");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.WriteLine("请输入第二个操作数：");
        //    int b = int.Parse(Console.ReadLine());

        //    int result1 = Add(a, b);
        //    Console.WriteLine("a+b=" + result1);

        //    int result2 = Sub(a, b);
        //    Console.WriteLine("a-b=" + result2);
        //    Console.Read();
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Sub(int num1, int num2)
        //{
        //    return num1 - num2;
        //}

        #endregion

        #region 基于面向对象的写法
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            Console.WriteLine("请输入第一个操作数：");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第二个操作数：");
            int b = int.Parse(Console.ReadLine());

            // 基于对象使用
            //Calculator calculator = new Calculator();
            CalDll.Calculator calculator = new CalDll.Calculator();

            int result1 = calculator.Add(a, b);
            Console.WriteLine("a+b=" + result1);

            int result2 = calculator.Sub(a, b);
            Console.WriteLine("a-b=" + result2);

            double result3 = calculator.Add(10.5, 67.8);
            Console.WriteLine("a+b=" + result3);
            Console.Read();
        }
        #endregion
    }
}
