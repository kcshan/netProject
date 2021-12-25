using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemeFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStu1 = new Student();
            string info = objStu1.GetStudentInfo("肖明", 1002, Convert.ToDateTime("1990-06-30"));
            Console.WriteLine(info);

            Student objStu2 = new Student();
            objStu2.StudentName = "黎明";
            objStu2.StudentId = 1003;
            objStu2.Birthday = Convert.ToDateTime("1992-06-21");
            objStu2.ShowStudentInfo();
            Console.ReadLine();
        }
    }
}
