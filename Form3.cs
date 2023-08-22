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
    public partial class Form3 : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public Form3()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox14.Properties.Settings.TeachingDBConnectionString"].ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseId, " + "courseTitle, instructor.instructorName FROM course JOIN instructor ON " + "course.instructorId = instructor.instructorId WHERE courseId = " + "@courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                if(courseTable.Rows.Count < 1)
                {
                    courseTitleLabel.Text = "No course found";
                    instructorLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                }
                else
                {
                    DataRow dr = courseTable.Rows[0];
                    courseId = int.Parse(dr["courseId"].ToString());
                    courseTitleLabel.Text = dr["courseTitle"].ToString();
                    instructorLabel.Text = dr["instructorName"].ToString();
                    deleteButton.Enabled = true;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("DELETE FROM course WHERE courseId = @courseId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("courseId", courseId);
                comd.ExecuteScalar();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
