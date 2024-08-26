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
    public partial class ViewStatus : Form
    {
        public ViewStatus()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=GQdb;Integrated Security=True");
        private void checkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT status FROM Request WHERE email='" + emailBox.Text + "' and event='" + eventCombo.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    statusCombo.Text = result.ToString();
                }
                else
                {
                    statusCombo.Text = "No data found";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Logged out");
            new Login().Show();
            this.Hide();
           
        }
    }
}
