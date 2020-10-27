namespace AbibevRecruitment
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managerBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managerBtn
            // 
            this.managerBtn.Location = new System.Drawing.Point(165, 120);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(415, 63);
            this.managerBtn.TabIndex = 0;
            this.managerBtn.Text = "Manager";
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(165, 245);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(415, 63);
            this.studentBtn.TabIndex = 0;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.managerBtn);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Label label1;
    }
}
