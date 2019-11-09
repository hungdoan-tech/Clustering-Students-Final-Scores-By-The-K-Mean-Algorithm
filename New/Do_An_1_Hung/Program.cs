using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Do_An_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Presentation.ProgressBarModern());

            Login_Form loginForm = new Login_Form();
            loginForm.ShowDialog();
            //ProgressBarModern progressBarModern = new ProgressBarModern();
            //progressBarModern.ShowDialog();
            if (loginForm.Professor != null)
            {
                if (loginForm.Professor.IsAdmin == true)
                {
                    Application.Run(new Main_Form(2, loginForm.Professor.ProfessorID));
                }
                else
                {
                    Application.Run(new Main_Form(1, loginForm.Professor.ProfessorID));
                }
            }
        }
    }
}
