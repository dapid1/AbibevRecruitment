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
        Image File;
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
                Result result = barcodeReader.Decode(bmp);
                if (result != null)
                {
                    String details = result.Text;
                    profileBox.Text = "Leaner Profile: \n";
                    profileBox.AppendText(details);
                    timer1.Stop();
                    try
                    {
                        if (CaptureDevice.IsRunning)
                        {
                            CaptureDevice.Stop();
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                       
                    }
                }
            }
        }

        private void profileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            while (CaptureDevice.IsRunning)
                CaptureDevice.Stop();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void uploadQRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaptureDevice.IsRunning)
                {
                    CaptureDevice.Stop();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error :\n" + ex.Message);
            }
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox.Image = File;
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Bitmap bmp = (Bitmap)pictureBox.Image;
                Result result = barcodeReader.Decode(bmp);
                if (result != null)
                {
                    String details = result.Text;
                    profileBox.Text = "Leaner Profile: \n";
                    profileBox.AppendText(details);
                    timer1.Stop();
                }
            }
        }

        private void groupBox1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
