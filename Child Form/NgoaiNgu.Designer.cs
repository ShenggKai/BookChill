namespace BookChill.Child_Form
{
    partial class NgoaiNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NgoaiNgu));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pCLose = new System.Windows.Forms.PictureBox();
            this.txtNameChildForm = new System.Windows.Forms.Label();
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookItem4 = new BookChill.User_Control.BookItem();
            this.bookItem5 = new BookChill.User_Control.BookItem();
            this.bookItem6 = new BookChill.User_Control.BookItem();
            this.bookItem7 = new BookChill.User_Control.BookItem();
            this.bookItem8 = new BookChill.User_Control.BookItem();
            this.bookItem9 = new BookChill.User_Control.BookItem();
            this.bookItem10 = new BookChill.User_Control.BookItem();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pCLose);
            this.panelHeader.Controls.Add(this.txtNameChildForm);
            this.panelHeader.Controls.Add(this.pMinimize);
            this.panelHeader.Controls.Add(this.cbSort);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1648, 84);
            this.panelHeader.TabIndex = 14;
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
            this.pCLose.TabIndex = 11;
            this.pCLose.TabStop = false;
            this.pCLose.Click += new System.EventHandler(this.pClose_Click);
            this.pCLose.MouseLeave += new System.EventHandler(this.pCLose_MouseLeave);
            this.pCLose.MouseHover += new System.EventHandler(this.pCLose_MouseHover);
            // 
            // txtNameChildForm
            // 
            this.txtNameChildForm.AutoSize = true;
            this.txtNameChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameChildForm.Location = new System.Drawing.Point(65, 10);
            this.txtNameChildForm.Name = "txtNameChildForm";
            this.txtNameChildForm.Size = new System.Drawing.Size(216, 54);
            this.txtNameChildForm.TabIndex = 1;
            this.txtNameChildForm.Text = "Ngoại ngữ";
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
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.cbSort.DropDownWidth = 3;
            this.cbSort.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSort.ForeColor = System.Drawing.Color.White;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbSort.ItemHeight = 41;
            this.cbSort.Items.AddRange(new object[] {
            "Giá từ cao đến thấp",
            "Giá từ thấp đến cao",
            "Sách được yêu thích",
            "Sách mới xuất bản"});
            this.cbSort.Location = new System.Drawing.Point(590, 17);
            this.cbSort.MaxDropDownItems = 5;
            this.cbSort.Name = "cbSort";
            this.cbSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSort.Size = new System.Drawing.Size(304, 49);
            this.cbSort.Sorted = true;
            this.cbSort.TabIndex = 9;
            this.cbSort.Text = "Sắp xếp theo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bookItem4);
            this.flowLayoutPanel1.Controls.Add(this.bookItem5);
            this.flowLayoutPanel1.Controls.Add(this.bookItem6);
            this.flowLayoutPanel1.Controls.Add(this.bookItem7);
            this.flowLayoutPanel1.Controls.Add(this.bookItem8);
            this.flowLayoutPanel1.Controls.Add(this.bookItem9);
            this.flowLayoutPanel1.Controls.Add(this.bookItem10);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 20, 20, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1648, 912);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // bookItem4
            // 
            this.bookItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem4.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem4.BookImage")));
            this.bookItem4.BookName = "    Giáo Trình Chuẩn HSK 1";
            this.bookItem4.Location = new System.Drawing.Point(70, 50);
            this.bookItem4.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem4.Name = "bookItem4";
            this.bookItem4.Price = "158.000 đ";
            this.bookItem4.Rating = "4.8";
            this.bookItem4.Size = new System.Drawing.Size(249, 365);
            this.bookItem4.TabIndex = 3;
            // 
            // bookItem5
            // 
            this.bookItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem5.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem5.BookImage")));
            this.bookItem5.BookName = "Tomato Toeic Speaking Flow";
            this.bookItem5.Location = new System.Drawing.Point(379, 50);
            this.bookItem5.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem5.Name = "bookItem5";
            this.bookItem5.Price = "238.000 đ";
            this.bookItem5.Rating = "4.8";
            this.bookItem5.Size = new System.Drawing.Size(249, 365);
            this.bookItem5.TabIndex = 4;
            // 
            // bookItem6
            // 
            this.bookItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem6.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem6.BookImage")));
            this.bookItem6.BookName = "Tự Học 2000 Từ Vựng Tiếng Anh Theo Chủ Đề";
            this.bookItem6.Location = new System.Drawing.Point(688, 50);
            this.bookItem6.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem6.Name = "bookItem6";
            this.bookItem6.Price = "65.000 đ";
            this.bookItem6.Rating = "4.2";
            this.bookItem6.Size = new System.Drawing.Size(249, 365);
            this.bookItem6.TabIndex = 5;
            // 
            // bookItem7
            // 
            this.bookItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem7.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem7.BookImage")));
            this.bookItem7.BookName = "Tập Viết Chữ Hán Cho Người Mới Bắt Đầu";
            this.bookItem7.Location = new System.Drawing.Point(997, 50);
            this.bookItem7.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem7.Name = "bookItem7";
            this.bookItem7.Price = "89.000 đ";
            this.bookItem7.Rating = "4.9";
            this.bookItem7.Size = new System.Drawing.Size(249, 365);
            this.bookItem7.TabIndex = 6;
            // 
            // bookItem8
            // 
            this.bookItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem8.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem8.BookImage")));
            this.bookItem8.BookName = "Barron\'s Essential Words For The Ielts";
            this.bookItem8.Location = new System.Drawing.Point(1306, 50);
            this.bookItem8.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem8.Name = "bookItem8";
            this.bookItem8.Price = "157.000 đ";
            this.bookItem8.Rating = "4.7";
            this.bookItem8.Size = new System.Drawing.Size(249, 365);
            this.bookItem8.TabIndex = 7;
            // 
            // bookItem9
            // 
            this.bookItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem9.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem9.BookImage")));
            this.bookItem9.BookName = "Luyện Nói Tiếng Trung Quốc Cấp Tốc Cho Người Bắt Đầu";
            this.bookItem9.Location = new System.Drawing.Point(70, 475);
            this.bookItem9.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem9.Name = "bookItem9";
            this.bookItem9.Price = "168.000 đ";
            this.bookItem9.Rating = "5";
            this.bookItem9.Size = new System.Drawing.Size(249, 365);
            this.bookItem9.TabIndex = 8;
            // 
            // bookItem10
            // 
            this.bookItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.bookItem10.BookImage = ((System.Drawing.Image)(resources.GetObject("bookItem10.BookImage")));
            this.bookItem10.BookName = "Giải Thích Ngữ Pháp Tiếng Anh (Với Bài Tập Và Đáp Án)";
            this.bookItem10.Location = new System.Drawing.Point(379, 475);
            this.bookItem10.Margin = new System.Windows.Forms.Padding(30);
            this.bookItem10.Name = "bookItem10";
            this.bookItem10.Price = "220.000 đ";
            this.bookItem10.Rating = "4.9";
            this.bookItem10.Size = new System.Drawing.Size(249, 365);
            this.bookItem10.TabIndex = 9;
            // 
            // NgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 996);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NgoaiNgu";
            this.Text = "Ngoại ngữ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.NgoaiNgu_SizeChanged);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private PictureBox pCLose;
        private Label txtNameChildForm;
        private PictureBox pMinimize;
        private ComboBox cbSort;
        private FlowLayoutPanel flowLayoutPanel1;
        private User_Control.BookItem bookItem4;
        private User_Control.BookItem bookItem5;
        private User_Control.BookItem bookItem6;
        private User_Control.BookItem bookItem7;
        private User_Control.BookItem bookItem8;
        private User_Control.BookItem bookItem9;
        private User_Control.BookItem bookItem10;
    }
}