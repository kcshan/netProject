using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Configuration;

namespace xiketang.com.TeachDemo03
{
    /// <summary>
    /// 对象工厂
    /// </summary>
    public class ObjectFactory
    {
        private static string className = ConfigurationManager.AppSettings["className"];
        private static string assName = ConfigurationManager.AppSettings["assName"];

        public static IMeeting StartSpeechAndTalk2()
        {
            //return (IMeeting)Assembly.Load("xiketang.com.TeachDemo03").CreateInstance("xiketang.com.TeachDemo03.Teacher");
            //return new President { Name = "王校长" };

            return (IMeeting)Assembly.Load(assName).CreateInstance(className);
        }
    }
}
