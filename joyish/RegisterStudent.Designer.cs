namespace joyish
{
    partial class RegisterStudent
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
            label1 = new Label();
            lblName = new Label();
            lblLast = new Label();
            lblCourse = new Label();
            lblSection = new Label();
            lblAge = new Label();
            txtFirstNmae = new TextBox();
            txtLastName = new TextBox();
            txtCourse = new TextBox();
            txtSection = new TextBox();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 15);
            lblName.TabIndex = 1;
            lblName.Text = "FirstName";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(46, 111);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(60, 15);
            lblLast.TabIndex = 2;
            lblLast.Text = "LastName";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(52, 149);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(44, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Location = new Point(50, 183);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(46, 15);
            lblSection.TabIndex = 4;
            lblSection.Text = "Section";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(52, 216);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // txtFirstNmae
            // 
            txtFirstNmae.Location = new Point(112, 71);
            txtFirstNmae.Name = "txtFirstNmae";
            txtFirstNmae.Size = new Size(168, 23);
            txtFirstNmae.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(112, 146);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(168, 23);
            txtCourse.TabIndex = 8;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(112, 180);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(168, 23);
            txtSection.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(112, 216);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(168, 23);
            txtAge.TabIndex = 10;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(txtAge);
            Controls.Add(txtSection);
            Controls.Add(txtCourse);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstNmae);
            Controls.Add(lblAge);
            Controls.Add(lblSection);
            Controls.Add(lblCourse);
            Controls.Add(lblLast);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblLast;
        private Label lblCourse;
        private Label lblSection;
        private Label lblAge;
        private TextBox txtFirstNmae;
        private TextBox txtLastName;
        private TextBox txtCourse;
        private TextBox txtSection;
        private TextBox txtAge;
    }
}