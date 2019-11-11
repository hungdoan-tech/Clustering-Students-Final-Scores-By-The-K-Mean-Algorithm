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
using System.Data.SqlClient;
using Do_An_1.Business;


namespace Do_An_1
{
    public partial class Main_Form : Form
    {
        public int LoginStatus { get; }
        public int ProfessorID { get; }
        public BLAnalysis Ana { get; set; }
        public int StudentIDUpdate { get; set; }
        public string ClassIDUpdate { get; set; }

        public Main_Form(int loginStatus, int professorID)
        {
            InitializeComponent();
            this.LoginStatus = loginStatus;
            this.ProfessorID = professorID;
        }
        
        #region Control Tool
        private void Form1_Load(object sender, EventArgs e)
        {

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
            btnAnalysis.TabStop = false;
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.FlatAppearance.BorderSize = 0;

            //
            btn_Logout.TabStop = false;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.FlatAppearance.BorderSize = 0;

            using (var ctx = new UniversityContext())
            {
                var professor = ctx.Professors.FirstOrDefault(s => s.ProfessorID == this.ProfessorID);
                lbl_UserName.Text = professor.ProfessorName;
                if (professor.IsAdmin == false)
                {
                    lbl_Permision.Text = "Professor";
                }
                else
                {
                    lbl_Permision.Text = "Administrator";
                }
            }

            txb_EditMark.Enabled = false;
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            lbl_Edit.Enabled = false;

            chart_AmountStudent.Hide();
            chart_PercentClusters.Hide();
            chart_AverageGrade.Hide();


            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Analysis);


            LoadComboBox();

            if (LoginStatus == 1)
            {
                cbb_Deparment.Enabled = false;      
            }
            else
            {
                lbl_SubjectOption.Enabled = false;
                cbb_Subject.Enabled = false;
            }


            using (var ctx = new UniversityContext())
            {
                var professor = ctx.Professors.FirstOrDefault(s => s.ProfessorID == this.ProfessorID);
                txb_ProfessorName.Text = professor.ProfessorName.ToString();
                if (professor.IsAdmin != true)
                {
                    //txb_DepartmentName.Text = ctx.Departments.FirstOrDefault(s => s.DepartmentID == professor.DepartmentID).ToString();                 
                    txb_PhoneNumber.Text = professor.PhoneNumber.ToString();
                    string[] element = new string[3];
                    element = professor.BirthDate.ToString().Split(new char[] { ' ' });
                    txb_BirthDate.Text = element[0];
                }
            }


            txb_ProfessorName.TextAlign = HorizontalAlignment.Center;
            txb_PhoneNumber.TextAlign = HorizontalAlignment.Center;
            txb_BirthDate.TextAlign = HorizontalAlignment.Center;
            txb_ProfessorName.Enabled = false;
            txb_PhoneNumber.Enabled = false;
            txb_BirthDate.Enabled = false;

            txb_ProfessorName.Enabled = false;
            txb_PhoneNumber.Enabled = false;
            TabControl_Main.TabPages.Remove(tabPage_Dashboard);
            TabControl_Main.TabPages.Add(tabPage_Dashboard);          
        }
        public void LoadComboBox()
        {
            using (var ctx = new UniversityContext())
            {
                if (LoginStatus == 1)
                {
                    //Đưa dữ liệu môn học vào Combobox
                    var subjects = (from c in ctx.Classes
                                    join s in ctx.Subjects on c.SubjectID equals s.SubjectID
                                    where c.ProfessorID.ToString() == this.ProfessorID.ToString()
                                    select new
                                    {
                                        c.SubjectID,
                                        s.SubjectName
                                    }).Distinct();
                    foreach (var a in subjects)
                    {
                        cbb_Subjects_GradeForm.Items.Add(a.SubjectID);
                        cbb_Subjects_StudentForm.Items.Add(a.SubjectID);
                        cbb_Subject.Items.Add(a.SubjectName);
                        if(cbb_Subject.Items.Count==1)
                        {
                            cbb_Subject.Text = cbb_Subject.Items[0].ToString();
                        }
                    }

                    //Đưa dữ liệu lớp vào Combobox
                    var classes = (from c in ctx.Classes
                                 join s in ctx.Subjects on c.SubjectID equals s.SubjectID
                                 where c.ProfessorID.ToString() == this.ProfessorID.ToString()
                                 select new
                                 {
                                     c.ClassID
                                 }).Distinct();
                    foreach (var a in classes)
                    {
                        cbb_Classes_GradeForm.Items.Add(a.ClassID);
                        cbb_Classes_StudentForm.Items.Add(a.ClassID);
                    }                 
                }
                else
                {
                    var subjects = (from c in ctx.Classes
                                 join s in ctx.Subjects on c.SubjectID equals s.SubjectID
                                 select new
                                 {
                                     c.SubjectID
                                 }).Distinct();
                    foreach (var a in subjects)
                    {
                        cbb_Subjects_GradeForm.Items.Add(a.SubjectID);
                        cbb_Subjects_StudentForm.Items.Add(a.SubjectID);
                    }

                    var classes = (from c in ctx.Classes
                                 join s in ctx.Subjects on c.SubjectID equals s.SubjectID
                                 select new
                                 {
                                     c.ClassID
                                 }).Distinct();
                    foreach (var a in classes)
                    {
                        cbb_Classes_GradeForm.Items.Add(a.ClassID);
                        cbb_Classes_StudentForm.Items.Add(a.ClassID);
                    }

                    cbb_Deparment.Items.Add("All");
                    cbb_Deparment.Text = "All";
                    var departments = ctx.Departments.ToList();
                    foreach(var de in departments)
                    {
                        var studentAmount = ctx.Students.Where(s => s.DepartmentID == de.DepartmentID).Count();
                        if(studentAmount > 0)
                        {
                            cbb_Deparment.Items.Add(de.DeparmentName);
                        }
                    }
                }
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            //
            btnDashboard.BackColor = Color.RoyalBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.DarkBlue;
            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Analysis);
            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Dashboard);
            TabControl_Main.TabPages.Add(tabPage_Dashboard);
            txb_ProfessorName.Enabled = false;
            txb_PhoneNumber.Enabled = false;           
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.RoyalBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.DarkBlue;

            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Analysis);
            TabControl_Main.TabPages.Add(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Dashboard);
        }
        private void btnGrade_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.RoyalBlue;
            btnAnalysis.BackColor = Color.DarkBlue;


            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Analysis);
            TabControl_Main.TabPages.Add(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Dashboard);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.RoyalBlue;


            TabControl_Main.TabPages.Remove(tabPage_Student);
            TabControl_Main.TabPages.Remove(tabPage_Grade);
            TabControl_Main.TabPages.Remove(tabPage_Analysis);
            TabControl_Main.TabPages.Add(tabPage_Analysis);
            TabControl_Main.TabPages.Remove(tabPage_Dashboard);
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.DarkBlue;

        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.DarkBlue;


        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
            Environment.Exit(0);
        }
        private void panelMain_Click(object sender, EventArgs e)
        {
            //Xử Lý Giao Diện của Form
            btnDashboard.BackColor = Color.DarkBlue;
            btnStudent.BackColor = Color.DarkBlue;
            btnGrade.BackColor = Color.DarkBlue;
            btnAnalysis.BackColor = Color.DarkBlue;
            //Ẩn các tác vụ của các button main khác

        }
        #endregion

        #region Grade Tabpage
        private void cbb_Subjects_GradeForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_Classes_GradeForm.Text = string.Empty;

            BLGrade grades = new BLGrade();
            var list = grades.DetailGradeInfo_cbb_Subjects(cbb_Subjects_GradeForm.Text, this.ProfessorID.ToString());
            dgv_Grade.DataSource = list.ToList();

            cbb_Classes_GradeForm.Items.Clear();
            var temp = (from s in list select new { s.ClassID }).Distinct();

            foreach (DataGridViewRow row in dgv_Grade.Rows)
            {
                if (row.Cells[5].Value == null)
                {
                    row.Cells[5].Value = string.Empty;
                }
            }
            foreach (var a in temp)
            {
                cbb_Classes_GradeForm.Items.Add(a.ClassID);
            }
        }
        private void cbb_Classes_GradeForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLGrade grades = new BLGrade();
            var list = grades.DetailGradeInfo_cbb_Classes(cbb_Classes_GradeForm.Text, this.ProfessorID.ToString());
            dgv_Grade.DataSource = list.ToList();
            foreach (DataGridViewRow row in dgv_Grade.Rows)
            {
                if (row.Cells[5].Value == null)
                {
                    row.Cells[5].Value = string.Empty;
                }
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            var readfile = new BLGrade();
            switch (readfile.Readfile(txb_Path.Text))
            {
                case 2:
                    {
                        MessageBox.Show("Load all the grades in this file successfully !");
                        BLGrade grades = new BLGrade();
                        if (cbb_Classes_GradeForm.Text != string.Empty)
                        {
                            var list = grades.DetailGradeInfo_cbb_Classes(cbb_Classes_GradeForm.Text, this.ProfessorID.ToString());
                            dgv_Grade.DataSource = list.ToList();
                        }
                        else
                        {
                            var list = grades.DetailGradeInfo_cbb_Subjects(cbb_Subjects_GradeForm.Text, this.ProfessorID.ToString());
                            dgv_Grade.DataSource = list.ToList();
                        }
                        foreach (DataGridViewRow row in dgv_Grade.Rows)
                        {
                            if (row.Cells[5].Value == null)
                            {
                                row.Cells[5].Value = string.Empty;
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("This file have something wrong (the Student ID or Class ID) \n Can't read that, please try again !");
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show(" Can't find out this file, please check the file path again ! Is it exists ? ");
                        break;
                    }
            }

            txb_Path.Clear();
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Noting that how the data in the TXT file should be organized as: \n StudentID     ClassID     Mark \n ");
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
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
                txb_Path.Text = openFileDialog.FileName;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BLGrade update = new BLGrade();
            if (update.UpdateMark(StudentIDUpdate, ClassIDUpdate, null) == true)
            {
                BLGrade grades = new BLGrade();
                if (cbb_Classes_GradeForm.Text != string.Empty)
                {
                    var list = grades.DetailGradeInfo_cbb_Classes(cbb_Classes_GradeForm.Text, this.ProfessorID.ToString());
                    dgv_Grade.DataSource = list.ToList();
                }
                else
                {
                    var list = grades.DetailGradeInfo_cbb_Subjects(cbb_Subjects_GradeForm.Text, this.ProfessorID.ToString());
                    dgv_Grade.DataSource = list.ToList();
                }
                foreach (DataGridViewRow row in dgv_Grade.Rows)
                {
                    if (row.Cells[5].Value == null)
                    {
                        row.Cells[5].Value = string.Empty;
                    }
                }
                MessageBox.Show(" Deleted !");
            }
            else
            {
                MessageBox.Show(" Something wrong !");
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            BLGrade update = new BLGrade();
            bool flag = false;

            if (txb_EditMark.Text == string.Empty)
            {
                flag = update.UpdateMark(StudentIDUpdate, ClassIDUpdate, null);
            }
            else
            {
                flag = update.UpdateMark(StudentIDUpdate, ClassIDUpdate, Convert.ToDouble(txb_EditMark.Text));
            }

            if (flag == true)
            {
                BLGrade grades = new BLGrade();
                if (cbb_Classes_GradeForm.Text != string.Empty)
                {
                    var list = grades.DetailGradeInfo_cbb_Classes(cbb_Classes_GradeForm.Text, this.ProfessorID.ToString());
                    dgv_Grade.DataSource = list.ToList();
                }
                else
                {
                    var list = grades.DetailGradeInfo_cbb_Subjects(cbb_Subjects_GradeForm.Text, this.ProfessorID.ToString());
                    dgv_Grade.DataSource = list.ToList();
                }
                foreach (DataGridViewRow row in dgv_Grade.Rows)
                {
                    if (row.Cells[5].Value == null)
                    {
                        row.Cells[5].Value = string.Empty;
                    }
                }
                MessageBox.Show(" Updated !");
            }
            else
            {
                MessageBox.Show(" Something wrong !");
            }
        }
        private void dgv_Grade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_EditMark.Enabled = true;
            btn_Save.Enabled = true;
            btn_Delete.Enabled = true;
            lbl_Edit.Enabled = true;

            int rowindex = dgv_Grade.CurrentCell.RowIndex;
            StudentIDUpdate = (int)dgv_Grade.Rows[rowindex].Cells[3].Value;
            ClassIDUpdate = dgv_Grade.Rows[rowindex].Cells[0].Value.ToString();
            if (dgv_Grade.Rows[rowindex].Cells[5].Value == null)
            {
                txb_EditMark.Text = string.Empty;
            }
            else
            {
                txb_EditMark.Text = dgv_Grade.Rows[rowindex].Cells[5].Value.ToString();
            }
        }
        private void txt_Search_GradeForm_TextChanged(object sender, EventArgs e)
        {
            BLGrade grades = new BLGrade();
            var list = grades.Search(txt_Search_GradeForm.Text, cbb_Classes_GradeForm.Text, cbb_Subjects_GradeForm.Text);
            dgv_Grade.DataSource = list.ToList();
        }
        #endregion

        #region Student TabPage
        private void cbb_Classes_StudentForm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BLStudent students = new BLStudent();
            var detailInfo = students.DetailStudentInfo_cbb_Classes(cbb_Classes_StudentForm.Text, this.ProfessorID.ToString());
            dgv_Student.DataSource = detailInfo;
        }

        private void cbb_Subjects_StudentForm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbb_Classes_StudentForm.Text = string.Empty;

            BLStudent getInfo = new BLStudent();
            var detailInfo = getInfo.DetailStudentInfo_cbb_Subjects(cbb_Subjects_StudentForm.Text, this.ProfessorID.ToString());
            dgv_Student.DataSource = detailInfo;

            cbb_Classes_StudentForm.Items.Clear();
            var temp = (from s in detailInfo select new { s.ClassID }).Distinct();
            foreach (var a in temp)
            {
                cbb_Classes_StudentForm.Items.Add(a.ClassID);
            }
        }

        private void txb_Search_StudentForm_TextChanged_1(object sender, EventArgs e)
        {
            BLStudent students = new BLStudent();
            var findOut = students.Search(txb_Search_StudentForm.Text, cbb_Classes_StudentForm.Text, cbb_Subjects_StudentForm.Text);
            dgv_Student.DataSource = findOut.ToList();
        }
        #endregion

        #region Analysis TabPage
        private void btn_Kmean_Click(object sender, EventArgs e)
        {

            this.Ana = new BLAnalysis((int)numericUpDown_ClusterAmount.Value);
            if (Ana.Kmean(radioButton_KmeanPlusPlus.Checked,cbb_Deparment.Text,cbb_Subject.Text,ProfessorID) == 0)
            {
                MessageBox.Show("Your data contains null value in some grade ! Please Check !");
                return;
            }

            chart_AmountStudent.Show();
            chart_PercentClusters.Show();
            chart_AverageGrade.Show();

            chart_AmountStudent.Series["Student"].Points.Clear();
            chart_AverageGrade.Series["Average Grade"].Points.Clear();
            chart_PercentClusters.Series["Student"].Points.Clear();

            chart_PercentClusters.Series["Student"].IsValueShownAsLabel = true;
            using (var ctx = new UniversityContext())
            {
                int studentAmount;
                if (cbb_Deparment.Text == "All")
                {
                    studentAmount = ctx.Students.Count();
                }
                else
                {
                    if (cbb_Deparment.Text != string.Empty)
                    {
                        var departmentid = ctx.Departments.FirstOrDefault(d => d.DeparmentName == cbb_Deparment.Text).DepartmentID;
                        studentAmount = ctx.Students.Where(s => s.DepartmentID == departmentid).Count();
                    }
                    else
                    {
                       var subject = ctx.Subjects.SingleOrDefault(s => s.SubjectName == cbb_Subject.Text);
                       var classes = ctx.Classes.Where(s => s.SubjectID == subject.SubjectID && s.ProfessorID == ProfessorID);
                       var points = from grade in ctx.Grades
                                    join eachclass in classes
                                    on grade.ClassID equals eachclass.ClassID
                                    select grade;
                       var pointList = points.GroupBy(s => s.StudentID).ToList();
                       studentAmount = pointList.Count;                     
                    }
                }
                int count = 0;
                foreach (var cluster in Ana.Clusters)
                {
                    chart_AmountStudent.Series["Student"].Points.AddXY("Cluster" + count.ToString(), cluster.Count());
                    chart_AmountStudent.Series["Student"].Points[count].Label = cluster.Count().ToString();

                    chart_PercentClusters.Series["Student"].Points.AddXY("Cluster" + count.ToString(), (cluster.Count() * 100 / studentAmount));

                    double? averageGrade = 0;
                    foreach (var grade in Ana.CentralPoint[count])
                    {
                        averageGrade += grade.Mark;
                    }
                    averageGrade = averageGrade / Ana.CentralPoint[count].Count();
                    chart_AverageGrade.Series["Average Grade"].Points.AddXY("Cluster" + count.ToString(), averageGrade);
                    chart_AverageGrade.Series["Average Grade"].Points[count].Label = String.Format("{0:0.00}", averageGrade);
                    count++;
                }
            }
        }
        public List<DataGridView> CreateDataGridviewList()
        {
            List<DataGridView> ListClusterDataGridView = new List<DataGridView>();
            using (var ctx = new UniversityContext())
            {
                for (int i = 0; i < Ana.ClusterAmount; i++)
                {
                    var Temp = new DataGridView();
                    ListClusterDataGridView.Add(Temp);

                    DataGridViewTextBoxColumn temporaryColumnStudentID = new DataGridViewTextBoxColumn();
                    temporaryColumnStudentID.HeaderText = "Student ID";
                    Temp.Columns.Add(temporaryColumnStudentID);

                    DataGridViewTextBoxColumn temporaryColumnStudentName = new DataGridViewTextBoxColumn();
                    temporaryColumnStudentName.HeaderText = "Student Name";
                    Temp.Columns.Add(temporaryColumnStudentName);


                    if (LoginStatus == 2)
                    {
                        foreach (var subject in ctx.Subjects)
                        {
                            DataGridViewTextBoxColumn temporaryColumn = new DataGridViewTextBoxColumn();
                            temporaryColumn.HeaderText = subject.SubjectName;
                            Temp.Columns.Add(temporaryColumn);
                        }
                    }
                    else
                    {
                        DataGridViewTextBoxColumn temporaryColumn = new DataGridViewTextBoxColumn();
                        temporaryColumn.HeaderText = cbb_Subject.Text;
                        Temp.Columns.Add(temporaryColumn);
                    }

                    Temp.Dock = DockStyle.None;
                    Temp.Width = 1300;
                    Temp.Height = 350;
                    Temp.Location = new Point(100, Ana.ClusterAmount * 110 + i * 450);
                    Temp.ReadOnly = true;
                    Temp.MultiSelect = false;
                    Temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    Temp.RowHeadersVisible = false;
                    Temp.AllowUserToAddRows = false;
                    Temp.AllowUserToDeleteRows = false;
                    Temp.AllowUserToOrderColumns = true;


                    DataGridViewRow tempRow = new DataGridViewRow();
                    Temp.Rows.Add(tempRow);

                    if (LoginStatus == 2)
                    {
                        foreach (var point in Ana.Clusters[i])
                        {
                            DataGridViewRow row = (DataGridViewRow)Temp.Rows[0].Clone();
                            row.Cells[0].Value = point.Key;
                            row.Cells[1].Value = ctx.Students.FirstOrDefault(s => s.StudentID == point.Key).StudentName;
                            for (int j = 0; j < point.Count(); j++)
                            {
                                row.Cells[j + 2].Value = point.ElementAt(j).Mark;
                            }
                            Temp.Rows.Add(row);
                        }
                        Temp.Rows.RemoveAt(0);
                    }
                    else
                    {
                        foreach (var point in Ana.Clusters[i])
                        {
                            DataGridViewRow row = (DataGridViewRow)Temp.Rows[0].Clone();
                            row.Cells[0].Value = point.Key;
                            row.Cells[1].Value = ctx.Students.FirstOrDefault(s => s.StudentID == point.Key).StudentName;                       
                            row.Cells[2].Value = point.ElementAt(0).Mark;
                            Temp.Rows.Add(row);
                        }
                        Temp.Rows.RemoveAt(0);
                    }
                }
            }
            return ListClusterDataGridView;
        }
        private void btn_DetailList_Click(object sender, EventArgs e)
        {
            List<DataGridView> ListClusterDataGridView = CreateDataGridviewList();
            DetailForm detailForm = new DetailForm(this.Ana, ListClusterDataGridView);
            detailForm.ShowDialog();
        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            List<DataGridView> ListClusterDataGridView = CreateDataGridviewList();

            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                app.DisplayFullScreen = true;
                for (int l = 0; l < ListClusterDataGridView.Count; l++)
                {
                    worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Worksheets[l + 1];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Cluster " + (l).ToString();
                    try
                    {
                        for (int i = 0; i < ListClusterDataGridView[l].Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1] = ListClusterDataGridView[l].Columns[i].HeaderText;
                        }
                        for (int i = 0; i < ListClusterDataGridView[l].Rows.Count; i++)
                        {
                            for (int j = 0; j < ListClusterDataGridView[l].Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = ListClusterDataGridView[l].Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (l != ListClusterDataGridView.Count - 1)
                        {
                            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Worksheets.Add();
                        }
                        worksheet = null;
                    }
                }
               
                //SaveFileDialog saveDialog = new SaveFileDialog();
                //saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                //saveDialog.FilterIndex = 1;

                //if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    workbook.SaveAs(saveDialog.FileName);
                //    MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btn_ExportTXT_Click(object sender, EventArgs e)
        {
            List<DataGridView> ListClusterDataGridView = CreateDataGridviewList();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("\r\n Thuật toán chạy trong " + this.Ana.LoopCount + " lần ! \r\n");
            for (int i = 0; i < this.Ana.ClusterAmount; i++)
            {
                builder.AppendLine("\r\n Central Point của Cluster thứ " + i.ToString() + " là: ");
                builder.Append("\r\n(");
                for (int j = 0; j < this.Ana.CentralPoint[i].Count; j++)
                {
                    if (j != 19)
                    {
                        builder.Append(this.Ana.CentralPoint[i].ElementAt(j).Mark + " , ");
                    }
                    else
                    {
                        builder.Append(this.Ana.CentralPoint[i].ElementAt(j).Mark + " ");
                    }
                }
                builder.AppendLine(" ) \r\n");
            }
            builder.AppendLine("\r\n Sau đây là danh sách chi tiết các sinh viên thuộc các cluster: \r\n");


            for (int l = 0; l < ListClusterDataGridView.Count; l++)
            {
                builder.AppendLine("\r\n Cluster" + l.ToString());
                List<string> headerCols = new List<string>();
                for (int i = 0; i < ListClusterDataGridView[l].Columns.Count; i++)
                {
                    if (ListClusterDataGridView[l].Columns[i].HeaderText.Length < 6)
                    {
                        headerCols.Add(ListClusterDataGridView[l].Columns[i].HeaderText + "       ");
                    }
                    else
                    {
                        headerCols.Add(ListClusterDataGridView[l].Columns[i].HeaderText);
                    }
                }
                builder.AppendLine(string.Join("\t", headerCols.ToArray()));
                for (int i = 0; i < ListClusterDataGridView[l].Rows.Count; i++)
                {
                    List<string> cols = new List<string>();
                    for (int j = 0; j < ListClusterDataGridView[l].Columns.Count; j++)
                    {
                        if (j < 2)
                        {
                            if (ListClusterDataGridView[l].Rows[i].Cells[j].Value.ToString().Length < 17)
                            {
                                cols.Add(ListClusterDataGridView[l].Rows[i].Cells[j].Value.ToString() + "       ");
                            }
                            else
                            {
                                cols.Add(ListClusterDataGridView[l].Rows[i].Cells[j].Value.ToString() + "    ");
                            }
                        }
                        else
                        {
                            cols.Add(ListClusterDataGridView[l].Rows[i].Cells[j].Value.ToString() + "            ");
                        }
                    }
                    builder.AppendLine(string.Join("\t", cols.ToArray()));
                }
            }

            System.IO.File.WriteAllText(dialog.FileName, builder.ToString());
            MessageBox.Show(@"Text file was created.");
        }
        #endregion
    }
}
