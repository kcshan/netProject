namespace WinForm_2._5._3
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnTestEvent = new System.Windows.Forms.Button();
            this.btnAndy = new System.Windows.Forms.Button();
            this.btnCarry = new System.Windows.Forms.Button();
            this.btnCoco = new System.Windows.Forms.Button();
            this.btnTestMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(28, 236);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "测试按钮的事件";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(171, 236);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "事件断开";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(171, 282);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 23);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "事件关联";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnTestEvent
            // 
            this.btnTestEvent.Location = new System.Drawing.Point(28, 34);
            this.btnTestEvent.Name = "btnTestEvent";
            this.btnTestEvent.Size = new System.Drawing.Size(120, 23);
            this.btnTestEvent.TabIndex = 3;
            this.btnTestEvent.Text = "测试事件的响应";
            this.btnTestEvent.UseVisualStyleBackColor = true;
            // 
            // btnAndy
            // 
            this.btnAndy.Location = new System.Drawing.Point(171, 34);
            this.btnAndy.Name = "btnAndy";
            this.btnAndy.Size = new System.Drawing.Size(75, 23);
            this.btnAndy.TabIndex = 4;
            this.btnAndy.Text = "Andy老师";
            this.btnAndy.UseVisualStyleBackColor = true;
            // 
            // btnCarry
            // 
            this.btnCarry.Location = new System.Drawing.Point(272, 34);
            this.btnCarry.Name = "btnCarry";
            this.btnCarry.Size = new System.Drawing.Size(75, 23);
            this.btnCarry.TabIndex = 5;
            this.btnCarry.Text = "Carry老师";
            this.btnCarry.UseVisualStyleBackColor = true;
            // 
            // btnCoco
            // 
            this.btnCoco.Location = new System.Drawing.Point(383, 34);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(75, 23);
            this.btnCoco.TabIndex = 6;
            this.btnCoco.Text = "Coco老师";
            this.btnCoco.UseVisualStyleBackColor = true;
            // 
            // btnTestMsg
            // 
            this.btnTestMsg.Location = new System.Drawing.Point(28, 82);
            this.btnTestMsg.Name = "btnTestMsg";
            this.btnTestMsg.Size = new System.Drawing.Size(120, 23);
            this.btnTestMsg.TabIndex = 7;
            this.btnTestMsg.Text = "测试消息框";
            this.btnTestMsg.UseVisualStyleBackColor = true;
            this.btnTestMsg.Click += new System.EventHandler(this.btnTestMsg_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 317);
            this.Controls.Add(this.btnTestMsg);
            this.Controls.Add(this.btnCoco);
            this.Controls.Add(this.btnCarry);
            this.Controls.Add(this.btnAndy);
            this.Controls.Add(this.btnTestEvent);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnTest);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "事件的测试";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnTestEvent;
        private System.Windows.Forms.Button btnAndy;
        private System.Windows.Forms.Button btnCarry;
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Button btnTestMsg;
    }
}

