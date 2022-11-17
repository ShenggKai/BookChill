using BookChill.Child_Form;
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
        private Form currentChildForm;

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

        // Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn Đăng xuất?", "BookChill",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void pCLose_MouseHover(object sender, EventArgs e)
        {
            pCLoseMain.BackColor = Color.FromArgb(232, 17, 35);
            pCLoseMain.Image = global::BookChill.Properties.Resources.close_white;
        }

        private void pCLose_MouseLeave(object sender, EventArgs e)
        {
            pCLoseMain.BackColor = Color.Transparent;
            pCLoseMain.Image = global::BookChill.Properties.Resources.close;
        }

        private void pMinimize_MouseHover(object sender, EventArgs e)
        {
            pMinimizeMain.BackColor = Color.DarkGray;
            pMinimizeMain.Image = global::BookChill.Properties.Resources.minimize_white;
        }

        private void pMinimize_MouseLeave(object sender, EventArgs e)
        {
            pMinimizeMain.BackColor = Color.Transparent;
            pMinimizeMain.Image = global::BookChill.Properties.Resources.minimize;
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
            hideSubMenu();
        }

        // hide sub menu collection
        private void btnCollection_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuColec);
        }

        private void btnVanhoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VanHoc());
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

        #region function to change button when click
        private void btnHome_MouseClick(object sender, MouseEventArgs e)
        {
            btnCollection.BackColor = Color.FromArgb(90, 130, 95);
            btnCollection.ForeColor = Color.White;
            btnCollection.Image = global::BookChill.Properties.Resources.books;

            btnScan.BackColor = Color.FromArgb(90, 130, 95);
            btnScan.ForeColor = Color.White;
            btnScan.Image = global::BookChill.Properties.Resources.qrcode;

            btnHome.BackColor = Color.Gainsboro;
            btnHome.ForeColor = Color.FromArgb(90, 130, 95);
            btnHome.Image = global::BookChill.Properties.Resources.house_green;
        }

        private void btnCollection_MouseClick(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(90, 130, 95);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::BookChill.Properties.Resources.house;

            btnScan.BackColor = Color.FromArgb(90, 130, 95);
            btnScan.ForeColor = Color.White;
            btnScan.Image = global::BookChill.Properties.Resources.qrcode;

            btnCollection.BackColor = Color.Gainsboro;
            btnCollection.ForeColor = Color.FromArgb(90, 130, 95);
            btnCollection.Image = global::BookChill.Properties.Resources.books_green;
        }

        private void btnScan_MouseClick(object sender, MouseEventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(90, 130, 95);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::BookChill.Properties.Resources.house;

            btnCollection.BackColor = Color.FromArgb(90, 130, 95);
            btnCollection.ForeColor = Color.White;
            btnCollection.Image = global::BookChill.Properties.Resources.books;

            btnScan.BackColor = Color.Gainsboro;
            btnScan.ForeColor = Color.FromArgb(90, 130, 95);
            btnScan.Image = global::BookChill.Properties.Resources.qrcode_green;
        }
        #endregion

        #region function to open child form
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion
    }
}
