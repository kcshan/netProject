using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoJSQ
{
    class Student
    {
        public Student()
        {
            this.StudentId = 1003;
            this.StudentName = "刘能";
        }
        public Student(int stuId, string stuName)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
        }
        public Student(int stuId, string stuName, int age)
            :this(stuId, stuName)
        {
            //this.StudentId = stuId;
            //this.StudentName = stuName;
            this.Age = age;
        }
        public Student(int stuId, string stuName, DateTime birthday)
            : this(stuId, stuName)
        {
            //this.StudentId = stuId;
            //this.StudentName = stuName;
            this.Birthday = birthday;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}
