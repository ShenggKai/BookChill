using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using SkiaSharp.QrCode;
using ZXing;
using ZXing.Aztec;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace BookChill.Child_Form
{
    public partial class ScanerForm : Form
    {
        public ScanerForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        #region Function button
        // Exit button
        private void pClose_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Bạn chắc chắn muốn Thoát?", "BookChill",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //if (result == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            Application.Exit();
        }

        // Minimize button
        private void pMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pCLose_MouseHover(object sender, EventArgs e)
        {
            pCLose.BackColor = Color.FromArgb(232, 17, 35);
            pCLose.Image = global::BookChill.Properties.Resources.close_white;
        }

        private void pCLose_MouseLeave(object sender, EventArgs e)
        {
            pCLose.BackColor = Color.Transparent;
            pCLose.Image = global::BookChill.Properties.Resources.close;
        }

        private void pMinimize_MouseHover(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.DarkGray;
            pMinimize.Image = global::BookChill.Properties.Resources.minimize_white;
        }

        private void pMinimize_MouseLeave(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.Transparent;
            pMinimize.Image = global::BookChill.Properties.Resources.minimize;
        }

        private void ScanerForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
        }
        #endregion


        private void ScanerForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex= 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScanerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }






        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (pictureBox.Image != null)
            //{
            //    QRCodeReader qRCodeReader = new QRCodeReader();
            //    Result result = qRCodeReader.decode((bi))
            //}

        }
    }
}
