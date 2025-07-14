using game;
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


namespace login
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public static string loggedInUsername; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();

            registerForm.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        
        private bool IsPasswordCorrect(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);

                con.Open();
                string storedPassword = (string)cmd.ExecuteScalar();  
                con.Close();

                
                return storedPassword == password;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;  
            string password = txtPassword.Text; 

            
            if (!IsUsernameExists(username))
            {
                MessageBox.Show("Username does not exist.");
                return;
            }

            
            if (!IsPasswordCorrect(username, password))
            {
                MessageBox.Show("Invalid password.");
                return;
            }

            loggedInUsername = username;

            DevilTrolls registerForm = new DevilTrolls();

            registerForm.Show();

            this.Hide();

        }
    }
}