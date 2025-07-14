using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace login
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;  
            string password = txtPassword.Text;  
            string confirmPassword = txtConfirmPassword.Text;  

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }

            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists, please choose a different one.");
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 7 characters long, contain at least one digit and one special character.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            InsertUser(username, password);

            MessageBox.Show("You really want to Register yourself in this trol!");
            Form1 LoginForm = new Form1();

            LoginForm.Show();

            this.Close();
        }
        private bool IsUsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                return count > 0;
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 7) return false;

            bool hasDigit = Regex.IsMatch(password, @"\d");

            return hasDigit;
        }

        private void InsertUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string userQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmdUser = new SqlCommand(userQuery, con);
                cmdUser.Parameters.AddWithValue("@Username", username);
                cmdUser.Parameters.AddWithValue("@Password", password);  

                string scorecardQuery = "INSERT INTO Scorecard (Username) VALUES (@Username)";
                SqlCommand cmdScorecard = new SqlCommand(scorecardQuery, con);
                cmdScorecard.Parameters.AddWithValue("@Username", username); 

                con.Open();

                SqlTransaction transaction = con.BeginTransaction();
                cmdUser.Transaction = transaction;
                cmdScorecard.Transaction = transaction;

                try
                {
                    cmdUser.ExecuteNonQuery();
                    cmdScorecard.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();

            LoginForm.Show();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}