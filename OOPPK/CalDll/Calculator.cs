using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalDll
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return (a + b) * 2;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
