using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joyish
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Get username and password from the textboxes

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //Check if username or password is empty
            if (username == "" || password == "") 
            {
                MessageBox.Show("Please enter username and password");
                return; //Stop LogIn Process
            }
            //Create Database Connection
            DBConnect db = new DBConnect();

            try
            {
                //Open Database
                db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                //Create MYSQL Query
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add Parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue(@"Password", password);
                //Execute query and get results number
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); //Release comman resources

                if (count == 1) 
                {
                    MessageBox.Show("Login Succesful");
                    //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                db.Close();
            }
        }
    }
}
