﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建几个学员对象
            Student objStu1 = new Student(1001, "小王");
            Student objStu2 = new Student(1002, "小张");
            Student objStu3 = new Student(1003, "小强");
            Student objStu4 = new Student(1004, "小李");

            // 创建集合对象
            List<Student> stuList = new List<Student>();
            stuList.Add(objStu1);
            stuList.Add(objStu2);
            stuList.Add(objStu3);
            stuList.Add(objStu4);
            stuList.Add(new Student()
            {
                StudentId = 1006,
                StudentName = "小静"
            });

            // 获取元素的个数
            Console.WriteLine("元素总数：{0}", stuList.Count);

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

            Console.ReadLine();
        }
    }
}
