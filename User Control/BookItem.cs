using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookChill.User_Control
{
    public partial class BookItem : UserControl
    {
        public BookItem()
        {
            InitializeComponent();
        }

        public Image BookImage
        {
            get
            {
                return pBook.Image;
            }

            set
            {
                pBook.Image = value;
            }
        }

        public string BookName
        {
            get
            {
                return txtNameBook.Text;
            }

            set
            {
                txtNameBook.Text = value;
            }
        }

        public string Rating
        {
            get 
            { 
                return txtRating.Text; 
            }

            set 
            { 
                txtRating.Text = value; 
            }
        }

        public string Price
        {
            get 
            {
                return txtPrice.Text;
            }
            set
            {
                txtPrice.Text = value;
            }
        }
    }
}
