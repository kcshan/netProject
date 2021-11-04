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
            Console.WriteLine("姓名\t年龄\t班级\n");
            Console.WriteLine("{0}\t{1}\t{2}", "张红1", 20, "软件1班");
            Console.WriteLine("{0}\t{1}\t{2}", "张红2", 21, "软件2班");
            Console.WriteLine("{0}\t{1}\t{2}", "张红3", 22, "软件3班");
            Console.WriteLine("{0}\t{1}\t{2}", "张红4", 23, "软件4班");
            #endregion

            Console.ReadLine();
        }

        public enum Genders
        {
            Male=0, Female=1
        }
    }
}
