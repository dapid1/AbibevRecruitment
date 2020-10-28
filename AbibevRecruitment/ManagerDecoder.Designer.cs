namespace AbibevRecruitment
{
    partial class ManagerDecode
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.scanBtn = new System.Windows.Forms.Button();
            this.profileBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.uploadQRBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Device";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(140, 27);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(242, 40);
            this.cboDevice.TabIndex = 1;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(24, 127);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(150, 46);
            this.scanBtn.TabIndex = 2;
            this.scanBtn.Text = "&Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // profileBox
            // 
            this.profileBox.Location = new System.Drawing.Point(507, 187);
            this.profileBox.Multiline = true;
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(251, 280);
            this.profileBox.TabIndex = 5;
            this.profileBox.TextChanged += new System.EventHandler(this.profileBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(201, 127);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(150, 46);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(32, 187);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(410, 384);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(654, 624);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(211, 32);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "⮌ go back to login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // uploadQRBtn
            // 
            this.uploadQRBtn.Location = new System.Drawing.Point(523, 127);
            this.uploadQRBtn.Name = "uploadQRBtn";
            this.uploadQRBtn.Size = new System.Drawing.Size(150, 46);
            this.uploadQRBtn.TabIndex = 9;
            this.uploadQRBtn.Text = "&Upload QR";
            this.uploadQRBtn.UseVisualStyleBackColor = true;
            this.uploadQRBtn.Click += new System.EventHandler(this.uploadQRBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManagerDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 679);
            this.Controls.Add(this.uploadQRBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManagerDecode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDecode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ManagerDecode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.TextBox profileBox;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button uploadQRBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

