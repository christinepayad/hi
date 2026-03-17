namespace joyish
{
    partial class StudentList
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
            lblStudentMasterlist = new Label();
            txtMasterList = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            label2 = new Label();
            lblUpdateStudent = new Label();
            dgvStudents = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cbCourse = new ComboBox();
            cbSection = new ComboBox();
            txtAge = new TextBox();
            btnSaveRecord = new Button();
            btnDeleteRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentMasterlist
            // 
            lblStudentMasterlist.AutoSize = true;
            lblStudentMasterlist.Location = new Point(22, 25);
            lblStudentMasterlist.Name = "lblStudentMasterlist";
            lblStudentMasterlist.Size = new Size(131, 15);
            lblStudentMasterlist.TabIndex = 0;
            lblStudentMasterlist.Text = "STUDENT MASTER LIST";
            // 
            // txtMasterList
            // 
            txtMasterList.Location = new Point(49, 54);
            txtMasterList.Name = "txtMasterList";
            txtMasterList.Size = new Size(152, 23);
            txtMasterList.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(226, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 36);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(355, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 37);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(528, 139);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // lblUpdateStudent
            // 
            lblUpdateStudent.AutoSize = true;
            lblUpdateStudent.Location = new Point(528, 95);
            lblUpdateStudent.Name = "lblUpdateStudent";
            lblUpdateStudent.Size = new Size(187, 15);
            lblUpdateStudent.TabIndex = 5;
            lblUpdateStudent.Text = "UPDATE STUDENT INFORMATION";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(49, 104);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(337, 270);
            dgvStudents.TabIndex = 6;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 173);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "FirstName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 207);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 8;
            label5.Text = "LastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 246);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 9;
            label6.Text = "Course";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 290);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 10;
            label7.Text = "Section";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(528, 325);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 11;
            label8.Text = "Age";
            // 
            // txtID
            // 
            txtID.Location = new Point(552, 136);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(591, 170);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(591, 207);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 14;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(591, 246);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(121, 23);
            cbCourse.TabIndex = 15;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(594, 282);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(121, 23);
            cbSection.TabIndex = 16;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(594, 322);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 17;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new Point(570, 365);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(143, 43);
            btnSaveRecord.TabIndex = 18;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(567, 421);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(148, 45);
            btnDeleteRecord.TabIndex = 19;
            btnDeleteRecord.Text = "DELETE RECORD";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 553);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnSaveRecord);
            Controls.Add(txtAge);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvStudents);
            Controls.Add(lblUpdateStudent);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtMasterList);
            Controls.Add(lblStudentMasterlist);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentMasterlist;
        private TextBox txtMasterList;
        private Button btnSearch;
        private Button btnRefresh;
        private Label label2;
        private Label lblUpdateStudent;
        private DataGridView dgvStudents;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cbCourse;
        private ComboBox cbSection;
        private TextBox txtAge;
        private Button btnSaveRecord;
        private Button btnDeleteRecord;
    }
}