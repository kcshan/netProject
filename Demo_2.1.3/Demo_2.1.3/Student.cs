﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2._1._3
{
    /// <summary>
    /// 学员类
    /// </summary>
    class Student
    {
        // 字段
        private int studentId;
        // 字段: 学员姓名
        private string studentName = string.Empty;
        // 属性：学号
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        // 属性：学生姓名
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        // 方法：获取学员信息
        public string GetStudent()
        {
            string info = string.Format("姓名: {0} 学号: {1}", studentName, studentId);
            return info;
        }

    }
}
