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
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            "Sách bán chạy",
            "Sách được yêu thích",
            "Sách mới xuất bản"});
            this.cbSort.Location = new System.Drawing.Point(65, 39);
            this.cbSort.MaxDropDownItems = 5;
            this.cbSort.Name = "cbSort";
            this.cbSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSort.Size = new System.Drawing.Size(304, 49);
            this.cbSort.Sorted = true;
            this.cbSort.TabIndex = 9;
            this.cbSort.Text = "Sắp xếp theo";
            // 
            // VanHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1648, 996);
            this.Controls.Add(this.cbSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VanHoc";
            this.Text = "Văn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox cbSort;
    }
}