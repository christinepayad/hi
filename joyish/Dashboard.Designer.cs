namespace joyish
{
    partial class Dashboard
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
            btnRegister = new Button();
            btnStudentList = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveBorder;
            btnRegister.Location = new Point(31, 147);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(331, 102);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnStudentList
            // 
            btnStudentList.BackColor = SystemColors.ActiveBorder;
            btnStudentList.Location = new Point(396, 147);
            btnStudentList.Name = "btnStudentList";
            btnStudentList.Size = new Size(310, 102);
            btnStudentList.TabIndex = 1;
            btnStudentList.Text = "STUDENT LIST";
            btnStudentList.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(799, 537);
            Controls.Add(btnStudentList);
            Controls.Add(btnRegister);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnStudentList;
    }
}