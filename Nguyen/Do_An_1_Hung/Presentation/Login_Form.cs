using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_1.DomainClass;
using Do_An_1.Presentation;
using System.Timers;
namespace Do_An_1
{
    public partial class Login_Form : Form
    {
        public Professor Professor { get; set; }
        public Login_Form()
        {
            InitializeComponent();
        }
        public void Login_Form_Load(object sender, EventArgs e)
        {
            rbtn_Admin.Checked = true;
            txb_Account.Text = "1120";
            txb_Password.Text = "10000020";
            metroProgressBarLogin.Visible = false;
            label1.Visible = false;
        }
        public bool Authentication(string Account, string Password)
        {
            using (var dn = new UniversityContext())
            {
                this.Professor = dn.Professors.FirstOrDefault(x => x.ProfessorID.ToString() == Account.ToString() && x.Password.ToString() == Password.ToString());
                if (this.Professor != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void timerProgcessBar_Tick(object sender, EventArgs e)
        {
            metroProgressBarLogin.ProgressBarStyle = ProgressBarStyle.Marquee;
            //panelHide.Location = new Point(106, 619);
            
        }
        private void timerAuthentication_Tick(object sender, EventArgs e)
        {
            if (Authentication(txb_Account.Text, txb_Password.Text) == true)
            {
                if (Professor.IsAdmin == false)
                {
                    if (rbtn_Admin.Checked == true)
                    {
                        MessageBox.Show("Quyền truy cập không cho phép \n Mời nhập lại!");
                        metroProgressBarLogin.Visible = false;
                        label1.Visible = false;
                        timerProgcessBar.Enabled = false;
                        timerAuthentication.Enabled = false;
                    }
                    if (rbtn_Professor.Checked == true)
                    {
                        this.Close();
                    }
                }
                else
                {
                    if (rbtn_Admin.Checked == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        metroProgressBarLogin.Visible = false;
                        label1.Visible = false;
                        MessageBox.Show("Quyền truy cập không cho phép\nMời nhập lại!");
                        timerProgcessBar.Enabled = false;
                        timerAuthentication.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã sai! \n Mời nhập lại!");
                txb_Password.Clear();
                txb_Account.Focus();
                metroProgressBarLogin.Visible = false;
                label1.Visible = false;
                timerProgcessBar.Enabled = false;
                timerAuthentication.Enabled = false;
            }
        }
        public void btn_Login_Click(object sender, EventArgs e)
        {
            
            timerProgcessBar.Enabled = true;
            metroProgressBarLogin.ProgressBarStyle = ProgressBarStyle.Marquee;
            timerAuthentication.Enabled = true;
            metroProgressBarLogin.Visible = true;
            label1.Visible = true;
        }

        private void rbtn_Admin_Click(object sender, EventArgs e)
        {
            //xử lý check
            rbtn_Professor.Checked = false;
            rbtn_Admin.Checked = true;
            //Hides Textbox password
            txb_Password.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
        }

        private void rbtn_Professor_Click(object sender, EventArgs e)
        {
            //xử lý check
            rbtn_Admin.Checked = false;
            rbtn_Professor.Checked = true;
            //Hides Textbox password
            txb_Password.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
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
                txb_Password.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
            else
            {
                //Hides Textbox password
                txb_Password.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            i++;
        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {
            txb_Password.PasswordChar = '*';
        }

        private void txb_Account_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void txb_Password_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        
    }
}
