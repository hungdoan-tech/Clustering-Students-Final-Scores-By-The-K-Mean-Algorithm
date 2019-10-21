using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Do_An_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            #region//Xóa Viền cho button
            //
            //Button on Panel main
            //
            //btnDashboard
            btnDashboard.TabStop = false;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize = 0;
            //btnStudent
            btnStudent.TabStop = false;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.FlatAppearance.BorderSize = 0;
            //btnGrade
            btnGrade.TabStop = false;
            btnGrade.FlatStyle = FlatStyle.Flat;
            btnGrade.FlatAppearance.BorderSize = 0;
            //btnReport
            btnReport.TabStop = false;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.FlatAppearance.BorderSize = 0;
            //btnSetting
            btnSetting.TabStop = false;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.FlatAppearance.BorderSize = 0;
            //btnHelp
            btnHelp.TabStop = false;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.FlatAppearance.BorderSize = 0;
            //
            //Xử lý viền các button trong panel Student
            //
            //btnInFoStudent
            btnInFoStudent.TabStop = false;
            btnInFoStudent.FlatStyle = FlatStyle.Flat;
            btnInFoStudent.FlatAppearance.BorderSize = 0;
            //btnAddStudent
            btnAddStudent.TabStop = false;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            //btnEditStudent
            btnEditStudent.TabStop = false;
            btnEditStudent.FlatStyle = FlatStyle.Flat;
            btnEditStudent.FlatAppearance.BorderSize = 0;
            //btnDelStudent
            btnDelStudent.TabStop = false;
            btnDelStudent.FlatStyle = FlatStyle.Flat;
            btnDelStudent.FlatAppearance.BorderSize = 0;
            //
            //Xử lý viền các button trong panel Grade
            //
            //btnInFoGrade
            btnInFoGrade.TabStop = false;
            btnInFoGrade.FlatStyle = FlatStyle.Flat;
            btnInFoGrade.FlatAppearance.BorderSize = 0;
            //btnAddGrade
            btnAddGrade.TabStop = false;
            btnAddGrade.FlatStyle = FlatStyle.Flat;
            btnAddGrade.FlatAppearance.BorderSize = 0;
            //btnEditGrade
            btnEditGrade.TabStop = false;
            btnEditGrade.FlatStyle = FlatStyle.Flat;
            btnEditGrade.FlatAppearance.BorderSize = 0;
            //btnDelGrade
            btnDelGrade.TabStop = false;
            btnDelGrade.FlatStyle = FlatStyle.Flat;
            btnDelGrade.FlatAppearance.BorderSize = 0;
            //
            //Xử lý viền các button trong panel Report
            //
            //btnExcel
            btnExcel.TabStop = false;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.FlatAppearance.BorderSize = 0;
            //btnGraph
            btnGraph.TabStop = false;
            btnGraph.FlatStyle = FlatStyle.Flat;
            btnGraph.FlatAppearance.BorderSize = 0;
            //btnPin
            btnPin.TabStop = false;
            btnPin.FlatStyle = FlatStyle.Flat;
            btnPin.FlatAppearance.BorderSize = 0;
            #endregion
            #region //Ẩn các tác vụ phụ đi
            //Ẩn các tác vụ phụ đi
            //btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //btnPin
            btnPin.Hide();
            #endregion
            picSmall.Hide();
            //Viền line
            txtLine.Enabled = false;
            txtLine1.Enabled = false;
            //Ẩn Panel Students
            panelStudent.Hide();
            //Ẩn Panel Phụ
            panelPhu.Hide();
            //Ẩn panel grade
            panelGrade.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            //
            btnDashboard.BackColor = Color.RoyalBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue; 
            btnReport.BackColor = Color.DarkBlue; 
            btnSetting.BackColor = Color.DarkBlue; 
            btnHelp.BackColor = Color.DarkBlue;
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();

            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Hiện Panel phụ
            panelPhu.Show();

            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();

            //Ẩn panel Grade
            panelGrade.Hide();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.RoyalBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnReport.BackColor = Color.DarkBlue;
            btnSetting.BackColor = Color.DarkBlue;
            btnHelp.BackColor = Color.DarkBlue;
            //Xử lý giao diện của panel Student
            //
            btnAddStudent.BackColor = Color.Gainsboro;
            btnInFoStudent.BackColor = Color.Gainsboro;
            btnEditStudent.BackColor = Color.Gainsboro;
            btnDelStudent.BackColor = Color.Gainsboro;
            // Hiện lên các tác vụ của button Student
            btnInFoStudent.Show();
            btnAddStudent.Show();
            btnEditStudent.Show();
            btnDelStudent.Show();
            btnPin.Show();
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Hiện Panel phụ
            panelPhu.Show();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Ẩn panel Grade
            panelGrade.Hide();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.RoyalBlue;
            btnReport.BackColor = Color.DarkBlue;
            btnSetting.BackColor = Color.DarkBlue;
            btnHelp.BackColor = Color.DarkBlue;
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Gainsboro;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Gainsboro;
            //
            // Hiện lên các tác vụ của button Grade
            btnInFoGrade.Show();
            btnAddGrade.Show();
            btnEditGrade.Show();
            btnDelGrade.Show();
            btnPin.Show();
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Hiện Panel phụ
            panelPhu.Show();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Ẩn panelStudent
            panelStudent.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnReport.BackColor = Color.RoyalBlue;
            btnSetting.BackColor = Color.DarkBlue;
            btnHelp.BackColor = Color.DarkBlue;
            //Xử lý giao diện của panel Report
            //
            btnExcel.BackColor = Color.Gainsboro;
            btnGraph.BackColor = Color.Gainsboro;
            //
            //
            // Hiện lên các tác vụ của button Grade
            btnExcel.Show();
            btnGraph.Show();
            //
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Hiện Panel phụ
            panelPhu.Show();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Ẩn panel Grade
            panelGrade.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnReport.BackColor = Color.DarkBlue;
            btnSetting.BackColor = Color.RoyalBlue;
            btnHelp.BackColor = Color.DarkBlue;
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Hiện Panel phụ
            panelPhu.Show();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Ẩn panel Grade
            panelGrade.Hide();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnReport.BackColor = Color.DarkBlue;
            btnSetting.BackColor = Color.DarkBlue;
            btnHelp.BackColor = Color.RoyalBlue;
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Hiện Panel phụ
            panelPhu.Show();
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Ẩn panel Grade
            panelGrade.Hide();
        }
        private void panelMain_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnReport.BackColor = Color.DarkBlue;
            btnSetting.BackColor = Color.DarkBlue;
            btnHelp.BackColor = Color.DarkBlue;
            //Ẩn các tác vụ của các button main khác
            //Tác vụ of btnStudent
            btnInFoStudent.Hide();
            btnAddStudent.Hide();
            btnEditStudent.Hide();
            btnDelStudent.Hide();
            //Tác vụ of btnGrade
            btnInFoGrade.Hide();
            btnAddGrade.Hide();
            btnEditGrade.Hide();
            btnDelGrade.Hide();
            //Tác vụ of btnReport
            btnExcel.Hide();
            btnGraph.Hide();
            //Ẩn Panel Student
            panelStudent.Hide();
            //Ẩn Panel Phụ
            panelPhu.Hide();

            //Ẩn panel Grade
            panelGrade.Hide();
        }
        //Button Grade
        private void btnInFoGrade_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Silver;
            btnAddGrade.BackColor = Color.Gainsboro;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Gainsboro;
            //Ẩn panel Grade
            panelGrade.Hide();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Silver;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Gainsboro;
            //Hiển thị panelGrade
            panelGrade.Show();
            //Ẩn các button edit và del
            btnEditGra.Hide();
            btnDeleteGra.Hide();
            //Show button Add
            btnAddGra.Show();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);
            
        }

        private void btnEditGrade_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Gainsboro;
            btnEditGrade.BackColor = Color.Silver;
            btnDelGrade.BackColor = Color.Gainsboro;
            //Ẩn các button add và del
            btnAddGra.Hide();
            btnDeleteGra.Hide();
            //Show button Edit
            btnEditGra.Show();
            //Hiển thị panelGrade
            panelGrade.Show();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);
        }

        private void btnDelGrade_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Gainsboro;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Silver;
            //Ẩn các button edit và add
            btnEditGra.Hide();
            btnAddGra.Hide();
            //Hiển thị panelGrade
            panelGrade.Show();
            //Show button Del
            btnDeleteGra.Show();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);

        }

        //Button Student
        private void btnInFoStudent_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoStudent.BackColor = Color.Silver;
            btnAddStudent.BackColor = Color.Gainsboro;
            btnEditStudent.BackColor = Color.Gainsboro;
            btnDelStudent.BackColor = Color.Gainsboro;
            //Ẩn panel Student
            panelStudent.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoStudent.BackColor = Color.Gainsboro;
            btnAddStudent.BackColor = Color.Silver;
            btnEditStudent.BackColor = Color.Gainsboro;
            btnDelStudent.BackColor = Color.Gainsboro;
            //Hiện Panel Students
            panelStudent.Show();
            btnTTAddStudent.Show();
            btnTTDelStudent.Hide();
            btnTTEditStudent.Hide();
            txtClassStudent.Enabled = true;
            txtContryStudent.Enabled = true;
            txtFacultyStudent.Enabled = true;
            txtIdentityStudent.Enabled = true;
            txtIDStudent.Enabled = true;
            txtNameStudent.Enabled = true;
            txtProvince_CityStudent.Enabled = true;
            dTPDateOfBirthStudent.Enabled = true;
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoStudent.BackColor = Color.Gainsboro;
            btnAddStudent.BackColor = Color.Gainsboro;
            btnEditStudent.BackColor = Color.Silver;
            btnDelStudent.BackColor = Color.Gainsboro;
            //Hiện Panel Students
            panelStudent.Show();
            //ẩn Hiện các button thêm xóa sửa
            btnTTEditStudent.Show();
            btnTTAddStudent.Hide();
            btnTTDelStudent.Hide();
            //Ẩn các txt
            txtClassStudent.Enabled = true;
            txtContryStudent.Enabled = true;
            txtFacultyStudent.Enabled = true;
            txtIdentityStudent.Enabled = true;
            txtIDStudent.Enabled = true;
            txtNameStudent.Enabled = true;
            txtProvince_CityStudent.Enabled = true;
            dTPDateOfBirthStudent.Enabled = true;
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoStudent.BackColor = Color.Gainsboro;
            btnAddStudent.BackColor = Color.Gainsboro;
            btnEditStudent.BackColor = Color.Gainsboro;
            btnDelStudent.BackColor = Color.Silver;
            //Hiện Panel Students
            panelStudent.Show();
            //Ẩn Các btn
            btnTTDelStudent.Show();
            btnTTAddStudent.Hide();
            btnTTEditStudent.Hide();
            //Ẩn các txt
            txtClassStudent.Enabled = false;
            txtContryStudent.Enabled = false;
            txtFacultyStudent.Enabled = false;
            txtIdentityStudent.Enabled = false;
            txtIDStudent.Enabled = false;
            txtNameStudent.Enabled = false;
            txtProvince_CityStudent.Enabled = false;
            dTPDateOfBirthStudent.Enabled = false;
            btnChoosePhoto.Enabled = false;
        }

        private void panelPhu_Click(object sender, EventArgs e)
        {
            //Student
            //
            btnInFoStudent.BackColor = Color.Gainsboro;
            btnAddStudent.BackColor = Color.Gainsboro;
            btnEditStudent.BackColor = Color.Gainsboro;
            btnDelStudent.BackColor = Color.Gainsboro;
            //
            //Grade
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Gainsboro;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Gainsboro;
            //
            //Report
            btnExcel.BackColor = Color.Gainsboro;
            btnGraph.BackColor = Color.Gainsboro;
            //Ẩn Panel Student
            panelStudent.Hide();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.BackColor = Color.Silver;
            btnGraph.BackColor = Color.Gainsboro;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            btnExcel.BackColor = Color.Gainsboro;
            btnGraph.BackColor = Color.Silver;
        }
        int dem = 1;
        private void btnPin_Click(object sender, EventArgs e)
        {
            
            if (dem % 2 != 0)
            {
                btnPin.BackColor = Color.Silver;
            }
            if (dem % 2 == 0)
            {
                btnPin.BackColor = Color.Gainsboro;
            }
            dem++;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
        }

        private void panelStudent_Click(object sender, EventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
        }

        private void btnStudent_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);
            panelStudent.Location = new Point(568, 0);
        }
        private void btnDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);
            panelStudent.Location = new Point(568, 0);
        }

        private void btnGrade_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
            //Hiển thị ở vị trí
            panelGrade.Location = new Point(568, 0);
            panelStudent.Location = new Point(568, 0);
        }

        private void btnReport_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();

        }

        private void btnSetting_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
        }

        private void btnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            //Hiện panel chính và trả panel phụ về vj trí cũ
            panelMain.Width = 230;
            panelPhu.Location = new Point(231, 0);
            picSmall.Hide();
        }

        private void btnDeleteGra_Click(object sender, EventArgs e)
        {

        }

        private void btnEditGra_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGra_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
            //Vi trí mới của panelStudent, panelGrade.
            panelGrade.Location = new Point(442,0);
            panelStudent.Location = new Point(442, 0);
        }

        private void panelStudent_MouseMove(object sender, MouseEventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
            //Vi trí mới của panelStudent, panelGrade.
            panelGrade.Location = new Point(442, 0);
            panelStudent.Location = new Point(442, 0);
        }

        private void panelGrade_MouseMove(object sender, MouseEventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
            //Vi trí mới của panelStudent, panelGrade.
            panelGrade.Location = new Point(442, 0);
            panelStudent.Location = new Point(442, 0);
        }

    }
}
