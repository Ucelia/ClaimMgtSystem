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
using System.Security.Cryptography;

namespace GQApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=GQdb;Integrated Security=True");

        private const string _salt = "Fghjfghjkghjmgnk57gk9oHnj";
        private const string _alg = "HmacSHA256";
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string enteredPassword = passwordBox.Text;

            if (adminCheck.Checked)
            {
                LoginAsAdmin();
            }
            else
            {
                LoginAsApplicant(email, enteredPassword);
            }
        }

        private void LoginAsAdmin()
        {
            try
            {
                string query = "SELECT email, password FROM Admin WHERE email = '"+emailBox.Text+"' AND password = '"+passwordBox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Admin login successful!");

                    new ViewRequests().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Admin login failed. Please check your credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoginAsApplicant(string email, string enteredPassword)
        {
            string storedPasswordHash = GetStoredApplicantPasswordHash(email);

            if (storedPasswordHash != null)
            {
                string enteredPasswordHash = GetHashedPassword(enteredPassword);

                if (storedPasswordHash == enteredPasswordHash)
                {
                    MessageBox.Show("Student login successful!");

                    new AttendEvent().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Student login failed. Please check your credentials.");
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
            con.Close();
        }

        private string GetStoredApplicantPasswordHash(string email)
        {
            con.Open();
            string query = "SELECT password FROM Applicant WHERE Email = @Email";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Email", email);
                object result = command.ExecuteScalar();
                return result as string;
            }
        }

        public static string GetHashedPassword(string password)
        {
            string key = string.Join(":", new string[] { password, _salt });

            using (HMAC hmac = HMACSHA256.Create(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(_salt);
                hmac.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(hmac.Hash);
            }
        }


        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
