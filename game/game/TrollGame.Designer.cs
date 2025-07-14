using System.Windows.Forms;

namespace game
{
    partial class DevilTrolls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevilTrolls));
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.pnlScreen1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlblockObstacle3 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase8 = new System.Windows.Forms.Panel();
            this.Goal = new System.Windows.Forms.Label();
            this.pnlGoal = new System.Windows.Forms.Panel();
            this.lblDeathCounter = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.pnlPlayerbase7 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase6 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase5 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase4 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase2 = new System.Windows.Forms.Panel();
            this.pnlblockObstacle1 = new System.Windows.Forms.Panel();
            this.pnllava = new System.Windows.Forms.Panel();
            this.pnlblockObstacle2 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase3 = new System.Windows.Forms.Panel();
            this.pnlPlayerbase1 = new System.Windows.Forms.Panel();
            this.pnllava2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnTrollScore = new System.Windows.Forms.Button();
            this.pboxSpikes3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxdumpSpikes = new System.Windows.Forms.PictureBox();
            this.pboxSpikes2 = new System.Windows.Forms.PictureBox();
            this.pboxSpikes1 = new System.Windows.Forms.PictureBox();
            this.pboxPlayer = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBase.SuspendLayout();
            this.pnlScreen1.SuspendLayout();
            this.pnlPlayerbase8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdumpSpikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Engravers MT", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(234, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(274, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Tolls";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 43F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl1.Location = new System.Drawing.Point(205, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(364, 101);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Devil Trolls";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(269, 122);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(217, 31);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Yes it Really Trolls 😈";
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlBase.Controls.Add(this.lblCredits);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.Location = new System.Drawing.Point(0, 372);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(776, 60);
            this.pnlBase.TabIndex = 2;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.lblCredits.ForeColor = System.Drawing.Color.Yellow;
            this.lblCredits.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCredits.Location = new System.Drawing.Point(251, 29);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(247, 31);
            this.lblCredits.TabIndex = 24;
            this.lblCredits.Text = "22BCA239 * 22BCA144";
            // 
            // pnlScreen1
            // 
            this.pnlScreen1.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlScreen1.Controls.Add(this.lblTimer);
            this.pnlScreen1.Controls.Add(this.pboxSpikes3);
            this.pnlScreen1.Controls.Add(this.pnlblockObstacle3);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase8);
            this.pnlScreen1.Controls.Add(this.pictureBox2);
            this.pnlScreen1.Controls.Add(this.pictureBox1);
            this.pnlScreen1.Controls.Add(this.pboxdumpSpikes);
            this.pnlScreen1.Controls.Add(this.pboxSpikes2);
            this.pnlScreen1.Controls.Add(this.pboxSpikes1);
            this.pnlScreen1.Controls.Add(this.pnlGoal);
            this.pnlScreen1.Controls.Add(this.lblDeathCounter);
            this.pnlScreen1.Controls.Add(this.lblDeaths);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase7);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase6);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase5);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase4);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase2);
            this.pnlScreen1.Controls.Add(this.pnlblockObstacle1);
            this.pnlScreen1.Controls.Add(this.pnllava);
            this.pnlScreen1.Controls.Add(this.pnlblockObstacle2);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase3);
            this.pnlScreen1.Controls.Add(this.pnlPlayerbase1);
            this.pnlScreen1.Controls.Add(this.pboxPlayer);
            this.pnlScreen1.Controls.Add(this.pnllava2);
            this.pnlScreen1.Location = new System.Drawing.Point(-3, 1);
            this.pnlScreen1.Name = "pnlScreen1";
            this.pnlScreen1.Size = new System.Drawing.Size(1001, 375);
            this.pnlScreen1.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimer.Location = new System.Drawing.Point(9, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(27, 31);
            this.lblTimer.TabIndex = 23;
            this.lblTimer.Text = "0";
            // 
            // pnlblockObstacle3
            // 
            this.pnlblockObstacle3.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlblockObstacle3.Location = new System.Drawing.Point(569, 55);
            this.pnlblockObstacle3.Name = "pnlblockObstacle3";
            this.pnlblockObstacle3.Size = new System.Drawing.Size(108, 27);
            this.pnlblockObstacle3.TabIndex = 21;
            // 
            // pnlPlayerbase8
            // 
            this.pnlPlayerbase8.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase8.Controls.Add(this.Goal);
            this.pnlPlayerbase8.Location = new System.Drawing.Point(673, 55);
            this.pnlPlayerbase8.Name = "pnlPlayerbase8";
            this.pnlPlayerbase8.Size = new System.Drawing.Size(109, 27);
            this.pnlPlayerbase8.TabIndex = 20;
            // 
            // Goal
            // 
            this.Goal.AutoSize = true;
            this.Goal.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.Goal.ForeColor = System.Drawing.Color.Yellow;
            this.Goal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Goal.Location = new System.Drawing.Point(50, 0);
            this.Goal.Name = "Goal";
            this.Goal.Size = new System.Drawing.Size(54, 31);
            this.Goal.TabIndex = 23;
            this.Goal.Text = "Goal";
            // 
            // pnlGoal
            // 
            this.pnlGoal.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlGoal.Location = new System.Drawing.Point(720, 3);
            this.pnlGoal.Name = "pnlGoal";
            this.pnlGoal.Size = new System.Drawing.Size(59, 54);
            this.pnlGoal.TabIndex = 14;
            // 
            // lblDeathCounter
            // 
            this.lblDeathCounter.AutoSize = true;
            this.lblDeathCounter.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.lblDeathCounter.ForeColor = System.Drawing.Color.Red;
            this.lblDeathCounter.Location = new System.Drawing.Point(9, 0);
            this.lblDeathCounter.Name = "lblDeathCounter";
            this.lblDeathCounter.Size = new System.Drawing.Size(27, 31);
            this.lblDeathCounter.TabIndex = 13;
            this.lblDeathCounter.Text = "0";
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
            this.lblDeaths.ForeColor = System.Drawing.Color.White;
            this.lblDeaths.Location = new System.Drawing.Point(3, 0);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(0, 31);
            this.lblDeaths.TabIndex = 3;
            // 
            // pnlPlayerbase7
            // 
            this.pnlPlayerbase7.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase7.Location = new System.Drawing.Point(181, 55);
            this.pnlPlayerbase7.Name = "pnlPlayerbase7";
            this.pnlPlayerbase7.Size = new System.Drawing.Size(392, 27);
            this.pnlPlayerbase7.TabIndex = 12;
            // 
            // pnlPlayerbase6
            // 
            this.pnlPlayerbase6.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase6.Location = new System.Drawing.Point(59, 144);
            this.pnlPlayerbase6.Name = "pnlPlayerbase6";
            this.pnlPlayerbase6.Size = new System.Drawing.Size(162, 27);
            this.pnlPlayerbase6.TabIndex = 11;
            // 
            // pnlPlayerbase5
            // 
            this.pnlPlayerbase5.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase5.Location = new System.Drawing.Point(275, 179);
            this.pnlPlayerbase5.Name = "pnlPlayerbase5";
            this.pnlPlayerbase5.Size = new System.Drawing.Size(201, 27);
            this.pnlPlayerbase5.TabIndex = 10;
            // 
            // pnlPlayerbase4
            // 
            this.pnlPlayerbase4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase4.Location = new System.Drawing.Point(525, 212);
            this.pnlPlayerbase4.Name = "pnlPlayerbase4";
            this.pnlPlayerbase4.Size = new System.Drawing.Size(201, 27);
            this.pnlPlayerbase4.TabIndex = 9;
            // 
            // pnlPlayerbase2
            // 
            this.pnlPlayerbase2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase2.Location = new System.Drawing.Point(214, 298);
            this.pnlPlayerbase2.Name = "pnlPlayerbase2";
            this.pnlPlayerbase2.Size = new System.Drawing.Size(214, 27);
            this.pnlPlayerbase2.TabIndex = 8;
            // 
            // pnlblockObstacle1
            // 
            this.pnlblockObstacle1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlblockObstacle1.Location = new System.Drawing.Point(138, 251);
            this.pnlblockObstacle1.Name = "pnlblockObstacle1";
            this.pnlblockObstacle1.Size = new System.Drawing.Size(61, 27);
            this.pnlblockObstacle1.TabIndex = 7;
            // 
            // pnllava
            // 
            this.pnllava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnllava.Location = new System.Drawing.Point(-25, 349);
            this.pnllava.Name = "pnllava";
            this.pnllava.Size = new System.Drawing.Size(1026, 83);
            this.pnllava.TabIndex = 6;
            // 
            // pnlblockObstacle2
            // 
            this.pnlblockObstacle2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlblockObstacle2.Location = new System.Drawing.Point(424, 298);
            this.pnlblockObstacle2.Name = "pnlblockObstacle2";
            this.pnlblockObstacle2.Size = new System.Drawing.Size(105, 27);
            this.pnlblockObstacle2.TabIndex = 5;
            // 
            // pnlPlayerbase3
            // 
            this.pnlPlayerbase3.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase3.Location = new System.Drawing.Point(525, 298);
            this.pnlPlayerbase3.Name = "pnlPlayerbase3";
            this.pnlPlayerbase3.Size = new System.Drawing.Size(257, 27);
            this.pnlPlayerbase3.TabIndex = 4;
            // 
            // pnlPlayerbase1
            // 
            this.pnlPlayerbase1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlPlayerbase1.Location = new System.Drawing.Point(48, 298);
            this.pnlPlayerbase1.Name = "pnlPlayerbase1";
            this.pnlPlayerbase1.Size = new System.Drawing.Size(76, 27);
            this.pnlPlayerbase1.TabIndex = 3;
            // 
            // pnllava2
            // 
            this.pnllava2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnllava2.Location = new System.Drawing.Point(-13, 0);
            this.pnllava2.Name = "pnllava2";
            this.pnllava2.Size = new System.Drawing.Size(22, 389);
            this.pnllava2.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnTrollScore
            // 
            this.btnTrollScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrollScore.Font = new System.Drawing.Font("Engravers MT", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrollScore.Location = new System.Drawing.Point(257, 270);
            this.btnTrollScore.Name = "btnTrollScore";
            this.btnTrollScore.Size = new System.Drawing.Size(241, 45);
            this.btnTrollScore.TabIndex = 4;
            this.btnTrollScore.Text = "Toll Score";
            this.btnTrollScore.UseVisualStyleBackColor = false;
            this.btnTrollScore.Click += new System.EventHandler(this.btnTrollScore_Click_1);
            // 
            // pboxSpikes3
            // 
            this.pboxSpikes3.BackColor = System.Drawing.Color.Transparent;
            this.pboxSpikes3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSpikes3.BackgroundImage")));
            this.pboxSpikes3.Location = new System.Drawing.Point(261, 43);
            this.pboxSpikes3.Name = "pboxSpikes3";
            this.pboxSpikes3.Size = new System.Drawing.Size(41, 14);
            this.pboxSpikes3.TabIndex = 22;
            this.pboxSpikes3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(541, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 14);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 12);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pboxdumpSpikes
            // 
            this.pboxdumpSpikes.BackColor = System.Drawing.Color.Transparent;
            this.pboxdumpSpikes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxdumpSpikes.BackgroundImage")));
            this.pboxdumpSpikes.Location = new System.Drawing.Point(379, 285);
            this.pboxdumpSpikes.Name = "pboxdumpSpikes";
            this.pboxdumpSpikes.Size = new System.Drawing.Size(58, 16);
            this.pboxdumpSpikes.TabIndex = 17;
            this.pboxdumpSpikes.TabStop = false;
            // 
            // pboxSpikes2
            // 
            this.pboxSpikes2.BackColor = System.Drawing.Color.Transparent;
            this.pboxSpikes2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSpikes2.BackgroundImage")));
            this.pboxSpikes2.Location = new System.Drawing.Point(356, 168);
            this.pboxSpikes2.Name = "pboxSpikes2";
            this.pboxSpikes2.Size = new System.Drawing.Size(41, 14);
            this.pboxSpikes2.TabIndex = 16;
            this.pboxSpikes2.TabStop = false;
            // 
            // pboxSpikes1
            // 
            this.pboxSpikes1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSpikes1.BackgroundImage")));
            this.pboxSpikes1.Location = new System.Drawing.Point(614, 200);
            this.pboxSpikes1.Name = "pboxSpikes1";
            this.pboxSpikes1.Size = new System.Drawing.Size(41, 14);
            this.pboxSpikes1.TabIndex = 15;
            this.pboxSpikes1.TabStop = false;
            // 
            // pboxPlayer
            // 
            this.pboxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pboxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pboxPlayer.Image")));
            this.pboxPlayer.Location = new System.Drawing.Point(48, 251);
            this.pboxPlayer.Name = "pboxPlayer";
            this.pboxPlayer.Size = new System.Drawing.Size(37, 50);
            this.pboxPlayer.TabIndex = 0;
            this.pboxPlayer.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Engravers MT", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(307, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DevilTrolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(776, 432);
            this.Controls.Add(this.pnlScreen1);
            this.Controls.Add(this.btnTrollScore);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DevilTrolls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devil Trolls";
            this.Load += new System.EventHandler(this.DevilTrolls_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DevilTrolls_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DevilTrolls_KeyUp);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.pnlScreen1.ResumeLayout(false);
            this.pnlScreen1.PerformLayout();
            this.pnlPlayerbase8.ResumeLayout(false);
            this.pnlPlayerbase8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxdumpSpikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpikes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlScreen1;
        private System.Windows.Forms.PictureBox pboxPlayer;
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Panel pnlPlayerbase1;
        private System.Windows.Forms.Panel pnlPlayerbase3;
        private System.Windows.Forms.Panel pnlblockObstacle1;
        private System.Windows.Forms.Panel pnllava;
        private System.Windows.Forms.Panel pnlblockObstacle2;
        private System.Windows.Forms.Panel pnlPlayerbase2;
        private System.Windows.Forms.Panel pnlPlayerbase7;
        private System.Windows.Forms.Panel pnlPlayerbase6;
        private System.Windows.Forms.Panel pnlPlayerbase5;
        private System.Windows.Forms.Panel pnlPlayerbase4;
        private Label lblDeaths;
        private Panel pnlGoal;
        private PictureBox pboxSpikes1;
        private PictureBox pboxdumpSpikes;
        private PictureBox pboxSpikes2;
        private Label lblDeathCounter;
        private PictureBox pictureBox1;
        private PictureBox pboxSpikes3;
        private Panel pnlblockObstacle3;
        private Panel pnlPlayerbase8;
        private PictureBox pictureBox2;
        private Label Goal;
        private Label lblCredits;
        private Label lblTimer;
        private Timer timer2;
        private Panel pnllava2;
        private Button btnTrollScore;
        private Button btnExit;
    }
}