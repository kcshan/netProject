﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    class Student
    {
        public Student() { }
        public Student(int stuId, string stuName)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
