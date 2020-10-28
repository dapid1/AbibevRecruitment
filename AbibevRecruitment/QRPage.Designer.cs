namespace AbibevRecruitment
{
    partial class QRPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detailsSaveBtn = new System.Windows.Forms.Button();
            this.detailBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qrDownloadBtn = new System.Windows.Forms.Button();
            this.qrPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learner Profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailsSaveBtn);
            this.groupBox1.Controls.Add(this.detailBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(38, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 878);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // detailsSaveBtn
            // 
            this.detailsSaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailsSaveBtn.Location = new System.Drawing.Point(550, 801);
            this.detailsSaveBtn.Name = "detailsSaveBtn";
            this.detailsSaveBtn.Size = new System.Drawing.Size(119, 46);
            this.detailsSaveBtn.TabIndex = 1;
            this.detailsSaveBtn.Text = "&Save";
            this.detailsSaveBtn.UseVisualStyleBackColor = true;
            this.detailsSaveBtn.Click += new System.EventHandler(this.detailsSaveBtn_Click);
            // 
            // detailBox
            // 
            this.detailBox.BackColor = System.Drawing.SystemColors.Control;
            this.detailBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailBox.Location = new System.Drawing.Point(25, 51);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(655, 705);
            this.detailBox.TabIndex = 0;
            this.detailBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qrDownloadBtn);
            this.groupBox2.Controls.Add(this.qrPicture);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(802, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 561);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Qr Code";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // qrDownloadBtn
            // 
            this.qrDownloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qrDownloadBtn.Location = new System.Drawing.Point(177, 498);
            this.qrDownloadBtn.Name = "qrDownloadBtn";
            this.qrDownloadBtn.Size = new System.Drawing.Size(150, 46);
            this.qrDownloadBtn.TabIndex = 1;
            this.qrDownloadBtn.Text = "&Download";
            this.qrDownloadBtn.UseVisualStyleBackColor = true;
            this.qrDownloadBtn.Click += new System.EventHandler(this.qrDownloadBtn_Click);
            // 
            // qrPicture
            // 
            this.qrPicture.Location = new System.Drawing.Point(25, 54);
            this.qrPicture.Name = "qrPicture";
            this.qrPicture.Size = new System.Drawing.Size(438, 438);
            this.qrPicture.TabIndex = 0;
            this.qrPicture.TabStop = false;
            this.qrPicture.WaitOnLoad = true;
            this.qrPicture.Click += new System.EventHandler(this.qrPicture_Click_1);
            // 
            // QRPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 1057);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QRPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRPage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button detailsSaveBtn;
        public System.Windows.Forms.RichTextBox detailBox;
        private System.Windows.Forms.Button qrDownloadBtn;
        public System.Windows.Forms.PictureBox qrPicture;
    }
}