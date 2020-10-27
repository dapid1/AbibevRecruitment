using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace AbibevRecruitment
{
    public partial class ManagerDecode : Form
    {
        public ManagerDecode()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CaptureDevice.IsRunning)
            {
                CaptureDevice.Stop();
            }
            Application.Exit();
       
        }

        private void ManagerDecode_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            CaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            CaptureDevice.NewFrame += CaptureDevice_Newframe;
            CaptureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Bitmap bmp = (Bitmap)pictureBox.Image;
                Result result = null;
                try
                {
                    result = barcodeReader.Decode(bmp);
                }
                catch (ArgumentNullException ex)
                {

                }

                if (result != null)
                {
                    String res = result.ToString();
                    char[] delimiter = { ';' };
                    String[] details = res.Split(delimiter, 3);
                    String profile = "Name: " + details[0] + "\n";
                    profile += "\nSurname:    " + details[1] + "\n";
                    profile += "course:  " + details[2] + "\n";
                    profileBox.Text = profile;
                    timer1.Stop();
                    if (CaptureDevice.IsRunning)
                        CaptureDevice.Stop();

                }
            }
        }

        private void profileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            while(CaptureDevice.IsRunning)
                CaptureDevice.Stop();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
