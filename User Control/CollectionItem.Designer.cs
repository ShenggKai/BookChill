namespace BookChill.User_Control
{
    partial class CollectionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionItem));
            this.pCollection = new System.Windows.Forms.PictureBox();
            this.txtNameItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // pCollection
            // 
            this.pCollection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCollection.Image = ((System.Drawing.Image)(resources.GetObject("pCollection.Image")));
            this.pCollection.Location = new System.Drawing.Point(0, 0);
            this.pCollection.Name = "pCollection";
            this.pCollection.Size = new System.Drawing.Size(330, 290);
            this.pCollection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCollection.TabIndex = 0;
            this.pCollection.TabStop = false;
            // 
            // txtNameItem
            // 
            this.txtNameItem.AutoSize = true;
            this.txtNameItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameItem.ForeColor = System.Drawing.Color.White;
            this.txtNameItem.Location = new System.Drawing.Point(44, 293);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(245, 31);
            this.txtNameItem.TabIndex = 1;
            this.txtNameItem.Text = "Điện ảnh - Nhạc - Họa";
            // 
            // CollectionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(160)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.pCollection);
            this.Margin = new System.Windows.Forms.Padding(50, 40, 20, 30);
            this.Name = "CollectionItem";
            this.Size = new System.Drawing.Size(330, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pCollection;
        private Label txtNameItem;
    }
}
