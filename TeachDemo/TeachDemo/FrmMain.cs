using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OpenNewForm(Form newFrm)
        {
            // 【1】关闭嵌入的其他窗体
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            
            // 将子窗体设置成为非顶级控件
            newFrm.TopLevel = false;
            // 去掉子窗体的边框
            //newFrm.FormBorderStyle = FormBorderStyle.None;
            // 指定子窗体要嵌入的容器
            newFrm.Parent = this.splitContainer1.Panel2;
            // 子窗体会随着容器大小而变化
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            OpenNewForm(new FrmAddProduct());
        }
    }
}
