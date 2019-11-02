using System;
using Do_An_1.DomainClass;
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
        const int ClusterAmount = 3;
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

            //Ẩn Panel Students

            //Ẩn Panel Phụ
            panelPhu.Hide();
            //Ẩn panel grade    
            using (var ctx = new UniversityContext())
            {
                //var x = new Department() {
                //    DepartmentID = 300, DeparmentName = "abcxyz", PhoneNumber = "978987988"
                //};
                //ctx.Departments.Add(x);
                //ctx.SaveChanges();
            }
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

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            //Xử lý giao diện của panel Student
            //
            btnInFoGrade.BackColor = Color.Gainsboro;
            btnAddGrade.BackColor = Color.Silver;
            btnEditGrade.BackColor = Color.Gainsboro;
            btnDelGrade.BackColor = Color.Gainsboro;


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
        ///////////////////////////////////////////////////////////////////////////////////
        static void CopyPoint(ref MyGrouping<int, Grade> a, IGrouping<int, Grade> b)
        {
            for (int j = 0; j < 20; j++)
            {
                a.Add(new Grade { });
            }
            int i = 0;
            foreach (var c in b)
            {
                a.ElementAt(i).Mark = c.Mark;
                i++;
            }
        }
        static void DeQuy(ref int startRan, List<int> listRan, int ViTriBatDau, int ViTriKetThuc, Random ran)
        {
            foreach (var c in listRan)
            {
                if (startRan == c)
                {
                    startRan = ran.Next(ViTriBatDau, ViTriKetThuc);
                    DeQuy(ref startRan, listRan, ViTriBatDau, ViTriKetThuc, ran);
                }
            }
        }
        static void KmeanPlusPlus(ref MyGrouping<int, Grade>[] CentralPoint, System.Collections.Generic.List<IGrouping<int, Grade>> myList)
        {
            Random ran = new Random();
            int ViTriBatDau = myList.First().Key;
            int ViTriKetThuc = myList.Last().Key;
            int Count = 1;
            CentralPoint[0] = new MyGrouping<int, Grade>();
            int vitribatdau = ran.Next(ViTriBatDau, ViTriKetThuc);
            CopyPoint(ref CentralPoint[0], myList.Single(c => c.Key == vitribatdau));
            while (true)
            {
                List<MyGrouping<double?, Grade>> MinDistanceList = new List<MyGrouping<double?, Grade>>();
                foreach (var point in myList)
                {
                    double?[] ketQua = new double?[Count];
                    for (int i = 0; i < Count; i++)
                    {
                        ketQua[i] = 0;
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < Count; j++)
                        {
                            ketQua[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                        }
                    }

                    double? ketQuaMin = ketQua[0];
                    for (int i = 0; i < Count; i++)
                    {
                        if (ketQua[i] < ketQuaMin)
                        {
                            ketQuaMin = ketQua[i];
                        }
                    }
                    MyGrouping<double?, Grade> Temp = new MyGrouping<double?, Grade>();
                    Temp.Key = ketQuaMin;
                    for (int j = 0; j < 20; j++)
                    {
                        Temp.Add(new Grade { });
                    }
                    int dem = 0;
                    foreach (var c in Temp)
                    {
                        Temp.ElementAt(dem).Mark = point.ElementAt(dem).Mark;
                        dem++;
                    }
                    MinDistanceList.Add(Temp);
                }
                if (Count == ClusterAmount)
                {
                    break;
                }
                IGrouping<double?, Grade> Max = MinDistanceList.First();
                foreach (var c in MinDistanceList)
                {
                    if (c.Key > Max.Key)
                    {
                        Max = c;
                    }
                }
                CentralPoint[Count] = new MyGrouping<int, Grade>();
                for (int j = 0; j < 20; j++)
                {
                    CentralPoint[Count].Add(new Grade { });
                }
                int dem2 = 0;
                foreach (var c in CentralPoint[Count])
                {
                    CentralPoint[Count].ElementAt(dem2).Mark = Max.ElementAt(dem2).Mark;
                    dem2++;
                }
                Count++;
            }
            return;
        }

        static void Kmean()
        {
            using (var ctx = new UniversityContext())
            {
                var myList = ctx.Grades.GroupBy(s => s.StudentID).ToList();
                var testList = ctx.Grades.ToList();
                List<IGrouping<int, Grade>>[] Group = new List<IGrouping<int, Grade>>[ClusterAmount];

                Random ran = new Random();
                int ViTriBatDau = myList.First().Key;
                int ViTriKetThuc = myList.Last().Key;
                int StartRan;
                List<int> listRan = new List<int>();

                MyGrouping<int, Grade>[] CentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                for (int i = 0; i < ClusterAmount; i++)
                {
                    CentralPoint[i] = new MyGrouping<int, Grade>();
                    StartRan = ran.Next(ViTriBatDau, ViTriKetThuc);
                    DeQuy(ref StartRan, listRan, ViTriBatDau, ViTriKetThuc, ran);
                    listRan.Add(StartRan);
                    CopyPoint(ref CentralPoint[i], myList.Single(c => c.Key == StartRan));
                }

                //MyGrouping<int, Grade>[] CentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                //KmeanPlusPlus(ref CentralPoint, myList);

                int SoLan = 0;
                while (true)
                {

                    Group = new List<IGrouping<int, Grade>>[ClusterAmount];
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        Group[i] = new List<IGrouping<int, Grade>>();
                    }

                    MyGrouping<int, Grade>[] CompareCentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        CompareCentralPoint[i] = new MyGrouping<int, Grade>();
                        CopyPoint(ref CompareCentralPoint[i], CentralPoint[i]);
                    }

                    foreach (var item in myList)
                    {
                        //double?[] tichVoHuong = new double?[ClusterAmount] { 0, 0, 0 };
                        //double? doDaiItem = 0;
                        //double?[] doDaiCentralPoint = new double?[ClusterAmount] { 0, 0, 0};
                        //double?[] ketQua = new double?[ClusterAmount] { 0, 0, 0};

                        //for (int i = 0; i < 20; i++)
                        //{
                        //    for (int j = 0; j < tichVoHuong.Length; j++)
                        //    {
                        //        tichVoHuong[j] += item.ElementAt(i).Mark * CentralPoint[j].ElementAt(i).Mark;
                        //    }

                        //    doDaiItem += item.ElementAt(i).Mark * item.ElementAt(i).Mark;

                        //    for (int j = 0; j < doDaiCentralPoint.Length; j++)
                        //    {
                        //        doDaiCentralPoint[j] += CentralPoint[j].ElementAt(i).Mark * CentralPoint[j].ElementAt(i).Mark;
                        //    }
                        //}
                        //doDaiItem = Math.Sqrt((double)doDaiItem);

                        //for (int j = 0; j < doDaiCentralPoint.Length; j++)
                        //{
                        //    doDaiCentralPoint[j] = Math.Sqrt((double)doDaiCentralPoint[j]);
                        //}

                        //for (int j = 0; j < ketQua.Length; j++)
                        //{
                        //    ketQua[j] = tichVoHuong[j] / (doDaiItem * doDaiCentralPoint[j]);
                        //}

                        double?[] ketQua = new double?[ClusterAmount] { 0, 0, 0 };
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < ClusterAmount; j++)
                            {
                                ketQua[j] += (item.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (item.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                            }
                        }

                        for (int i = 0; i < ClusterAmount; i++)
                        {
                            ketQua[i] = Math.Sqrt(Convert.ToDouble(ketQua[i]));
                        }
                        double? ketQuaMax = ketQua[0];
                        int GroupMax = 0;
                        for (int i = 0; i < ketQua.Length; i++)
                        {
                            if (ketQua[i] < ketQuaMax)
                            {
                                ketQuaMax = ketQua[i];
                                GroupMax = i;
                            }
                        }
                        Group[GroupMax].Add(item);
                    }

                    double?[] danhSachDiemTam = new double?[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int count = 0;
                    foreach (var a in Group)
                    {
                        danhSachDiemTam = new double?[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        foreach (var b in a)
                        {
                            int i = 0;
                            foreach (var c in b)
                            {
                                danhSachDiemTam[i] += c.Mark;
                                i++;
                            }
                        }
                        for (int i = 0; i < danhSachDiemTam.Length; i++)
                        {
                            CentralPoint[count].ElementAt(i).Mark = danhSachDiemTam[i] / a.Count();
                        }
                        count++;
                    }
                    bool flag = true;
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (CompareCentralPoint.ElementAt(i).ElementAt(j).Mark != CentralPoint.ElementAt(i).ElementAt(j).Mark)
                            {
                                flag = false;
                                i = ClusterAmount + 100;
                                break;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                    SoLan++;
                    Console.WriteLine(SoLan);
                }
                for (int i = 0; i < ClusterAmount; i++)
                {
                    Console.Write("Cebtral " + i + " : ");
                    double avg = 0;
                    foreach (var d in CentralPoint[i])
                    {
                        avg += (double)d.Mark;
                        Console.Write(d.Mark + " ");
                    }
                    avg = avg / 20;
                    Console.Write("       " + avg + "\n");
                }
                Console.WriteLine();
                for (int i = 0; i < Group.Length; i++)
                {
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Danh sach cac sinh vien trong group " + i + " :");
                    foreach (var e in Group.ElementAt(i))
                    {
                        Console.Write(e.Key + "  ");
                        double avg = 0;
                        foreach (var f in e)
                        {
                            avg += (double)f.Mark;
                            Console.Write(f.Mark + " ");
                        }
                        avg = avg / 20;
                        Console.Write("       " + avg + "\n");
                    }
                }
            }
        }
        static void readfile()
        {
            using (var ctx = new Do_An_1.UniversityContext())
            {
                Console.WriteLine("Start ");
                string filepath = @"\test3.txt";
                string[] line;
                int i = 0;
                int phantram = 0;

                if (System.IO.File.Exists(filepath))
                {
                    line = System.IO.File.ReadAllLines(filepath);
                    Console.WriteLine(phantram);
                    foreach (var c in line)
                    {
                        string[] d = new string[3];
                        d = c.Split(new char[] { ' ' });
                        int stu = Convert.ToInt32(d[0]);
                        string cla = d[1];
                        try
                        {
                            ctx.Grades.SingleOrDefault(b => b.StudentID == stu && b.ClassID == cla).Mark = Convert.ToDouble(d[2]);
                        }
                        catch (Exception ex)
                        {
                            Console.Write("Du lieu input chua dung !");
                            Console.WriteLine(ex.Message);
                            break;
                        }
                        i++;
                        if (i != 0 && i % 80 == 0)
                        {
                            phantram++;
                            Console.Clear();
                            Console.Write(phantram);
                        }
                    }
                    ctx.SaveChanges();
                }
                else
                {
                    Console.WriteLine("File doest not exist");
                }
            }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
        }
    }
}
