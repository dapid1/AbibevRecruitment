using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbibevRecruitment
{
    public partial class StudentForm : Form
    {
        private string name, surname, course, cellNumber, emailAddress, homeAddress;
        private String details, qrString;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Space)
            {
                nameBox.Text = nameBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void surnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                surnameBox.Text = surnameBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void courseBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                courseBox.Text = courseBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void cellNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                cellNumberBox.Text = cellNumberBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void emailAddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                emailAddressBox.Text = emailAddressBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void homeAddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                homeAddressBox.Text = homeAddressBox.Text.Replace(" ", "");
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            name = nameBox.Text;
            surname = surnameBox.Text;
            course = courseBox.Text;
            cellNumber = cellNumberBox.Text;
            emailAddress = emailAddressBox.Text;
            homeAddress = homeAddressBox.Text;
            error = evalError(error);
            if (!error.Equals(""))
            {
                MessageBox.Show("Error :\n" +error + "cannot be empty");
            }

            //Combine details to form profile

        }

        public string evalError(string error)
        {
            if (name == "")
            {
                error = String.Concat(error, "\t>Name\n");
            }
            if (surname == "")
            {
                error = String.Concat(error, "\t>Surname\n");
            }
            if (course == "")
            {
                error = String.Concat(error, "\t>Course\n");
            }
            if (cellNumber == "")
            {
                error = String.Concat(error, "\t>Cell Number\n");
            }
            if (emailAddress == "")
            {
                error = String.Concat(error, "\t>Email Address\n");
            }
            if (homeAddress == "")
            {
                error = String.Concat(error, "\t>Home Address\n");
            }

            return error;
        }
    }
}
