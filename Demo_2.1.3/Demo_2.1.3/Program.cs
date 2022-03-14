using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建对象
            Student objstudent = new Student();

            // 给对象属性赋值
            objstudent.StudentId = 10001;
            objstudent.StudentName = "王丽丽";

            // 调用对象方法
            string info = objstudent.GetStudent();
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
