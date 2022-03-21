using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._4._4
{
    class Student : IComparable<Student> // 默认排序，只能有一种
    {
        public Student() { }
        public Student(int stuId, string stuName, int age)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
            this.Age = age;
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

    #region 排序类
    // 添加4个排序类并且分别实现排序接口
    class StuNameASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }

    class StuNameDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }

    class AgeASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    class AgeDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Age.CompareTo(x.Age);
        }
    }
    #endregion
}
