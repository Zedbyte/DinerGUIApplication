using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUIApplication
{
    public partial class cashForm : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        double total;
        double customerPayment;
        RichTextBox txtbxReceipt;
        StringBuilder heading = new StringBuilder();
        string dineOrTake;


        public cashForm(double totalToPay, RichTextBox txtbxReceipt, string dineOrTake)
        {
            InitializeComponent();
            this.total = totalToPay;
            this.txtbxReceipt = txtbxReceipt;
            this.dineOrTake = dineOrTake;
            InitializeReceipt(total);
            lblTotalToPay.Text = total.ToString();
            InitializeCustomFont_Receipt(txtBxReceipt);
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public void InitializeCustomFont_Receipt(RichTextBox txtBx)
        {

            int fontLength = Properties.Resources.fake_receipt.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.fake_receipt;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            txtBx.Font = new Font(pfc.Families[0], (float)8f);

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
            txtBxReceipt.Clear();
            /* DateTime currentDateTime = DateTime.Now;
             string date = currentDateTime.ToString("dddd, dd MMMM yyyy hh:mm tt");*/

            /*heading.Append("\n" +
                "              Diner by the Valley" +
                "\n          Angeles University Corp." +
                "\n                  BSIT 2A" +
                "\n     " + date +
                "\n             Receipt No. " + RandomNumberGenerator.GetInt32(100000) +
                "\n=========================================");*/
            heading.Append(txtbxReceipt.Text);

            string queueNumber = String.Format("\n{0,-20} {1,-20}", "     " + "Queue Number        ", RandomNumberGenerator.GetInt32(100));
            string orderNumber = String.Format("\n{0,-20} {1,-20}", "     " + "Order Number        ", RandomNumberGenerator.GetInt32(100));

            heading.Append("\n\n\n\n\n\n\n-------------------------------------------");

            heading.Append(queueNumber);
            heading.Append(orderNumber);

            heading.Append("\n-------------------------------------------");



            string stringTotal = String.Format("\n{0,-20} {1,-30}", "     " + "Total             ", "P " + total.ToString());

            heading.Append(stringTotal);

            txtBxReceipt.Text = heading.ToString();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (txtBxCalculator.Text != "0")
            {
                double payment = Convert.ToDouble(txtBxCalculator.Text);

                if (payment >= total)
                {
                    double change = payment - total;
                    heading.Append("\n-------------------------------------------");
                    string moneyPaid = String.Format("\n\n{0,-20} {1,-20}", "     " + "Payment:          ", "P " + payment);
                    string changeOwed = String.Format("\n\n{0,-20} {1,-20}", "     " + "Change Owed       ", "P " + change);
                    heading.Append(moneyPaid);
                    heading.Append(changeOwed);

                    txtBxCalculator.Text = "0";
                    txtBxReceipt.Text = heading.ToString();

                    printPreviewReceipt.Document = printDocumentReceipt;
                    printPreviewReceipt.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Insufficient Payment. Please pay the right amount.");
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewReceipt.Document = printDocumentReceipt;
            printPreviewReceipt.ShowDialog();
        }

        private void printPreviewReceipt_Load(object sender, EventArgs e)
        {

        }

        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBxReceipt.Text, new Font(pfc.Families[0], (float)30f), Brushes.Black, new Point(10, 10));
        }
    }
}
