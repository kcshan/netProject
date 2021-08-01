using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCal
{
    public class MyCal
    {
        /// <summary>
        /// 实现俩个数相加
        /// </summary>
        /// <param name="a">第一个int参数</param>
        /// <param name="b">第二个int参数</param>
        /// <returns>返回俩个参数的和，返回值为int类型</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 实现俩个数相加 + 1
        /// </summary>
        /// <param name="a">第一个double参数</param>
        /// <param name="b">第二个double参数</param>
        /// <returns>返回俩个参数的和，返回值为double类型</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
