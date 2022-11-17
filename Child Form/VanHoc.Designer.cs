namespace BookChill.Child_Form
{
    partial class VanHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VanHoc));
            this.txtNameChildForm = new System.Windows.Forms.Label();
            this.pCLose = new System.Windows.Forms.PictureBox();
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pCart = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.btnSearch = new BookChill.User_Control.RoundButton();
            this.cbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameChildForm
            // 
            this.txtNameChildForm.AutoSize = true;
            this.txtNameChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameChildForm.Location = new System.Drawing.Point(65, 10);
            this.txtNameChildForm.Name = "txtNameChildForm";
            this.txtNameChildForm.Size = new System.Drawing.Size(167, 54);
            this.txtNameChildForm.TabIndex = 1;
            this.txtNameChildForm.Text = "Văn học";
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
            this.pCLose.TabIndex = 5;
            this.pCLose.TabStop = false;
            this.pCLose.Click += new System.EventHandler(this.pClose_Click);
            this.pCLose.MouseLeave += new System.EventHandler(this.pCLose_MouseLeave);
            this.pCLose.MouseHover += new System.EventHandler(this.pCLose_MouseHover);
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
            this.pMinimize.TabIndex = 6;
            this.pMinimize.TabStop = false;
            this.pMinimize.Click += new System.EventHandler(this.pMinimize_Click);
            this.pMinimize.MouseLeave += new System.EventHandler(this.pMinimize_MouseLeave);
            this.pMinimize.MouseHover += new System.EventHandler(this.pMinimize_MouseHover);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pCart);
            this.panelHeader.Controls.Add(this.txtNameChildForm);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Controls.Add(this.pUser);
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.pCLose);
            this.panelHeader.Controls.Add(this.pMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1648, 84);
            this.panelHeader.TabIndex = 8;
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
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.cbSort.DropDownWidth = 3;
            this.cbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSort.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSort.ForeColor = System.Drawing.Color.White;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbSort.ItemHeight = 41;
            this.cbSort.Items.AddRange(new object[] {
            "Sách mới xuất bản",
            "Sách được yêu thích",
            "Sách bán chạy",
            ""});
            this.cbSort.Location = new System.Drawing.Point(65, 113);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(304, 49);
            this.cbSort.TabIndex = 9;
            this.cbSort.Text = "Sắp xếp theo";
            // 
            // VanHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1648, 509);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VanHoc";
            this.Text = "Văn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label txtNameChildForm;
        private PictureBox pCLose;
        private PictureBox pMinimize;
        private Panel panelHeader;
        private User_Control.RoundButton btnSearch;
        private PictureBox pUser;
        private TextBox textBox1;
        private PictureBox pCart;
        private ComboBox cbSort;
    }
}