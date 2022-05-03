using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01e
{
    class Student:Person
    {
        public Student() { }

        public Student(string idNo, string name)
        {
            base.IDNo = idNo;
            base.Name = name;
        }

        // 重写父类的抽象方法
        public override void Dowork()
        {
            Console.WriteLine("我们是做电气工程师和.NET软件开发的");
        }

        public override void Rest()
        {
            Console.WriteLine("我们都是下班后，很晚才休息！");
        }

        /// <summary>
        /// 重写虚方法
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            // 子类中可以继续调用父类的虚方法或其他可用的方法
            return base.GetInfo() + " 姓别： " + base.Gender;
        }
    }
}
