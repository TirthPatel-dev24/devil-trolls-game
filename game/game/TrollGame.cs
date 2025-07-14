using login;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace game
{
    public partial class DevilTrolls : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        bool rightM, leftM, jump;
        int Gravity, Force = 9;
        private Panel[] playerBases;
        private bool isOnObstacle, isgoalReached = false, isTimerStarted = false;
        private int deathCounter, timeElapsed = 0;

        public DevilTrolls()
        {
            InitializeComponent();
            timer2.Stop();
        }

        private void DevilTrolls_Load(object sender, EventArgs e)
        {
            pboxPlayer.Hide();
            pnlBase.Hide();
            pnlScreen1.Hide();

            playerBases = new Panel[] { pnlPlayerbase1, pnlPlayerbase2, pnlPlayerbase3, pnlPlayerbase4, pnlPlayerbase5, pnlPlayerbase6, pnlPlayerbase7, pnlPlayerbase8 };
            isOnObstacle = false;
            deathCounter = -1;
            lblTimer.Text = "00:00";
            
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Black;
            btnStart.ForeColor = Color.Red;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(255, 128, 0);
            btnStart.ForeColor = Color.Black;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnTrollScore.Hide();
            btnExit.Hide();
            lbl1.Hide();
            lbl2.Hide();
            pboxPlayer.Show();
            pnlBase.Show();
            pnlScreen1.Show();
            lblDeaths.Show();
            this.Focus();
            RespawnPlayer();
            MessageBox.Show("Not Everything You See Is Real & Every Real thing is Unreal", "Disclaimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rightM) { pboxPlayer.Left += 5; }
            if (leftM) { pboxPlayer.Left -= 5; }

            if (jump)
            {
                pboxPlayer.Top -= Gravity;
                Gravity -= 1;


                foreach (var basePanel in playerBases)
                {
                    if (pboxPlayer.Bounds.IntersectsWith(basePanel.Bounds) && pboxPlayer.Top < basePanel.Top)
                    {
                        pboxPlayer.Top = basePanel.Top - pboxPlayer.Height;
                        Gravity = 0;
                        jump = false;
                        return;
                    }
                }


                if (pboxPlayer.Bounds.IntersectsWith(pnllava.Bounds)||pboxPlayer.Bounds.IntersectsWith(pnllava2.Bounds))
                {
                    RespawnPlayer();
                    return;
                }
            }
            else
            {
                pboxPlayer.Top += 5;


                bool isOnGround = false;
                foreach (var basePanel in playerBases)
                {
                    if (pboxPlayer.Bounds.IntersectsWith(basePanel.Bounds))
                    {
                        if (pboxPlayer.Top + pboxPlayer.Height > basePanel.Top)
                        {
                            pboxPlayer.Top = basePanel.Top - pboxPlayer.Height;
                            Gravity = 0;
                            jump = false;
                            isOnGround = true;
                        }
                        break;
                    }
                }


                if (pboxPlayer.Bounds.IntersectsWith(pnllava.Bounds) ||
                    pboxPlayer.Bounds.IntersectsWith(pnllava2.Bounds) ||
                    pboxPlayer.Top > this.ClientSize.Height ||
                    pboxPlayer.Left < 0 ||
                    pboxPlayer.Right > this.ClientSize.Width)
                {
                    RespawnPlayer();
                }


                if (pboxPlayer.Bounds.IntersectsWith(pboxSpikes1.Bounds) ||
                    pboxPlayer.Bounds.IntersectsWith(pboxSpikes2.Bounds) ||
                    pboxPlayer.Bounds.IntersectsWith(pboxSpikes3.Bounds) ||
                    pboxPlayer.Bounds.IntersectsWith(pnlBase.Bounds))
                {
                    RespawnPlayer();
                }


                if (!isOnGround && pboxPlayer.Top + pboxPlayer.Height > pnlBase.Top)
                {
                    RespawnPlayer();
                }


                if (isOnObstacle)
                {
                    pboxPlayer.Top += 5;
                }
            }

            if (pboxPlayer.Bounds.IntersectsWith(pnlGoal.Bounds) && !isgoalReached)
            {
                isgoalReached = true;
                pboxPlayer.Enabled = false;
                timer1.Stop();
                MessageBox.Show($"Congratulations! You've reached the goal!\nTime taken: {timeElapsed}Seconds",
                                "Goal Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveScoreToDatabase(Form1.loggedInUsername, timeElapsed, deathCounter);
                btnStart.Show();
                btnTrollScore.Show();
                btnExit.Show();
                lbl1.Show();
                lbl2.Show();
                pboxPlayer.Hide();
                pnlBase.Hide();
                pnlScreen1.Hide();
                lblDeaths.Hide();
                this.Focus();

            }
        }
        private void SaveScoreToDatabase(string username, int time, int attempts)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Scorecard (Username, Time, Attempt) VALUES (@Username, @Time, @Attempt)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Time", TimeSpan.FromSeconds(time));
                    cmd.Parameters.AddWithValue("@Attempt", attempts);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Your score has been saved!", "Score Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving score: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isgoalReached)
            {
                timeElapsed++;
                TimeSpan time = TimeSpan.FromSeconds(timeElapsed);
                lblTimer.Text = "Time: " + time.ToString(@"hh\:mm\:ss");
                if (pboxPlayer.Bounds.IntersectsWith(pnlGoal.Bounds) && !isgoalReached)
                {
                    isgoalReached = true;
                    timer2.Stop();
                    pboxPlayer.Enabled = false;
                }
            }
        }

        private void btnTrollScore_Click_1(object sender, EventArgs e)
        {
            Form3 ScoreForm = new Form3();

            ScoreForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RespawnPlayer()
        {
            deathCounter++;
            lblDeathCounter.Text = "Deaths: " + deathCounter;

            pboxPlayer.Location = new Point(50, 251);
            Gravity = 9;
            jump = false;
        }

        private void CheckCollisions()
        {

            if (pboxPlayer.Bounds.IntersectsWith(pnllava.Bounds) || pboxPlayer.Bounds.IntersectsWith(pnlBase.Bounds))
            {
                HandleDeath();
            }
        }

        private void HandleDeath()
        {
            deathCounter++;
            lblDeathCounter.Text = deathCounter.ToString();
            RespawnPlayer();
        }

        private void DevilTrolls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rightM = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                leftM = false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void DevilTrolls_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right) { 
                rightM = true;
                pboxPlayer.Image = Properties.Resources.player_right;
                StartTimerIfNotStarted();
            }
            if (e.KeyCode == Keys.Left) { 
                leftM = true;
                pboxPlayer.Image = Properties.Resources.player_left;
                StartTimerIfNotStarted();
            }
            if (e.KeyCode == Keys.Up && !jump)
            {
                jump = true;
                Gravity = Force;
                StartTimerIfNotStarted();
            }
        }
        private void StartTimerIfNotStarted()
        {
            if (!isTimerStarted)
            {
                timer2.Start();
                isTimerStarted = true;
            }
        }
    }
}