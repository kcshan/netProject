﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiketang.com.WinformBase
{
    public partial class FrmEventApp : Form
    {
        public FrmEventApp()
        {
            InitializeComponent();
            // 多个按钮响应同一个事件，在此做事件关联
            //this.btn01.Click += new System.EventHandler(this.btn_Click);
            //this.btn02.Click += new System.EventHandler(this.btn_Click);
            //this.btn03.Click += new System.EventHandler(this.btn_Click);
            //this.btn04.Click += new System.EventHandler(this.btn_Clicnew System.EventHandler(this.btn_Click);k);
            //this.btn05.Click += new System.EventHandler(this.btn_Click);
            //this.btn06.Click += new System.EventHandler(this.btn_Click);
            //this.btn07.Click += new System.EventHandler(this.btn_Click);
            //this.btn08.Click += new System.EventHandler(this.btn_Click);
            //this.btn09.Click += new System.EventHandler(this.btn_Click);
            //this.btn10.Click += new System.EventHandler(this.btn_Click);
            //this.btn11.Click += new System.EventHandler(this.btn_Click);
            //this.btn12.Click += new System.EventHandler(this.btn_Click);
            // 以上方法，如果你这么写程序，会被别人认为你什么都不懂！

            foreach (Control item in Controls)
            {
                if (item is Button) // 通过控件类型过滤我们不需要的控件
                {
                    Button btn = item as Button;
                    if (btn.Tag.ToString() != "Save") // 过滤我们不需要的按钮，请大家特别注意Tag的使用
                    {
                        btn.Click += new System.EventHandler(this.btn_Click);
                    }
                }
            }
        }

        // 事件集中处理方法
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Tag.ToString());
        }
    }
}
