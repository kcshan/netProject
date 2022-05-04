using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.TeachDemo03
{
    public interface ITeach
    {
        /// <summary>
        /// 教学研究
        /// </summary>
        void StudyCourse();

        /// <summary>
        /// 组织考试
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        bool Exam(string term);
    }
}
