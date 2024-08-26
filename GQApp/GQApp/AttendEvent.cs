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
    public partial class AttendEvent : Form
    {
        public AttendEvent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=GQdb;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Request (fullName, email, event) VALUES ('" + fullNameBox.Text + "','" + emailBox.Text + "','" + eventCombo.Text + "')";
                SqlCommand command = new SqlCommand(query, con);
                int cmd = (int)command.ExecuteNonQuery();
                if (cmd != 1)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Request sent successfully");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            new ViewStatus().Show();
            this.Hide();
        }
    }
}
