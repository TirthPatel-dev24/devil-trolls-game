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
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadScoreboard();
            CustomizeDataGridView();
        }
        private void LoadScoreboard()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // SQL query to select the data from Scorecard, excluding rows where Time is '00:00:00'
                string query = @"
            SELECT Username, CONVERT(varchar(8), Time, 108) AS Time, Attempt 
            FROM Scorecard 
            WHERE Time != '00:00:00'  -- Exclude players with default time
            ORDER BY Time ASC, Attempt ASC";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Bind the data to the DataGridView
                dataGridView2.DataSource = dt;

                // Optionally, format the DataGridView columns
                dataGridView2.Columns["Time"].DefaultCellStyle.Format = "HH:mm:ss";  // Ensure the format is valid for a TIME value
                dataGridView2.Columns["Attempt"].HeaderText = "Attempts";  // Set custom column header text if needed
            }
        }
        private void CustomizeDataGridView()
        {
            // Make the columns fill the full width of the DataGridView
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set the background color of the DataGridView
            dataGridView2.BackgroundColor = Color.Red;

            // Set the cell background color to red
            dataGridView2.DefaultCellStyle.BackColor = Color.Red;



            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            dataGridView2.GridColor = Color.White;

            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkRed;

            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;

            dataGridView2.RowHeadersVisible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DevilTrolls game = new DevilTrolls();
            game.Show();
            this.Close();
        }
    }
}