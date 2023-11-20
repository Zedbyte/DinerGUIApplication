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
    public partial class cashForm : Form
    {

        double total;
        double customerPayment;


        public cashForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtBxCalculator.Text == "0")
            {
                txtBxCalculator.Text = button.Text;
            }
            else
            {
                txtBxCalculator.Text += button.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtBxCalculator.Text.Length != 0)
            {
                txtBxCalculator.Text = txtBxCalculator.Text.Remove(txtBxCalculator.Text.Length - 1);
            }
            else
            {
                txtBxCalculator.Text = "0";
            }
        }

        private void InitializeReceipt(double total)
        {

        }
    }
}
