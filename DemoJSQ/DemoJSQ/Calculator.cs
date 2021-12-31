using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSQ
{
    class Calculator
    {
        //private int test;
        public Calculator()
        {
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Sub(int a, double b)
        {
            return a - b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        //public string getStudent()
        //{
        //    return "你好";
        //}
    }
}
