using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        bool Hidden;
        int PanelWidth; 
        public Form1()
        {
            InitializeComponent();
            PanelWidth = panel2.Width;
            Hidden = false;            
        }
        public void XoaTabControl()
        {
            this.tabControl1.TabPages.Remove(tabPage1);
            this.tabControl1.TabPages.Remove(tabPage2);
            this.tabControl1.TabPages.Remove(tabPage3);
        }
        private void MoveIndicator(Control control)
        {
            pxbIndicator.Top = control.Top;
            pxbIndicator.Height = control.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            XoaTabControl();
            this.tabControl1.TabPages.Add(tabPage1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            XoaTabControl();
            this.tabControl1.TabPages.Add(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            XoaTabControl();
            this.tabControl1.TabPages.Add(tabPage3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(Hidden)
            {
                panel2.Width = panel2.Width + 10;
                if(panel2.Width >= PanelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 10;
                if (panel2.Width <= 50)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
