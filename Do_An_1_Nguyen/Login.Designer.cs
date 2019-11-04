namespace Do_An_1
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBShowPass = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnĐangNhap = new System.Windows.Forms.Button();
            this.rdBUserTeacher = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBAdmin = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rdBShowPass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnĐangNhap);
            this.panel1.Controls.Add(this.rdBUserTeacher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdBAdmin);
            this.panel1.Location = new System.Drawing.Point(82, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 443);
            this.panel1.TabIndex = 13;
            // 
            // rdBShowPass
            // 
            this.rdBShowPass.AutoSize = true;
            this.rdBShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBShowPass.Location = new System.Drawing.Point(395, 223);
            this.rdBShowPass.Name = "rdBShowPass";
            this.rdBShowPass.Size = new System.Drawing.Size(121, 28);
            this.rdBShowPass.TabIndex = 14;
            this.rdBShowPass.TabStop = true;
            this.rdBShowPass.Text = "Show Pass";
            this.rdBShowPass.UseVisualStyleBackColor = true;
            this.rdBShowPass.CheckedChanged += new System.EventHandler(this.rdBShowPass_CheckedChanged);
            this.rdBShowPass.Click += new System.EventHandler(this.rdBShowPass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(42, 213);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(347, 52);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnExit.Image = global::Do_An_1.Properties.Resources.User_logout_man_profile_account_x67;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(294, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 73);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "      Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(42, 75);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(474, 52);
            this.txtUser.TabIndex = 9;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseDown);
            // 
            // btnĐangNhap
            // 
            this.btnĐangNhap.BackColor = System.Drawing.Color.SkyBlue;
            this.btnĐangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnĐangNhap.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnĐangNhap.Image = global::Do_An_1.Properties.Resources.user_login_man_256_x67;
            this.btnĐangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnĐangNhap.Location = new System.Drawing.Point(15, 342);
            this.btnĐangNhap.Name = "btnĐangNhap";
            this.btnĐangNhap.Size = new System.Drawing.Size(226, 73);
            this.btnĐangNhap.TabIndex = 11;
            this.btnĐangNhap.Text = "     Login";
            this.btnĐangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnĐangNhap.UseVisualStyleBackColor = false;
            // 
            // rdBUserTeacher
            // 
            this.rdBUserTeacher.AutoSize = true;
            this.rdBUserTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBUserTeacher.Location = new System.Drawing.Point(309, 292);
            this.rdBUserTeacher.Name = "rdBUserTeacher";
            this.rdBUserTeacher.Size = new System.Drawing.Size(109, 29);
            this.rdBUserTeacher.TabIndex = 12;
            this.rdBUserTeacher.TabStop = true;
            this.rdBUserTeacher.Text = "Teacher";
            this.rdBUserTeacher.UseVisualStyleBackColor = true;
            this.rdBUserTeacher.Click += new System.EventHandler(this.rdBUserTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "User :";
            // 
            // rdBAdmin
            // 
            this.rdBAdmin.AutoSize = true;
            this.rdBAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBAdmin.Location = new System.Drawing.Point(128, 292);
            this.rdBAdmin.Name = "rdBAdmin";
            this.rdBAdmin.Size = new System.Drawing.Size(90, 29);
            this.rdBAdmin.TabIndex = 10;
            this.rdBAdmin.TabStop = true;
            this.rdBAdmin.Text = "Admin";
            this.rdBAdmin.UseVisualStyleBackColor = true;
            this.rdBAdmin.Click += new System.EventHandler(this.rdBAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Do_An_1.Properties.Resources.user_male_circle_120px;
            this.pictureBox1.Location = new System.Drawing.Point(290, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Do_An_1.Properties.Resources.Capture_;
            this.ClientSize = new System.Drawing.Size(695, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnĐangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton rdBUserTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdBShowPass;
    }
}