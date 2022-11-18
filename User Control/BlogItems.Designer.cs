namespace BookChill
{
    partial class BlogItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBlog = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBlog)).BeginInit();
            this.SuspendLayout();
            // 
            // pBlog
            // 
            this.pBlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBlog.Image = global::BookChill.Properties.Resources.blog1;
            this.pBlog.Location = new System.Drawing.Point(0, 0);
            this.pBlog.Name = "pBlog";
            this.pBlog.Size = new System.Drawing.Size(437, 169);
            this.pBlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBlog.TabIndex = 0;
            this.pBlog.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(0, 169);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(417, 28);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "4 tác phẩm văn học Việt Nam hay cho bạn đọc\r\n";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlogItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pBlog);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(65, 0, 40, 40);
            this.Name = "BlogItems";
            this.Size = new System.Drawing.Size(437, 222);
            ((System.ComponentModel.ISupportInitialize)(this.pBlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBlog;
        private Label txtTitle;
    }
}
