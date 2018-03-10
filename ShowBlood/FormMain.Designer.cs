namespace ShowBlood
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.spTest = new System.IO.Ports.SerialPort(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelConfig = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBaudrateTest = new System.Windows.Forms.ComboBox();
            this.cbxPortTest = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.panelConfig.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(290, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.BackColor = System.Drawing.Color.Black;
            this.btnUpdateConfig.ForeColor = System.Drawing.Color.White;
            this.btnUpdateConfig.Location = new System.Drawing.Point(241, 2);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(43, 21);
            this.btnUpdateConfig.TabIndex = 1;
            this.btnUpdateConfig.Text = "更新";
            this.btnUpdateConfig.UseVisualStyleBackColor = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Black;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(241, 27);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(43, 27);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // panelConfig
            // 
            this.panelConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConfig.BackColor = System.Drawing.Color.Transparent;
            this.panelConfig.Controls.Add(this.label3);
            this.panelConfig.Controls.Add(this.btnTest);
            this.panelConfig.Controls.Add(this.btnExit);
            this.panelConfig.Controls.Add(this.label4);
            this.panelConfig.Controls.Add(this.cbxBaudrateTest);
            this.panelConfig.Controls.Add(this.cbxPortTest);
            this.panelConfig.Controls.Add(this.lblMsg);
            this.panelConfig.Controls.Add(this.label2);
            this.panelConfig.Controls.Add(this.label1);
            this.panelConfig.Controls.Add(this.cbxBaudrate);
            this.panelConfig.Controls.Add(this.cbxPort);
            this.panelConfig.Controls.Add(this.btnUpdateConfig);
            this.panelConfig.Location = new System.Drawing.Point(126, 209);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(339, 58);
            this.panelConfig.TabIndex = 11;
            this.panelConfig.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "测试波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "测试串口号";
            // 
            // cbxBaudrateTest
            // 
            this.cbxBaudrateTest.FormattingEnabled = true;
            this.cbxBaudrateTest.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "14400",
            "38400"});
            this.cbxBaudrateTest.Location = new System.Drawing.Point(74, 31);
            this.cbxBaudrateTest.Name = "cbxBaudrateTest";
            this.cbxBaudrateTest.Size = new System.Drawing.Size(59, 20);
            this.cbxBaudrateTest.TabIndex = 6;
            // 
            // cbxPortTest
            // 
            this.cbxPortTest.FormattingEnabled = true;
            this.cbxPortTest.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbxPortTest.Location = new System.Drawing.Point(74, 3);
            this.cbxPortTest.Name = "cbxPortTest";
            this.cbxPortTest.Size = new System.Drawing.Size(59, 20);
            this.cbxPortTest.TabIndex = 5;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(10, 165);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 12);
            this.lblMsg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串口号";
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "14400",
            "38400"});
            this.cbxBaudrate.Location = new System.Drawing.Point(177, 31);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(58, 20);
            this.cbxBaudrate.TabIndex = 1;
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cbxPort.Location = new System.Drawing.Point(177, 3);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(58, 20);
            this.cbxPort.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.lblNumber);
            this.panel.Controls.Add(this.panelConfig);
            this.panel.Controls.Add(this.pb);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(589, 419);
            this.panel.TabIndex = 13;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // lblNumber
            // 
            this.lblNumber.FlatAppearance.BorderSize = 0;
            this.lblNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumber.ForeColor = System.Drawing.Color.Red;
            this.lblNumber.Location = new System.Drawing.Point(239, 175);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(104, 23);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "100";
            this.lblNumber.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(589, 419);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 14;
            this.pb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            // 
            // timerAnimate
            // 
            this.timerAnimate.Interval = 1000;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 419);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "血量";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateConfig;
        private System.IO.Ports.SerialPort spTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBaudrateTest;
        private System.Windows.Forms.ComboBox cbxPortTest;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button lblNumber;
        private System.Windows.Forms.Timer timerAnimate;
    }
}

