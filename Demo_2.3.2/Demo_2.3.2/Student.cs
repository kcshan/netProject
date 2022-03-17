using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._3._2
{
    class Student
    {
        public Student()
        {
            this.StudentId = 10001;
            this.StudentName = "张晓宇";
        }
        public Student(int stuId, string stuName)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
        }
        public Student(int stuId, string stuName, DateTime birthday) : this(stuId, stuName)
        {
            this.Birthday = birthday;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}
