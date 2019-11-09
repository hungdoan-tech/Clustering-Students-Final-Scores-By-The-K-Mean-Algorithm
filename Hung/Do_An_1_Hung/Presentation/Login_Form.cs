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
using System.Timers;
namespace Do_An_1
{
    public partial class Login_Form : Form
    {
        public Professor Professor { get; set; }
        private int StatusPass = 1;
        public Login_Form()
        {
            InitializeComponent();
        }
        public void Login_Form_Load(object sender, EventArgs e)
        {

            using (var ctx = new UniversityContext())
            {
                bool dbExists = System.Data.Entity.Database.Exists(ctx.Database.Connection);
                if (dbExists == false)
                {
                    var x = new Department() { DepartmentID = 24071999, DeparmentName = "Admin" };
                    ctx.Departments.Add(x);
                    ctx.Departments.Remove(x);
                    ctx.SaveChanges();
                }
            }

            rbtn_Admin.Checked = true;
            txb_Account.Text = "1120";
            txb_Password.Text = "10000020";
            progressBar_Proccesing.Visible = false;
            progressBar_Proccesing.Style = ProgressBarStyle.Marquee;
            label_Processing.Visible = false;
        }
        public bool Authentication(string Account, string Password)
        {
            using (var ctx = new UniversityContext())
            {
                this.Professor = ctx.Professors.FirstOrDefault(x => x.ProfessorID.ToString() == Account.ToString() && x.Password.ToString() == Password.ToString());
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
            //Hiện hộp thoại hỏi đáp
            var traloi = MessageBox.Show("Do you want Exit?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Kiểm tra có nhấp chọn nút ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void timerAuthentication_Tick(object sender, EventArgs e)
        {
            if (Authentication(txb_Account.Text, txb_Password.Text) == true)
            {
                if (this.Professor.IsAdmin == false)
                {
                    if (rbtn_Admin.Checked == true)
                    {
                        timerAuthentication.Stop();
                        timerAuthentication.Enabled = false;
                        MessageBox.Show("Quyền truy cập không cho phép \n Mời nhập lại!");
                        progressBar_Proccesing.Visible = false;
                        label_Processing.Visible = false;
                    }
                    else 
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
                        timerAuthentication.Stop();
                        timerAuthentication.Enabled = false;
                        progressBar_Proccesing.Visible = false;
                        label_Processing.Visible = false;
                        MessageBox.Show("Quyền truy cập không cho phép\nMời nhập lại!");
                    }
                }
            }
            else
            {
                timerAuthentication.Stop();
                timerAuthentication.Enabled = false;
                MessageBox.Show("Tài khoản hoặc mật khẩu đã sai! \n Mời nhập lại!");
                txb_Password.Clear();
                txb_Account.Focus();
                progressBar_Proccesing.Visible = false;
                label_Processing.Visible = false;
            }
        }
        public void btn_Login_Click(object sender, EventArgs e)
        {
            timerAuthentication.Enabled = true;
            timerAuthentication.Start();
            progressBar_Proccesing.Visible = true;
            label_Processing.Visible = true;
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

        private void rdBShowPass_Click(object sender, EventArgs e)
        {
            if (StatusPass % 2 == 0)
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
            StatusPass++;
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
