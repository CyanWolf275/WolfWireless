namespace Wireless
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.portlst = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disconnect = new System.Windows.Forms.Button();
            this.rsa = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.rsa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(631, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disconnected";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // portlst
            // 
            this.portlst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portlst.FormattingEnabled = true;
            this.portlst.Location = new System.Drawing.Point(6, 20);
            this.portlst.Name = "portlst";
            this.portlst.Size = new System.Drawing.Size(121, 20);
            this.portlst.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(133, 20);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 20);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(38, 108);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.ReadOnly = true;
            this.msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msg.Size = new System.Drawing.Size(727, 233);
            this.msg.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(640, 21);
            this.textBox2.TabIndex = 4;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(690, 357);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 21);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(214, 20);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 20);
            this.disconnect.TabIndex = 6;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // rsa
            // 
            this.rsa.Controls.Add(this.label2);
            this.rsa.Controls.Add(this.enable);
            this.rsa.Location = new System.Drawing.Point(359, 41);
            this.rsa.Name = "rsa";
            this.rsa.Size = new System.Drawing.Size(161, 47);
            this.rsa.TabIndex = 7;
            this.rsa.TabStop = false;
            this.rsa.Text = "RSA Encryption";
            this.rsa.Enter += new System.EventHandler(this.rsa_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(110, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "OFF";
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(6, 18);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(75, 23);
            this.enable.TabIndex = 0;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portlst);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Location = new System.Drawing.Point(38, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(550, 57);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rsa);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WolfWireless";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rsa.ResumeLayout(false);
            this.rsa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portlst;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.GroupBox rsa;
        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
    }
}

