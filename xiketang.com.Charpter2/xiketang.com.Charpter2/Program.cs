using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.Charpter2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Method1();
            // Method2();
            // Method3();
            // Method4();
            // Method5();
            // Method6();
            //  Method7();
            //  Method8();
            // Method9();
            // Method10();
            // Method11();
            Console.Read();
        }

        #region 变量的定义基本规范

        static void Method1()
        {
            int courseId;//声明变量（默认0）
            courseId = 60266;

            string courseName = ".NET全栈开发课程";

            //通过字符串拼接输出
            Console.WriteLine("课程编号：" + courseId + "  课程名称：" + courseName);

            //使用占位符格式化输出
            Console.WriteLine("课程编号：{0}   课程名称：{1}", courseId, courseName);

            //使用4.6版本的语法糖
            Console.WriteLine($"课程编号：{courseId}   课程名称：{courseName}");
            Console.WriteLine("**************************************************");

            //顺便学习一下其他的方法,输出后，不换行
            Console.Write("1");
            Console.Write("2    \r\n");
            Console.WriteLine("**************************************************");

            //从控制台输入信息
            Console.WriteLine("请输入您现在学习的课程：");
            string name = Console.ReadLine();
            Console.WriteLine("您正在学习：" + name);
            Console.WriteLine("**************************************************");

            Console.WriteLine("请输入您现在的年龄：");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"您输入的年龄是：{age}");//字符串和整数相加，如果最后结果类型是字符串，能自动转换
            string a = "您好！" + age;
            // int b= "您好！" + age;   //这种情况是不允许
            Console.WriteLine("**************************************************");

        }

        #endregion

        #region 变量定义常见错误

        static void Method2()
        {
            //错误1：变量未声明，先使用
            //  string teacher = "常老师";
            //   Console.WriteLine("课程主讲："+teacher);

            //错误2：变量未赋值，先使用
            string teacher;
            //  string teacher = null;//这样是允许
            // Console.WriteLine("课程主讲：" + teacher);

            //string student0;
            //string student1 = null;
            // bool result = student0.Equals(student1);

            string student2 = string.Empty;
            string student3 = ""; //显式的给变量赋一个初始值，使我们编程的一个好习惯
            string student4 = " ";

            bool result = student2.Equals(student3);
            Console.WriteLine(result);
            Console.WriteLine(student3.Equals(student4));

            //错误3：使用非法的变量名  $teacher

            // string $teacher = string.Empty;
            //int 20Age = 20;

            //错误4：变量名重复定义
            // string teacher;

            //错误5：使用关键字命名变量 this 
            // int this = 20;
            //int string
        }

        #endregion

        #region 常量的定义和使用

        static void Method3()
        {
            const double PAI = 3.14;

            //   PAI = 3;

            double result = PAI * (5 * 5);
            Console.WriteLine("面积=" + result);
            Console.WriteLine("--------------------------------------------------");
        }

        #endregion

        #region 枚举的使用

        static void Method4()
        {
            //使用枚举定义变量
            Gender gender = Gender.Male;
            Console.WriteLine((int)gender);
        }

        #endregion

        #region 运算符的基本使用

        static void Method5()
        {
            int num1 = 50;
            int num2 = 30;
            int result0 = num1 + num2;
            Console.WriteLine("result1={0}", result0);
            Console.WriteLine("**************************************************");

            string a = "50";
            string b = "60";
            string result1 = a + b;
            Console.WriteLine("result1={0}", result1);
            Console.WriteLine("**************************************************");

            int result2 = result0 % 3;
            int result3 = result0 / 3;
            Console.WriteLine("result2={0}", result2);
            Console.WriteLine("result3={0}", result3);
            Console.WriteLine("**************************************************");

            num1++;  //自加1  相当于num1=num1+1;
            num2--;    //自减一 相当于num2=num2-1;
            int result4 = num1 * num2;
            Console.WriteLine($"{num1}*{num2}={result4}");
            Console.WriteLine("**************************************************");

            ++num1;
            --num2;
            result4 = num1 * num2;
            Console.WriteLine($"{num1}*{num2}={result4}");
            Console.WriteLine("**************************************************");


            //以下是你面试的时候，经常会考到（记住：++或者--在前面，就是先运算后输出，反之是先输出后运算）
            int testAdd = 10;

            Console.WriteLine(testAdd++);
            Console.WriteLine(testAdd);

            Console.WriteLine(++testAdd);
        }

        #endregion

        #region 自动类型转换：值类型之间

        static void Method6()
        {
            double a = 10.25;
            int b = 20;
            double result = a + b;
            Console.WriteLine($"【自动类型转换】10.25+20={result}");
            Console.WriteLine("--------------------------------------------------");
        }


        #endregion

        #region 强制类型转换1：值类型之间

        //static void Method7()
        //{
        //    double a = 10.25;
        //    int b = 20;
        //    int result = a + b;  //如果将result改为int类型，这样就会出错
        //    Console.WriteLine($"result={result}");
        //}

        static void Method7()
        {
            Console.WriteLine(" \r\n【强制转换1】：(类型名) 表达式  \r\n");
            double a = 10.25;
            int b = 20;
            int result = (int)a + b;  //实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【dobule-->目标int】10.25+20={result} 【精度会丢失】");

            a = 10.50;
            result = (int)a + b;       //实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【dobule-->目标int】10.50+20={result} 【精度会丢失】");

            a = 10.55;
            result = (int)a + b;         //实现强制类型转换，但是精度会丢失
            Console.WriteLine($"【dobule-->目标int】10.55+20={result} 【精度会丢失】");

            Console.WriteLine("--------------------------------------------------");
        }

        //特别的，object类型转换成值类型也可以这样“适当的”使用！
        static void Method8()
        {
            object a = 10.25; //这样不行，应该是 object a = 10；也就是object类型转换的时候，必须保证后面的类型和要转换的“形式上”一致。
                              //  object a = 10;
            int b = 20;
            int result = (int)a + b;
            //  int result = (int)(double)a + b;
            Console.WriteLine($"result={result}");
            Console.WriteLine("--------------------------------------------------");
        }

        #endregion

        #region 强制类型转换2：字符串和值类型之间

        static void Method9()
        {
            Console.WriteLine(" \r\n【强制转换2】：类型.Parse('字符串')  \r\n");
            //有效类型的【字符串】转成【值类型】要求：字符串的格式必须符合目标类型的有效形式
            double a = double.Parse("20.5");
            float b = float.Parse("20.25");
            int c = int.Parse("20");

            //非有效形式：张三李四   20.2==>int


            //将值类型转成字符串类型，直接使用ToString()方法
            string aa = a.ToString();
            string bb = b.ToString();
            string cc = c.ToString();

            Console.WriteLine($"a={aa},b={bb},c={cc}");
            Console.WriteLine("--------------------------------------------------");
        }

        #endregion

        #region 强制类型转换3：万能转换器

        static void Method10()
        {
            Console.WriteLine(" \r\n【强制转换3】：Convert  \r\n");        

            //字符类型的浮点数，转换成正式的浮点数（完全符合我们正常的逻辑）
            double a = Convert.ToDouble("20.4");           
            Console.WriteLine($"【字符串（string）-->值类型（double）】20.40=>{a} "); 
            float b = Convert.ToSingle("19.55");
            Console.WriteLine($"【字符串（string）-->值类型（double）】19.55=>{b}");
            int c= Convert.ToInt32("20");
            Console.WriteLine($"【字符串（string）-->值类型（int）】20=>{c}");
            Console.WriteLine("--------------------------------------------------\r\n");

            //值类型之间（有一个特殊情况）
            int d = Convert.ToInt32(20.49);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=20.49=>转为整数 {d} 舍掉");
            d = Convert.ToInt32(19.49);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=19.49=>转为整数 {d} 舍掉");
            d = Convert.ToInt32(20.55);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=20.55=>转为整数 {d} 进位");
            d = Convert.ToInt32(19.55);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=19.55=>转为整数 {d} 进位");

            Console.WriteLine("\r\n----------------------【小数部分等于0.5的时候是特殊情况】----------------------\r\n");
            d = Convert.ToInt32(20.50);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=20.50=>转为整数 {d} 舍掉");   
            d = Convert.ToInt32(19.50);
            Console.WriteLine($"【值类型（double）-->值类型（int）】d=19.50=>转为整数 {d} 进位  【特殊】：小数部分等于0.5的时候，看整数部分：奇进、偶不进");
            Console.WriteLine("--------------------------------------------------");

 
            //时间转换
            DateTime dateTime = Convert.ToDateTime("2025-01-11");
            Console.WriteLine(" 【时间转换】" + dateTime);
            Console.WriteLine("--------------------------------------------------");

            double f = Convert.ToDouble(20);
            Console.WriteLine($"【值类型（int）-->值类型（double）】f=20=>{f} 正常");
            Console.WriteLine("--------------------------------------------------");
        }

        #endregion

        #region 强制转换中的特殊问题

        static void Method11()
        {
            //以下方法不行！
            //int a = int.Parse("35.8");
            //int b = Convert.ToInt32("35.8");

            Console.WriteLine("强制类型转换中特殊问题的解决：");
            //通过中间转换
            int a = (int)double.Parse("35.8");
            int b = (int)Convert.ToDouble("35.8");
            Console.WriteLine($"a=>35.8=>{a} b=>35.8=>{b}");
        }

        #endregion

    }

    //定义性别枚举
    public enum Gender
    {
        Male = 1,
        Female = 0
    }

}
