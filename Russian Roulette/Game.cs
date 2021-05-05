using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Game : Form
    {
        GameClass Obj_GameLogic = new GameClass();

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // Set form so only the correct  sections work and lables are transperent
            this.lbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbShotsLeft.BackColor = System.Drawing.Color.Transparent;
            btnPlayer.Enabled = false;
            btnAway.Enabled = false;
            btnNewPlayer.Enabled = false;
            btnPlayAgain.Enabled = false;

            btnSpinChambers.Enabled = false;
            Obj_GameLogic.shot = Obj_GameLogic.go -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // If player name empty dont save score. If populated save score to csv
            Obj_GameLogic.Player = txtPlayerName.Text;
            Obj_GameLogic.Score = Convert.ToInt16(txtScore.Text);
            if (txtPlayerName.Text == "")
            {
                this.Close();
            }
            else try
            {
                string path = @"Russian Roulette 2.Resources.PlayerScore.csv";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Obj_GameLogic.Player + "," + Obj_GameLogic.Score);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(Obj_GameLogic.Player + "," + Obj_GameLogic.Score);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File seems tp be missing. Please check path");
            }
            txtPlayerName.Clear();
            txtScore.Clear();

            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Start);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

    
        private void btnSpinChambers_Click(object sender, EventArgs e)
        {
            // Enable player and away
            btnPlayer.Enabled = true;
            btnAway.Enabled = true;

            // Random Bullet 1 - 6
            Random rnd = new Random();
            Obj_GameLogic.bullet = Obj_GameLogic.Rand_number();

            // For Testing purposes
            //MessageBox.Show(bullet.ToString());

            // Play Revolution sound
            System.IO.Stream str = Properties.Resources.LoadChambers;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Disable Buttons not needed at this point.
            btnSpinChambers.Enabled = false;
        }

        private void btnLoadBullet_Click(object sender, EventArgs e)
        {
            // Display error if player name not present
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Please enter Player Name");
                return;
            }
            else btnSpinChambers.Enabled = true;

            //Play Load bullet Sound
            System.IO.Stream str = Properties.Resources.LoadBullet;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            //Disable Buttons not needed at this point.
            btnLoadBullet.Enabled = false;
            txtPlayerName.Enabled = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Reset form for player to bea able to play again. Leave name and score.
            btnPlayer.Enabled = false;
            btnAway.Enabled = false;
            pbShot1.Visible = true;
            pbShot2.Visible = true;
            pbShot3.Visible = true;
            pbShot4.Visible = true;
            pbShot5.Visible = true;
            pbShot6.Visible = true;
            Obj_GameLogic.go = 7;
            Obj_GameLogic.away = 1;
            btnSpinChambers.Enabled = false;
            btnNewPlayer.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnLoadBullet.Enabled = true;
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            //Score
            Obj_GameLogic.Score = Convert.ToInt16(txtScore.Text);

            //Play Gunshot Sound
            System.IO.Stream str = Properties.Resources.Gunshot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Remove Bullet / Shot + add score
            if (Obj_GameLogic.go >= 1)
            {
                Obj_GameLogic.go = Obj_GameLogic.go - 1;
            }
            if (Obj_GameLogic.go == 6)
            {
                pbShot6.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 5)
            {
                pbShot5.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 4)
            {
                pbShot4.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 3)
            {
                pbShot3.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 2)
            {
                pbShot2.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 1)
            {
                pbShot1.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == Obj_GameLogic.bullet)
            {
                txtScore.Text = (Obj_GameLogic.Score - 500).ToString();
                MessageBox.Show("YOU ARE DEAD!!");
                btnPlayer.Enabled = false;
                btnAway.Enabled = false;
                btnNewPlayer.Enabled = true;
                btnPlayAgain.Enabled = true;
            }
        }

        private void btnAway_Click(object sender, EventArgs e)
        {
            //Score
            Obj_GameLogic.Score = Convert.ToInt16(txtScore.Text);
            //Play Gunshot Sound
            System.IO.Stream str = Properties.Resources.Gunshot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Remove Bullet / Shot + add score
            if (Obj_GameLogic.go >= 1)
            {
                Obj_GameLogic.go = Obj_GameLogic.go - 1;
            }
            if (Obj_GameLogic.go == 6)
            {
                pbShot6.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go== 5)
            {
                pbShot5.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 4)
            {
                pbShot4.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 3)
            {
                pbShot3.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 2)
            {
                pbShot2.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == 1)
            {
                pbShot1.Visible = false;
                txtScore.Text = (Obj_GameLogic.Score + 100).ToString();
            }
            if (Obj_GameLogic.go == Obj_GameLogic.bullet)
            {
                txtScore.Text = (Obj_GameLogic.Score + 1000).ToString();
                MessageBox.Show("***YOU BAGGED YOURSELF A STAG***");
                btnPlayer.Enabled = false;
                btnAway.Enabled = false;
                btnNewPlayer.Enabled = true;
                btnPlayAgain.Enabled = true;
            }
            // Set Away to 2 shots only
            if (Obj_GameLogic.away == 0)
            {
                btnAway.Enabled = false;
            }
            if (Obj_GameLogic.away >= 1)
            {
                Obj_GameLogic.away = Obj_GameLogic.away - 1;
            }
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            //Resetting form in sections.
            btnPlayer.Enabled = false;
            btnAway.Enabled = false;
            pbShot1.Visible = true;
            pbShot2.Visible = true;
            pbShot3.Visible = true;
            pbShot4.Visible = true;
            pbShot5.Visible = true;
            pbShot6.Visible = true;
            Obj_GameLogic.go = 7;
            Obj_GameLogic.away = 1;
            btnSpinChambers.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnNewPlayer.Enabled = false;
            btnLoadBullet.Enabled = true;
            txtPlayerName.Enabled = true;
            // Save players score+name to csv
            Obj_GameLogic.Player = txtPlayerName.Text;
            Obj_GameLogic.Score = Convert.ToInt16(txtScore.Text);
            try
            {
                string path = @"Russian Roulette 2.Resources.PlayerScore.csv";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Obj_GameLogic.Player + "," + Obj_GameLogic.Score);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(Obj_GameLogic.Player + "," + Obj_GameLogic.Score);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File seems tp be missing. Please check path");
            }
            // Set score to 0 and player name ready for next player.
            txtPlayerName.Clear();
            int KK;
            KK = 0;
            txtScore.Text = (KK).ToString();
        }

    }
}
