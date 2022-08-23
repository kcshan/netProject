
namespace Demo_2._5._2
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
            this.btnCoco = new System.Windows.Forms.Button();
            this.btnCarry = new System.Windows.Forms.Button();
            this.btnAndy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(59, 36);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(127, 37);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "测试按钮的事件";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(223, 41);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(119, 32);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "事件断开";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(360, 41);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(121, 32);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "事件关联";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnTestEvent
            // 
            this.btnTestEvent.Location = new System.Drawing.Point(59, 102);
            this.btnTestEvent.Name = "btnTestEvent";
            this.btnTestEvent.Size = new System.Drawing.Size(127, 34);
            this.btnTestEvent.TabIndex = 3;
            this.btnTestEvent.Text = "测试事件的响应";
            this.btnTestEvent.UseVisualStyleBackColor = true;
            // 
            // btnCoco
            // 
            this.btnCoco.Location = new System.Drawing.Point(273, 174);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(75, 23);
            this.btnCoco.TabIndex = 9;
            this.btnCoco.Text = "Coco老师";
            this.btnCoco.UseVisualStyleBackColor = true;
            this.btnCoco.Click += new System.EventHandler(this.btnCoco_Click);
            // 
            // btnCarry
            // 
            this.btnCarry.Location = new System.Drawing.Point(162, 174);
            this.btnCarry.Name = "btnCarry";
            this.btnCarry.Size = new System.Drawing.Size(75, 23);
            this.btnCarry.TabIndex = 8;
            this.btnCarry.Text = "Carry老师";
            this.btnCarry.UseVisualStyleBackColor = true;
            this.btnCarry.Click += new System.EventHandler(this.btnCarry_Click);
            // 
            // btnAndy
            // 
            this.btnAndy.Location = new System.Drawing.Point(61, 174);
            this.btnAndy.Name = "btnAndy";
            this.btnAndy.Size = new System.Drawing.Size(75, 23);
            this.btnAndy.TabIndex = 7;
            this.btnAndy.Text = "Andy老师";
            this.btnAndy.UseVisualStyleBackColor = true;
            this.btnAndy.Click += new System.EventHandler(this.btnAndy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnCoco);
            this.Controls.Add(this.btnCarry);
            this.Controls.Add(this.btnAndy);
            this.Controls.Add(this.btnTestEvent);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Button btnCarry;
        private System.Windows.Forms.Button btnAndy;
    }
}

