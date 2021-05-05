using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Instructions : Form
    {

        public Instructions()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close this form and show first form
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Start);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            // set lable to transpearent
            this.label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
