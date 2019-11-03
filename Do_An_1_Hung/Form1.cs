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
        static int ClusterAmount = 3;
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
            //using (var ctx = new UniversityContext())
            //{
            //    var x = new Department()
            //    {
            //        DepartmentID = 300,
            //        DeparmentName = "abcxyz",
            //        PhoneNumber = "978987988"
            //    };
            //    ctx.Departments.Add(x);
            //    ctx.SaveChanges();
            //}
            MessageBox.Show("Done");
            
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
            MainTabControl.TabPages.Remove(tabPageStudent);
            MainTabControl.TabPages.Remove(tabPageGrade);
            MainTabControl.TabPages.Remove(tabPageAnalysis);
            MainTabControl.TabPages.Add(tabPageAnalysis);
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
        static void CopyPoint(ref MyGrouping<int, Grade> a, IGrouping<int, Grade> b)        //Copy cac gia tri trong variable dang reference type sang 1 variable khac 
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
        static void ExceptDuplicate(ref int startRan, List<int> listRan, int startingStudentID, int endingStudentID, Random ran)  // Khu truong hop trung ID khi khoi tao central point khi dung khoi tao kmean binh thuong
        {
            foreach (var c in listRan)
            {
                if (startRan == c)
                {
                    startRan = ran.Next(startingStudentID, endingStudentID);
                    ExceptDuplicate(ref startRan, listRan, startingStudentID, endingStudentID, ran);
                }
            }
        }
        static void KmeanPlusPlus(ref List<MyGrouping<int, Grade>> CentralPoint, System.Collections.Generic.List<IGrouping<int, Grade>> pointList)
        {
            Random ran = new Random();      // Khoi tao Student ID bat dau va ket thuc trong danh sach de random vi tri khoi tao
            int startingStudentID = pointList.First().Key;
            int endingStudentID = pointList.Last().Key;

            var temporaryVariable = new MyGrouping<int, Grade>();       // Khoi tao central point dau tien bang cach random
            CentralPoint.Add(temporaryVariable);
            int kmeanPlusPlusInitializePoint = ran.Next(startingStudentID, endingStudentID);
            var TheFisrtPoint = CentralPoint[0];
            CopyPoint(ref TheFisrtPoint, pointList.Single(c => c.Key == kmeanPlusPlusInitializePoint));

            int Count = 1;      // Da ton tai san 1 central point
            while (true)            // Bat dau tim cac central point con lai
            {
                if (Count == ClusterAmount)     // Thoa so luong cluster yeu cau thi break 
                {
                    break;
                }

                List<MyGrouping<double?, Grade>> MinDistanceList = new List<MyGrouping<double?, Grade>>();      // Khoi tao List chua khoang cach be nhat den central point gan nhat cua tat cac cac point
                foreach (var point in pointList)
                {
                    List<double?> Result = new List<double?>(); // List chua khoang cach den tung central point cua 1 diem 
                    for (int i = 0; i < Count; i++)
                    {
                        var temp = 0;
                        Result.Add(temp);
                    }
                    for (int i = 0; i < 20; i++)        // An gian, cong thuc tinh khoang cach, nhung khong tinh cang bac 2
                    {
                        for (int j = 0; j < Count; j++)
                        {
                            Result[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                        }
                    }

                    double? minResult = Result[0];      // Tim ra khoang cach be nhat
                    for (int i = 0; i < Count; i++)
                    {
                        if (Result[i] < minResult)
                        {
                            minResult = Result[i];
                        }
                    }

                    MyGrouping<double?, Grade> temporaryCentralPoint = new MyGrouping<double?, Grade>(); // khoi tao 1 instance dai dien cho 1 point voi key la khoang cach ngan nhat toi central point gan nhat cua point do
                    temporaryCentralPoint.Key = minResult;
                    for (int j = 0; j < 20; j++)
                    {
                        temporaryCentralPoint.Add(new Grade { });
                    }
                    int elementCount = 0;
                    foreach (var c in temporaryCentralPoint)
                    {
                        temporaryCentralPoint.ElementAt(elementCount).Mark = point.ElementAt(elementCount).Mark;
                        elementCount++;
                    }
                    MinDistanceList.Add(temporaryCentralPoint);
                }

                IGrouping<double?, Grade> MaxPoint = MinDistanceList.First();       // Sau khi da co duoc ket qua khoang cach cua tung point den central point gan nhat cua no, ta se duyet het tat ca cac khoang cach nay va tim ra khoang cach lon nhat, point tuong ung se tro thanh point tiep theo  
                foreach (var Point in MinDistanceList)                  // key o day chinh la khoang cach giua 1 point va central point gan nhat cua no
                {
                    if (Point.Key > MaxPoint.Key)
                    {
                        MaxPoint = Point;
                    }
                }

                var TemporaryPoint = new MyGrouping<int, Grade>();      // Copy point cac thanh phan trong 1 reference type variable sang 1 variable khac 
                CentralPoint.Add(TemporaryPoint);
                for (int j = 0; j < 20; j++)
                {
                    CentralPoint[Count].Add(new Grade { });
                }
                int gradeCount = 0;
                foreach (var c in CentralPoint[Count])
                {
                    CentralPoint[Count].ElementAt(gradeCount).Mark = MaxPoint.ElementAt(gradeCount).Mark;
                    gradeCount++;
                }

                Count++; // Them thanh cong 1 central point
            }
            return;
        }

        static void Kmean()
        {
            using (var ctx = new UniversityContext())
            {
                var pointList = ctx.Grades.GroupBy(s => s.StudentID).ToList();         // danh sach tat ca sinh vien va diem so cua tung sinh vien, 1 Point tuc la 1 student 

                List<List<IGrouping<int, Grade>>> Cluster = new List<List<IGrouping<int, Grade>>>();      // Khai bai List chua cac cluster  
                for (int i = 0; i < ClusterAmount; i++)
                {
                    var Temp = new List<IGrouping<int, Grade>>();
                    Cluster.Add(Temp);
                }

                Random ran = new Random();                      //Khai bao ID bat dau va ID ket thuc trong danh sach sinh vien de random 
                int startingStudentID = pointList.First().Key;
                int endingStudentID = pointList.Last().Key;
                List<int> listRan = new List<int>();

                //int StartRan;
                //List<MyGrouping<int, Grade>> CentralPoint = new List<MyGrouping<int, Grade>>();             // Khoi tao cac central point trong cac cluster theo cach random thong thuong
                //for (int i = 0; i < ClusterAmount; i++)
                //{
                //    var Temp = new MyGrouping<int, Grade>();
                //    CentralPoint.Add(Temp);
                //    StartRan = ran.Next(startingStudentID, endingStudentID);
                //    ExceptDuplicate(ref StartRan, listRan, startingStudentID, endingStudentID, ran);
                //    listRan.Add(StartRan);
                //    var TempPoint = CentralPoint[i];
                //    CopyPoint(ref TempPoint, pointList.Single(c => c.Key == StartRan));
                //}

                List<MyGrouping<int, Grade>> CentralPoint = new List<MyGrouping<int, Grade>>();           //  Khoi tao cac central point trong cac cluster theo cach k-mean ++
                for (int i = 0; i < ClusterAmount; i++)
                {
                    var Temp = new MyGrouping<int, Grade>();
                    CentralPoint.Add(Temp);
                }
                KmeanPlusPlus(ref CentralPoint, pointList);

                int SoLan = 0;
                while (true)
                {
                    Cluster = new List<List<IGrouping<int, Grade>>>();              // Khoi tao lai danh sach Cluter sau moi lan duyet het tat cac phan tu 
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new List<IGrouping<int, Grade>>();
                        Cluster.Add(Temp);
                    }

                    List<MyGrouping<int, Grade>> CompareCentralPoint = new List<MyGrouping<int, Grade>>();  // Khoi tao lai danh sach Temporary Central Point de so sanh voi cac Central Point duoc dieu chinh lai khi duyet het lai tat cac cac phan tu  
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new MyGrouping<int, Grade>();
                        CompareCentralPoint.Add(Temp);
                        var TempPoint = CompareCentralPoint[i];
                        CopyPoint(ref TempPoint, CentralPoint[i]);
                    }

                    foreach (var point in pointList) // Bat dau duyet tung phan tu de tinh xem phan tu do thuoc cluster nao
                    {
                        List<double?> Result = new List<double?>();    // Khoi tao danh sach ket qua de luu khoach cach cua 1 Point lan luot den cac Central Point
                        for (int i = 0; i < ClusterAmount; i++)
                        {
                            var Temp = 0;
                            Result.Add(Temp);
                        }

                        for (int i = 0; i < 20; i++)        // Tinh theo cong thuc |A1A2| = SQRT( (x1-x2)*((x1-x2) + (y1-y2)*((y1-y2) +... )  // trong do A1 la 1 sinh vien, A2 la central point
                        {
                            for (int j = 0; j < ClusterAmount; j++)
                            {
                                Result[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                            }
                        }
                        for (int i = 0; i < ClusterAmount; i++)
                        {
                            Result[i] = Math.Sqrt(Convert.ToDouble(Result[i]));
                        }

                        double? minResult = Result[0];      // Tim ra khoang cach nho nhat cua phan tu voi cac central point, va gan phan tu thuoc cluster tuong ung
                        int GroupMax = 0;
                        for (int i = 0; i < Result.Count; i++)
                        {
                            if (Result[i] < minResult)
                            {
                                minResult = Result[i];
                                GroupMax = i;
                            }
                        }
                        Cluster[GroupMax].Add(point);
                    }

                    List<double?> elementList = new List<double?>();

                    int count = 0;
                    foreach (var eachCluster in Cluster)     // Moi Cluster 
                    {
                        elementList = new List<double?>();   // Khoi tao danh sach cac phan tu trong 1 Temporary Point de luu gia tri cua central point sau khi tinh lai 
                        for (int i = 0; i < 20; i++)
                        {
                            var Temp = 0;
                            elementList.Add(Temp);
                        }

                        foreach (var point in eachCluster)    // Moi Point 
                        {
                            int i = 0;
                            foreach (var element in point)      // Moi element trong Point
                            {
                                elementList[i] += element.Mark;
                                i++;
                            }
                        }
                        for (int i = 0; i < elementList.Count; i++)     // Tinh lai gia tri cua central point trong cluster do 
                        {
                            CentralPoint[count].ElementAt(i).Mark = elementList[i] / eachCluster.Count();
                        }
                        count++;
                    }

                    bool flag = true;               // Kiem tra xem co du dieu kien de ket thuc vong lap chua ( neu central point khong thay doi )
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
            }
        }
        static void Readfile()
        {
            using (var ctx = new Do_An_1.UniversityContext())
            {
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

        private void btn_BrowseAnalysis_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               // TextBoxAnalysis.Text = openFileDialog.FileName;
            }
        }

        private void tabPageAnalysis_Click(object sender, EventArgs e)
        {
            panelMain.Width = 60;
            panelPhu.Location = new Point(60, 0);
            picSmall.Show();
        }

        private void btnKmean_Click(object sender, EventArgs e)
        {
            Kmean();
        }
    }
}
