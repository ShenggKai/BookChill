namespace BookChill
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pPass = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Label();
            this.txtExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookChill.Properties.Resources.astronaut;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Cascadia Mono", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.txtName.Location = new System.Drawing.Point(535, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 79);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "BookChill";
            // 
            // pUser
            // 
            this.pUser.Image = global::BookChill.Properties.Resources.user;
            this.pUser.Location = new System.Drawing.Point(496, 201);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(40, 40);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 2;
            this.pUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(563, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 2);
            this.panel1.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(563, 195);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(355, 36);
            this.txtUser.TabIndex = 2;
            // 
            // pPass
            // 
            this.pPass.Image = global::BookChill.Properties.Resources._lock;
            this.pPass.Location = new System.Drawing.Point(496, 309);
            this.pPass.Name = "pPass";
            this.pPass.Size = new System.Drawing.Size(40, 40);
            this.pPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPass.TabIndex = 2;
            this.pPass.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.panel2.Location = new System.Drawing.Point(563, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 2);
            this.panel2.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(563, 303);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(355, 36);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(622, 403);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(180, 57);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtClear
            // 
            this.txtClear.AutoSize = true;
            this.txtClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.txtClear.Location = new System.Drawing.Point(683, 480);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(58, 35);
            this.txtClear.TabIndex = 5;
            this.txtClear.Text = "Xóa";
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // txtExit
            // 
            this.txtExit.AutoSize = true;
            this.txtExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(130)))), ((int)(((byte)(95)))));
            this.txtExit.Location = new System.Drawing.Point(954, 9);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(32, 38);
            this.txtExit.TabIndex = 6;
            this.txtExit.Text = "x";
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookChill";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtName;
        private PictureBox pUser;
        private Panel panel1;
        private TextBox txtUser;
        private PictureBox pPass;
        private Panel panel2;
        private TextBox txtPass;
        private Button btLogin;
        private Label txtClear;
        private Label txtExit;
    }
}