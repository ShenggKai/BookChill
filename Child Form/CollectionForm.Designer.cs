namespace BookChill.Child_Form
{
    partial class CollectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionForm));
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.pCLose = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pCart = new System.Windows.Forms.PictureBox();
            this.txtNameChildForm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.btnSearch = new BookChill.User_Control.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fpanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.collectionItem1 = new BookChill.User_Control.CollectionItem();
            this.collectionItem2 = new BookChill.User_Control.CollectionItem();
            this.collectionItem3 = new BookChill.User_Control.CollectionItem();
            this.collectionItem4 = new BookChill.User_Control.CollectionItem();
            this.collectionItem5 = new BookChill.User_Control.CollectionItem();
            this.collectionItem6 = new BookChill.User_Control.CollectionItem();
            this.collectionItem7 = new BookChill.User_Control.CollectionItem();
            this.collectionItem8 = new BookChill.User_Control.CollectionItem();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fpanelBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMinimize
            // 
            this.pMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pMinimize.Image = global::BookChill.Properties.Resources.minimize;
            this.pMinimize.Location = new System.Drawing.Point(1535, 0);
            this.pMinimize.Name = "pMinimize";
            this.pMinimize.Size = new System.Drawing.Size(40, 40);
            this.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pMinimize.TabIndex = 7;
            this.pMinimize.TabStop = false;
            this.pMinimize.Click += new System.EventHandler(this.pMinimize_Click);
            this.pMinimize.MouseLeave += new System.EventHandler(this.pMinimize_MouseLeave);
            this.pMinimize.MouseHover += new System.EventHandler(this.pMinimize_MouseHover);
            // 
            // pCLose
            // 
            this.pCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCLose.BackColor = System.Drawing.Color.Transparent;
            this.pCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCLose.Image = global::BookChill.Properties.Resources.close;
            this.pCLose.Location = new System.Drawing.Point(1601, 0);
            this.pCLose.Name = "pCLose";
            this.pCLose.Size = new System.Drawing.Size(40, 40);
            this.pCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pCLose.TabIndex = 8;
            this.pCLose.TabStop = false;
            this.pCLose.Click += new System.EventHandler(this.pClose_Click);
            this.pCLose.MouseLeave += new System.EventHandler(this.pCLose_MouseLeave);
            this.pCLose.MouseHover += new System.EventHandler(this.pCLose_MouseHover);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pCart);
            this.panelHeader.Controls.Add(this.pCLose);
            this.panelHeader.Controls.Add(this.txtNameChildForm);
            this.panelHeader.Controls.Add(this.pMinimize);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Controls.Add(this.pUser);
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1648, 84);
            this.panelHeader.TabIndex = 9;
            // 
            // pCart
            // 
            this.pCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCart.Image = ((System.Drawing.Image)(resources.GetObject("pCart.Image")));
            this.pCart.Location = new System.Drawing.Point(1164, 10);
            this.pCart.Name = "pCart";
            this.pCart.Size = new System.Drawing.Size(50, 50);
            this.pCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pCart.TabIndex = 10;
            this.pCart.TabStop = false;
            // 
            // txtNameChildForm
            // 
            this.txtNameChildForm.AutoSize = true;
            this.txtNameChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameChildForm.Location = new System.Drawing.Point(65, 10);
            this.txtNameChildForm.Name = "txtNameChildForm";
            this.txtNameChildForm.Size = new System.Drawing.Size(207, 54);
            this.txtNameChildForm.TabIndex = 1;
            this.txtNameChildForm.Text = "Danh mục";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(378, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(614, 34);
            this.textBox1.TabIndex = 9;
            // 
            // pUser
            // 
            this.pUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUser.Image = ((System.Drawing.Image)(resources.GetObject("pUser.Image")));
            this.pUser.Location = new System.Drawing.Point(1322, 10);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(50, 50);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 9;
            this.pUser.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 28;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(347, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 10, 15, 10);
            this.btnSearch.Size = new System.Drawing.Size(709, 54);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BookChill.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(3049, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BookChill.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(2983, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // fpanelBooks
            // 
            this.fpanelBooks.BackColor = System.Drawing.Color.Transparent;
            this.fpanelBooks.Controls.Add(this.collectionItem1);
            this.fpanelBooks.Controls.Add(this.collectionItem2);
            this.fpanelBooks.Controls.Add(this.collectionItem3);
            this.fpanelBooks.Controls.Add(this.collectionItem4);
            this.fpanelBooks.Controls.Add(this.collectionItem5);
            this.fpanelBooks.Controls.Add(this.collectionItem6);
            this.fpanelBooks.Controls.Add(this.collectionItem7);
            this.fpanelBooks.Controls.Add(this.collectionItem8);
            this.fpanelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpanelBooks.Location = new System.Drawing.Point(0, 84);
            this.fpanelBooks.Name = "fpanelBooks";
            this.fpanelBooks.Size = new System.Drawing.Size(1648, 996);
            this.fpanelBooks.TabIndex = 10;
            // 
            // collectionItem1
            // 
            this.collectionItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem1.ItemImage = global::BookChill.Properties.Resources.vh;
            this.collectionItem1.ItemLabel = "            Văn học";
            this.collectionItem1.Location = new System.Drawing.Point(50, 40);
            this.collectionItem1.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem1.Name = "collectionItem1";
            this.collectionItem1.Size = new System.Drawing.Size(330, 330);
            this.collectionItem1.TabIndex = 0;
            this.collectionItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collectionItem2
            // 
            this.collectionItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem2.ItemImage = global::BookChill.Properties.Resources.td;
            this.collectionItem2.ItemLabel = "Tư duy - Kỹ năng sống";
            this.collectionItem2.Location = new System.Drawing.Point(450, 40);
            this.collectionItem2.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem2.Name = "collectionItem2";
            this.collectionItem2.Size = new System.Drawing.Size(330, 330);
            this.collectionItem2.TabIndex = 1;
            this.collectionItem2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem3
            // 
            this.collectionItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem3.ItemImage = global::BookChill.Properties.Resources.nn;
            this.collectionItem3.ItemLabel = "      Học ngoại ngữ";
            this.collectionItem3.Location = new System.Drawing.Point(850, 40);
            this.collectionItem3.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem3.Name = "collectionItem3";
            this.collectionItem3.Size = new System.Drawing.Size(330, 330);
            this.collectionItem3.TabIndex = 2;
            this.collectionItem3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem4
            // 
            this.collectionItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem4.ItemImage = global::BookChill.Properties.Resources.tn;
            this.collectionItem4.ItemLabel = "        Sách thiếu nhi";
            this.collectionItem4.Location = new System.Drawing.Point(1250, 40);
            this.collectionItem4.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem4.Name = "collectionItem4";
            this.collectionItem4.Size = new System.Drawing.Size(330, 330);
            this.collectionItem4.TabIndex = 3;
            this.collectionItem4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem5
            // 
            this.collectionItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem5.ItemImage = global::BookChill.Properties.Resources.tt;
            this.collectionItem5.ItemLabel = "       Truyện tranh";
            this.collectionItem5.Location = new System.Drawing.Point(50, 440);
            this.collectionItem5.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem5.Name = "collectionItem5";
            this.collectionItem5.Size = new System.Drawing.Size(330, 330);
            this.collectionItem5.TabIndex = 4;
            this.collectionItem5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem6
            // 
            this.collectionItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem6.ItemImage = global::BookChill.Properties.Resources.kh;
            this.collectionItem6.ItemLabel = "   Khoa học - Kỹ thuật";
            this.collectionItem6.Location = new System.Drawing.Point(450, 440);
            this.collectionItem6.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem6.Name = "collectionItem6";
            this.collectionItem6.Size = new System.Drawing.Size(330, 330);
            this.collectionItem6.TabIndex = 5;
            this.collectionItem6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem7
            // 
            this.collectionItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem7.ItemImage = global::BookChill.Properties.Resources.dnh;
            this.collectionItem7.ItemLabel = "Điện ảnh - Nhạc - Họa";
            this.collectionItem7.Location = new System.Drawing.Point(850, 440);
            this.collectionItem7.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem7.Name = "collectionItem7";
            this.collectionItem7.Size = new System.Drawing.Size(330, 330);
            this.collectionItem7.TabIndex = 6;
            this.collectionItem7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // collectionItem8
            // 
            this.collectionItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.collectionItem8.ItemImage = global::BookChill.Properties.Resources.tudien;
            this.collectionItem8.ItemLabel = "             Từ điển";
            this.collectionItem8.Location = new System.Drawing.Point(1250, 440);
            this.collectionItem8.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.collectionItem8.Name = "collectionItem8";
            this.collectionItem8.Size = new System.Drawing.Size(330, 330);
            this.collectionItem8.TabIndex = 7;
            this.collectionItem8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1080);
            this.Controls.Add(this.fpanelBooks);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CollectionForm";
            this.Text = "CollectionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.CollectionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fpanelBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pMinimize;
        private PictureBox pCLose;
        private Panel panelHeader;
        private PictureBox pCart;
        private Label txtNameChildForm;
        private TextBox textBox1;
        private PictureBox pUser;
        private User_Control.RoundButton btnSearch;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel fpanelBooks;
        private User_Control.CollectionItem collectionItem1;
        private User_Control.CollectionItem collectionItem2;
        private User_Control.CollectionItem collectionItem3;
        private User_Control.CollectionItem collectionItem4;
        private User_Control.CollectionItem collectionItem5;
        private User_Control.CollectionItem collectionItem6;
        private User_Control.CollectionItem collectionItem7;
        private User_Control.CollectionItem collectionItem8;
    }
}