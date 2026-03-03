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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 111);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 149);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 183);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Section";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 216);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // txtFirstNmae
            // 
            txtFirstNmae.Location = new Point(112, 71);
            txtFirstNmae.Name = "txtFirstNmae";
            txtFirstNmae.Size = new Size(100, 23);
            txtFirstNmae.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(112, 146);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(100, 23);
            txtCourse.TabIndex = 8;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(112, 180);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(100, 23);
            txtSection.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(112, 216);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
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
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstNmae;
        private TextBox txtLastName;
        private TextBox txtCourse;
        private TextBox txtSection;
        private TextBox txtAge;
    }
}