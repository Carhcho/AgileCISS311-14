using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace dropbox14
{
    public partial class Form2 : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public Form2()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox14.Properties.Settings.TeachingDBConnectionString"].ConnectionString;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM instructor", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                newInstructorComboBox.DisplayMember = "instructorName";
                newInstructorComboBox.ValueMember = "instructorId";
                newInstructorComboBox.DataSource = instructorTable;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseId, courseTitle, instructor.instructorName FROM course" + " JOIN instructor ON course.instructorId = instructor.instructorId " + "WHERE courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                if(courseTable.Rows.Count < 1)
                {
                    courseTitleLabel.Text = "No course found";
                    newInstructorComboBox.Enabled = false;
                    updateButton.Enabled = false;
                    currentInstructorLabel.Text = string.Empty;
                }
                else
                {
                    DataRow dr = courseTable.Rows[0];
                    courseId = int.Parse(dr["courseId"].ToString());
                    courseTitleLabel.Text = dr["courseTitle"].ToString();
                    currentInstructorLabel.Text = dr["instructorName"].ToString(); 
                    newInstructorComboBox.Enabled = true;
                    updateButton.Enabled = true;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE course SET instructorId = @instructorId " + "WHERE courseId = @courseId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@instructorId", newInstructorComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Record updated.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
