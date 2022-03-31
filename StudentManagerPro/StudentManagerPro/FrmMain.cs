using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // 修改密码
        private void tsmi_PwdModify_Click(object sender, EventArgs e)
        {

        }

        #region 关闭前面窗体嵌入新窗体
        private void ClosePreForm()
        {
            // 首先判断当前容器中是否已经存在窗体
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }

        private void OpenForm(Form objFrm)
        {
            objFrm.TopLevel = false; // 将子窗体设置成非顶级控件
            objFrm.WindowState = FormWindowState.Maximized; // 让子窗体最大化显示
            objFrm.FormBorderStyle = FormBorderStyle.None; // 去掉窗体的边框
            objFrm.Parent = this.spContainer.Panel2; // 指定子窗体显示的容器
            objFrm.Show();
        }
        #endregion

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClosePreForm(); // 关闭已经存在的窗体
            OpenForm(new FrmAddStudent());
            // FrmAddStudent objFrm = new FrmAddStudent();
        }

        private void btnStuManage_Click(object sender, EventArgs e)
        {
            ClosePreForm(); // 关闭已经存在的窗体
            OpenForm(new FrmStudentManage());
        }
    }
}
