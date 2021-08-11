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
            // Test6();
            // Test7();
            // Test8();
            // Test9();
            // Test10();
            // Test11();
            // Test12();
            // Test13();
            Test14();
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
		static void Test7()
		{
			Console.WriteLine("请输入客户消费金额：");
			int totalMoney = int.Parse(Console.ReadLine());
			if (totalMoney >= 1000)
			{
				Console.WriteLine("需付款：" + totalMoney * 0.8);
				Console.WriteLine("您的会员类型：");
				string customerType = Console.ReadLine();
				if (customerType == "普通")
				{
					Console.WriteLine("同时送您100元代金券");
				}
				else if (customerType == "vip")
				{
					Console.WriteLine("同时送您200元代金券");
				}
			}
			else
			{
				Console.WriteLine("需付款：" + totalMoney);
			}
			Console.ReadLine();
		}
		static void Test8()
		{
			Console.WriteLine("请输入您购买的课程类型");
			string band = Console.ReadLine();
			switch (band)
			{
				case "A":
					Console.WriteLine("可以抽奖Ipad");
					break;
				case "B":
					Console.WriteLine("可以抽奖键盘鼠标");
					break;
				case "C":
					Console.WriteLine("可以抽奖智能手机");
					break;
				default:
					Console.WriteLine("无抽奖参与");
					break;
			}
		}
		static void Test9()
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"这是第{i + 1}遍练习", i + 1);
			}
			Console.ReadLine();
		}
		static void Test10()
		{
			for (int a = 1; a <= 9; a++) // 外循环，控制行数
			{
				for (int b = 1; b <= a; b++) // 内循环，控制每行的内容
				{
					Console.Write($"{a}*{b}={a * b}\t");
				}
				Console.WriteLine();
			}
		}
		static void Test11()
		{
			for (int a = 1; a <= 5; a++)  // 外循环，控制行数
			{
				for (int b = 1; b <= 5 - a; b++) // 内循环，打印空白
				{
					Console.Write(" ");
				}
				for (int c = 1; c < 2 * a; c++) // 内循环，打印星号
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}
		}
		static void Test12()
		{
			Console.WriteLine("请输入你现在每分钟打字个数：");
			int count = int.Parse(Console.ReadLine());
			while (count < 120)
			{
				Console.WriteLine("请继续练习！你没有达标！");
				Console.WriteLine("-------------------------");
				Console.WriteLine("练习后，继续测试打字个数为：");
				count = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("您已经达标，可以参加比赛！");
		}
		static void Test13()
		{
			int count = 0;
			do
			{
				Console.WriteLine("请输入你现在每分钟打字个数：");
				count = int.Parse(Console.ReadLine());
			} while (count < 120);

	        Console.WriteLine("您已经达标，可以参加比赛！");
		}
        static void Test14()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"第{i + 1}个产品开始检验");
                Console.WriteLine("合格吗？y/n");
                if (Console.ReadLine() == "n")
                {
                    count++;
                }
                if (count == 5)
                {
                    Console.WriteLine("====这批产品不合格====");
                    break;
                }
            }
        }
    }
}
