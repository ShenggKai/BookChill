namespace BookChill.Child_Form
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelHeading = new System.Windows.Forms.Panel();
            this.pClose = new System.Windows.Forms.PictureBox();
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.pArrowright = new System.Windows.Forms.PictureBox();
            this.pArrowleft = new System.Windows.Forms.PictureBox();
            this.pBook = new System.Windows.Forms.PictureBox();
            this.txtNews = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.blogItems1 = new BookChill.BlogItems();
            this.blogItems2 = new BookChill.BlogItems();
            this.blogItems3 = new BookChill.BlogItems();
            this.blogItems4 = new BookChill.BlogItems();
            this.blogItems5 = new BookChill.BlogItems();
            this.blogItems6 = new BookChill.BlogItems();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrowright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrowleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBook)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.Transparent;
            this.panelHeading.BackgroundImage = global::BookChill.Properties.Resources.banner_1;
            this.panelHeading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelHeading.Controls.Add(this.pClose);
            this.panelHeading.Controls.Add(this.pMinimize);
            this.panelHeading.Controls.Add(this.pArrowright);
            this.panelHeading.Controls.Add(this.pArrowleft);
            this.panelHeading.Controls.Add(this.pBook);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1648, 515);
            this.panelHeading.TabIndex = 4;
            // 
            // pClose
            // 
            this.pClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pClose.BackColor = System.Drawing.Color.Transparent;
            this.pClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pClose.Image = global::BookChill.Properties.Resources.close;
            this.pClose.Location = new System.Drawing.Point(1601, 0);
            this.pClose.Name = "pClose";
            this.pClose.Size = new System.Drawing.Size(40, 40);
            this.pClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pClose.TabIndex = 11;
            this.pClose.TabStop = false;
            this.pClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pClose.MouseLeave += new System.EventHandler(this.pClose_MouseLeave);
            this.pClose.MouseHover += new System.EventHandler(this.pClose_MouseHover);
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
            this.pMinimize.TabIndex = 10;
            this.pMinimize.TabStop = false;
            this.pMinimize.Click += new System.EventHandler(this.pMinimize_Click);
            this.pMinimize.MouseLeave += new System.EventHandler(this.pMinimize_MouseLeave);
            this.pMinimize.MouseHover += new System.EventHandler(this.pMinimize_MouseHover);
            // 
            // pArrowright
            // 
            this.pArrowright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pArrowright.BackColor = System.Drawing.Color.Transparent;
            this.pArrowright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pArrowright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pArrowright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pArrowright.Image = global::BookChill.Properties.Resources.angle_right;
            this.pArrowright.Location = new System.Drawing.Point(1600, 243);
            this.pArrowright.Name = "pArrowright";
            this.pArrowright.Size = new System.Drawing.Size(30, 30);
            this.pArrowright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pArrowright.TabIndex = 9;
            this.pArrowright.TabStop = false;
            this.pArrowright.Click += new System.EventHandler(this.pArrowright_Click);
            // 
            // pArrowleft
            // 
            this.pArrowleft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pArrowleft.BackColor = System.Drawing.Color.Transparent;
            this.pArrowleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pArrowleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pArrowleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pArrowleft.Image = global::BookChill.Properties.Resources.angle_left;
            this.pArrowleft.Location = new System.Drawing.Point(10, 243);
            this.pArrowleft.Name = "pArrowleft";
            this.pArrowleft.Size = new System.Drawing.Size(30, 30);
            this.pArrowleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pArrowleft.TabIndex = 8;
            this.pArrowleft.TabStop = false;
            this.pArrowleft.Click += new System.EventHandler(this.pArrowleft_Click);
            // 
            // pBook
            // 
            this.pBook.Image = global::BookChill.Properties.Resources.nhagiakim;
            this.pBook.Location = new System.Drawing.Point(75, 70);
            this.pBook.Name = "pBook";
            this.pBook.Size = new System.Drawing.Size(400, 400);
            this.pBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBook.TabIndex = 5;
            this.pBook.TabStop = false;
            // 
            // txtNews
            // 
            this.txtNews.AutoSize = true;
            this.txtNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNews.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNews.Location = new System.Drawing.Point(0, 515);
            this.txtNews.Name = "txtNews";
            this.txtNews.Padding = new System.Windows.Forms.Padding(10);
            this.txtNews.Size = new System.Drawing.Size(151, 66);
            this.txtNews.TabIndex = 6;
            this.txtNews.Text = "Tin mới";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.blogItems1);
            this.flowLayoutPanel1.Controls.Add(this.blogItems2);
            this.flowLayoutPanel1.Controls.Add(this.blogItems3);
            this.flowLayoutPanel1.Controls.Add(this.blogItems4);
            this.flowLayoutPanel1.Controls.Add(this.blogItems5);
            this.flowLayoutPanel1.Controls.Add(this.blogItems6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 581);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1648, 499);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // blogItems1
            // 
            this.blogItems1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems1.ItemImage = ((System.Drawing.Image)(resources.GetObject("blogItems1.ItemImage")));
            this.blogItems1.ItemLabel = "4 tác phẩm văn học Việt Nam hay cho bạn đọc\r\n";
            this.blogItems1.Location = new System.Drawing.Point(65, 0);
            this.blogItems1.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems1.Name = "blogItems1";
            this.blogItems1.Size = new System.Drawing.Size(437, 222);
            this.blogItems1.TabIndex = 0;
            // 
            // blogItems2
            // 
            this.blogItems2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems2.ItemImage = global::BookChill.Properties.Resources.blog2;
            this.blogItems2.ItemLabel = "Những cuốn sách dành cho tuổi trẻ lạc lối";
            this.blogItems2.Location = new System.Drawing.Point(607, 0);
            this.blogItems2.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems2.Name = "blogItems2";
            this.blogItems2.Size = new System.Drawing.Size(437, 222);
            this.blogItems2.TabIndex = 1;
            // 
            // blogItems3
            // 
            this.blogItems3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems3.ItemImage = global::BookChill.Properties.Resources.blog3;
            this.blogItems3.ItemLabel = "Top Sách Best-Seller Tháng 10-2022";
            this.blogItems3.Location = new System.Drawing.Point(1149, 0);
            this.blogItems3.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems3.Name = "blogItems3";
            this.blogItems3.Size = new System.Drawing.Size(437, 222);
            this.blogItems3.TabIndex = 2;
            // 
            // blogItems4
            // 
            this.blogItems4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems4.ItemImage = global::BookChill.Properties.Resources.blog4;
            this.blogItems4.ItemLabel = "Chọn sách cho con";
            this.blogItems4.Location = new System.Drawing.Point(65, 262);
            this.blogItems4.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems4.Name = "blogItems4";
            this.blogItems4.Size = new System.Drawing.Size(437, 222);
            this.blogItems4.TabIndex = 3;
            // 
            // blogItems5
            // 
            this.blogItems5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems5.ItemImage = global::BookChill.Properties.Resources.blog5;
            this.blogItems5.ItemLabel = "Review sách hay: Đắc nhân tâm";
            this.blogItems5.Location = new System.Drawing.Point(607, 262);
            this.blogItems5.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems5.Name = "blogItems5";
            this.blogItems5.Size = new System.Drawing.Size(437, 222);
            this.blogItems5.TabIndex = 4;
            // 
            // blogItems6
            // 
            this.blogItems6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.blogItems6.ItemImage = global::BookChill.Properties.Resources.blog6;
            this.blogItems6.ItemLabel = "Sách hay giúp chữa lành nỗi đau tâm hồn";
            this.blogItems6.Location = new System.Drawing.Point(1149, 262);
            this.blogItems6.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.blogItems6.Name = "blogItems6";
            this.blogItems6.Size = new System.Drawing.Size(437, 222);
            this.blogItems6.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1080);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNews);
            this.Controls.Add(this.panelHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.HomeForm_SizeChanged);
            this.panelHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrowright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrowleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBook)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeading;
        private PictureBox pBook;
        private PictureBox pArrowleft;
        private PictureBox pArrowright;
        private PictureBox pMinimize;
        private PictureBox pClose;
        private Label txtNews;
        private FlowLayoutPanel flowLayoutPanel1;
        private BlogItems blogItems1;
        private BlogItems blogItems2;
        private BlogItems blogItems3;
        private BlogItems blogItems4;
        private BlogItems blogItems5;
        private BlogItems blogItems6;
        private System.Windows.Forms.Timer timer1;
    }
}