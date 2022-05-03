using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01
{
    class Student:Person
    {
        public Student() { }

        public Student(string idNo, string name)
        {
            base.IDNo = idNo;
            base.Name = name;
        }
    }
}
