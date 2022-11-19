namespace BookChill.Child_Form
{
    partial class ScanerForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pCLose = new System.Windows.Forms.PictureBox();
            this.txtNameChildForm = new System.Windows.Forms.Label();
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pCLose);
            this.panelHeader.Controls.Add(this.txtNameChildForm);
            this.panelHeader.Controls.Add(this.pMinimize);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1648, 84);
            this.panelHeader.TabIndex = 10;
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
            // 
            // txtNameChildForm
            // 
            this.txtNameChildForm.AutoSize = true;
            this.txtNameChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameChildForm.Location = new System.Drawing.Point(65, 10);
            this.txtNameChildForm.Name = "txtNameChildForm";
            this.txtNameChildForm.Size = new System.Drawing.Size(276, 54);
            this.txtNameChildForm.TabIndex = 1;
            this.txtNameChildForm.Text = "Quét QR code";
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BookChill.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(4497, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(4431, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // ScanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1080);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanerForm";
            this.Text = "ScanerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private PictureBox pCLose;
        private Label txtNameChildForm;
        private PictureBox pMinimize;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}