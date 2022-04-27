namespace CourseManageUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnTeacherManage = new System.Windows.Forms.Button();
            this.btnCousreManage = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.btnModifyPwd);
            this.panel2.Controls.Add(this.btnTeacherManage);
            this.panel2.Controls.Add(this.btnCousreManage);
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(9, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 468);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel3.BackgroundImage = global::CourseManageUI.Properties.Resources.mainbg;
            this.panel3.Location = new System.Drawing.Point(223, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 468);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CourseManageUI.Properties.Resources.bannerbg;
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 66);
            this.panel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 1);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnTeacherManage
            // 
            this.btnTeacherManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTeacherManage.ForeColor = System.Drawing.Color.White;
            this.btnTeacherManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManage.Image")));
            this.btnTeacherManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManage.Location = new System.Drawing.Point(32, 299);
            this.btnTeacherManage.Name = "btnTeacherManage";
            this.btnTeacherManage.Size = new System.Drawing.Size(151, 38);
            this.btnTeacherManage.TabIndex = 1;
            this.btnTeacherManage.Text = "讲 师 信 息 管 理 ";
            this.btnTeacherManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacherManage.UseVisualStyleBackColor = false;
            // 
            // btnCousreManage
            // 
            this.btnCousreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCousreManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCousreManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCousreManage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCousreManage.ForeColor = System.Drawing.Color.White;
            this.btnCousreManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCousreManage.Image")));
            this.btnCousreManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCousreManage.Location = new System.Drawing.Point(32, 255);
            this.btnCousreManage.Name = "btnCousreManage";
            this.btnCousreManage.Size = new System.Drawing.Size(151, 38);
            this.btnCousreManage.TabIndex = 2;
            this.btnCousreManage.Text = "课 程 信 息 管 理 ";
            this.btnCousreManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCousreManage.UseVisualStyleBackColor = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(32, 211);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(151, 38);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "添 加 课 程 信 息 ";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyPwd.ForeColor = System.Drawing.Color.White;
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(32, 377);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(151, 38);
            this.btnModifyPwd.TabIndex = 4;
            this.btnModifyPwd.Text = "修 改 登 录 密 码 ";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(889, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrentUser.Image")));
            this.lblCurrentUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentUser.Location = new System.Drawing.Point(800, 27);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(74, 23);
            this.lblCurrentUser.TabIndex = 6;
            this.lblCurrentUser.Text = "常老师";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnTeacherManage;
        private System.Windows.Forms.Button btnCousreManage;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnClose;
    }
}