using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_2._5._2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // 将按钮的单击事件和事件响应方法结合
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);

            // 给三个按钮添加同一个事件响应方法
            this.btnAndy.Click += new System.EventHandler(this.btn_TeacherClick);
            this.btnCarry.Click += new System.EventHandler(this.btn_TeacherClick);
            this.btnCoco.Click += new System.EventHandler(this.btn_TeacherClick);
        }

        // 事件的响应方法
        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好！");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.btnTest.Click -= new System.EventHandler(this.btnTest_Click);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
        }

        // 事件响应的公共方法(sender: 表示的是"事件源"对象)
        private void btn_TeacherClick(object sender, EventArgs e)
        {
            string txt = ((Button)sender).Text;
            MessageBox.Show(txt + "您好！");
        }

        private void btnAndy_Click(object sender, EventArgs e)
        {

        }

        private void btnCarry_Click(object sender, EventArgs e)
        {

        }

        private void btnCoco_Click(object sender, EventArgs e)
        {

        }
    }
}
