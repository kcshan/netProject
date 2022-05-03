using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01e
{
    class Test2
    {
        public void MyTest()
        {
            Teacher teacherChang = new Teacher();
            teacherChang.Name = "常老师";
            teacherChang.Dowork();
            teacherChang.Rest();

            // 下面这个是子类特有的方法
            teacherChang.Chat();

            Student studentYi = new Student();
            studentYi.Name = "易同学";
            studentYi.Dowork();
            studentYi.Rest();
        }

        public void OtherTest()
        {
            //Teacher teacherChang = new Teacher();
            //Student studentYi = new Student();
            //CoreTest(teacherChang);
            //CoreTest(studentYi);

            // 下面的写法和上面的是一样的
            CoreTest(new Teacher());
            CoreTest(new Student());

            Person p = GetPerson("teacher");
        }

        /// <summary>
        /// 多态实现1：父类作为方法的参数，实际传递的是具体子类
        /// 
        /// 好处：我们在写这个方法的时候，根本不考虑方法参数传递什么样的子类
        /// </summary>
        /// <param name="person"></param>
        public void CoreTest(Person person)
        {
            person.Dowork();
            person.Rest();
            person.GetInfo();
        }

        /// <summary>
        /// 多态实现2：父类作为方法的返回值类型，实际返回的是具体子类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        //public Person GetPerson(string type)
        //{
        //    if (type == "teacher")
        //    {
        //        return new Teacher();
        //    }
        //    else
        //    {
        //        return new Student();
        //    }
        //    // 通过反射可以将这部分封闭
        //}

        public Person GetPerson(string type)
        {
            return new Teacher(); // 通过反射可以将这部分封闭，返回不同的子类
        }
    }
}
