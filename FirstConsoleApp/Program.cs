﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VBCaluator;

namespace FirstConsoleApp
{
    class Program
    {
        // 程序的入口点
        static void Main(string[] args)
        {
            // 在c#中，严格区分大小写；
            Console.WriteLine("我们正在跟常老师学习C#");

            MyCal cal = new MyCal();
            int result = cal.Add(10, 20);

            Console.WriteLine("10 + 20 = " + result);

            Console.Read();
        }
    }
}
