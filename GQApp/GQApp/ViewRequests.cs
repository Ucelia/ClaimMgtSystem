using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GQApp
{
    public partial class ViewRequests : Form
    {
        public ViewRequests()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=GQdb;Integrated Security=True");
        private void ViewRequests_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Request", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            requestDgv.DataSource = dt;
        }

        private void requestDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.requestDgv.Rows[e.RowIndex];
            fullNameBox.Text = row.Cells["fullName"].Value.ToString();
            emailBox.Text = row.Cells["email"].Value.ToString();
            eventCombo.Text = row.Cells["event"].Value.ToString();
            statusCombo.Text = row.Cells["status"].Value.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "update Request set status ='" + statusCombo.Text + "' where email= '" + emailBox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Submitted successfully");
            displayData();
        }

        private void displayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Request", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Request");
            requestDgv.DataSource = ds.Tables["Request"];
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out");
            new Login().Show();
            this.Hide();
            
        }
    }
}
