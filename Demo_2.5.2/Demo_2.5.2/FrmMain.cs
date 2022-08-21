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
        }

        // 事件的响应方法
        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
