namespace BookChill.User_Control
{
    partial class BookItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookItem));
            this.pBook = new System.Windows.Forms.PictureBox();
            this.txtNameBook = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.pStar = new System.Windows.Forms.PictureBox();
            this.txtRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBook
            // 
            this.pBook.Image = ((System.Drawing.Image)(resources.GetObject("pBook.Image")));
            this.pBook.Location = new System.Drawing.Point(25, 0);
            this.pBook.Name = "pBook";
            this.pBook.Size = new System.Drawing.Size(200, 200);
            this.pBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBook.TabIndex = 0;
            this.pBook.TabStop = false;
            // 
            // txtNameBook
            // 
            this.txtNameBook.AllowDrop = true;
            this.txtNameBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameBook.ForeColor = System.Drawing.Color.White;
            this.txtNameBook.Location = new System.Drawing.Point(3, 203);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(243, 104);
            this.txtNameBook.TabIndex = 1;
            this.txtNameBook.Text = "Doraemon Movie Story: Nobita Và Hòn Đảo Diệu Kì - Cuộc Phiêu Lưu Của Loài Thú";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.txtPrice.Location = new System.Drawing.Point(108, 314);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 38);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "188.000 đ";
            // 
            // pStar
            // 
            this.pStar.Image = global::BookChill.Properties.Resources.star;
            this.pStar.Location = new System.Drawing.Point(12, 321);
            this.pStar.Name = "pStar";
            this.pStar.Size = new System.Drawing.Size(30, 30);
            this.pStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pStar.TabIndex = 3;
            this.pStar.TabStop = false;
            // 
            // txtRating
            // 
            this.txtRating.AutoSize = true;
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRating.Location = new System.Drawing.Point(48, 321);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(36, 25);
            this.txtRating.TabIndex = 4;
            this.txtRating.Text = "4.5";
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.pStar);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.pBook);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(249, 365);
            ((System.ComponentModel.ISupportInitialize)(this.pBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBook;
        private Label txtNameBook;
        private Label txtPrice;
        private PictureBox pStar;
        private Label txtRating;
    }
}
