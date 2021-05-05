namespace Russian_Roulette
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChambers = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.pbShot1 = new System.Windows.Forms.PictureBox();
            this.pbShot2 = new System.Windows.Forms.PictureBox();
            this.pbShot3 = new System.Windows.Forms.PictureBox();
            this.pbShot4 = new System.Windows.Forms.PictureBox();
            this.pbShot5 = new System.Windows.Forms.PictureBox();
            this.pbShot6 = new System.Windows.Forms.PictureBox();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbShotsLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(833, 446);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 46);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.Color.Lime;
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.Location = new System.Drawing.Point(40, 455);
            this.btnLoadBullet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(251, 52);
            this.btnLoadBullet.TabIndex = 1;
            this.btnLoadBullet.Text = "LOAD BULLET";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChambers
            // 
            this.btnSpinChambers.BackColor = System.Drawing.Color.Lime;
            this.btnSpinChambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChambers.Location = new System.Drawing.Point(345, 455);
            this.btnSpinChambers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpinChambers.Name = "btnSpinChambers";
            this.btnSpinChambers.Size = new System.Drawing.Size(251, 52);
            this.btnSpinChambers.TabIndex = 2;
            this.btnSpinChambers.Text = "SPIN CHAMBERS";
            this.btnSpinChambers.UseVisualStyleBackColor = false;
            this.btnSpinChambers.Click += new System.EventHandler(this.btnSpinChambers_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Cyan;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(682, 368);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(251, 52);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(215, 20);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayerName.MaxLength = 10;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(234, 26);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(581, 20);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 18;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackgroundImage = global::Russian_Roulette.Properties.Resources.Bigeyes;
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPlayer.Location = new System.Drawing.Point(49, 78);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(274, 358);
            this.btnPlayer.TabIndex = 22;
            this.btnPlayer.Text = "YOURSELF";
            this.btnPlayer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnAway
            // 
            this.btnAway.BackgroundImage = global::Russian_Roulette.Properties.Resources.Noeyes;
            this.btnAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAway.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAway.Location = new System.Drawing.Point(356, 78);
            this.btnAway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(274, 358);
            this.btnAway.TabIndex = 23;
            this.btnAway.Text = "STAG";
            this.btnAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // pbShot1
            // 
            this.pbShot1.Image = ((System.Drawing.Image)(resources.GetObject("pbShot1.Image")));
            this.pbShot1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot1.InitialImage")));
            this.pbShot1.Location = new System.Drawing.Point(803, 138);
            this.pbShot1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot1.Name = "pbShot1";
            this.pbShot1.Size = new System.Drawing.Size(35, 189);
            this.pbShot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot1.TabIndex = 8;
            this.pbShot1.TabStop = false;
            // 
            // pbShot2
            // 
            this.pbShot2.Image = ((System.Drawing.Image)(resources.GetObject("pbShot2.Image")));
            this.pbShot2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot2.InitialImage")));
            this.pbShot2.Location = new System.Drawing.Point(846, 138);
            this.pbShot2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot2.Name = "pbShot2";
            this.pbShot2.Size = new System.Drawing.Size(35, 189);
            this.pbShot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot2.TabIndex = 9;
            this.pbShot2.TabStop = false;
            // 
            // pbShot3
            // 
            this.pbShot3.Image = ((System.Drawing.Image)(resources.GetObject("pbShot3.Image")));
            this.pbShot3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot3.InitialImage")));
            this.pbShot3.Location = new System.Drawing.Point(889, 138);
            this.pbShot3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot3.Name = "pbShot3";
            this.pbShot3.Size = new System.Drawing.Size(35, 189);
            this.pbShot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot3.TabIndex = 10;
            this.pbShot3.TabStop = false;
            // 
            // pbShot4
            // 
            this.pbShot4.Image = ((System.Drawing.Image)(resources.GetObject("pbShot4.Image")));
            this.pbShot4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot4.InitialImage")));
            this.pbShot4.Location = new System.Drawing.Point(932, 138);
            this.pbShot4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot4.Name = "pbShot4";
            this.pbShot4.Size = new System.Drawing.Size(35, 189);
            this.pbShot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot4.TabIndex = 11;
            this.pbShot4.TabStop = false;
            // 
            // pbShot5
            // 
            this.pbShot5.Image = ((System.Drawing.Image)(resources.GetObject("pbShot5.Image")));
            this.pbShot5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot5.InitialImage")));
            this.pbShot5.Location = new System.Drawing.Point(975, 138);
            this.pbShot5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot5.Name = "pbShot5";
            this.pbShot5.Size = new System.Drawing.Size(35, 189);
            this.pbShot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot5.TabIndex = 12;
            this.pbShot5.TabStop = false;
            // 
            // pbShot6
            // 
            this.pbShot6.Image = ((System.Drawing.Image)(resources.GetObject("pbShot6.Image")));
            this.pbShot6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShot6.InitialImage")));
            this.pbShot6.Location = new System.Drawing.Point(1018, 138);
            this.pbShot6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShot6.Name = "pbShot6";
            this.pbShot6.Size = new System.Drawing.Size(35, 189);
            this.pbShot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShot6.TabIndex = 13;
            this.pbShot6.TabStop = false;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.Color.Cyan;
            this.btnNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(957, 368);
            this.btnNewPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(206, 52);
            this.btnNewPlayer.TabIndex = 4;
            this.btnNewPlayer.Text = "NEW PLAYER";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPlayerName.Location = new System.Drawing.Point(44, 19);
            this.lbPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(163, 25);
            this.lbPlayerName.TabIndex = 25;
            this.lbPlayerName.Text = "PLAYER NAME";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbScore.Location = new System.Drawing.Point(457, 20);
            this.lbScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(88, 25);
            this.lbScore.TabIndex = 26;
            this.lbScore.Text = "SCORE";
            // 
            // lbShotsLeft
            // 
            this.lbShotsLeft.AutoSize = true;
            this.lbShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShotsLeft.Location = new System.Drawing.Point(828, 90);
            this.lbShotsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShotsLeft.Name = "lbShotsLeft";
            this.lbShotsLeft.Size = new System.Drawing.Size(147, 25);
            this.lbShotsLeft.TabIndex = 28;
            this.lbShotsLeft.Text = "SHOTS LEFT";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 862);
            this.ControlBox = false;
            this.Controls.Add(this.lbShotsLeft);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnSpinChambers);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.pbShot6);
            this.Controls.Add(this.pbShot5);
            this.Controls.Add(this.pbShot4);
            this.Controls.Add(this.pbShot3);
            this.Controls.Add(this.pbShot2);
            this.Controls.Add(this.pbShot1);
            this.Controls.Add(this.btnExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ll";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShot6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChambers;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.PictureBox pbShot1;
        private System.Windows.Forms.PictureBox pbShot2;
        private System.Windows.Forms.PictureBox pbShot3;
        private System.Windows.Forms.PictureBox pbShot4;
        private System.Windows.Forms.PictureBox pbShot5;
        private System.Windows.Forms.PictureBox pbShot6;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbShotsLeft;
    }
}