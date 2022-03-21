using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>()
            { "小王", "小张", "小赵", "小李" };

            foreach (string item in nameList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----排序后----");
            nameList.Sort(); // 调用Sort()方法直接排序元素
            foreach (string item in nameList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("----排序后反转----");
            nameList.Reverse(); // 调用Reverse()方法反转元素
            foreach (string item in nameList)
            {
                Console.WriteLine(item);
            }

            List<int> ageList = new List<int>()
            {
               20, 25, 21, 22, 23, 26
            };
            ageList.Sort(); // 升序排列
            foreach (int item in ageList)
            {
                Console.WriteLine(item);
            }

            // 创建几个学员对象
            Student objStu1 = new Student(1001, "小王");
            Student objStu2 = new Student(1002, "小刘");
            Student objStu3 = new Student(1003, "小张");
            Student objStu4 = new Student(1004, "小李");
            List<Student> list = new List<Student>()
            {
                objStu1, objStu2, objStu3, objStu4
            };
            list.Sort();
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId);
            }

            Console.ReadLine();
        }
    }
}
