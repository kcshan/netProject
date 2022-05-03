using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachDemo01
{
    class Test1
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
    }
}
