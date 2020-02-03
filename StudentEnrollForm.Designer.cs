namespace Coursework
{
    partial class StudentEnrollForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortingPanel = new System.Windows.Forms.Panel();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sortOrderCB = new System.Windows.Forms.ComboBox();
            this.courseCB = new System.Windows.Forms.ComboBox();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.birthDateDP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.registerDP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.genderCBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contacTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.weeklyReportDP = new System.Windows.Forms.DateTimePicker();
            this.weeklyReportOfStudent = new System.Windows.Forms.DataGridView();
            this.Programee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.sortingPanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Enrollment Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sortingPanel);
            this.panel1.Controls.Add(this.courseCB);
            this.panel1.Controls.Add(this.IdTxtBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.birthDateDP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.registerDP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.genderCBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.emailTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.contacTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addressTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lNameTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fNameTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 387);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sortingPanel
            // 
            this.sortingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortingPanel.Controls.Add(this.sortBtn);
            this.sortingPanel.Controls.Add(this.sortCB);
            this.sortingPanel.Controls.Add(this.label12);
            this.sortingPanel.Controls.Add(this.label13);
            this.sortingPanel.Controls.Add(this.sortOrderCB);
            this.sortingPanel.Location = new System.Drawing.Point(33, 309);
            this.sortingPanel.Name = "sortingPanel";
            this.sortingPanel.Size = new System.Drawing.Size(333, 67);
            this.sortingPanel.TabIndex = 24;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(235, 20);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortCB
            // 
            this.sortCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCB.FormattingEnabled = true;
            this.sortCB.Items.AddRange(new object[] {
            "Name",
            "Registration Date"});
            this.sortCB.Location = new System.Drawing.Point(91, 35);
            this.sortCB.Name = "sortCB";
            this.sortCB.Size = new System.Drawing.Size(106, 21);
            this.sortCB.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Sort acoording: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sorting Order: ";
            // 
            // sortOrderCB
            // 
            this.sortOrderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderCB.FormattingEnabled = true;
            this.sortOrderCB.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderCB.Location = new System.Drawing.Point(91, 8);
            this.sortOrderCB.Name = "sortOrderCB";
            this.sortOrderCB.Size = new System.Drawing.Size(106, 21);
            this.sortOrderCB.TabIndex = 0;
            this.sortOrderCB.SelectedIndexChanged += new System.EventHandler(this.sortOrder_SelectedIndexChanged);
            // 
            // courseCB
            // 
            this.courseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCB.FormattingEnabled = true;
            this.courseCB.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.courseCB.Location = new System.Drawing.Point(110, 163);
            this.courseCB.Name = "courseCB";
            this.courseCB.Size = new System.Drawing.Size(217, 21);
            this.courseCB.TabIndex = 23;
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(110, 7);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.ReadOnly = true;
            this.IdTxtBox.Size = new System.Drawing.Size(217, 20);
            this.IdTxtBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id:";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(72, 280);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(261, 280);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(165, 280);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // birthDateDP
            // 
            this.birthDateDP.Location = new System.Drawing.Point(110, 244);
            this.birthDateDP.Name = "birthDateDP";
            this.birthDateDP.Size = new System.Drawing.Size(217, 20);
            this.birthDateDP.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Birth Date:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // registerDP
            // 
            this.registerDP.Location = new System.Drawing.Point(110, 218);
            this.registerDP.Name = "registerDP";
            this.registerDP.Size = new System.Drawing.Size(217, 20);
            this.registerDP.TabIndex = 15;
            this.registerDP.Value = new System.DateTime(2020, 1, 2, 14, 17, 29, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Registration Date:";
            // 
            // genderCBox
            // 
            this.genderCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCBox.FormattingEnabled = true;
            this.genderCBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCBox.Location = new System.Drawing.Point(110, 190);
            this.genderCBox.Name = "genderCBox";
            this.genderCBox.Size = new System.Drawing.Size(217, 21);
            this.genderCBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(110, 112);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(217, 20);
            this.emailTxtBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contacTxtBox
            // 
            this.contacTxtBox.Location = new System.Drawing.Point(110, 86);
            this.contacTxtBox.Name = "contacTxtBox";
            this.contacTxtBox.Size = new System.Drawing.Size(217, 20);
            this.contacTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact No:";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(110, 138);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(217, 20);
            this.addressTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.Location = new System.Drawing.Point(110, 60);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(217, 20);
            this.lNameTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Location = new System.Drawing.Point(110, 34);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(217, 20);
            this.fNameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartPanel
            // 
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Controls.Add(this.chart);
            this.chartPanel.Location = new System.Drawing.Point(427, 47);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(373, 311);
            this.chartPanel.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 6);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(365, 297);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridStudent.Location = new System.Drawing.Point(12, 440);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.Size = new System.Drawing.Size(396, 148);
            this.dataGridStudent.TabIndex = 3;
            this.dataGridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.weeklyReportDP);
            this.panel2.Controls.Add(this.weeklyReportOfStudent);
            this.panel2.Location = new System.Drawing.Point(427, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 224);
            this.panel2.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Weekly report of students";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Date Time Picker: ";
            // 
            // weeklyReportDP
            // 
            this.weeklyReportDP.Location = new System.Drawing.Point(111, 36);
            this.weeklyReportDP.Name = "weeklyReportDP";
            this.weeklyReportDP.Size = new System.Drawing.Size(200, 20);
            this.weeklyReportDP.TabIndex = 1;
            this.weeklyReportDP.ValueChanged += new System.EventHandler(this.weeklyReportDP_ValueChanged);
            // 
            // weeklyReportOfStudent
            // 
            this.weeklyReportOfStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportOfStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Programee,
            this.totalStudents});
            this.weeklyReportOfStudent.Location = new System.Drawing.Point(3, 75);
            this.weeklyReportOfStudent.Name = "weeklyReportOfStudent";
            this.weeklyReportOfStudent.Size = new System.Drawing.Size(365, 144);
            this.weeklyReportOfStudent.TabIndex = 0;
            // 
            // Programee
            // 
            this.Programee.HeaderText = "Programee";
            this.Programee.Name = "Programee";
            // 
            // totalStudents
            // 
            this.totalStudents.HeaderText = "Total Students";
            this.totalStudents.Name = "totalStudents";
            // 
            // StudentEnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(813, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridStudent);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StudentEnrollForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentEnrollForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sortingPanel.ResumeLayout(false);
            this.sortingPanel.PerformLayout();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportOfStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contacTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderCBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker registerDP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker birthDateDP;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox courseCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel sortingPanel;
        private System.Windows.Forms.ComboBox sortCB;
        private System.Windows.Forms.ComboBox sortOrderCB;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker weeklyReportDP;
        private System.Windows.Forms.DataGridView weeklyReportOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programee;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStudents;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label15;
    }
}

