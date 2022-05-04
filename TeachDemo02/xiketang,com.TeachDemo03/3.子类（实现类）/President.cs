using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.TeachDemo03
{
    public class President : Person, IMeeting
    {
        public override void Dowork()
        {
            Console.WriteLine("校长开始工作...");
        }

        public override void Rest()
        {
            Console.WriteLine("校长下班休息...");
        }

        // 显示实现接口：通常是你实现了俩个或俩个以上的接口类，但是这些接口类中，有相同的方法
        public void Speech()
        {
            Console.WriteLine("校长Speech...");
        }

        public string Talk(string topic)
        {
           return $"校长{topic}...";
        }
    }
}
