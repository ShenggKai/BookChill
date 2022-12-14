using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Configuration;

namespace BookChill
{
    public partial class BlogItems : UserControl
    {
        public BlogItems()
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

        public System.Drawing.ContentAlignment TextAlign
        {
            get 
            {
                return txtTitle.TextAlign;
            }
            set 
            {
                txtTitle.TextAlign = value;
            }
        }
    }
}
