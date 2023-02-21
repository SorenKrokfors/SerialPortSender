namespace SerialPortSender
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReveiveData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewCommand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNewCommand = new System.Windows.Forms.TextBox();
            this.btnAddtoSend = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(102, 28);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(222, 28);
            this.cmbPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud";
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(102, 62);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(122, 27);
            this.txtBaud.TabIndex = 3;
            this.txtBaud.Text = "9600";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(102, 95);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(222, 304);
            this.txtData.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(249, 411);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReveiveData
            // 
            this.txtReveiveData.Location = new System.Drawing.Point(627, 41);
            this.txtReveiveData.Multiline = true;
            this.txtReveiveData.Name = "txtReveiveData";
            this.txtReveiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReveiveData.Size = new System.Drawing.Size(387, 358);
            this.txtReveiveData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Receive";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(939, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNewCommand
            // 
            this.btnNewCommand.Location = new System.Drawing.Point(541, 41);
            this.btnNewCommand.Name = "btnNewCommand";
            this.btnNewCommand.Size = new System.Drawing.Size(80, 28);
            this.btnNewCommand.TabIndex = 31;
            this.btnNewCommand.Text = "Add";
            this.btnNewCommand.UseVisualStyleBackColor = true;
            this.btnNewCommand.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Commands";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "set iout 10,00",
            "read iout",
            "set vout 110,00",
            "read vout",
            "set precharge_dis 1",
            "set sd_bridge 0",
            "set fan 100",
            "get fan rpm",
            "led green",
            "led red",
            "led yellow",
            "led off",
            "WAIT 500"});
            this.listBox1.Location = new System.Drawing.Point(348, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 324);
            this.listBox1.TabIndex = 33;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // txtNewCommand
            // 
            this.txtNewCommand.Location = new System.Drawing.Point(348, 41);
            this.txtNewCommand.Name = "txtNewCommand";
            this.txtNewCommand.Size = new System.Drawing.Size(187, 27);
            this.txtNewCommand.TabIndex = 34;
            // 
            // btnAddtoSend
            // 
            this.btnAddtoSend.Location = new System.Drawing.Point(498, 405);
            this.btnAddtoSend.Name = "btnAddtoSend";
            this.btnAddtoSend.Size = new System.Drawing.Size(123, 30);
            this.btnAddtoSend.TabIndex = 35;
            this.btnAddtoSend.Text = "Add to send list";
            this.btnAddtoSend.UseVisualStyleBackColor = true;
            this.btnAddtoSend.Click += new System.EventHandler(this.btnAddtoSend_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(249, 60);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 29);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 453);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAddtoSend);
            this.Controls.Add(this.txtNewCommand);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewCommand);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReveiveData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtBaud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPorts);
            this.Name = "frmMain";
            this.Text = "Serial Port Sender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbPorts;
        private Label label1;
        private Label label2;
        private TextBox txtBaud;
        private TextBox txtData;
        private Button btnSend;
        private TextBox txtReveiveData;
        private Label label3;
        private Button btnClear;
        private Button btnNewCommand;
        private Label label4;
        private ListBox listBox1;
        private TextBox txtNewCommand;
        private Button btnAddtoSend;
        private Button btnOpen;
    }
}