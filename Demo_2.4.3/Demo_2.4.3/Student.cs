using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._4._3
{
    class Student:IComparable<Student>
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


        //int IComparable<Student>.CompareTo(Student other)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 接口的实现方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            //throw new NotImplementedException();
            // 降序
            //return other.StudentId.CompareTo(this.StudentId);
            // 升序
            return this.StudentId.CompareTo(other.StudentId);
        }
    }
}
