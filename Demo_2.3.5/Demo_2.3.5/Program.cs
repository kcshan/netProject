using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int result = Square(ref a);
            Console.WriteLine("a的平方={0} a的值={1}", result, a);

            int square = 0;
            int result1 = Operation(a, out square);
            Console.WriteLine("a的平方={0} a的立方={1}", square, result1);
            Console.ReadLine();
        }
        static int Square(ref int num1)
        {
            num1 = num1 * num1;
            return num1;
        }

        static int Operation(int num1, out int square)
        {
            square = num1 * num1;
            int result = num1 * num1 * num1;
            return result;
        }
    }
}
