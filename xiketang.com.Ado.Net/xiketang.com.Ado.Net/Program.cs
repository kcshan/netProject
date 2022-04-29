using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 引入需要的命名空间
using System.Data.SqlClient;
using System.Data;

namespace xiketang.com.Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConnectDB();
            //ExecuteInsert();
            //ExecuteUpdate();
            //ExecuteDelete();
            //ExecuteSingleResult();
            //ExecuteReader();
            //ExecuteInsertByHelper();
            //ExecuteSingleResultByHelper();
            ExecuteReaderByHelper();
            Console.Read();
        }

        #region 建立连接
        static void ConnectDB()
        {
            // 创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 打开连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 关闭连接
            conn.Close();
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("关闭成功！");
            }

        }
        #endregion

        #region 插入数据
        static void ExecuteInsert()
        {
            // 【1】创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 定义sql语句
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += "values('运动控制开发VIP课程', '雷赛固高Zmotion运动控制卡', 200, 10, 11, 1000)";

            // 【2】创建Command对象
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = sql;
            //cmd.Connection = conn;

            SqlCommand cmd = new SqlCommand(sql, conn);

            // 【3】打开数据库连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine($"受影响的行数{result}");

            // 【5】关闭连接
            conn.Close();
        }
        #endregion

        #region 修改数据
        static void ExecuteUpdate()
        {
            // 【1】创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 定义sql语句
            string sql = "update Course set CourseName='.Net/C#上位机开发VIP课程',CourseContent='C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',";
            sql += "ClassHour=20,CategoryId=10,TeacherId=1001";
            sql += "where CourseId=1042";

            // 【2】创建Command对象
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 【3】打开数据库连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine($"受影响的行数{result}");

            // 【5】关闭连接
            conn.Close();
        }
        #endregion

        #region 删除数据
        static void ExecuteDelete()
        {
            // 【1】创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 定义sql语句
            string sql = "delete from Course where CourseId=1042";

            // 【2】创建Command对象
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 【3】打开数据库连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine($"受影响的行数{result}");

            // 【5】关闭连接
            conn.Close();
        }
        #endregion

        #region 执行单一结果的查询
        static void ExecuteSingleResult()
        {
            // 【1】创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 定义sql语句
            string sql = "select Count(*) as 课程总数 from Course";

            // 【2】创建Command对象
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 【3】打开数据库连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 【4】执行查询(下面这个方法，一般执行的都是查询，但是有时候也可以同时执行只能用于执行insert、update、delete操作，后面会讲到)
            object result = cmd.ExecuteScalar();

            Console.WriteLine($"查询结果={result}");

            // 【5】关闭连接
            conn.Close();
        }
        #endregion

        #region 返回一个结果集
        static void ExecuteReader()
        {
            // 【1】创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            // 定义sql语句
            string sql = "select CourseName,CourseContent,ClassHour from Course where CourseId<1020";

            // 【2】创建Command对象
            SqlCommand cmd = new SqlCommand(sql, conn);

            // 【3】打开数据库连接
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("连接成功！");
            }

            // 【4】执行查询
            SqlDataReader reader = cmd.ExecuteReader();

            // 判断是否有查询结果，来决定读取数据
            while (reader.Read())
            {
                Console.WriteLine($"{reader["CourseName"]}\t{reader[1]}\t{reader["ClassHour"]}");
            }
            reader.Close(); // 关闭读取器对象

            // 【5】关闭连接
            conn.Close();
        }
        #endregion

        #region 增删改
        static void ExecuteInsertByHelper()
        {
            // 定义sql语句
            string sql = "insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)";
            sql += "values('运动控制开发VIP课程', '雷赛固高Zmotion运动控制卡', 200, 10, 11, 1000)";
            int result = SQLHelper.Update(sql);
            Console.WriteLine(result);
        }
        #endregion

        #region 单一查询
        static void ExecuteSingleResultByHelper()
        {
            string sql = "select Count(*) as 课程总数 from Course";
            object result = SQLHelper.GetSingleResult(sql);
            Console.WriteLine(result);
        }
        #endregion

        static void ExecuteReaderByHelper()
        {
            // 定义sql语句
            string sql = "select CourseName,CourseContent,ClassHour from Course where CourseId<1020";
            SqlDataReader reader = SQLHelper.GetReader(sql);

            while (reader.Read())
            {
                Console.WriteLine($"{reader["CourseName"]}\t{reader[1]}\t{reader["ClassHour"]}");
            }
            reader.Close(); // 关闭读取器对象
        }

    }
}
