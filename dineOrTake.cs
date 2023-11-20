using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUIApplication
{
    public partial class dineOrTake : Form
    {
        public dineOrTake()
        {
            InitializeComponent();
        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm("Dine in");
            mainForm.Show();
            this.Close();
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm("Take out");
            mainForm.Show();
            this.Close();
        }
    }
}
