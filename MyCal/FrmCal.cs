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
using MyCalModel;
namespace MyCal
{
    public partial class FrmCal : Form
    {
        public FrmCal()
        {
            InitializeComponent();
        }

        private Calculator myCal = new Calculator();

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.txtNum1.Text.Trim());
            int num2 = Convert.ToInt32(this.txtNum2.Text.Trim());

            this.txtResult.Text = myCal.Add(num1, num2).ToString();
        }
    }
}
