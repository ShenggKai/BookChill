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
    public partial class CollectionItem : UserControl
    {
        public CollectionItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return pCollection.Image;
            }

            set
            {
                pCollection.Image = value;
            }
        }

        public string ItemLabel
        {
            get
            {
                return txtNameItem.Text;
            }

            set
            {
                txtNameItem.Text = value;
            }
        }

        public System.Drawing.ContentAlignment TextAlign
        {
            get
            {
                return txtNameItem.TextAlign;
            }
            set
            {
                txtNameItem.TextAlign = value;
            }
        }
    }
}
