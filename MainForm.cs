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
    public partial class MainForm : Form
    {
        private Form currentChildForm;

        public MainForm()
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
            OpenChildForm(new CollectionForm());
            showSubMenu(panelSubMenuColec);
        }

        private void btnVanhoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VanHoc());
            hideSubMenu();
        }

        private void btnTuduy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TdKn());
            hideSubMenu();
        }

        private void btnNgoaingu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NgoaiNgu());
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
