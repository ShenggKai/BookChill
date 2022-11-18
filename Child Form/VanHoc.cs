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
    public partial class VanHoc : Form
    {
        public VanHoc()
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
        #endregion
    }
}
