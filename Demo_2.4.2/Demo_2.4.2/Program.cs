using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建几个学员对象
            Student objStu1 = new Student(1001, "小王");
            Student objStu2 = new Student(1002, "小刘");
            Student objStu3 = new Student(1003, "小张");
            Student objStu4 = new Student(1004, "小李");

            // 创建Dictionary泛型集合
            Dictionary<string, Student> stus = new Dictionary<string, Student>();
            stus.Add("小王", objStu1);
            stus.Add("小刘", objStu2);
            stus.Add("小张", objStu3);
            stus.Add("小李", objStu4);

            Console.WriteLine(stus["小张"].StudentId);

            foreach (string key in stus.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("===========");


            foreach (Student value in stus.Values)
            {
                Console.WriteLine(value.StudentName + "\t" + value.StudentId);
            }

            Console.ReadLine();
        }
    }
}
