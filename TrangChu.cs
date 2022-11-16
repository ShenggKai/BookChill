using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookChill
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            panelSubMenuColec.Visible = false;
            panelSubMenuSca.Visible = false;
        }

        #region function button
        // Exit button
        private void pClose_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Do you want to Exit?", "BookChill",
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

        // Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?", "BookChill",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                new Login().Show();
                this.Hide();
            }
        }
        #endregion

        #region Submenu code
        private void hideSubMenu()
        {
            if (panelSubMenuColec.Visible == true)
            {
                panelSubMenuColec.Visible = false;
            }

            if (panelSubMenuSca.Visible == true)
            {
                panelSubMenuSca.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Submenu for Collection
        // hide sub menu collection
        private void btnCollection_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuColec);
        }

        private void btnVanhoc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTuduy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNgoaingu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnThieunhi_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTruyentranh_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnKhoahoc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDienanh_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTudien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Submenu for Scan
        // hide sub menu scan
        private void btnScan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSca);
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
        #endregion

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
            else if(count_left < 4)
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
