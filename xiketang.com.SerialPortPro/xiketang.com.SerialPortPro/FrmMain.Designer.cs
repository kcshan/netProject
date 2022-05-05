namespace xiketang.com.SerialPortPro
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.chk_Dtr = new System.Windows.Forms.CheckBox();
            this.chk_Rts = new System.Windows.Forms.CheckBox();
            this.cmb_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.chk_HexShow = new System.Windows.Forms.CheckBox();
            this.btn_HandClear = new System.Windows.Forms.Button();
            this.chk_AutoClear = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_SendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_ReceiveCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SendPath = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendClear = new System.Windows.Forms.Button();
            this.chk_HexSend = new System.Windows.Forms.CheckBox();
            this.btn_HandSend = new System.Windows.Forms.Button();
            this.chk_AutoSend = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtb_Send = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Clear = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Open);
            this.groupBox1.Controls.Add(this.chk_Dtr);
            this.groupBox1.Controls.Add(this.chk_Rts);
            this.groupBox1.Controls.Add(this.cmb_StopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_DataBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_Parity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_Baud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btn_Open
            // 
            this.btn_Open.Image = global::xiketang.com.SerialPortPro.Properties.Resources.poweroff;
            this.btn_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Open.Location = new System.Drawing.Point(84, 211);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(104, 39);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.Text = "打开串口  ";
            this.btn_Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // chk_Dtr
            // 
            this.chk_Dtr.AutoSize = true;
            this.chk_Dtr.Location = new System.Drawing.Point(28, 235);
            this.chk_Dtr.Name = "chk_Dtr";
            this.chk_Dtr.Size = new System.Drawing.Size(42, 16);
            this.chk_Dtr.TabIndex = 3;
            this.chk_Dtr.Text = "DTR";
            this.chk_Dtr.UseVisualStyleBackColor = true;
            // 
            // chk_Rts
            // 
            this.chk_Rts.AutoSize = true;
            this.chk_Rts.Location = new System.Drawing.Point(28, 203);
            this.chk_Rts.Name = "chk_Rts";
            this.chk_Rts.Size = new System.Drawing.Size(42, 16);
            this.chk_Rts.TabIndex = 2;
            this.chk_Rts.Text = "RTS";
            this.chk_Rts.UseVisualStyleBackColor = true;
            // 
            // cmb_StopBits
            // 
            this.cmb_StopBits.FormattingEnabled = true;
            this.cmb_StopBits.Location = new System.Drawing.Point(85, 168);
            this.cmb_StopBits.Name = "cmb_StopBits";
            this.cmb_StopBits.Size = new System.Drawing.Size(104, 20);
            this.cmb_StopBits.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // cmb_DataBits
            // 
            this.cmb_DataBits.FormattingEnabled = true;
            this.cmb_DataBits.Location = new System.Drawing.Point(85, 136);
            this.cmb_DataBits.Name = "cmb_DataBits";
            this.cmb_DataBits.Size = new System.Drawing.Size(104, 20);
            this.cmb_DataBits.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据位";
            // 
            // cmb_Parity
            // 
            this.cmb_Parity.FormattingEnabled = true;
            this.cmb_Parity.Location = new System.Drawing.Point(85, 104);
            this.cmb_Parity.Name = "cmb_Parity";
            this.cmb_Parity.Size = new System.Drawing.Size(104, 20);
            this.cmb_Parity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "检验位";
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Location = new System.Drawing.Point(85, 72);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(104, 20);
            this.cmb_Baud.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // cmb_Port
            // 
            this.cmb_Port.FormattingEnabled = true;
            this.cmb_Port.Location = new System.Drawing.Point(85, 40);
            this.cmb_Port.Name = "cmb_Port";
            this.cmb_Port.Size = new System.Drawing.Size(104, 20);
            this.cmb_Port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SavePath);
            this.groupBox2.Controls.Add(this.btn_SelectPath);
            this.groupBox2.Controls.Add(this.btn_SaveFile);
            this.groupBox2.Controls.Add(this.btn_Pause);
            this.groupBox2.Controls.Add(this.chk_HexShow);
            this.groupBox2.Controls.Add(this.btn_HandClear);
            this.groupBox2.Controls.Add(this.chk_AutoClear);
            this.groupBox2.Location = new System.Drawing.Point(27, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 182);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(20, 143);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.Size = new System.Drawing.Size(176, 21);
            this.txt_SavePath.TabIndex = 7;
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Location = new System.Drawing.Point(20, 108);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(85, 29);
            this.btn_SelectPath.TabIndex = 6;
            this.btn_SelectPath.Text = "选择路径";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(111, 108);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(85, 29);
            this.btn_SaveFile.TabIndex = 6;
            this.btn_SaveFile.Text = "保存数据";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(111, 63);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(85, 29);
            this.btn_Pause.TabIndex = 6;
            this.btn_Pause.Text = "暂停接收";
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // chk_HexShow
            // 
            this.chk_HexShow.AutoSize = true;
            this.chk_HexShow.Location = new System.Drawing.Point(28, 70);
            this.chk_HexShow.Name = "chk_HexShow";
            this.chk_HexShow.Size = new System.Drawing.Size(72, 16);
            this.chk_HexShow.TabIndex = 5;
            this.chk_HexShow.Text = "十六进制";
            this.chk_HexShow.UseVisualStyleBackColor = true;
            // 
            // btn_HandClear
            // 
            this.btn_HandClear.Location = new System.Drawing.Point(112, 18);
            this.btn_HandClear.Name = "btn_HandClear";
            this.btn_HandClear.Size = new System.Drawing.Size(85, 29);
            this.btn_HandClear.TabIndex = 6;
            this.btn_HandClear.Text = "手动清空";
            this.btn_HandClear.UseVisualStyleBackColor = true;
            // 
            // chk_AutoClear
            // 
            this.chk_AutoClear.AutoSize = true;
            this.chk_AutoClear.Location = new System.Drawing.Point(28, 24);
            this.chk_AutoClear.Name = "chk_AutoClear";
            this.chk_AutoClear.Size = new System.Drawing.Size(72, 16);
            this.chk_AutoClear.TabIndex = 5;
            this.chk_AutoClear.Text = "自动清空";
            this.chk_AutoClear.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_Status,
            this.toolStripStatusLabel3,
            this.tssl_SendCount,
            this.toolStripStatusLabel5,
            this.tssl_ReceiveCount,
            this.tssl_Clear,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "     系统工作状态：";
            // 
            // tssl_Status
            // 
            this.tssl_Status.AutoSize = false;
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(230, 17);
            this.tssl_Status.Text = "初始化正常！";
            this.tssl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel3.Text = "发送字节数：";
            // 
            // tssl_SendCount
            // 
            this.tssl_SendCount.AutoSize = false;
            this.tssl_SendCount.Name = "tssl_SendCount";
            this.tssl_SendCount.Size = new System.Drawing.Size(80, 17);
            this.tssl_SendCount.Text = "0";
            this.tssl_SendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel5.Text = "接收字节数：";
            // 
            // tssl_ReceiveCount
            // 
            this.tssl_ReceiveCount.AutoSize = false;
            this.tssl_ReceiveCount.Name = "tssl_ReceiveCount";
            this.tssl_ReceiveCount.Size = new System.Drawing.Size(80, 17);
            this.tssl_ReceiveCount.Text = "0";
            this.tssl_ReceiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Period);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_SendPath);
            this.groupBox3.Controls.Add(this.btn_OpenFile);
            this.groupBox3.Controls.Add(this.btn_SendFile);
            this.groupBox3.Controls.Add(this.btn_SendClear);
            this.groupBox3.Controls.Add(this.chk_HexSend);
            this.groupBox3.Controls.Add(this.btn_HandSend);
            this.groupBox3.Controls.Add(this.chk_AutoSend);
            this.groupBox3.Location = new System.Drawing.Point(27, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 220);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // txt_Period
            // 
            this.txt_Period.Location = new System.Drawing.Point(123, 180);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(73, 21);
            this.txt_Period.TabIndex = 9;
            this.txt_Period.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "自动发送周期（ms）";
            // 
            // txt_SendPath
            // 
            this.txt_SendPath.Location = new System.Drawing.Point(20, 143);
            this.txt_SendPath.Name = "txt_SendPath";
            this.txt_SendPath.Size = new System.Drawing.Size(176, 21);
            this.txt_SendPath.TabIndex = 7;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(20, 108);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(85, 29);
            this.btn_OpenFile.TabIndex = 6;
            this.btn_OpenFile.Text = "打开文件";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(111, 108);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(85, 29);
            this.btn_SendFile.TabIndex = 6;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            // 
            // btn_SendClear
            // 
            this.btn_SendClear.Location = new System.Drawing.Point(111, 63);
            this.btn_SendClear.Name = "btn_SendClear";
            this.btn_SendClear.Size = new System.Drawing.Size(85, 29);
            this.btn_SendClear.TabIndex = 6;
            this.btn_SendClear.Text = "清空发送";
            this.btn_SendClear.UseVisualStyleBackColor = true;
            this.btn_SendClear.Click += new System.EventHandler(this.btn_SendClear_Click);
            // 
            // chk_HexSend
            // 
            this.chk_HexSend.AutoSize = true;
            this.chk_HexSend.Location = new System.Drawing.Point(28, 70);
            this.chk_HexSend.Name = "chk_HexSend";
            this.chk_HexSend.Size = new System.Drawing.Size(72, 16);
            this.chk_HexSend.TabIndex = 5;
            this.chk_HexSend.Text = "十六进制";
            this.chk_HexSend.UseVisualStyleBackColor = true;
            // 
            // btn_HandSend
            // 
            this.btn_HandSend.Location = new System.Drawing.Point(112, 18);
            this.btn_HandSend.Name = "btn_HandSend";
            this.btn_HandSend.Size = new System.Drawing.Size(85, 29);
            this.btn_HandSend.TabIndex = 6;
            this.btn_HandSend.Text = "手动发送";
            this.btn_HandSend.UseVisualStyleBackColor = true;
            this.btn_HandSend.Click += new System.EventHandler(this.btn_HandSend_Click);
            // 
            // chk_AutoSend
            // 
            this.chk_AutoSend.AutoSize = true;
            this.chk_AutoSend.Location = new System.Drawing.Point(28, 24);
            this.chk_AutoSend.Name = "chk_AutoSend";
            this.chk_AutoSend.Size = new System.Drawing.Size(72, 16);
            this.chk_AutoSend.TabIndex = 5;
            this.chk_AutoSend.Text = "自动发送";
            this.chk_AutoSend.UseVisualStyleBackColor = true;
            this.chk_AutoSend.CheckedChanged += new System.EventHandler(this.chk_AutoSend_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(265, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 205);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtb_Send);
            this.groupBox5.Location = new System.Drawing.Point(265, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 226);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // rtb_Send
            // 
            this.rtb_Send.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtb_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Send.ForeColor = System.Drawing.Color.Lime;
            this.rtb_Send.Location = new System.Drawing.Point(3, 17);
            this.rtb_Send.Name = "rtb_Send";
            this.rtb_Send.Size = new System.Drawing.Size(476, 206);
            this.rtb_Send.TabIndex = 0;
            this.rtb_Send.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(265, 467);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(482, 86);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "快捷命令（HEX）";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(370, 35);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 28);
            this.button12.TabIndex = 0;
            this.button12.Text = "快捷命令04";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(259, 35);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 28);
            this.button11.TabIndex = 0;
            this.button11.Text = "快捷命令03";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(144, 35);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 28);
            this.button10.TabIndex = 0;
            this.button10.Text = "快捷命令02";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "快捷命令01";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button13);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.textBox6);
            this.groupBox7.Controls.Add(this.checkBox7);
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.checkBox8);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Location = new System.Drawing.Point(265, 571);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(482, 128);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "命令模式（HEX）";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(346, 83);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 28);
            this.button13.TabIndex = 0;
            this.button13.Text = "发送命令";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(270, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 21);
            this.textBox5.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(216, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "数据";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(270, 85);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 21);
            this.textBox6.TabIndex = 7;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(216, 88);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 16);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "帧尾";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(95, 21);
            this.textBox4.TabIndex = 7;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(28, 86);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(48, 16);
            this.checkBox8.TabIndex = 5;
            this.checkBox8.Text = "校验";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "帧头";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // tssl_Clear
            // 
            this.tssl_Clear.AutoSize = false;
            this.tssl_Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tssl_Clear.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssl_Clear.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tssl_Clear.Name = "tssl_Clear";
            this.tssl_Clear.Size = new System.Drawing.Size(80, 17);
            this.tssl_Clear.Text = "清空计数";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 728);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试助手";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_Dtr;
        private System.Windows.Forms.CheckBox chk_Rts;
        private System.Windows.Forms.ComboBox cmb_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txt_SavePath;
        private System.Windows.Forms.Button btn_SelectPath;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.CheckBox chk_HexShow;
        private System.Windows.Forms.Button btn_HandClear;
        private System.Windows.Forms.CheckBox chk_AutoClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SendPath;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendClear;
        private System.Windows.Forms.CheckBox chk_HexSend;
        private System.Windows.Forms.Button btn_HandSend;
        private System.Windows.Forms.CheckBox chk_AutoSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtb_Send;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssl_SendCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tssl_ReceiveCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Clear;
    }
}

