namespace Do_An_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelPhu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageGrade = new System.Windows.Forms.TabPage();
            this.tabPageAnalysis = new System.Windows.Forms.TabPage();
            this.btnKmean = new System.Windows.Forms.Button();
            this.chart_Circle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Column = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_ClusterAmount = new System.Windows.Forms.NumericUpDown();
            this.radioButton_Kmean = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnEditGrade = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDelGrade = new System.Windows.Forms.Button();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.btnInFoGrade = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnInFoStudent = new System.Windows.Forms.Button();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelPhu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPhu
            // 
            this.panelPhu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPhu.Controls.Add(this.btnExcel);
            this.panelPhu.Controls.Add(this.btnGraph);
            this.panelPhu.Controls.Add(this.btnPin);
            this.panelPhu.Controls.Add(this.btnEditGrade);
            this.panelPhu.Controls.Add(this.btnEditStudent);
            this.panelPhu.Controls.Add(this.btnAddStudent);
            this.panelPhu.Controls.Add(this.btnDelGrade);
            this.panelPhu.Controls.Add(this.btnDelStudent);
            this.panelPhu.Controls.Add(this.btnInFoGrade);
            this.panelPhu.Controls.Add(this.btnAddGrade);
            this.panelPhu.Controls.Add(this.btnInFoStudent);
            this.panelPhu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPhu.Location = new System.Drawing.Point(230, 0);
            this.panelPhu.Name = "panelPhu";
            this.panelPhu.Size = new System.Drawing.Size(207, 846);
            this.panelPhu.TabIndex = 1;
            this.panelPhu.Click += new System.EventHandler(this.panelPhu_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkBlue;
            this.panelMain.Controls.Add(this.picSmall);
            this.panelMain.Controls.Add(this.btnHelp);
            this.panelMain.Controls.Add(this.btnSetting);
            this.panelMain.Controls.Add(this.btnGrade);
            this.panelMain.Controls.Add(this.btnReport);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.btnStudent);
            this.panelMain.Controls.Add(this.btnDashboard);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(230, 846);
            this.panelMain.TabIndex = 0;
            this.panelMain.Click += new System.EventHandler(this.panelMain_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainTabControl.Controls.Add(this.tabPageStudent);
            this.MainTabControl.Controls.Add(this.tabPageGrade);
            this.MainTabControl.Controls.Add(this.tabPageAnalysis);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(437, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1353, 846);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 2;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.dataGridView1);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(1293, 759);
            this.tabPageStudent.TabIndex = 0;
            this.tabPageStudent.Text = "Student";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            this.tabPageStudent.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageGrade
            // 
            this.tabPageGrade.Location = new System.Drawing.Point(4, 4);
            this.tabPageGrade.Name = "tabPageGrade";
            this.tabPageGrade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrade.Size = new System.Drawing.Size(1293, 759);
            this.tabPageGrade.TabIndex = 1;
            this.tabPageGrade.Text = "Grade";
            this.tabPageGrade.UseVisualStyleBackColor = true;
            this.tabPageGrade.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Controls.Add(this.listView1);
            this.tabPageAnalysis.Controls.Add(this.radioButton2);
            this.tabPageAnalysis.Controls.Add(this.radioButton_Kmean);
            this.tabPageAnalysis.Controls.Add(this.button3);
            this.tabPageAnalysis.Controls.Add(this.button1);
            this.tabPageAnalysis.Controls.Add(this.button2);
            this.tabPageAnalysis.Controls.Add(this.numericUpDown_ClusterAmount);
            this.tabPageAnalysis.Controls.Add(this.chart_Column);
            this.tabPageAnalysis.Controls.Add(this.chart_Circle);
            this.tabPageAnalysis.Controls.Add(this.btnKmean);
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 4);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalysis.Size = new System.Drawing.Size(1345, 820);
            this.tabPageAnalysis.TabIndex = 2;
            this.tabPageAnalysis.Text = "Analysis";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;
            this.tabPageAnalysis.Click += new System.EventHandler(this.tabPageAnalysis_Click);
            // 
            // btnKmean
            // 
            this.btnKmean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKmean.Location = new System.Drawing.Point(771, 27);
            this.btnKmean.Name = "btnKmean";
            this.btnKmean.Size = new System.Drawing.Size(212, 72);
            this.btnKmean.TabIndex = 4;
            this.btnKmean.Text = "Analize ";
            this.btnKmean.UseVisualStyleBackColor = true;
            this.btnKmean.Click += new System.EventHandler(this.btnKmean_Click);
            // 
            // chart_Circle
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 60;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Name = "ChartArea1";
            this.chart_Circle.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Circle.Legends.Add(legend2);
            this.chart_Circle.Location = new System.Drawing.Point(538, 138);
            this.chart_Circle.Name = "chart_Circle";
            this.chart_Circle.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Circle.Series.Add(series2);
            this.chart_Circle.Size = new System.Drawing.Size(300, 300);
            this.chart_Circle.TabIndex = 5;
            this.chart_Circle.Text = "chart1";
            // 
            // chart_Column
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart_Column.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Column.Legends.Add(legend1);
            this.chart_Column.Location = new System.Drawing.Point(81, 105);
            this.chart_Column.Name = "chart_Column";
            this.chart_Column.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart_Column.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sinh viên ";
            series1.YValuesPerPoint = 4;
            this.chart_Column.Series.Add(series1);
            this.chart_Column.Size = new System.Drawing.Size(399, 300);
            this.chart_Column.TabIndex = 6;
            this.chart_Column.Text = "Amount ";
            // 
            // numericUpDown_ClusterAmount
            // 
            this.numericUpDown_ClusterAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_ClusterAmount.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_ClusterAmount.Location = new System.Drawing.Point(442, 81);
            this.numericUpDown_ClusterAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_ClusterAmount.Name = "numericUpDown_ClusterAmount";
            this.numericUpDown_ClusterAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_ClusterAmount.Size = new System.Drawing.Size(216, 18);
            this.numericUpDown_ClusterAmount.TabIndex = 7;
            this.numericUpDown_ClusterAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_ClusterAmount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // radioButton_Kmean
            // 
            this.radioButton_Kmean.AutoSize = true;
            this.radioButton_Kmean.Location = new System.Drawing.Point(442, 27);
            this.radioButton_Kmean.Name = "radioButton_Kmean";
            this.radioButton_Kmean.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Kmean.TabIndex = 13;
            this.radioButton_Kmean.TabStop = true;
            this.radioButton_Kmean.Text = "K-mean";
            this.radioButton_Kmean.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(608, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "K-mean++";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Do_An_1.Properties.Resources.icons8_text_64px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(309, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "Export TXT";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Do_An_1.Properties.Resources.graph_50px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(596, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "      Graph";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Do_An_1.Properties.Resources.report_card1_40px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(36, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "         Export Excel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::Do_An_1.Properties.Resources.report_card1_40px;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(-4, 245);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(210, 70);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "         Export Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Image = global::Do_An_1.Properties.Resources.graph_50px;
            this.btnGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.Location = new System.Drawing.Point(-4, 314);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(210, 70);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.Text = "      Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnPin
            // 
            this.btnPin.Image = global::Do_An_1.Properties.Resources.pin_30px;
            this.btnPin.Location = new System.Drawing.Point(166, 0);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(40, 37);
            this.btnPin.TabIndex = 4;
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnEditGrade
            // 
            this.btnEditGrade.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGrade.Image = global::Do_An_1.Properties.Resources.edit_property_60px;
            this.btnEditGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditGrade.Location = new System.Drawing.Point(-3, 383);
            this.btnEditGrade.Name = "btnEditGrade";
            this.btnEditGrade.Size = new System.Drawing.Size(210, 70);
            this.btnEditGrade.TabIndex = 6;
            this.btnEditGrade.Text = "      Edit";
            this.btnEditGrade.UseVisualStyleBackColor = false;
            this.btnEditGrade.Click += new System.EventHandler(this.btnEditGrade_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.Image = global::Do_An_1.Properties.Resources.edit_user_male_45px;
            this.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStudent.Location = new System.Drawing.Point(4, 383);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(202, 70);
            this.btnEditStudent.TabIndex = 3;
            this.btnEditStudent.Text = "  Edit";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Image = global::Do_An_1.Properties.Resources.student_registration_40px;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(4, 314);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(202, 70);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "   Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDelGrade
            // 
            this.btnDelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelGrade.Image = global::Do_An_1.Properties.Resources.filled_trash_50px;
            this.btnDelGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelGrade.Location = new System.Drawing.Point(0, 452);
            this.btnDelGrade.Name = "btnDelGrade";
            this.btnDelGrade.Size = new System.Drawing.Size(207, 70);
            this.btnDelGrade.TabIndex = 4;
            this.btnDelGrade.Text = "          Delete";
            this.btnDelGrade.UseVisualStyleBackColor = true;
            this.btnDelGrade.Click += new System.EventHandler(this.btnDelGrade_Click);
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStudent.Image = global::Do_An_1.Properties.Resources.delete_60px;
            this.btnDelStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelStudent.Location = new System.Drawing.Point(-7, 452);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(213, 70);
            this.btnDelStudent.TabIndex = 1;
            this.btnDelStudent.Text = "         Delete";
            this.btnDelStudent.UseVisualStyleBackColor = false;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // btnInFoGrade
            // 
            this.btnInFoGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInFoGrade.Image = global::Do_An_1.Properties.Resources.report_card_60px;
            this.btnInFoGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInFoGrade.Location = new System.Drawing.Point(-3, 245);
            this.btnInFoGrade.Name = "btnInFoGrade";
            this.btnInFoGrade.Size = new System.Drawing.Size(210, 70);
            this.btnInFoGrade.TabIndex = 3;
            this.btnInFoGrade.Text = "           Grade";
            this.btnInFoGrade.UseVisualStyleBackColor = true;
            this.btnInFoGrade.Click += new System.EventHandler(this.btnInFoGrade_Click);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.Image = global::Do_An_1.Properties.Resources.add_50px;
            this.btnAddGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGrade.Location = new System.Drawing.Point(0, 314);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(207, 70);
            this.btnAddGrade.TabIndex = 5;
            this.btnAddGrade.Text = "       Add";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // btnInFoStudent
            // 
            this.btnInFoStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInFoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInFoStudent.Image = global::Do_An_1.Properties.Resources.id_male_student_60px;
            this.btnInFoStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInFoStudent.Location = new System.Drawing.Point(-4, 245);
            this.btnInFoStudent.Name = "btnInFoStudent";
            this.btnInFoStudent.Size = new System.Drawing.Size(210, 70);
            this.btnInFoStudent.TabIndex = 0;
            this.btnInFoStudent.Text = "          Student";
            this.btnInFoStudent.UseVisualStyleBackColor = false;
            this.btnInFoStudent.Click += new System.EventHandler(this.btnInFoStudent_Click);
            // 
            // picSmall
            // 
            this.picSmall.Image = global::Do_An_1.Properties.Resources.home_50px;
            this.picSmall.Location = new System.Drawing.Point(3, 99);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(50, 50);
            this.picSmall.TabIndex = 8;
            this.picSmall.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::Do_An_1.Properties.Resources.help_40px;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(5, 590);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(225, 70);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = " Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Do_An_1.Properties.Resources.settings_40px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(5, 521);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(225, 70);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "    Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.Color.White;
            this.btnGrade.Image = global::Do_An_1.Properties.Resources.exam_40px;
            this.btnGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrade.Location = new System.Drawing.Point(3, 383);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(227, 70);
            this.btnGrade.TabIndex = 5;
            this.btnGrade.Text = "   Grade";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkBlue;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Do_An_1.Properties.Resources.report_file_40px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 452);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(227, 70);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "  Analysis ";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Do_An_1.Properties.Resources.home_120px;
            this.pictureBox1.Location = new System.Drawing.Point(60, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::Do_An_1.Properties.Resources.student_male_50px;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 314);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(230, 70);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "       Students";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Do_An_1.Properties.Resources.squared_menu_40px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 245);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(227, 70);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "            Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(915, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 206);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1790, 846);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.panelPhu);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panelPhu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAnalysis.ResumeLayout(false);
            this.tabPageAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClusterAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPhu;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnEditGrade;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDelGrade;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Button btnInFoGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnInFoStudent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabPageGrade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Column;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Circle;
        private System.Windows.Forms.Button btnKmean;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClusterAmount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton_Kmean;
        private System.Windows.Forms.ListView listView1;
    }
}

