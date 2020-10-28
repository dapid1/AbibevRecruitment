namespace AbibevRecruitment
{
    partial class StudentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.cellNumberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.homeAddressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailAddressBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Resume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameBox
            // 
            this.nameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(261, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(624, 39);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "Nomasam";
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_OnKeyDown);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(261, 142);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(624, 39);
            this.surnameBox.TabIndex = 3;
            this.surnameBox.Text = "Mbanjwa";
            this.surnameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.surnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameBox_KeyPress);
            // 
            // cellNumberBox
            // 
            this.cellNumberBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellNumberBox.Location = new System.Drawing.Point(261, 371);
            this.cellNumberBox.Name = "cellNumberBox";
            this.cellNumberBox.Size = new System.Drawing.Size(624, 39);
            this.cellNumberBox.TabIndex = 3;
            this.cellNumberBox.Text = "083 123 4567";
            this.cellNumberBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cellNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cellNumberBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cell Number";
            // 
            // courseBox
            // 
            this.courseBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseBox.Location = new System.Drawing.Point(261, 233);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(624, 39);
            this.courseBox.TabIndex = 3;
            this.courseBox.Text = "CNET";
            this.courseBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.courseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.courseBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Course ";
            // 
            // homeAddressBox
            // 
            this.homeAddressBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeAddressBox.Location = new System.Drawing.Point(261, 547);
            this.homeAddressBox.Multiline = true;
            this.homeAddressBox.Name = "homeAddressBox";
            this.homeAddressBox.Size = new System.Drawing.Size(624, 150);
            this.homeAddressBox.TabIndex = 3;
            this.homeAddressBox.Text = "123 Street Kas\r\nBoksburg\r\nJohannesburg\r\n1401";
            this.homeAddressBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.homeAddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.homeAddressBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Home Address";
            // 
            // emailAddressBox
            // 
            this.emailAddressBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddressBox.Location = new System.Drawing.Point(261, 454);
            this.emailAddressBox.Name = "emailAddressBox";
            this.emailAddressBox.Size = new System.Drawing.Size(624, 39);
            this.emailAddressBox.TabIndex = 3;
            this.emailAddressBox.Text = "nom@me.com";
            this.emailAddressBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.emailAddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailAddressBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email Address";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(31, 861);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(914, 46);
            this.progressBar.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(743, 994);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 30);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "⮌ go back to login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(733, 924);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(150, 46);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.homeAddressBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.emailAddressBox);
            this.groupBox1.Controls.Add(this.cellNumberBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.courseBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 716);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Fill the details :";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 1043);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox cellNumberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox homeAddressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailAddressBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}