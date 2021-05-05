using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
          
        }


        private void start_Load(object sender, EventArgs e)
        {
            //Setup Page, Hide Scores and make heading background invisible
            this.label1.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Close this Form Load instructions Form
            this.Hide();
            Instructions g = new Instructions();
            g.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit Game
            this.Close();
        }

        private void btnPLAY_Click(object sender, EventArgs e)
        {
            // Close this Form load game Form
            this.Hide();
            Game g = new Game();
            g.ShowDialog();
        }

       
    }
}
