﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.csharpbase
{
    /// <summary>
    /// 这个是控制台核心类
    /// 主要是供我们练习使用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();

            int result = Add(10, 20);

            //Test2();

            //Test3();

            //Test4();

            //Test5();

            //Test6();

            //Test7();

            //Test8();

            //Test9();

            //Test10();

            //Test11();

            //Test12();

            //Test13();

            //Test14();

            //Test15();

            //Test16();

            //Test17();

            //Test18();

            //Test19();

            //Test20();

            //Test21();

            //Test22();

            //Test23();

            //Test24();

            //Test25();

            //Test26();

            //Test27();

            //Test28();

            //Test29();

            //Test30();

            //Test31();

            //Test32();

            //Test33();

            //Test34();

            //Test35();

            //Test36();

            //Test37();

            //Test38();

            //Test39();

            //Test40();

            //TestString();

            //Test41();

            //Test42();

            //Test43();

            debugTest();

            Console.ReadLine();
        }

        #region 01.变量的基本使用
        static void Test1()
        {
            int score; // 变量类型 变量名称

            score = 98; // 给变量赋值

            string subject = "C#基础语法"; // 声明变量同时赋值

            // 使用变量
            Console.WriteLine("科目：" + subject + " 分数：" + score);

            Console.ReadLine();
        }

        /// <summary>
        /// 实现俩个数相加
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns>返回俩个数的和</returns>
        static int Add(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region 02.控制台的使用技巧

        static void Test2()
        {
            //int score = 90;
            //string name = "jack";

            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine()); // 90

            //Console.WriteLine(90);
            //Console.WriteLine("C#编程");

            Console.WriteLine("姓名：" + name + " 成绩：" + score);

        }

        // 字符串格式化方法和控制台输出格式化
        static void Test3()
        {
            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine()); // 90
            Console.Write("请输入班级：");
            string className = Console.ReadLine();

            // 使用 + 拼接字符串
            string info1 = "姓名：" + name + " 成绩：" + score;

            // 使用占位符拼接字符串
            string info2 = string.Format("姓名：{0} 成绩：{1} 班级：{2}", name, score, className);

            Console.WriteLine(info2);
            Console.WriteLine();

            // WriteLine方法支持直接的格式化方法
            Console.WriteLine("姓名：{0} 成绩：{1} 班级：{2}", name, score, className);

            Console.WriteLine("**********下面是新特性的格式化方法***********");
            // 使用新特性简化字符串格式化
            string info3 = $"姓名: {name} 成绩: {score} 班级：{className}";
            Console.WriteLine(info3);
            Console.WriteLine($"姓名: {name} 成绩: {score} 班级：{className}");
        }
        #endregion

        #region 03.赋值和算数运算符的使用

        static void Test4()
        {
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine($"a + b = {result}");

            result = a - b;
            Console.WriteLine($"a - b = {result}");

            result = a * b;
            Console.WriteLine($"a * b = {result}");

            result = a / b;
            Console.WriteLine($"a / b = {result}");

            result = b / a;
            Console.WriteLine($"b / a = {result}");

            int c = 12;
            result = c % a;
            Console.WriteLine($"c % a = {result}");

            result = a * (b - c) / 2;
            Console.WriteLine($"a * (b - c) / 2 = {result}");

            a = a + b;
            Console.WriteLine("a=" + a);
            a = a - b;
            Console.WriteLine("a=" + a);

            a += b;
            Console.WriteLine($"a += b -> {a}");

            a -= b;
            Console.WriteLine($"a -= b -> {a}");

            a *= b;
            Console.WriteLine($"a *= b -> {a}");

            int d = 100;
            d++;
            Console.WriteLine($"d = {d}");

            d--;
            Console.WriteLine($"d = {d}");

            ++d;
            Console.WriteLine($"d = {d}");

            --d;
            Console.WriteLine($"d = {d}");

            int i = 200;
            Console.WriteLine($"i++后的值：{i++}");
            Console.WriteLine($"i的值：{i}");

            int e = 300;
            Console.WriteLine($"++e后的值：{++e}");

            int f = 400;
            Console.WriteLine($"f++后的值：{f--}");
            Console.WriteLine($"f的值：{f}");

            int h = 500;
            Console.WriteLine($"--h后的值：{--h}");
        }

        #endregion

        #region 04.本阶段练习

        static void Test5()
        {
            Console.Write("请输入第1位学员的成绩：");
            int stuScore1 = int.Parse(Console.ReadLine());
            Console.Write("请输入第2位学员的成绩：");
            int stuScore2 = int.Parse(Console.ReadLine());
            Console.Write("请输入第3位学员的成绩：");
            int stuScore3 = int.Parse(Console.ReadLine());
            Console.Write("请输入第4位学员的成绩：");
            int stuScore4 = int.Parse(Console.ReadLine());
            Console.Write("请输入第5位学员的成绩：");
            int stuScore5 = int.Parse(Console.ReadLine());

            int avgScore = (stuScore1 + stuScore2 + stuScore3 + stuScore4 + stuScore5) / 5;
            // 计算平均成绩
            Console.WriteLine($"5位学员的平均成绩：{avgScore}");
        }

        static void Test6()
        {
            Console.Write("请输入第1位进入本楼的人员姓名：");
            string name_1 = Console.ReadLine();
            Console.Write("请输入第2位进入本楼的人员姓名：");
            string name_2 = Console.ReadLine();
            Console.Write("请输入第3位进入本楼的人员姓名：");
            string name_3 = Console.ReadLine();

            Console.WriteLine("*****************************");

            string info1 = "刚才进出的3位人员是：" + name_1 + ";" + name_2 + ";" + name_3 + ";";
            string info2 = "刚才进出的3位人员是：" + string.Format("{0};{1};{2};", name_1, name_2, name_3);
            string info3 = $"刚才进出的3位人员是：{name_1};{name_2};{name_3};";

            Console.WriteLine(info1);
            Console.WriteLine(info2);
            Console.WriteLine(info3);
        }

        #endregion

        #region 05.比较运算符

        static void Test7()
        {
            string name1 = "james";
            string name2 = "jacks";
            string name3 = "james";

            bool result1 = name1.Equals(name2);
            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1 == name3);
            Console.WriteLine(name1 != name2);

            //if (name1 == name2)
            //{

            //}
            Console.WriteLine("*****************************");
            int a = 100;
            int b = 200;
            int c = b - a;

            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine(b != c);

            Console.WriteLine(a > b);
            Console.WriteLine(a <= c);
        }

        #endregion

        #region 06.自动类型转换：值类型之间

        static void Test8()
        {
            //Console.WriteLine("*****************************");
            double a = 100.5;
            int b = 200;

            double result = a + b; // 这个转换是自动完成的
            Console.WriteLine($"自动实现类型转换： 100.5 + 200 = {result}");
        }

        #endregion

        #region 07.强制类型转换：值类型之间

        static void Test9()
        {
            double a = 100.5;
            int b = 200;

            int result = (int)a + b; // 这种语法的转换，一般是值类型之间可以用。
            Console.WriteLine($"强制类型转换一： 100.5 + 200 = {result}");

            // 结论： 这种方式，会出现精度丢失！
        }

        // 特别的：如果要转换的类型是object类型，也可以使用这种语法。
        static void Test10()
        {
            object a = 100.5;
            int b = 200;

            int result = (int)(double)a + b; // object属于引用类型
            Console.WriteLine($"强制类型转换二： 100.5 + 200 = {result}");

            // 结论： 这种方式，会出现精度丢失！
        }

        // 总结：当我们使用（数据类型）这种强制转换方法的时候，要求被转换的变量"大类型"必须和目标大类型一致

        #endregion

        #region 08.强制类型转换：字符串和值类型之间

        static void Test11()
        {
            // 只有"有效的"字符串类型，才能转换成对应的值类型。有效的：也就是说字符串内容必须符合目标类型
            double a = double.Parse("100.5");
            float b = float.Parse("20.36");
            int c = int.Parse("500");

            //int d = int.Parse("19.56"); // 这种方式会出错，因为"19.56"不是int的有效表示形式
            int d = (int)double.Parse("19.56");
            double e = double.Parse("100");

            // 总结转换方法： 目标类型 变量 = 目标类型.Parse("字符串的有效表示");

            // -> 值类型 ==> 字符串
            string s1 = a.ToString();
            string s2 = b.ToString();
        }

        #endregion

        #region 09.强制类型转换：万能转换器Convert

        static void Test12()
        {
            double a = Convert.ToDouble("100.5");
            float b = Convert.ToSingle("20.36");
            int c = Convert.ToInt32("500");
            DateTime dt = Convert.ToDateTime("2022-10-01");

            int d = Convert.ToInt32(a);

            // 注意：以上情况，同样要求，字符串或者要转换的类型，必须是目标类型的有效表示形式
            c = (int)Convert.ToInt32("500.5");
        }

        #endregion

        #region 10.if条件选择与逻辑运算符

        static void Test13()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();

            // 判断
            //if (uName == null) // 在控制台输入中，如果用户什么都没有输入，返回的是空字符串，不是空值null
            //{
            //    Console.WriteLine("用户名不能为空!");
            //}

            // 判断字符串是空通常用下面的三种方式（注意不是null）
            if (uName == "")
            {
                Console.WriteLine("【1】用户名不能为空!");
            }
            if (uName == string.Empty)
            {
                Console.WriteLine("【2】用户名不能为空!");
            }
            if (uName.Length == 0)
            {
                Console.WriteLine("【3】用户名不能为空!");
            }

            if (uName == "" || uPwd == "")
            {
                Console.WriteLine("用户密码不能为空！");
            }
            // 这种或运算符，只要检测到一个条件满足，后面的就不再检测（短路）
        }

        static void Test14()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();

            // 判断字符串是空通常用下面的三种方式（注意不是null）
            if (uName == "")
            {
                Console.WriteLine("【1】用户名不能为空!");
            }
            if (uName == string.Empty)
            {
                Console.WriteLine("【2】用户名不能为空!");
            }
            if (uName.Length == 0)
            {
                Console.WriteLine("【3】用户名不能为空!");
            }

            if (uName != "" && uPwd != "")
            {
                Console.WriteLine("账号密码正确");
            }
        }

        static void Test15()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();

            // 判断字符串是空通常用下面的三种方式（注意不是null）
            if (uName == "")
            {
                Console.WriteLine("【1】用户名不能为空!");
            }
            if (uName == string.Empty)
            {
                Console.WriteLine("【2】用户名不能为空!");
            }
            if (uName.Length == 0)
            {
                Console.WriteLine("【3】用户名不能为空!");
            }
            if (uName != "" || uPwd != "")
            {
                if (uName == "abc" && uPwd == "123")
                {
                    Console.WriteLine("用户登录成功");
                }
            }
        }

        static void Test16()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();
            Console.Write("您是管理员吗？");
            bool isAdmin = Convert.ToBoolean(Console.ReadLine());

            // 判断字符串是空通常用下面的三种方式（注意不是null）
            if (uName == "")
            {
                Console.WriteLine("【1】用户名不能为空!");
            }
            if (uName == string.Empty)
            {
                Console.WriteLine("【2】用户名不能为空!");
            }
            if (uName.Length == 0)
            {
                Console.WriteLine("【3】用户名不能为空!");
            }
            if (uName != "" || uPwd != "")
            {
                if (uName == "abc" && uPwd == "123")
                {
                    Console.WriteLine("用户登录成功");
                }
            }
            if (!isAdmin)
            {
                Console.WriteLine("当前用户不是管理员！");
            }
        }

        #endregion

        #region 11.if条件选择与逻辑运算符

        static void Test17()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int labScore = int.Parse(Console.ReadLine());

            if (writeScore >= 80 && labScore >= 90)
            {
                Console.WriteLine("考试成绩优秀！");
            }

            if ((writeScore == 100 && labScore > 60) || (writeScore > 60 && labScore == 100))
            {
                Console.WriteLine("考试成绩优秀！");
            }
        }

        #endregion

        #region 12.if-else 条件选择与三元运算符

        static void Test18()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int labScore = int.Parse(Console.ReadLine());

            if (writeScore >= 80 && labScore >= 90)
            {
                Console.WriteLine("考试成绩优秀！");
            }
            else
            {
                Console.WriteLine("请继续努力哦！争取下次考试优秀！");
            }
        }

        static void Test19()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int labScore = int.Parse(Console.ReadLine());

            string result = "";

            if (writeScore > labScore)
            {
                result = "请加强机试练习";
            }
            else
            {
                result = "请加强笔试练习";
            }

            Console.WriteLine(result);
            Console.WriteLine("********************");

            // 三元运算符适合if-else的简单条件和简单赋值的语句
            result = writeScore > labScore ? "请加强机试练习" : "请加强笔试练习";
            Console.WriteLine(result);

            int a = 10;
            int b = 20;
            int c = a - b > 0 ? a * b : a + b;

            Console.WriteLine(c);
        }

        #endregion

        #region 13.多条件选择else-if与选择嵌套

        static void Test20()
        {
            Console.Write("请输入客户消费金额：");
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
        }

        static void Test21()
        {
            Console.Write("请输入客户消费金额：");
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
        }

        static void Test22()
        {
            Console.Write("请输入客户消费金额：");
            int totalMoney = int.Parse(Console.ReadLine());

            if (totalMoney >= 1000)
            {
                int realMoney = totalMoney - 500;
                Console.WriteLine("需要付款：" + realMoney);

                Console.Write("请输入会员类型：");
                // 再次判断
                string customerType = Console.ReadLine();
                if (customerType == "普通")
                {
                    Console.WriteLine("同时送100元代金券！");
                }
                else if (customerType.Equals("vip"))
                {
                    Console.WriteLine("同时送200元代金券！");
                }
            }
            else
            {
                Console.WriteLine($"需要付款：{totalMoney}");
            }
        }

        #endregion

        #region 14.switch分支结构

        static void Test23()
        {
            Console.Write("请输入您购买的课程类型：");
            string type = Console.ReadLine();

            switch (type)
            {
                case "A":
                    Console.WriteLine("可以抽奖安卓手机！");
                    break;
                case "B":
                    Console.WriteLine("可以抽奖平板电脑！");
                    break;
                case "C":
                    Console.WriteLine("可以抽奖固态硬盘！");
                    break;
                default:
                    Console.WriteLine("您不能参与抽奖！");
                    break;
            }
        }

        #endregion

        #region 15.for循环的使用

        static void Test24()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"这个是我第{i + 1}次做项目");
            }
        }

        static void Test25()
        {
            for (int a = 1; a <= 3; a++) // 外层循环；控制的是3次温度的显示
            {
                double t_sum = 0; // 用来累计温度

                for (int b = 0; b < 3; b++) // 内层循环；控制的是3次采集的次数
                {
                    Console.Write("请输入当前温度：");
                    t_sum += double.Parse(Console.ReadLine());
                    if (b == 2)
                    {
                        double t_avg = t_sum / 3;
                        Console.WriteLine($"**********第{a}次温度采集结果是：{t_avg}度");
                    }
                }
            }
        }

        #endregion

        #region 16.while循环的使用

        // 按照订单箱数包装饮料
        static void Test26()
        {
            for (int i = 0; i < 3; i++) // 外层循环：控制箱数
            {
                int count = 0;
                while (count < 6) // 内层循环：控制的是每箱包装的瓶数
                {
                    Console.Write("当前产品是否合格？");
                    string result = Console.ReadLine();
                    if (result == "y" || result == "1")
                    {
                        count++; // 计数累计
                        Console.WriteLine(".....放入箱中！");
                    }
                    else
                    {
                        Console.WriteLine("《剔除当前不合格产品！》");
                    }
                }
                Console.WriteLine($"......第{i + 1}箱包装成功！");
            }
            Console.WriteLine("**********订单包装数完成！");
        }

        // 不固定箱数包装饮料
        static void Test27()
        {
            int sum = 0; // 用于保存包装总数
            while (true) // 外层循环：控制箱数（不固定）
            {
                int count = 0;
                while (count < 6) // 内层循环：控制的是每箱包装的瓶数
                {
                    Console.Write("当前产品是否合格？");
                    string result = Console.ReadLine();
                    if (result != "y" && result != "1") // 如果产品不合格
                    {
                        Console.WriteLine("《剔除当前不合格产品！》");
                        continue; // 放弃本次循环，开始下一次新的循环
                    }
                    count++; // 计数累计（循环条件的改变）
                    Console.WriteLine(".....放入箱中！");
                }
                sum++;
                Console.WriteLine($"......第{sum}箱包装成功！");
                Console.Write("还继续打包吗？y/n");
                if (Console.ReadLine() == "n")
                {
                    Console.WriteLine("**********订单包装数完成！");
                    break; // 退出整个while循环
                }
            }
        }

        #endregion

        #region 17.do while循环的使用

        // 把前面的while循环，其实可以改成do while
        static void Test28()
        {
            for (int i = 0; i < 3; i++) // 外层循环：控制箱数
            {
                int count = 0;
                do
                {
                    Console.Write("当前产品是否合格？");
                    string result = Console.ReadLine();
                    if (result == "y" || result == "1")
                    {
                        count++; // 计数累计
                        Console.WriteLine(".....放入箱中！");
                    }
                    else
                    {
                        Console.WriteLine("《剔除当前不合格产品！》");
                    }
                }
                while (count < 6); // 内层循环：控制的是每箱包装的瓶数
                Console.WriteLine($"......第{i + 1}箱包装成功！");
            }
            Console.WriteLine("**********订单包装数完成！");
        }

        static void Test29()
        {
            do
            {
                Console.Write("当前网络返回的数据是：");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("******网络测试成功！");
                    break;
                }
            } while (true);
        }

        #endregion

        #region 18.字符串的常用处理方法

        static void Test30()
        {
            string email = "thinger@qq.com";
            int index1 = email.IndexOf("@"); // 获取符合字符串条件的第一个索引的位置
            int index2 = email.IndexOf("qq.com");

            int index3 = email.IndexOf("qq.net"); // 这个返回-1表示没有找到

            Console.WriteLine($"{index1}\t{index2}\t{index3}");

            int length = email.Length; // 获得字符串的长度是通过Length属性得到

            Console.WriteLine("当前字符串的长度是：" + length);

            string info = "现在大家学习的是常老师主讲的.NET/C#开发的系列课程！ ";

            Console.WriteLine(info.IndexOf("常老师")); // 返回8

            Console.WriteLine(info.Length); // 字符串长度是30（因为最后有一个空格）
        }

        static void Test31()
        {
            string email = "thinger@qq.com";
            string userName = email.Substring(0, 7);
            Console.WriteLine(userName);

            // 如果我们想从某一个字符串位置之前的内容全部获取，只需要找到这个字符串的索引即可
            string userName2 = email.Substring(0, email.IndexOf("@"));
            Console.WriteLine(userName2);

            // 如果我们希望得到某一个字符串后面的全部内容，截取的位置是这个字符串索引位置+1
            string type = email.Substring(email.IndexOf("@") + 1);
            Console.WriteLine(type);
        }

        static void Test32()
        {
            string name1 = "jack";
            string name2 = "jack";
            string name3 = "james";
            string name4 = "JAMES";

            // 字符串判断是否相等，在项目中实现用户登录账号或密码判断的时候，经常使用。
            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1.Equals(name2));
            Console.WriteLine(name1 == name3);
            Console.WriteLine(name3.Equals(name4)); // 字符串这种比较的方法是区分大小写的
            Console.WriteLine(name3 == name4);

            // 提醒： ==或Equals方法默认只能比较值类型或字符串类型。对象类型（引用类型）是不能使用这种方式比较的。

            Console.WriteLine("********************");
            int a = 20;
            int b = 30;
            int c = 20;
            Console.WriteLine(a == b);
            Console.WriteLine(b.Equals(c));
            Console.WriteLine(a.Equals(c));
        }

        // 字符串格式化和形式扩展
        static void Test33()
        {
            string name = "tom";
            int age = 20;
            Console.WriteLine($"学员姓名：{name} 年龄：{age}");
            string info = string.Format("学员姓名：{0} 年龄 {1}", name, age);

            int money = 255555;
            string moneyType = string.Format("总金额：{0:C}", money);
            Console.WriteLine(moneyType);
        }

        // 字符串空值的处理方法
        static void Test34()
        {
            string name1 = ""; // 这个空字符串是占用空间的
            string name2 = string.Empty; // 这个和上面是一样的
            Console.WriteLine(name1.Equals(name2));

            string name3; // 这个是没有赋值的过程
            string name4 = null; // 这个存在着一个赋值的过程

            //Console.WriteLine(name3 == name4); // 这个会有语法错误

            Console.WriteLine(name4 == name1); // 这个是允许使用的，返回的是false

            Console.WriteLine("name1.Length=" + name1.Length);
            Console.WriteLine("name2.Length=" + name2.Length);

            // 下面这个会出现错误 System.NullReferenceException: 未将对象引用设置到对象的实例
            Console.WriteLine("name4.Length=" + name4.Length);

            // 字符串我们后面在学习对象的时候，string其实是String的一个别名
            // 也就是说String对象在使用的时候必须要实例化（有具体值，不能是null）如果是null是没有办法调用方法或属性
            Console.WriteLine(name4.Equals(name1));
        }

        // 字符串处理的其他方法（简单但非常实用）
        static void Test35()
        {
            // 字符串去空格的方法（我们在获取用户表单数据的时候，通常会去掉）
            string info = "  jack";
            Console.WriteLine(info.Length);
            // 从当前 System.String 对象移除所有前导空白字符和尾部空白字符
            Console.WriteLine(info.Trim().Length);

            string name3 = "james";
            string name4 = "JAMES";
            // 把name4全部转换成小写后再比较
            Console.WriteLine(name3.Equals(name4.ToLower()));
            Console.WriteLine(name3.ToUpper().Equals(name4));

            // 获取符合字符串条件的最后一个索引位置
            string url = "http://xiketang.ke.qq.com/?tuin=aee16c2e";
            Console.WriteLine(url.LastIndexOf("."));

            // 关于字符串其他的方法，可以通过查看定义去了解
        }

        #endregion

        #region 19.StringBuilder字符串的高效处理

        static void Test36()
        {
            // 普通字符串的拼接
            string data = string.Empty;
            data += "AB";
            data += "CD";
            data += "EF";
            Console.WriteLine(data);

            // 高效字符串的组合
            Console.WriteLine("*******************");
            StringBuilder builder1 = new StringBuilder();
            builder1.Append("AB");
            builder1.Append("CD");
            builder1.Append("EF");
            Console.WriteLine(builder1.ToString());

            Console.WriteLine("*******************");
            builder1.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"请输入第{i + 1}个数据：");
                builder1.Append(Console.ReadLine());
            }
            Console.WriteLine(builder1.ToString());

            Console.WriteLine("*******************");
            StringBuilder builder2 = new StringBuilder("本期课程信息-》");
            string teacher = "常老师";
            string month = "3个月";
            builder2.AppendFormat("主讲老师：{0},课程周期：{1}", teacher, month);
            Console.WriteLine(builder2.ToString());

            Console.WriteLine("*******************");
            StringBuilder builder3 = new StringBuilder(".Net工控上位机发展势头迅猛！");
            builder3.Insert(0, "中国的");
            builder3.Insert(builder3.ToString().Length, "大家要加快学习速度！");
            Console.WriteLine(builder3.ToString());

            Console.WriteLine("*******************");
            builder3.Remove(0, builder3.ToString().IndexOf("."));
            Console.WriteLine(builder3.ToString());
        }

        #endregion

        #region 20.数组Array的使用

        static void Test37()
        {
            // 4个步骤
            int[] scores; // 声明数组
            scores = new int[5]; // 分配空间（具体空间一般在开发中，会根据实际情况确定）
            scores[0] = 67;
            scores[1] = 89;
            scores[2] = 78;
            scores[3] = 80;
            scores[4] = 75;
            // 元素操作
            int avgScore = (scores[0] + scores[1] + scores[2] + scores[3] + scores[4]) / 5;
            Console.WriteLine($"简单相加得到学员的平均成绩：{ avgScore }");

            // 3种情况
            int[] score1 = new int[5] { 67, 89, 78, 80, 75 };
            int[] score2 = new int[] { 67, 89, 78, 80, 75 };
            int[] score3 = { 67, 89, 78, 80, 75 };

            // 使用for循环遍历数组
            Console.WriteLine("*******************");
            int sumScore = 0;
            for (int i = 0; i < score1.Length; i++)
            {
                sumScore += score1[i];
            }
            avgScore = sumScore / score1.Length;
            Console.WriteLine($"for循环得到学员的平均成绩：{avgScore}");

            // 使用foreach循环遍历数组（同样也是不用关心循环次数，但是要求循环的对象，必须有固定的循环次数）
            // 对比： while循环，不仅不关心循环次数，而且也不关心，具体什么时候结束，因为结束是根据条件决定的
            sumScore = 0;
            foreach (int item in score1)
            {
                sumScore += item;
            }
            avgScore = sumScore / score1.Length;
            Console.WriteLine($"for循环得到学员的平均成绩：{avgScore}");
        }

        #endregion

        #region 21.字符串的分隔和连接

        static void Test38()
        {
            string data = "AB EF HU 00"; // 使用空字符分隔的字符串
            string[] dataArray = data.Split(); // 使用空格分隔的时候，此方法内部不需要参数。
            string newData = string.Join("_", dataArray);
            Console.WriteLine(newData);

            Console.WriteLine("*********************");
            // 使用逗号分隔字符串
            data = "AB,EF,HU,00";
            dataArray = data.Split(',');
            newData = string.Join("&", dataArray);
            Console.WriteLine("数组元素个数：" + dataArray.Length);

            Console.WriteLine("*********************");
            // 字符串替换
            data = "AB,EF,HU,00";
            string dataInfo = data.Replace(',', '-');
            Console.WriteLine(dataInfo);

            // 数组使用中常见问题
            //int[] netScore = new int[5] { 90, 56, 78 }; // 这行代码编译不通过
            int[] netScore2 = new int[3] { 90, 56, 78 }; // 正确的写
            //int myScore = netScore2[3]; // System.IndexOutOfRangeException:“索引超出了数组界限。”
            // 数组界限：数组最大的索引值。-> 索引超出了数组最大的索引值。

        }

        #endregion

        #region 22.值类型变量的使用

        static void Test39()
        {
            int wangScore = 90;
            int zhangScore = wangScore;
            Console.WriteLine($"修改前二人的成绩如下：小王成绩：{wangScore} 小张成绩：{zhangScore}");

            // 修改小张的成绩
            zhangScore += 5;
            Console.WriteLine($"修改后二人的成绩如下：小王成绩：{wangScore} 小张成绩：{zhangScore}");
        }

        // 引用类型的变量传递
        static void Test40()
        {
            int[] oldScore = { 90, 90 }; // 定义数组保存小王和小张的成绩
            Console.WriteLine($"修改前二人的成绩如下：小王成绩：{oldScore[0]} 小张成绩：{oldScore[1]}");

            // 修改小张的成绩
            int[] newScore = oldScore;
            newScore[1] += 5;
            Console.WriteLine($"修改后【oldScore】二人的成绩如下：小王成绩：{oldScore[0]} 小张成绩：{oldScore[1]}");
            // 思考：上面的输出会不会是90 90
            Console.WriteLine("********************************");
            // 思考：上面的输出会不会是90 95
            Console.WriteLine($"修改后【newScore】二人的成绩如下：小王成绩：{newScore[0]} 小张成绩：{newScore[1]}");
        }

        // 字符串在类型划分上属于引用类型，但是实际应用效果上是和值类型一样的！
        static void TestString()
        {
            string teacherName = "常老师";
            string newTeacher = teacherName;
            newTeacher = "james";
            Console.WriteLine(teacherName + "\t" + newTeacher);
        }

        #endregion

        #region 23.常量和枚举的使用

        static void Test41()
        {
            const double PAI = 3.14;
            //PAI += 1; // 常量不允许修改
            double result = PAI * (5 * 5);
            Console.WriteLine("圆的面积 = " + result);
        }

        static void Test42()
        {
            Gender gender = Gender.Female;
            // gender = "女";
            Console.WriteLine((int)gender);
        }

        // 系统定义的枚举
        static void Test43()
        {
            DayOfWeek week = DayOfWeek.Thursday;
            switch (week)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("今天是星期日");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("今天是星期一");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("今天是星期二");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("今天是星期三");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("今天是星期四");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("今天是星期五");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("今天是星期六");
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 24.debug程序调试测试

        static void debugTest()
        {
            Console.WriteLine("请看下面的5行文字：");
            int i = 1;
            Test();
            while (i <= 5)
            {
                Console.WriteLine($"第{i}行：我们正在跟常老师学习C#开发语言");
                i++;
            }
        }

        // 打断点；预估程序可能在哪里出现问题，如果你不知道或者无法准确的判断，那么可以在程序入口处打断点！
        // 断点方法：鼠标/F9在指定行
        // 调试：俩个断点之间，如果不想在=再逐行调试，可以直接按F5把中间这部分代码全部跳过。
        // 逐过程：F10，可以直接跳过某个方法的调用，而F11，如果遇到方法调用，会进入方法内部逐条语句执行。
        // 以后大家会经常遇到：未将对引用到对象的实例！这种问题，通常都会需要调试或观察！

        static void Test()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);

        }
        #endregion
    }

    // 定义性别枚举
    public enum Gender
    {
        Male = 1,
        Female = 0
    }
}
