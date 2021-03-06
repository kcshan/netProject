using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//引入命名空间
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TextFileObj
{
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 封装数据
            Student objStudent = new Student()
            {
                Name = this.txtName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),
                Birthday = Convert.ToDateTime(this.txtBirthday.Text.Trim())
            };
            // 保存到文件里面
            FileStream fs = new FileStream("objStudent.obj", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            // 一行一行写入
            sw.WriteLine(objStudent.Name);
            sw.WriteLine(objStudent.Age);
            sw.WriteLine(objStudent.Gender);
            sw.WriteLine(objStudent.Birthday);
            // 关闭对象
            sw.Close();
            fs.Close();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("objStudent.obj", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            // 一行一行读取
            Student objStudent = new Student()
            {
                Name = sr.ReadLine(),
                Age = Convert.ToInt32(sr.ReadLine()),
                Gender = sr.ReadLine(),
                Birthday = Convert.ToDateTime(sr.ReadLine())
            };
            sr.Close();
            fs.Close();
            // 显示数据
            this.txtName.Text = objStudent.Name;
            this.txtAge.Text = objStudent.Age.ToString();
            this.txtGender.Text = objStudent.Gender;
            this.txtBirthday.Text = objStudent.Birthday.ToShortDateString();
        }

        // 序列化对象
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            // 封装数据
            Student objStudent = new Student()
            {
                Name = this.txtName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),
                Birthday = Convert.ToDateTime(this.txtBirthday.Text.Trim())
            };
            // 【1】创建文件流
            FileStream fs = new FileStream("objStudent.stu", FileMode.Create);
            // 【2】创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            // 【3】调用序列化方法
            formatter.Serialize(fs, objStudent);
            // 【4】关闭文件流
            fs.Close();

        }

        // 反序列化对象
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            // 【1】创建文件流
            FileStream fs = new FileStream("objStudent.stu", FileMode.Open);
            // 【2】创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            // 【3】调用反序列方法
            Student objStudent = (Student)formatter.Deserialize(fs);
            // 【4】关闭文件流
            fs.Close();

            // 显示数据
            this.txtName.Text = objStudent.Name;
            this.txtAge.Text = objStudent.Age.ToString();
            this.txtGender.Text = objStudent.Gender;
            this.txtBirthday.Text = objStudent.Birthday.ToShortDateString();
        }
    }
}
