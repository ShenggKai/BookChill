using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookChill
{
    public partial class BookItems : UserControl
    {
        public BookItems()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return pBlog.Image;
            }
            
            set
            {
                pBlog.Image = value;
            }
        }

        public string ItemLabel
        {
            get
            {
                return txtTitle.Text;
            }

            set
            {
                txtTitle.Text = value;
            }
        }
    }
}
