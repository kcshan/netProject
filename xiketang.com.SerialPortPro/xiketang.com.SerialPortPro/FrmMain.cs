using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiketang.com.SerialPortPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            InitialSetting();
        }

        #region 系统变量

        // 串口状态
        private bool isOpen = false;
        public bool IsOpen
        {
            get { return isOpen;}
            set
            {
                isOpen = value;
                if (value)
                {
                    this.btn_Open.Text = "关闭串口";
                    this.btn_Open.Image = Properties.Resources.poweron;
                }
                else
                {
                    this.btn_Open.Text = "打开串口";
                    this.btn_Open.Image = Properties.Resources.poweroff;
                }

            }
        }

        // 串口对象
        private SerialPort serialPort = null;

        #endregion

        #region 初始化配置信息
        private void InitialSetting()
        {
            // 通信端口
            // 获取串行端口的数组
            string[] PortList = SerialPort.GetPortNames();
            if (PortList.Length > 0)
            {
                this.cmb_Port.DataSource = PortList;
                this.cmb_Port.SelectedIndex = 0;
            }

            // 波特率
            string[] BaudList = new string[] { "2400", "4800", "9600", "19200", "38400" };
            this.cmb_Baud.DataSource = BaudList;
            this.cmb_Baud.SelectedIndex = 2;

            // 检验位
            this.cmb_Parity.DataSource = Enum.GetNames(typeof(Parity));
            this.cmb_Parity.SelectedIndex = 0;

            // 停止位
            this.cmb_StopBits.DataSource = Enum.GetNames(typeof(StopBits));
            this.cmb_StopBits.SelectedIndex = 1;

            // 数据位
            int[] DataList = new int[] { 5, 6, 7, 8 };
            this.cmb_DataBits.DataSource = DataList;
            this.cmb_DataBits.SelectedIndex = 3;


        }

        #endregion

        #region 串口打开

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                // 串口关闭
                if (this.serialPort != null)
                {
                    if (this.serialPort.IsOpen)
                    {
                        this.serialPort.Close();
                    }
                    IsOpen = false;
                    this.tssl_Status.Text = this.cmb_Port.Text.Trim() + " 串口关闭成功";
                }
            }
            else
            {
                // 串口打开
                // 实例化对象
                this.serialPort = new SerialPort();

                try
                {
                    // 设置串口属性
                    this.serialPort.PortName = this.cmb_Port.Text.Trim();
                    this.serialPort.BaudRate = Convert.ToInt32(this.cmb_Baud.Text.Trim());
                    this.serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.cmb_Parity.Text.Trim(), true);
                    this.serialPort.DataBits = Convert.ToInt32(this.cmb_DataBits.Text.Trim());
                    this.serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cmb_StopBits.Text.Trim(), true);

                    this.serialPort.RtsEnable = this.chk_Rts.Checked;
                    this.serialPort.DtrEnable = this.chk_Dtr.Checked;

                    // 触发接收的字节的大小
                    this.serialPort.ReceivedBytesThreshold = 1;

                    this.serialPort.DataReceived += SerialPort_DataReceived;

                    if (this.serialPort.IsOpen)
                    {
                        this.serialPort.Close();
                    }
                    this.serialPort.Open();
                    IsOpen = true;
                    this.tssl_Status.Text = this.cmb_Port.Text.Trim() + " 串口打开成功";
                }
                catch (Exception ex)
                {

                    this.tssl_Status.Text = this.cmb_Port.Text.Trim() + "串口打开失败：" + ex.Message;
                }
                
            }
        }
        #endregion

        /// <summary>
        /// 串口接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
