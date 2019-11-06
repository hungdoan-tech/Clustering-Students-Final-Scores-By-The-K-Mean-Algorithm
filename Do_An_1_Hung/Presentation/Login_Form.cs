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

namespace Do_An_1
{
    public partial class Login_Form : Form
    {
        public Professor Professor { get; set; }
        public Login_Form()
        {
            InitializeComponent();
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Authentication(txb_Account.Text, txb_Password.Text) == true)
            {
                if (Professor.IsAdmin == false)
                {
                    if (rbtn_Admin.Checked == true)
                    {
                        MessageBox.Show("Quyền truy cập không cho phép \n Mời nhập lại!");
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
                        MessageBox.Show("Quyền truy cập không cho phép\nMời nhập lại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã sai! \n Mời nhập lại!");
                txb_Password.Clear();
                txb_Account.Focus();
            }
        }
    }
}
