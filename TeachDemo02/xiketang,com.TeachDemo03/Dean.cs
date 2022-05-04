using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.TeachDemo03
{
    public class Dean : IMeeting
    {
        public void Speech()
        {
            Console.WriteLine("主任Speech...");
        }

        public string Talk(string topic)
        {
            return $"主任正在讨论{topic}...";
        }
    }
}
