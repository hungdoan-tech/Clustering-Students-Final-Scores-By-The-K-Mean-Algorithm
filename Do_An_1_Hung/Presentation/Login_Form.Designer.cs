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
            this.btn_Login = new System.Windows.Forms.Button();
            this.rbtn_Professor = new System.Windows.Forms.RadioButton();
            this.rbtn_Admin = new System.Windows.Forms.RadioButton();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(281, 335);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(138, 39);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // rbtn_Professor
            // 
            this.rbtn_Professor.AutoSize = true;
            this.rbtn_Professor.Location = new System.Drawing.Point(272, 274);
            this.rbtn_Professor.Name = "rbtn_Professor";
            this.rbtn_Professor.Size = new System.Drawing.Size(69, 17);
            this.rbtn_Professor.TabIndex = 20;
            this.rbtn_Professor.Text = "Professor";
            this.rbtn_Professor.UseVisualStyleBackColor = true;
            // 
            // rbtn_Admin
            // 
            this.rbtn_Admin.AutoSize = true;
            this.rbtn_Admin.Checked = true;
            this.rbtn_Admin.Location = new System.Drawing.Point(170, 274);
            this.rbtn_Admin.Name = "rbtn_Admin";
            this.rbtn_Admin.Size = new System.Drawing.Size(85, 17);
            this.rbtn_Admin.TabIndex = 19;
            this.rbtn_Admin.TabStop = true;
            this.rbtn_Admin.Text = "Administrator";
            this.rbtn_Admin.UseVisualStyleBackColor = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(83, 205);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 18;
            this.label_Password.Text = "Password";
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Location = new System.Drawing.Point(83, 81);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(61, 13);
            this.label_Account.TabIndex = 17;
            this.label_Account.Text = "Account ID";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(170, 187);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(444, 42);
            this.txb_Password.TabIndex = 16;
            this.txb_Password.Text = "10000020";
            // 
            // txb_Account
            // 
            this.txb_Account.Location = new System.Drawing.Point(170, 78);
            this.txb_Account.Multiline = true;
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(444, 42);
            this.txb_Account.TabIndex = 15;
            this.txb_Account.Text = "1120";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 452);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.rbtn_Professor);
            this.Controls.Add(this.rbtn_Admin);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Account);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Account);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.RadioButton rbtn_Professor;
        private System.Windows.Forms.RadioButton rbtn_Admin;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Account;
    }
}