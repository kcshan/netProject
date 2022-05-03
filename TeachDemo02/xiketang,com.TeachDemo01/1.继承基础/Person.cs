using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01
{
    class Person
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

        public void Dowork()
        {
            Console.WriteLine("我们每天都工作！");
        }

        public void Rest()
        {
            Console.WriteLine("下班了，我们都要及时休息！");
        }
    }
}
