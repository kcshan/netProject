namespace StudentManagerPro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.学员管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStuManage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tsmi_PwdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学员AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量导入学员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学员管理MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PwdModify,
            this.toolStripSeparator1,
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统ToolStripMenuItem.Text = "系统(&S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 学员管理MToolStripMenuItem
            // 
            this.学员管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学员AToolStripMenuItem,
            this.批量导入学员ToolStripMenuItem,
            this.toolStripSeparator2,
            this.学员信息管理ToolStripMenuItem});
            this.学员管理MToolStripMenuItem.Name = "学员管理MToolStripMenuItem";
            this.学员管理MToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.学员管理MToolStripMenuItem.Text = "学员管理(&M)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "版本号：V2.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel2.Text = "        [当前用户：***]";
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 25);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.button8);
            this.spContainer.Panel1.Controls.Add(this.button6);
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.button7);
            this.spContainer.Panel1.Controls.Add(this.button5);
            this.spContainer.Panel1.Controls.Add(this.btnStuManage);
            this.spContainer.Panel1.Controls.Add(this.button2);
            this.spContainer.Panel1.Controls.Add(this.btnAddStudent);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Panel2.Controls.Add(this.label1);
            this.spContainer.Size = new System.Drawing.Size(1095, 655);
            this.spContainer.SplitterDistance = 300;
            this.spContainer.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.ico");
            this.imageList1.Images.SetKeyName(1, "Close.ico");
            this.imageList1.Images.SetKeyName(2, "CustomerOrder.ico");
            this.imageList1.Images.SetKeyName(3, "MngIncdown.bmp");
            this.imageList1.Images.SetKeyName(4, "people.ico");
            this.imageList1.Images.SetKeyName(5, "PROPS.ICO");
            this.imageList1.Images.SetKeyName(6, "Sells.ico");
            this.imageList1.Images.SetKeyName(7, "SysIco.ico");
            this.imageList1.Images.SetKeyName(8, "TABLE.ICO");
            this.imageList1.Images.SetKeyName(9, "BOOKS01.ICO");
            this.imageList1.Images.SetKeyName(10, "关闭.bmp");
            this.imageList1.Images.SetKeyName(11, "修改.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正兰亭超细黑简体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用学员管理系统";
            // 
            // button8
            // 
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 10;
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(183, 606);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 28);
            this.button8.TabIndex = 1;
            this.button8.Text = "退出系统";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 8;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(183, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "成绩浏览";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 5;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(183, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = " 考勤打卡";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 11;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(27, 606);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "密码修改";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 6;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(27, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "成绩分析";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnStuManage
            // 
            this.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuManage.ImageIndex = 4;
            this.btnStuManage.ImageList = this.imageList1;
            this.btnStuManage.Location = new System.Drawing.Point(27, 266);
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(85, 28);
            this.btnStuManage.TabIndex = 1;
            this.btnStuManage.Text = "学员管理";
            this.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuManage.UseVisualStyleBackColor = true;
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(183, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "批量导入";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.ImageIndex = 3;
            this.btnAddStudent.ImageList = this.imageList1;
            this.btnAddStudent.Location = new System.Drawing.Point(27, 223);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(85, 28);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = " 添加学员";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tsmi_PwdModify
            // 
            this.tsmi_PwdModify.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_PwdModify.Image")));
            this.tsmi_PwdModify.Name = "tsmi_PwdModify";
            this.tsmi_PwdModify.Size = new System.Drawing.Size(144, 22);
            this.tsmi_PwdModify.Text = "密码修改(&M)";
            this.tsmi_PwdModify.Click += new System.EventHandler(this.tsmi_PwdModify_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem.Image")));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 添加学员AToolStripMenuItem
            // 
            this.添加学员AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加学员AToolStripMenuItem.Image")));
            this.添加学员AToolStripMenuItem.Name = "添加学员AToolStripMenuItem";
            this.添加学员AToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加学员AToolStripMenuItem.Text = "添加学员(&A)";
            // 
            // 批量导入学员ToolStripMenuItem
            // 
            this.批量导入学员ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("批量导入学员ToolStripMenuItem.Image")));
            this.批量导入学员ToolStripMenuItem.Name = "批量导入学员ToolStripMenuItem";
            this.批量导入学员ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.批量导入学员ToolStripMenuItem.Text = "批量导入学员(&I)";
            // 
            // 学员信息管理ToolStripMenuItem
            // 
            this.学员信息管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("学员信息管理ToolStripMenuItem.Image")));
            this.学员信息管理ToolStripMenuItem.Name = "学员信息管理ToolStripMenuItem";
            this.学员信息管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学员信息管理ToolStripMenuItem.Text = "学员信息管理";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 702);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学员信息管理系统]-最适合初学者实践的项目";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PwdModify;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 学员管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学员AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量导入学员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStuManage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

