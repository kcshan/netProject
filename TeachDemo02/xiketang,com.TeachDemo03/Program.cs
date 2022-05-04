using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.TeachDemo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            Test2();
            Console.Read();
        }

        /// <summary>
        /// 接口多态：接口作为方法参数类型，实际上传递的是接口实现类对象（多个不同...）
        /// 面向对象的基本原则之一：面向抽象编程
        /// 
        /// 适合：根据不同的对象，实现不同的业务，但是业务流程相同
        /// 用户不关心，你让这个对象做什么。这个是方法需要对象
        /// </summary>
        /// <param name="meeting"></param>
        public static void StartSpeechAndTalk1(IMeeting meeting)
        {
            meeting.Speech();
            string content = meeting.Talk("《学习完毕后的就业问题》");
            Console.WriteLine(content);
        }

        /// <summary>
        /// 接口多态2：接口作为方法返回值类型，实际上返回的是具体的子类对象
        /// 
        /// 适合：就想得到不同的对象。用户不关心得到的什么对象。用户需要对象
        /// </summary>
        /// <returns></returns>
        public static IMeeting StartSpeechAndTalk2()
        {
            // 这个地方，我们可以通过反射，实现代码的无修改，而返回不同的对象
            //return new Teacher() { Name = "常老师" };
            return new President() { Name = "王校长" };
        }

        /// <summary>
        /// 接口多态的测试
        /// </summary>
        public static void Test1()
        {
            // 调用者需要对象
            StartSpeechAndTalk1(new Teacher { Name = "付老师" });
            Console.WriteLine("-------------------------");
            StartSpeechAndTalk1(new President { Name = "王校长" });
            Console.WriteLine("-------------------------");

            // 用户需要对象
            IMeeting meeting2 = StartSpeechAndTalk2();
            meeting2.Speech();
            string content = meeting2.Talk("《全栈和上位机课程》");
            Console.WriteLine(content);

            // 如果不用接口，你就会发现用户需求变化的时候，代码要不断的修改
            //Teacher tea = new Teacher();
            //President p = new President();

            // 使用接口的完成扩展的时候，如果实现类的特有的行为，是不能被使用的。
            List<string> list = new List<string>(); // 开发中，我们这样使用
            IList<string> list1 = new List<string>(); // 这个不建议使用
        }

        public static void Test2()
        {
            IMeeting meeting2 = ObjectFactory.StartSpeechAndTalk2();
            meeting2.Speech();
            string content = meeting2.Talk("《全栈和上位机VIP课程平时学习问题》");
            Console.WriteLine(content);
        }
    }
}
