using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AbibevRecruitment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            ManagerDecode decPage = new ManagerDecode();
            this.Hide();
            decPage.ShowDialog();
            
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
