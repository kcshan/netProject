using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace xiketang.com.Ado.Net
{
    /// <summary>
    /// 课程数据访问类
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 添加课程：使用多个参数，非常麻烦
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="courseContent"></param>
        /// <param name="classHour"></param>
        /// <param name="credit"></param>
        /// <param name="categoryId"></param>
        /// <param name="teacherId"></param>
        /// <returns></returns>
        public int AddCourse(string courseName,string courseContent,int classHour,int credit,int categoryId,int teacherId)
        {
            // 定义sql语句
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += $"values('{courseName}', '{courseContent}', {classHour}, {credit}, {categoryId}, {teacherId})";

            // 执行SQL语句
            return SQLHelper.Update(sql);
        }
        /// <summary>
        /// 添加课程（通过实体类作为参数）
        /// </summary>
        /// <param name="course">课程对象</param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            // 定义sql语句，并解析实体数据
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += $"values('{course.CourseName}', '{course.CourseContent}', {course.ClassHour}, {course.Credit}, {course.CategoryId}, {course.TeacherId})";

            // 执行SQL语句
            return SQLHelper.Update(sql);
        }
        public int UpdateCourse(Course course)
        {
            // 定义sql语句，并解析实体数据
            string sql = $"update Course set CourseName='{course.CourseName}',CourseContent='{course.CourseContent}'";
            sql += $"where CourseId={course.CourseId}";

            // 执行SQL语句
            return SQLHelper.Update(sql);
        }
        public int DeleteCourse(int courseId)
        {
            string sql = "delete from Course where CourseId=" + courseId;
            return SQLHelper.Update(sql);
        }
        /// <summary>
        /// 删除的时候，我建议大家使用对象，因为后面我们深入学习的会讲ORM，ORM框架里面全部都是对象
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = "delete from Course where CourseId=" + course.CourseId;
            return SQLHelper.Update(sql);
        }
    }
}
