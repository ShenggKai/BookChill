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
    public partial class BookChill : Form
    {
        public BookChill()
        {
            InitializeComponent();
            panelSubMenuColec.Visible = false;
            panelSubMenuSca.Visible = false;
        }

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
            pCLose.BackColor = Color.LightGray;
        }

        private void pCLose_MouseLeave(object sender, EventArgs e)
        {
            pCLose.BackColor = Color.Transparent;
        }

        private void pMinimize_MouseHover(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.LightGray;
        }

        private void pMinimize_MouseLeave(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.Transparent;
        }
    }
}
