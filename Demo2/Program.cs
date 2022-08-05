using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建对象
            Student objStudent = new Student();

            // 给对象属性赋值
            objStudent.StudentId = 10001;
            objStudent.StudentName = "王丽丽";

            String info = objStudent.GetStudent();
            Console.WriteLine(info);

            objStudent.Birthday = Convert.ToDateTime("1990-12-12");
            Console.WriteLine(objStudent.Age);

            Console.ReadLine();
        }
    }
}
