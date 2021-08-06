using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teach03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test1();
            // Test2();
            // Test3();
            // Test4();
            // Test5();
            Test6();
            Console.ReadLine();
        }
        static void Test1()
        {
            Console.WriteLine("请输入客户消费总金额:");
            int totalMoney = int.Parse(Console.ReadLine());
            // 使用if条件作出判断
            if (totalMoney >= 1000)
            {
                Console.WriteLine("客户消费金额满1000元，赠送300元代金券");
            }

        }
        static void Test2()
        {
            Console.WriteLine("请输入笔试成绩：");
            int writeExam = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入机试成绩：");
            int labExam = int.Parse(Console.ReadLine());

            if (writeExam >= 80 && labExam >= 90)
            {
                Console.WriteLine("考试成绩优秀");
            }

            if ((writeExam == 100 && labExam >= 60) || (labExam == 100 && writeExam >= 60))
            {
                Console.WriteLine("考试成绩优秀！");
            }
            Console.ReadLine();
        }
        // ifelse选择结构
        static void Test3()
        {
            Console.WriteLine("请输入客户消费的总金额：");
            int totalMoney = int.Parse(Console.ReadLine());

            // 使用if条件作出判断
            if (totalMoney >= 1000)
            {
                double money = totalMoney * 0.8;
                Console.WriteLine($"客户消费满1000元，总金额按照8折计算={money}");
                // Console.WriteLine("客户消费满1000元，总金额按照8折计算{0}", money);
            }
            else
            {
                Console.WriteLine("客户消费金额不满1000元");
            }
        }
        static void Test4()
        {
            int a = 10;
            int b = 20;
            bool result = a > b ? true : false;

            Console.WriteLine("a > b 比较结果是:" + result);
            Console.ReadLine();
        }
        static void Test5()
        {
            Console.WriteLine("请输入客户消费金额");
            int totalMoney = int.Parse(Console.ReadLine());
            if (totalMoney >= 1000 && totalMoney < 2000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.8);
            }
            if (totalMoney >= 2000 && totalMoney < 3000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.7);
            }
            if (totalMoney >= 3000 && totalMoney < 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.6);
            }
            if (totalMoney >= 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.5);
            }
            if (totalMoney < 1000)
            {
                Console.WriteLine("需付款：" + totalMoney);
            }
            Console.ReadLine();
        }
        static void Test6()
        {
            Console.WriteLine("请输入客户消费金额");
            int totalMoney = int.Parse(Console.ReadLine());
            if (totalMoney >= 1000 && totalMoney < 2000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.8);
            }
            else if (totalMoney >= 2000 && totalMoney < 3000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.7);
            }
            else if (totalMoney >= 3000 && totalMoney < 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.6);
            }
            else if (totalMoney >= 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.5);
            }
            else
            {
                Console.WriteLine("需付款：" + totalMoney);
            }
            Console.ReadLine();
        }
    }
}
