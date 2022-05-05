using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
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
            get { return isOpen; }
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

        /// <summary>
        /// 发送字节字数
        /// </summary>

        private int totalSendNum = 0;

        public int TotalSendNum
        {
            get { return totalSendNum; }
            set
            {
                totalSendNum = value;
                this.tssl_SendCount.Text = value.ToString();
            }
        }

        /// <summary>
        /// 接收字节字数
        /// </summary>

        private int totalRcvNum = 0;

        public int TotalRcvNum
        {
            get { return totalRcvNum; }
            set
            {
                totalRcvNum = value;
                this.tssl_ReceiveCount.Text = value.ToString();
            }
        }

        // 串口对象
        private SerialPort serialPort = null;

        //private Encoding encoding = Encoding.UTF8;
        private Encoding encoding = Encoding.Default;

        // 定时器
        private System.Timers.Timer AutoSendTimer = new System.Timers.Timer();

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

                    this.serialPort.Encoding = this.encoding;

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
            Invoke(new Action(() =>
            {
                // 定义最终的字符串
                string Result = string.Empty;
                if (this.chk_HexShow.Checked)
                {
                    // 定义一个字节数组
                    try
                    {
                        byte[] data = new byte[serialPort.BytesToRead];


                        // 读取缓冲区值到字节数组
                        this.serialPort.Read(data, 0, data.Length);
                        foreach (byte item in data)
                        {
                            string hex = Convert.ToString(item, 16).ToUpper();
                            Result += (hex.Length == 1 ? "0" + hex : hex) + " ";
                        }
                        // 显示
                        this.rtb_Receive.AppendText(Result + Environment.NewLine);

                        // 更新接收字节总数
                        TotalRcvNum += data.Length;
                    }
                    catch (Exception ex)
                    {
                        this.tssl_Status.Text = "接收出现错误：" + ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        Result = this.serialPort.ReadExisting();
                        // 显示
                        this.rtb_Receive.AppendText(Result + Environment.NewLine);

                        // 更新接收字节总数
                        TotalRcvNum += this.serialPort.Encoding.GetByteCount(Result);
                    }
                    catch (Exception ex)
                    {
                        this.tssl_Status.Text = "接收出现错误：" + ex.Message;
                    }

                }
            }));

            
        }

        #region 手动发送

        private void btn_HandSend_Click(object sender, EventArgs e)
        {
            SendData();
        }
        #endregion

        #region 定时发送
        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_AutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (IsOpen == false && this.chk_AutoSend.CheckState == CheckState.Checked)
            {
                this.chk_AutoSend.CheckState = CheckState.Unchecked;

                // 停止定时器
                this.AutoSendTimer.Enabled = false;
                this.tssl_Status.Text = "自动发送失败，串口未打开";
                return;
            }
            if (IsOpen == true && this.chk_AutoSend.CheckState == CheckState.Checked)
            {
                // 禁用手动发送
                this.btn_HandSend.Enabled = false;
                // 获取时间周期
                int interval = 0;
                if (int.TryParse(this.txt_Period.Text.Trim(), out interval))
                {
                    if (interval < 1 || interval > 60000)
                    {
                        interval = 1000;
                        txt_Period.Text = "1000";
                        this.tssl_Status.Text = "周期设定过大，限制为1000ms";
                    }
                    // 开始自动发送
                    this.AutoSendTimer.Interval = interval;
                    this.AutoSendTimer.Elapsed += AutoSendTimer_Elapsed;
                    this.AutoSendTimer.Enabled = true;
                    // 禁用周期设置
                    this.txt_Period.Enabled = false;
                }
                else
                {
                    this.chk_AutoSend.CheckState = CheckState.Unchecked;

                    // 停止定时器
                    this.AutoSendTimer.Enabled = false;
                    this.tssl_Status.Text = "自动发送失败，周期设定格式不正确";
                    return;
                }
            }
            else
            {
                this.btn_HandSend.Enabled = true;
                this.txt_Period.Enabled = true;
                this.AutoSendTimer.Enabled = false;
            }
        }

        private void AutoSendTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                SendData();
            }));
        }
        #endregion

        #region 发送数据

        /// <summary>
        /// 发送数据
        /// </summary>
        private void SendData()
        {
            if (this.chk_HexSend.Checked)
            {
                // 去掉空格 01 04 50
                string temp = this.rtb_Send.Text.Replace(" ", "");
                try
                {
                    byte[] b = HexHelper.HexStringToBytes(temp);
                    serialPort.Write(b, 0, b.Length);
                    TotalSendNum += b.Length;
                }
                catch (Exception ex)
                {
                    this.tssl_Status.Text = "发送失败：" + ex.Message;
                    isOpen = false;
                }
            }
            else
            {
                try
                {
                    byte[] b = encoding.GetBytes(this.rtb_Send.Text);

                    serialPort.Write(b, 0, b.Length);

                    TotalSendNum += b.Length;
                }
                catch (Exception ex)
                {
                    this.tssl_Status.Text = "发送失败：" + ex.Message;
                    isOpen = false;
                }

            }
        }

        #endregion

        #region 清空发送区

        /// <summary>
        /// 清空发送区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendClear_Click(object sender, EventArgs e)
        {
            this.rtb_Send.Clear();
        }


        #endregion

        #region 选择文件
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            // 创建OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();

            // 设置OpenFileDialog属性
            dialog.Title = "请选择要发送的文件";
            dialog.Filter = "文本文件(*.txt)|*.txt|二进制文件(*.bin)|*.bin|HEX文件(*.hex)|*.hex";
            dialog.RestoreDirectory = true;

            // 打开OpenFileDialog
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 把十六进制的选择取消
                this.chk_HexSend.Checked = false;

                // 获取文件的名称并显示
                string fileName = dialog.FileName;
                this.txt_SendPath.Text = fileName;

                // 读取内容显示
                StreamReader sr = new StreamReader(fileName, encoding);

                this.rtb_Send.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        #endregion

        #region 发送文件
        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                if (this.txt_SendPath.Text.Length == 0)
                {
                    this.tssl_Status.Text = "请先选择要发送的文件";
                    return;
                }


                byte[] byteMessage = encoding.GetBytes(this.rtb_Send.Text);
                int sendCount = byteMessage.Length / 4096;
                int sendRemaind = byteMessage.Length % 4086;
                try
                {
                    // 循环发送
                    for (int i = 0; i < sendCount; i++)
                    {
                        this.serialPort.Write(byteMessage, 4096 * i, 4096);
                        Thread.Sleep(50);
                    }
                    // 最后一次发送
                    if (sendRemaind > 0)
                    {
                        this.serialPort.Write(byteMessage, 4096 * sendCount, sendRemaind);
                    }
                }
                catch (Exception ex)
                {

                    this.tssl_Status.Text = "发送文件失败：" + ex.Message;
                    return;
                }

                // 更新发送计数
                TotalSendNum += byteMessage.Length;
            }
            else
            {
                this.tssl_Status.Text = "发送文件失败：串口未连接";
            }
        }

        #endregion
    }
}
