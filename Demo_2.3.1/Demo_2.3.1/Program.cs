using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Student objStudent1 = new Student(1002, "刘超");
            Student objStudent2 = new Student(1001, "黎明", 18);

            Console.WriteLine("姓名={0} 学号={1}", objStudent.StudentName, objStudent.StudentId);
            Console.WriteLine("姓名={0} 学号={1}", objStudent1.StudentName, objStudent1.StudentId);
            Console.WriteLine("姓名={0} 学号={1} 年龄={2}", objStudent2.StudentName, objStudent2.StudentId, objStudent2.Age);

            Console.ReadLine();
        }
    }
}
