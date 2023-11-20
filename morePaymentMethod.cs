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
    public partial class morePaymentMethod : Form
    {
        public morePaymentMethod()
        {
            InitializeComponent();
        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            gcashForm gcashForm = new gcashForm();
            gcashForm.Show();

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            cashForm cashForm = new cashForm();
            cashForm.Show();
            this.Close();
        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            cryptoForm cryptoForm = new cryptoForm();
            cryptoForm.Show();
        }
    }
}
