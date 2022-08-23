using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deme_2._4._1
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

            // 创建集合对象
            List<Student> stuList = new List<Student>();
            stuList.Add(objStu1);
            stuList.Add(objStu2);
            stuList.Add(objStu3);
            stuList.Add(objStu4);
            stuList.Add(new Student()
            {
                StudentId = 10006,
                StudentName = "小静"
            });

            Teacher objTeacher = new Teacher() { TeacherId = 1000, TeacherName = "Andy老师" };
            //stuList.Add(objTeacher);

            // 获取元素的个数
            Console.WriteLine("元素总数: {0}", stuList.Count);

            // 删除一个元素
            stuList.Remove(objStu3);
            stuList.RemoveAt(0);

            // 插入一个对象
            stuList.Insert(0, new Student(1005, "小白"));

            // 遍历集合
            foreach (Student item in stuList)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId);
            }
            Console.WriteLine("*****************************************");
            // 使用集合初始化器初始化泛型集合
            List<Student> list = new List<Student>() { objStu1, objStu2, objStu3, objStu4 };
            List<string> nameList = new List<string>() { "小王", "小张", "小赵", "小李"};


            foreach (Student item in list)
            {
                Console.WriteLine(item.StudentName + "\t" + item.StudentId);
            }
            Console.WriteLine("*****************************************");
            foreach (string item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
