using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量
            //// 【声明变量】，即“根据数据类型在内存申请空间”
            //int age;

            //// 【给变量赋值】，即“将数据存储至对应的内存空间”
            //age = 20;

            //// 【也可以同时声明和赋值】
            //string name = "小王";

            //// 【使用变量】，即取出数据使用
            //Console.WriteLine("我叫" + name + " 今年" + age + "岁");
            #endregion

            #region 常量
            //const double PAI = 3.14; // 常量要求定义的时候必须初始化
            ////PAI = PAI + 1;
            //double result = PAI * (5 * 5);
            //Console.WriteLine("圆的面积：" + result);
            #endregion

            #region 枚举
            //Genders gender = Genders.Male;
            //Console.WriteLine((int)gender);

            #endregion

            #region Console类1
            //Console.WriteLine();
            //Console.WriteLine("输出后换行");
            //Console.Write("输出后不换行");
            //Console.Write("输出后不换行");
            #endregion

            #region Console类2
            //string stuName = "张三";
            //int stuAge = 20;
            //Console.WriteLine("学员姓名：" + stuName + " 年龄：" + stuAge);
            //Console.WriteLine("学员姓名：{0} 年龄: {1}", stuName, stuAge);
            #endregion

            #region Console类3
            //Console.WriteLine("请输入学员姓名：");
            //string stuName = Console.ReadLine();

            //Console.WriteLine("请输入学员年龄：");
            //int stuAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("学员姓名：" + stuName + " 年龄：" + stuAge);
            //Console.WriteLine("学员姓名：{0} 年龄: {1}", stuName, stuAge);
            #endregion

            #region Console类4
            //Console.WriteLine("姓名\t年龄\t班级\n");
            //Console.WriteLine("{0}\t{1}\t{2}", "张红1", 20, "软件1班");
            //Console.WriteLine("{0}\t{1}\t{2}", "张红2", 21, "软件2班");
            //Console.WriteLine("{0}\t{1}\t{2}", "张红3", 22, "软件3班");
            //Console.WriteLine("{0}\t{1}\t{2}", "张红4", 23, "软件4班");
            #endregion

            #region 运算符1
            //int num1 = 50;
            //int num2 = 30;
            //int result1 = num1 + num2;
            //string a = "50";
            //string b = "60";
            //string result0 = a + b;
            //int result2 = result1 % 3;
            //int result3 = result1 / 3;
            //num1++;
            //num2--;
            //int result4 = num1 * num2;
            //Console.WriteLine("result1={0}", result1);
            //Console.WriteLine("result0={0}", result0);
            //Console.WriteLine("result2={0}", result2);
            //Console.WriteLine("result3={0}", result3);
            //Console.WriteLine("result4={0}", result4);

            #endregion

            #region 运算符2
            //int num1 = 50;
            //Console.WriteLine("num1++={0}", num1++);
            //Console.WriteLine("num1={0}", num1);

            //num1 = 50;
            //Console.WriteLine("++num1={0}", ++num1);

            //int num2 = 40;
            //Console.WriteLine("num2--={0}", num2--);
            //Console.WriteLine("--num2={0}", --num2);

            #endregion

            #region 自动类型转换
            //double a = 10.25;
            //int b = 20;
            //double result = a + b;
            //Console.WriteLine("result={0}", result);
            #endregion

            #region 强制类型转换1
            //double a = 10.25;
            //int b = 20;
            //int result = (int)a + b;
            //Console.WriteLine("result={0}", result);

            #endregion

            #region 强制类型转换2
            //// 字符串强制转换成值类型
            //double a = double.Parse("20.5");
            //float b = float.Parse("20.25");
            //// 字符串部分必须是数字的有效表示形式！
            //int c = int.Parse("20");

            //// 值类型强制转换成字符串类型
            //string aa = a.ToString();
            //string bb = b.ToString();
            //string cc = c.ToString();

            //Console.WriteLine("a={0},b={1},c={2}", aa, bb, cc);
            #endregion

            #region 强制类型转换3
            //double a = Convert.ToDouble("20.325");
            //float b = Convert.ToSingle("20.55");
            //int c = Convert.ToInt32("20");

            //DateTime dateTime = Convert.ToDateTime("2021-11-05");

            //int d = Convert.ToInt32(a);
            //int e = Convert.ToInt32(b);
            //double f = Convert.ToDouble(c);

            //Console.WriteLine("a={0} b={1} c={2} datetime={3} d={4} e={5} f={6}", a, b, c, dateTime, d, e, f);

            #endregion

            #region 问题思考
            //int a = int.Parse("35.8");
            //int b = Convert.ToInt32("35.8");

            int a = (int)double.Parse("35.8");
            int b = (int)Convert.ToDouble("35.8");
            Console.WriteLine("a={0} b={1}", a, b);
            #endregion

            Console.ReadLine();
        }

        public enum Genders
        {
            Male=0, Female=1
        }
    }
}
