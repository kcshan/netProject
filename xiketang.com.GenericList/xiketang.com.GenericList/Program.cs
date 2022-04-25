using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGenericList test = new TestGenericList();
            List<Course> courseList = test.CreateCourses();
            //test.TraversalList1(courseList);
            //Console.WriteLine("*****************");
            //test.TraversalList2(courseList);
            //Console.WriteLine("*****************");
            //test.QueryElements(courseList);
            //Console.WriteLine("*****************");
            test.ListOrder();

            Console.ReadLine();
        }
    }
}
