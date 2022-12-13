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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pCLose = new System.Windows.Forms.PictureBox();
            this.txtNameChildForm = new System.Windows.Forms.Label();
            this.pMinimize = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pCLose);
            this.panelHeader.Controls.Add(this.txtNameChildForm);
            this.panelHeader.Controls.Add(this.pMinimize);
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
            this.pCLose.Click += new System.EventHandler(this.pClose_Click);
            this.pCLose.MouseLeave += new System.EventHandler(this.pCLose_MouseHover);
            this.pCLose.MouseHover += new System.EventHandler(this.pCLose_MouseHover);
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
            this.pMinimize.Click += new System.EventHandler(this.pMinimize_Click);
            this.pMinimize.MouseLeave += new System.EventHandler(this.pMinimize_MouseLeave);
            this.pMinimize.MouseHover += new System.EventHandler(this.pMinimize_MouseHover);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(856, 276);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(497, 469);
            this.txtQRCode.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(122, 276);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(577, 506);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(377, 150);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(322, 45);
            this.cboDevice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(868, 152);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 1080);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanerForm";
            this.Text = "ScanerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanerForm_FormClosing);
            this.Load += new System.EventHandler(this.ScanerForm_Load);
            this.SizeChanged += new System.EventHandler(this.ScanerForm_SizeChanged);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private PictureBox pCLose;
        private Label txtNameChildForm;
        private PictureBox pMinimize;
        private Button btnStart;
        private Label label1;
        private ComboBox cboDevice;
        private PictureBox pictureBox;
        private TextBox txtQRCode;
        private System.Windows.Forms.Timer timer1;
    }
}