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
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conn;
        int courseId;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox14.Properties.Settings.TeachingDBConnectionString"].ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseId, courseTitle FROM course WHERE courseId = " + "@courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                if (courseTable.Rows.Count < 1)
                    currentTitleLabel.Text = "No course found";
                else
                {
                    newTitleTextBox.Enabled = true;
                    newTitleTextBox.Focus();
                    updateButton.Enabled = true;
                    DataRow dr = courseTable.Rows[0];
                    courseId = int.Parse(dr["courseId"].ToString());
                    currentTitleLabel.Text = dr["courseTitle"].ToString();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE course SET courseTitle " + "= @courseNewTitle WHERE courseId = @courseId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseNewTitle", newTitleTextBox.Text);
                comd.Parameters.AddWithValue("@courseId", courseId);
                comd.ExecuteScalar();
                MessageBox.Show("Record updated.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
