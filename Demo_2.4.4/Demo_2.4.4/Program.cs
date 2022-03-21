using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建几个学员对象
            Student objStu1 = new Student(1001, "小王", 17);
            Student objStu2 = new Student(1002, "小刘", 18);
            Student objStu3 = new Student(1003, "小张", 16);
            Student objStu4 = new Student(1004, "小李", 20);
            List<Student> list = new List<Student>()
            {
                objStu1, objStu2, objStu3, objStu4
            };
            // 默认排序
            Console.WriteLine("-----------默认排序-------------");
            list.Sort();
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId + "\t" + item.Age);
            }
            Console.WriteLine("-----------按照姓名升序排序-------------");
            list.Sort(new StuNameASC());
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId + "\t" + item.Age);
            }
            Console.WriteLine("-----------按照姓名降序排序-------------");
            list.Sort(new StuNameDESC());
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId + "\t" + item.Age);
            }

            Console.WriteLine("-----------按照年龄降序排序-------------");
            list.Sort(new AgeASC());
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId + "\t" + item.Age);
            }
            Console.WriteLine("-----------按照年龄降序排序-------------");
            list.Sort(new AgeDESC());
            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId + "\t" + item.Age);
            }

            Console.ReadLine();
        }
    }
}
