using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookChill.Child_Form
{
    public partial class ScanerForm : Form
    {
        public ScanerForm()
        {
            InitializeComponent();
        }

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

        }
    }
}
