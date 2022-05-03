using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01e
{
    public abstract class Person
    {
        public Person() { }

        public Person(string idNo, string name)
        {
            this.IDNo = idNo;
            this.Name = name;
        }

        public string IDNo { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        // 这俩个是抽象方法，抽象方法就是没有实现的方法

        public abstract void Dowork();

        public abstract void Rest();

        // 虚方法
        public virtual string GetInfo()
        {
            return $"编号：{IDNo} 姓名：{Name}";
        }
    }
}
