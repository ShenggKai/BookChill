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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        #region function button
        // Exit button
        private void pictureClose_Click(object sender, EventArgs e)
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

        private void pClose_MouseHover(object sender, EventArgs e)
        {
            pClose.BackColor = Color.FromArgb(232, 17, 35);
            pClose.Image = global::BookChill.Properties.Resources.close_white;
        }

        private void pClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
            pClose.Image = global::BookChill.Properties.Resources.close;
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

        private void HomeForm_SizeChanged(object sender, EventArgs e)
        {
            //List<Form> listForm = new List<Form>();
            
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    //listForm.Add(frm);
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
        }

        #endregion

        #region function for Arrow button
        private void changeImage(int count)
        {
            switch (count)
            {
                case 0:
                    panelHeading.BackgroundImage = global::BookChill.Properties.Resources.banner_1;
                    pBook.Image = global::BookChill.Properties.Resources.nhagiakim;
                    break;
                case 1:
                    panelHeading.BackgroundImage = global::BookChill.Properties.Resources.banner_2;
                    pBook.Image = global::BookChill.Properties.Resources.hanhtinhcuamotkenghinhieu;
                    break;
                case 2:
                    panelHeading.BackgroundImage = global::BookChill.Properties.Resources.banner_4;
                    pBook.Image = global::BookChill.Properties.Resources.chotoixinmotvedituoitho;
                    break;
                case 3:
                    panelHeading.BackgroundImage = global::BookChill.Properties.Resources.banner_3;
                    pBook.Image = global::BookChill.Properties.Resources.suimlangcuabaycuu;
                    break;
                default:
                    break;
            }
        }

        int count = 0;

        private void pArrowleft_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            changeImage(count);
        }

        private void pArrowright_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                count++;
            }
            changeImage(count);
        }

        int count_right = 3;
        int count_left = 0;
        int tempt = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count_right > 0)
            {
                tempt = count_right;
                count_right--;
            }
            else if (count_left < 4)
            {
                tempt = count_left;
                count_left++;
            }
            else
            {
                count_right = 3;
                count_left = 0;
                tempt = count_right;
            }

            changeImage(tempt);
        }
        #endregion
    }
}
