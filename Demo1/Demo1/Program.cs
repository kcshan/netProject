using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单if 选择结构1
            //Console.WriteLine("请输入客户消费总金额：");
            //int totalMoney = int.Parse(Console.ReadLine());
            //// 使用if条件作出判断
            //if (totalMoney >= 1000)
            //{
            //    Console.WriteLine("客户消费金额满1000元，赠送300元代金券");
            //}
            //Console.WriteLine("消费不够，不送代金券");
            #endregion

            #region 复杂if 选择结构2
            //Console.WriteLine("请输入笔试成绩：");
            //int writeExam = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入机试成绩：");
            //int labExam = int.Parse(Console.ReadLine());

            //if (writeExam >= 80 && labExam >= 90)
            //{
            //    Console.WriteLine("考试成绩优秀！");
            //}
            //if ((writeExam == 100 && labExam >= 60) || (labExam == 100 && writeExam >= 60))
            //{
            //    Console.WriteLine("考试成绩优秀！");
            //}
            #endregion

            #region if-else 选择结构1
            //Console.WriteLine("请输入客户消费金额：");
            //int totalMoney = int.Parse(Console.ReadLine());
            //if (totalMoney >= 1000)
            //{
            //    double discountMoney = totalMoney * 0.8;
            //    Console.WriteLine("客户消费满1000元，总金额按照8折计算，总金额={0}元", discountMoney);
            //}
            //else
            //{
            //    Console.WriteLine("客户消费金额不满1000元，按照原价计算，总金额={0}元", totalMoney);
            //}
            #endregion

            #region 三元运算符
            //int a = 10;
            //int b = 20;
            //bool result;
            //if (a > b)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}
            //bool result = a > b ? true : false;
            //Console.WriteLine("a>b比较结果是："+result);
            #endregion

            #region

            #endregion

            Console.ReadLine();
        }
    }
}
