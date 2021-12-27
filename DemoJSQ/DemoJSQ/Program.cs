using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator objCal = new Calculator();
            int result1 = objCal.Add(1, 1);
            double result2 = objCal.Add(1, 1.0);
            int result3 = Calculator.Add(1, 2, 3);
            Console.WriteLine("result1={0}", result1);
            Console.WriteLine("result2={0}", result2);
            Console.WriteLine("result3={0}", result3);
            Console.ReadLine();
        }
    }
}
