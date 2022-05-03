using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01e
{
    class Teacher:Person
    {
        public Teacher() { }

        public Teacher(string idNo, string name)
        {
            base.IDNo = idNo;
            base.Name = name;
        }
       
        // 重写的父类方法
        public override void Dowork()
        {
            Console.WriteLine("我是做.NET教学工作的！"); ;
        }

        public override void Rest()
        {
            Console.WriteLine("下班了，晚饭后给学员继续答疑，然后睡觉！");
        }
        // 子类特有的方法
        public void Chat()
        {
            Console.WriteLine("聊天");
        }
    }
}
