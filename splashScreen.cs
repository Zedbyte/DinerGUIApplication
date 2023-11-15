using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DinerGUIApplication
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timerTick(object sender, EventArgs e)
        {
            splashScreenProgBar.Increment(1);

            if (splashScreenProgBar.Value <= 25)
            {
                lblLoading.Text = "Gathering data, please wait...";
            }
            else if (splashScreenProgBar.Value <= 50)
            {
                lblLoading.Text = "Preparing your food...";
            }
            else if (splashScreenProgBar.Value <= 75)
            {
                lblLoading.Text = "Ready your money...";
            }
            else
            {
                lblLoading.Text = "Ready your money and tummy!";
            }

            // Update percentage label text
            lblNum.Text = splashScreenProgBar.Value.ToString() + "%";

            if (splashScreenProgBar.Value == 100)
            {
                timerProgress.Enabled = false;

                startScreen start = new startScreen();
                start.Show();

                this.Close();

            }

        }

        private void splashScreenPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
