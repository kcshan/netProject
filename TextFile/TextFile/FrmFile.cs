using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 引入命名空间
using System.IO;

namespace TextFile
{
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }

        // 写入文件
        private void btnWriteAll_Click(object sender, EventArgs e)
        {
            // 【1】创建文件流
            FileStream fs = new FileStream("E:\\test.txt", FileMode.Create);

            // 【2】创建写入器
            StreamWriter sw = new StreamWriter(fs);

            // 【3】以流的方式写入数据
            sw.Write(this.txtContent.Text.Trim());

            // 【4】关闭写入器
            sw.Close();

            // 【5】关闭文件流
            fs.Close();
        }

        // 读取文件
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            // 【1】创建文件流
            FileStream fs = new FileStream("E:\\test.txt", FileMode.Open);

            // 【2】创建读取器
            //StreamReader sr = new StreamReader(fs, Encoding.Default);
            StreamReader sr = new StreamReader(fs);

            // 【3】以流的方式读取数据
            this.txtContent.Text = sr.ReadToEnd();

            // 【4】关闭读取器
            sr.Close();

            // 【5】关闭文件流
            fs.Close();
        }

        // 模拟写入系统文件
        private void btnWriteLine_Click(object sender, EventArgs e)
        {
            // 【1】 创建文件流
            FileStream fs = new FileStream("E:\\test.txt", FileMode.Append);

            // 【2】创建写入器
            StreamWriter sw = new StreamWriter(fs);

            // 【3】以流的方式"逐行写入"数据
            sw.WriteLine(DateTime.Now.ToString() + " [文件操作正常!]");

            // 【4】关闭写入器
            sw.Close();

            // 【5】关闭文件流
            fs.Close();
        }
    }
}
