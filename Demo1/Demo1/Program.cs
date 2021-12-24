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

            #region 多重if 选择结构1
            //Console.WriteLine("请输入客户消费金额：");
            //int totalMoney = int.Parse(Console.ReadLine());
            //if (totalMoney >= 1000 && totalMoney < 2000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.8);
            //}
            //if (totalMoney >= 2000 && totalMoney < 3000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.7);
            //}
            //if (totalMoney >= 3000 && totalMoney < 4000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.6);
            //}
            //if (totalMoney >= 4000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.5);
            //}
            //if (totalMoney < 1000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney);
            //}
            #endregion

            #region 多重if 选择结构2
            //Console.WriteLine("请输入客户消费金额：");
            //int totalMoney = int.Parse(Console.ReadLine());
            //if (totalMoney >= 1000 && totalMoney < 2000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.8);
            //}
            //else if (totalMoney >= 2000 && totalMoney < 3000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.7);
            //}
            //else if (totalMoney >= 3000 && totalMoney < 4000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.6);
            //}
            //else if (totalMoney >= 4000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.5);
            //}
            //else
            //{
            //    Console.WriteLine("需付款：" + totalMoney);
            //}
            #endregion

            #region 选择结构的嵌套1
            //Console.WriteLine("请输入客户消费金额：");
            //int totalMoney = int.Parse(Console.ReadLine());
            //if (totalMoney >= 1000)
            //{
            //    Console.WriteLine("需付款：" + totalMoney * 0.8);
            //    Console.Write("您的会员类型是： ");
            //    string customerType = Console.ReadLine();
            //    if (customerType == "普通")
            //    {
            //        Console.WriteLine("同时送您100代金券");
            //    }
            //    else if (customerType == "vip")
            //    {
            //        Console.WriteLine("同时送您200代金券");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("需付款：" + totalMoney);
            //}

            #endregion

            #region switch选择结构
            //Console.WriteLine("请输入您购买的电器品牌：");
            //string band = Console.ReadLine();
            //switch (band)
            //{
            //    case "A":
            //        Console.WriteLine("赠送您热水器一台");
            //        break;
            //    case "B":
            //        Console.WriteLine("赠送您手机一部");
            //        break;
            //    case "C":
            //        Console.WriteLine("赠送您音响一套");
            //        break;
            //    default:
            //        Console.WriteLine("赠送您热水器一台");
            //        break;
            //}
            #endregion

            #region for循环
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("这是第{0}圈", i + 1);
            //}
            #endregion

            #region for循环与程序逻辑1
            //for (int a = 1; a <= 9; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", a, b, a * b);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region for循环与程序逻辑2
            //for (int i = 1; i <= 5; i++) // 外循环控制行数
            //{
            //    for (int a = 1; a <= 5 - i; a++) // 内循环，打印的空白
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int b = 1; b < 2 * i; b++) // 内循环，打印星号
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();
            #endregion

            #region while循环1
            //Console.WriteLine("您以前长跑最短时间：");
            //int times = int.Parse(Console.ReadLine());
            //while (times > 10)
            //{
            //    Console.WriteLine("请坚持锻炼，您没有达标！");
            //    Console.WriteLine("-------------------");
            //    Console.WriteLine("锻炼后的测试时间：");
            //    times = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("恭喜您达标了");
            #endregion

            #region do while循序1
            //int times = 0;
            //do
            //{
            //    Console.Write("您本次长跑所用时间：");
            //    times = int.Parse(Console.ReadLine());
            //} while (times > 10);
            //Console.WriteLine("您达标了");

            #endregion

            #region 用break跳出整个循环
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("这是第{0}圈", i + 1);
            //    Console.Write("您还能坚持住吗? y/n: ");
            //    if (Console.ReadLine() == "n")
            //    {
            //        Console.WriteLine("您退出了");
            //        break;
            //    }
            //}
            #endregion

            #region 用continue跳出本次循环
            //int count = 0;
            //while (count < 6)
            //{
            //    Console.Write("当前队员的成绩：");
            //    int score = int.Parse(Console.ReadLine());
            //    if (score < 60)
            //    {
            //        continue;
            //    }
            //    // 登记学员工作
            //    count++;
            //    Console.Write("该队员姓名：");
            //    Console.ReadLine();
            //}
            //Console.Write("队员已招满！");

            #endregion

            #region  解决程序错误的步骤1
            //Console.WriteLine("请看下面5行文字：");
            //int i = 1;
            //while (i < 5)
            //{
            //    Console.WriteLine("第{0}行：C#语言非常强大！", i);
            //    i++;
            //}
            #endregion

            #region 字符串处理1
            //string email = "xiaoqiang@qq.com";
            //int position = email.IndexOf("@");
            //Console.WriteLine("@所在位置索引:" + position);
            #endregion

            #region 字符串处理2
            //string userPwd = "12345678";
            //int pwdLength = userPwd.Length;
            //Console.WriteLine("密码长度：{0}", pwdLength);
            #endregion

            #region 字符串处理3
            //string name1 = "xiaowang";
            //string name2 = "xiaowang";
            //string name3 = "wang";
            //Console.WriteLine(name1 == name2);
            //Console.WriteLine(name1.Equals(name2));
            //Console.WriteLine(name2 == name3);
            //Console.WriteLine(name2.Equals(name3));
            #endregion

            #region 字符串处理4
            //string email = "xiaoqiang@qq.com";
            //int position = email.IndexOf("@");
            //string userName = email.Substring(0, position);
            //Console.WriteLine("邮箱用户名：" + userName);
            //string emailType = email.Substring(position);
            //Console.WriteLine("邮箱类型：" + emailType);

            #endregion

            #region 字符串处理5
            //string name = "小刘";
            //Console.WriteLine("我的名字是：" + name + ",我的年龄是：" + 20);

            //string name1 = "小刘";
            //Console.WriteLine("我的名字是：{0},我的年龄是：{1}", name1, 20);

            //string name2 = "小刘";
            //string info = "我的名字是：{0},我的年龄是：{1}";
            //info = string.Format(info, name1, 20);
            //Console.WriteLine(info);

            #endregion

            #region 字符串处理6
            //string moneyTotal = string.Format("总金额：{0:C3}", 255555);
            //Console.WriteLine(moneyTotal);

            //string str1 = string.Format("{0:D3}", 5000);
            //Console.WriteLine(str1);

            //string str2 = string.Format("{0:F3}", 5000);
            //Console.WriteLine(str2);

            //string str3 = string.Format("{0:N3}", 250000);
            //Console.WriteLine(str3);

            //string str4 = string.Format("{0:P3}", 0.25755);
            //Console.WriteLine(str4);

            //string str5 = string.Format("{0:X000}", 12);
            //Console.WriteLine(str5);
            #endregion

            #region 字符串处理7
            //string name = "";
            //if (name == "")
            //{
            //    Console.WriteLine(true);
            //}
            //if (name.Equals(string.Empty))
            //{
            //    Console.WriteLine(true);
            //}
            //if (name.Length == 0)
            //{
            //    Console.WriteLine(true);
            //}
            #endregion

            #region 字符串处理8
            //string name1 = " xiaowang ";
            //name1 = name1.Trim();
            //Console.WriteLine("--name1:{0}--",name1);

            //string name2 = "xiaowang";
            //name2 = name2.ToUpper();
            //Console.WriteLine("--name2:{0}--", name2);

            //string name3 = "XIAOWANG";
            //name3 = name3.ToLower();
            //Console.WriteLine("--name3:{0}--", name3);

            //string name4 = "http://www.baidu.com/detail?user=abc";
            //int position = name4.LastIndexOf(".");
            //Console.WriteLine("--name4:{0}--", position);

            #endregion

            #region 关于字符串的拼接
            //string strText = "我正在学习";
            //strText += ".NET平台";
            //strText += "与C#开发语言";
            //Console.WriteLine(strText);
            #endregion

            #region StringBuilder类的使用
            //StringBuilder myBuilder = new StringBuilder();
            //myBuilder.Append("我正在学习");
            //myBuilder.Append(".NET平台");
            //myBuilder.Append("与C#开发语言");
            //Console.WriteLine(myBuilder.ToString());
            #endregion

            #region 数组使用概述
            //// 【1】声明数组
            //int[] scores;

            //// 【2】分配空间
            //scores = new int[5];

            //// 【3】赋值
            //scores[0] = 67;

            //// 【4】处理数据
            //scores[0] = scores[0] + 5;

            //// 数组声明同时初始化的三种情况
            //int[] netScore1 = new int[3] { 67, 89, 78 };
            //int[] netScore2 = new int[] { 67, 89, 78 };
            //int[] netScore3 = { 67, 89, 78 };
            #endregion

            #region 数组应用
            //// 声明数组，并赋值
            //int[] netScore = new int[] { 67, 89, 78, 69, 95 };
            //int sumScore = 0;
            //// 使用for循环读取数组元素
            //for (int i = 0; i < netScore.Length; i++)
            //{
            //    // sumScore = sumScore + netScore[i];
            //    sumScore += netScore[i];
            //}
            //int avgScore = sumScore / netScore.Length;
            //Console.WriteLine("学员平均成绩：{0}", avgScore);

            #endregion

            #region 数组遍历的新方法foreach
            //// 声明数组，并赋值
            //int[] netScore = new int[] { 67, 89, 78, 69, 95 };
            //int sumScore = 0;
            //// 使用for循环读取数组元素
            //foreach ( int score in netScore)
            //{
            //    sumScore += score;
            //}
            //int avgScore = sumScore / netScore.Length;
            //Console.WriteLine("学员平均成绩：{0}", avgScore);
            #endregion

            #region 字符串的处理（补充）
            //// 使用空字符分割字符串
            //string name1 = "x i a o w a n g";
            //string[] letterArray = name1.Split();
            //// 使用逗号分割字符串
            //string name2 = "小王,小刘,小江";
            //string[] nameList = name2.Split(',');
            //// 将分割后的字符串使用下划线连接在一起
            //string name3 = string.Join("_", nameList);
            //Console.WriteLine(letterArray.Length);
            //Console.WriteLine(name3);
            #endregion

            #region 值类型变量1
            //int wangScore = 90;
            //int zhangScore = wangScore;
            //Console.WriteLine("小王成绩：{0},小张成绩：{1}", wangScore, zhangScore);

            //// 修改小张的成绩
            //zhangScore += 5;
            //Console.WriteLine("修改后俩人的成绩如下：");
            //Console.WriteLine("小王成绩：{0}, 小张成绩: {1}", wangScore, zhangScore);

            #endregion

            #region 引用类型变量1
            //int[] score = { 90, 90 };
            //Console.WriteLine("审阅前二人成绩：小王:{0}, 小张:{1}", score[0], score[1]);

            //// 修改小张的成绩
            //int[] editedScore = score;
            //editedScore[1] += 5;

            //Console.WriteLine("修改后二人成绩：小王: {0}, 小张: {1}", editedScore[0], editedScore[1]);
            //Console.WriteLine("-------------------");
            //Console.WriteLine("审阅前二人成绩：小王:{0}, 小张:{1}", score[0], score[1]);

            #endregion

            Console.ReadLine();
        }
    }
}
