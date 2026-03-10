namespace joyish
{
    partial class LogIn
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
            lblUsernme = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // lblUsernme
            // 
            lblUsernme.AutoSize = true;
            lblUsernme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsernme.Location = new Point(27, 62);
            lblUsernme.Name = "lblUsernme";
            lblUsernme.Size = new Size(76, 19);
            lblUsernme.TabIndex = 0;
            lblUsernme.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(30, 95);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(103, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(113, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(103, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(113, 29);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(103, 130);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(113, 47);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 477);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsernme);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsernme;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogIn;
    }
}