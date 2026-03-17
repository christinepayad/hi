using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace joyish
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            cbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            LoadStudents();
        private void LoadStudents()
        {
            string search = btnSearch.Text.Trim();
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM students WHERE firstname LIKE @search or lastname @search or course LIKE @search or section LIKE @search";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                //Fill table
                adapter.Fill(table);
                dgvStudents.DataSource = table;

                //Change column headers
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "firstname";
                dgvStudents.Columns["lastname"].HeaderText = "lastname";
                dgvStudents.Columns["course"].HeaderText = "course";
                dgvStudents.Columns["section"].HeaderText = "section";
                dgvStudents.Columns["age"].HeaderText = "age";
                adapter.Dispose();
                cmd.Dispose();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].ToString();
                txtID.Text = row.Cells["firstnmae"].Value.ToString();
                txtID.Text = row.Cells["lastname"].Value.ToString();
                txtID.Text = row.Cells["course"].Value.ToString();
                txtID.Text = row.Cells["section"].Value.ToString();
                txtID.Text = row.Cells["age"].Value.ToString();
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstNmae.Text;
            string lastname = txtLastName.Text;
            string course = cbCourse.SelectedItem.ToString();
            string section = cbSection.SelectedItem.ToString();
            int age;
            int ID;

            if (string.IsNullOrEmpty(firstname)
                || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(course)
                || string.IsNullOrEmpty(section)

            {

                MessageBox.Show("Please fill all fileds");
                return;
            }
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid age");
                return;
            }
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please enter a valid age");
                return;
                DBConnect db = new DBConnect();
                try
                {
                    db.Open();
                    string query = "UPDATE students SET firstname=@firstname, lastname=@lastname, course=@course, section=@section, age=@age WHERE ID =@ID";

                    MySql.Data.MySqlClient.MySqlcommand cmd =
                        new MySql.Data.MySqlClient().MySqlCommand(query, db.Connection);

                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    txtID.Clear();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    cbCourse.SelectedIndex = -1;
                    cbSection.SelectedIndex = -1;
                    LoadStudents();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            int ID;
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click Record to Delete");
                return;
            }
            try() 
            { 
            
            }
        }
         
    }
         
}
