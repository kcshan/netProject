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

        // 删除文件
        private void btnDel_Click(object sender, EventArgs e)
        {
            File.Delete(this.txtFrom.Text);
        }

        // 复制文件
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtTo.Text.Trim()))
            {
                File.Delete(this.txtTo.Text);
            }
            File.Copy(this.txtFrom.Text.Trim(), this.txtTo.Text.Trim());
        }

        // 移动文件
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 首先判断目标路径文件是否存在（如果文件存在，直接复制会出现错误）
            if (File.Exists(this.txtTo.Text.Trim()))
            {
                // 删除文件
                File.Delete(this.txtTo.Text.Trim()); 
            }
            // 如果当前文件存在则移动
            if (File.Exists(this.txtFrom.Text.Trim()))
            {
                // 移动文件
                File.Move(this.txtFrom.Text.Trim(), this.txtTo.Text.Trim());
            }
            else
            {
                MessageBox.Show("文件不存在！");
            }
        }
    }
}
