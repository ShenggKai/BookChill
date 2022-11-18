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
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.fpanelBooks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fpanelBooks.Location = new System.Drawing.Point(0, 84);
            this.fpanelBooks.Name = "fpanelBooks";
            this.fpanelBooks.Size = new System.Drawing.Size(1648, 500);
            this.fpanelBooks.TabIndex = 10;
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
    }
}