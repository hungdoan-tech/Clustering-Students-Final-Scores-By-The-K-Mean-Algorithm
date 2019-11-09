namespace Do_An_1
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroProgressBarLogin = new MetroFramework.Controls.MetroProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBShowPass = new System.Windows.Forms.RadioButton();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.rbtn_Professor = new System.Windows.Forms.RadioButton();
            this.label_Account = new System.Windows.Forms.Label();
            this.rbtn_Admin = new System.Windows.Forms.RadioButton();
            this.timerProgcessBar = new System.Windows.Forms.Timer(this.components);
            this.timerAuthentication = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroProgressBarLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdBShowPass);
            this.panel1.Controls.Add(this.txb_Password);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txb_Account);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.rbtn_Professor);
            this.panel1.Controls.Add(this.label_Account);
            this.panel1.Controls.Add(this.rbtn_Admin);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 608);
            this.panel1.TabIndex = 22;
            // 
            // metroProgressBarLogin
            // 
            this.metroProgressBarLogin.Cursor = System.Windows.Forms.Cursors.No;
            this.metroProgressBarLogin.Location = new System.Drawing.Point(104, 547);
            this.metroProgressBarLogin.Name = "metroProgressBarLogin";
            this.metroProgressBarLogin.Size = new System.Drawing.Size(321, 45);
            this.metroProgressBarLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Waiting.....";
            // 
            // rdBShowPass
            // 
            this.rdBShowPass.AutoSize = true;
            this.rdBShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBShowPass.Location = new System.Drawing.Point(393, 263);
            this.rdBShowPass.Name = "rdBShowPass";
            this.rdBShowPass.Size = new System.Drawing.Size(121, 28);
            this.rdBShowPass.TabIndex = 14;
            this.rdBShowPass.TabStop = true;
            this.rdBShowPass.Text = "Show Pass";
            this.rdBShowPass.UseVisualStyleBackColor = true;
            this.rdBShowPass.Click += new System.EventHandler(this.rdBShowPass_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password.Location = new System.Drawing.Point(40, 304);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(424, 52);
            this.txb_Password.TabIndex = 13;
            this.txb_Password.TextChanged += new System.EventHandler(this.txb_Password_TextChanged);
            this.txb_Password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txb_Password_MouseDown);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(34, 257);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(149, 31);
            this.label_Password.TabIndex = 11;
            this.label_Password.Text = "Password :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Image = global::Do_An_1.Properties.Resources.User_logout_man_profile_account_x67;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(292, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 73);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "      Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txb_Account
            // 
            this.txb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Account.Location = new System.Drawing.Point(40, 166);
            this.txb_Account.Multiline = true;
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(424, 52);
            this.txb_Account.TabIndex = 9;
            this.txb_Account.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txb_Account_MouseDown);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Login.Image = global::Do_An_1.Properties.Resources.user_login_man_256_x67;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(13, 433);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(226, 73);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "     Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // rbtn_Professor
            // 
            this.rbtn_Professor.AutoSize = true;
            this.rbtn_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Professor.Location = new System.Drawing.Point(307, 383);
            this.rbtn_Professor.Name = "rbtn_Professor";
            this.rbtn_Professor.Size = new System.Drawing.Size(109, 29);
            this.rbtn_Professor.TabIndex = 12;
            this.rbtn_Professor.TabStop = true;
            this.rbtn_Professor.Text = "Teacher";
            this.rbtn_Professor.UseVisualStyleBackColor = true;
            this.rbtn_Professor.Click += new System.EventHandler(this.rbtn_Professor_Click);
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Account.Location = new System.Drawing.Point(34, 119);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(87, 31);
            this.label_Account.TabIndex = 8;
            this.label_Account.Text = "User :";
            // 
            // rbtn_Admin
            // 
            this.rbtn_Admin.AutoSize = true;
            this.rbtn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Admin.Location = new System.Drawing.Point(126, 383);
            this.rbtn_Admin.Name = "rbtn_Admin";
            this.rbtn_Admin.Size = new System.Drawing.Size(90, 29);
            this.rbtn_Admin.TabIndex = 10;
            this.rbtn_Admin.TabStop = true;
            this.rbtn_Admin.Text = "Admin";
            this.rbtn_Admin.UseVisualStyleBackColor = true;
            this.rbtn_Admin.Click += new System.EventHandler(this.rbtn_Admin_Click);
            // 
            // timerProgcessBar
            // 
            this.timerProgcessBar.Interval = 2500;
            this.timerProgcessBar.Tick += new System.EventHandler(this.timerProgcessBar_Tick);
            // 
            // timerAuthentication
            // 
            this.timerAuthentication.Interval = 2500;
            this.timerAuthentication.Tick += new System.EventHandler(this.timerAuthentication_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Do_An_1.Properties.Resources.user_male_circle_120px;
            this.pictureBox1.Location = new System.Drawing.Point(208, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 617);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBShowPass;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.RadioButton rbtn_Professor;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.RadioButton rbtn_Admin;
        public System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarLogin;
        private System.Windows.Forms.Timer timerProgcessBar;
        private System.Windows.Forms.Timer timerAuthentication;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}