using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            rdBAdmin.Checked = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Khai báo biến trả lời
            DialogResult traloi;
            //Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Do you want Exit?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Kiểm tra có nhấp chọn nút ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void rdBAdmin_Click(object sender, EventArgs e)
        {
            //xử lý check
            rdBUserTeacher.Checked = false;
            rdBAdmin.Checked = true;
            //Hides Textbox password
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
        }

        private void rdBUserTeacher_Click(object sender, EventArgs e)
        {
            //xử lý check
            rdBAdmin.Checked = false;
            rdBUserTeacher.Checked = true;
            //Hides Textbox password
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
        }

        private void rdBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //xử lý che password
        int i = 1;
        private void rdBShowPass_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                rdBShowPass.Checked = false;
            }
            else
            {
                rdBShowPass.Checked = true;
            }

            if (rdBShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
            else
            {
                //Hides Textbox password
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            i++;
        }
    }
}
