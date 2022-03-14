using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建对象
            Student objStudent = new Student();

            // 给对象属性赋值
            objStudent.StudentId = 10001;
            objStudent.StudentName = "王丽丽";
            objStudent.Birthday = Convert.ToDateTime("1990-5-1");

            // 调用对象方法
            string info = objStudent.GetStudent();
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}
