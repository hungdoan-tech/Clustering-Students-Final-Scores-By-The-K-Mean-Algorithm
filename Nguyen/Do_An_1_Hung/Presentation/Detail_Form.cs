using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_1.Business;

namespace Do_An_1
{
    public partial class DetailForm : Form
    {
        public BLAnalysis Ana { get; set; }
        public List<DataGridView> ListDGV { get; set; }
        public DetailForm(BLAnalysis ana, List<DataGridView> list)
        {
            this.Ana = ana;
            this.ListDGV = list;
            InitializeComponent();
        }
        private void DetailForm_Load(object sender, EventArgs e)
        {
            RichTextBox mainRichTextBox = new RichTextBox();
            mainRichTextBox.BorderStyle = BorderStyle.None;
            //mainRichTextBox.TextAlign  = HorizontalAlignment.Center; 
            mainRichTextBox.Multiline = true;
            mainRichTextBox.Width = 1300;
            mainRichTextBox.Height = this.Ana.ClusterAmount*100;
            mainRichTextBox.Location = new Point(100,10);
            mainRichTextBox.Font = new Font("Arial", 10);
            mainRichTextBox.Text += "\r\n Thuật toán chạy trong " + Ana.LoopCount +" lần ! \r\n";
            for (int i = 0; i < this.Ana.ClusterAmount; i++)
            {
                mainRichTextBox.Text += "\r\n Central Point của Cluster thứ " + i.ToString() + " là: ( ";
                for (int j=0; j < this.Ana.CentralPoint[i].Count;j++)
                {
                    if (j != 19)
                    {
                        mainRichTextBox.Text += this.Ana.CentralPoint[i].ElementAt(j).Mark + " , ";
                    }
                    else
                    {
                        mainRichTextBox.Text += this.Ana.CentralPoint[i].ElementAt(j).Mark +" ";
                    }
                }
                mainRichTextBox.Text += " ) \r\n";
            }
            mainRichTextBox.Text += "\r\n Sau đây là danh sách chi tiết các sinh viên thuộc các cluster: \r\n";
            mainRichTextBox.Enabled = false;
            this.Controls.Add(mainRichTextBox);
            for (int i = 0; i < this.ListDGV.Count; i++)
            {
                Label startLabel = new Label();
                startLabel.Location = new Point(ListDGV[i].Location.X, ListDGV[i].Location.Y-20);
                startLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                startLabel.Text = "Cluster " + i.ToString();
                this.Controls.Add(startLabel);
                this.Controls.Add(ListDGV[i]);
            }
        }
    }
}
