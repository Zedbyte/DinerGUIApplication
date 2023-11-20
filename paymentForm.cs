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
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();

            // Attach event handlers to the radio buttons
            rdButtonMasterCard.CheckedChanged += RadioButton_CheckedChanged;
            rdButtonVisa.CheckedChanged += RadioButton_CheckedChanged;
            rdButtonMore.CheckedChanged += RadioButton_CheckedChanged;
            txtBoxCNum.KeyPress += txtBoxCNum_KeyPress;

            // Attach event handlers to existing textboxes
            txtBoxMonth.Enter += txtBox_Enter;
            txtBoxMonth.Leave += txtBox_Leave;
            txtBoxMonth.KeyPress += txtBox_KeyPress;

            txtBoxYr.Enter += txtBox_Enter;
            txtBoxYr.Leave += txtBox_Leave;
            txtBoxYr.KeyPress += txtBox_KeyPress;

            // Attach event handlers to existing textboxes
            txtBoxCode1.Enter += txtBox_EnterCode;
            txtBoxCode1.Leave += txtBox_LeaveCode;
            txtBoxCode1.KeyPress += txtBox_KeyPressCode;

            txtBoxCode2.Enter += txtBox_EnterCode;
            txtBoxCode2.Leave += txtBox_LeaveCode;
            txtBoxCode2.KeyPress += txtBox_KeyPressCode;

            txtBoxCode3.Enter += txtBox_EnterCode;
            txtBoxCode3.Leave += txtBox_LeaveCode;
            txtBoxCode3.KeyPress += txtBox_KeyPressCode;
        }

        private void DisableTextBoxes()
        {
            // Disable all textboxes
            txtBoxCName.Enabled = false;
            txtBoxMonth.Enabled = false;
            txtBoxYr.Enabled = false;
            txtBoxCNum.Enabled = false;
            txtBoxCode1.Enabled = false;
            txtBoxCode2.Enabled = false;
            txtBoxCode3.Enabled = false;
        }

        private void EnableTextBoxes()
        {
            // Enable all textboxes
            txtBoxCName.Enabled = true;
            txtBoxMonth.Enabled = true;
            txtBoxYr.Enabled = true;
            txtBoxCNum.Enabled = true;
            txtBoxCode1.Enabled = true;
            txtBoxCode2.Enabled = true;
            txtBoxCode3.Enabled = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check which radio button is selected
            RadioButton selectedRadioButton = (RadioButton)sender;

            // Uncheck the other radio buttons
            if (selectedRadioButton.Checked)
            {
                if (selectedRadioButton == rdButtonMasterCard)
                {
                    rdButtonVisa.Checked = false;
                    rdButtonMore.Checked = false;
                }
                else if (selectedRadioButton == rdButtonVisa)
                {
                    rdButtonMasterCard.Checked = false;
                    rdButtonMore.Checked = false;
                }
                else if (selectedRadioButton == rdButtonMore)
                {
                    rdButtonMasterCard.Checked = false;
                    rdButtonVisa.Checked = false;
                }
            }
            if (selectedRadioButton == rdButtonMore && rdButtonMore.Checked)
            {
                // Disable all textboxes when rdButtonCash is selected
                DisableTextBoxes();
            }
            else
            {
                // Enable all textboxes when other radio buttons are selected
                EnableTextBoxes();
            }
        }

        private void txtBoxCNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and a backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }

            // Limit the total number of digits to 16
            if (txtBoxCNum.Text.Length >= 16 && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "MM" || textBox.Text == "YYYY")
            {
                textBox.Text = string.Empty;
            }
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtBoxMonth)
                {
                    textBox.Text = "MM";
                }
                else if (textBox == txtBoxYr)
                {
                    textBox.Text = "YYYY";
                }
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Allow only digits and a backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }

            // Limit the total number of digits to 2 for txtBoxMonth and 4 for txtBoxYr
            if ((textBox == txtBoxMonth && textBox.Text.Length >= 2 && e.KeyChar != 8) ||
                (textBox == txtBoxYr && textBox.Text.Length >= 4 && e.KeyChar != 8))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtBox_EnterCode(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
            }
        }

        private void txtBox_LeaveCode(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        private void txtBox_KeyPressCode(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Allow only digits and a backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }

            // Limit the total number of digits to 1
            if (textBox.Text.Length >= 1 && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected
            if (rdButtonMasterCard.Checked || rdButtonVisa.Checked)
            {
                // Check if any of the required textboxes are not filled
                if (string.IsNullOrWhiteSpace(txtBoxCName.Text) ||
                    txtBoxMonth.Text == "MM" ||
                    txtBoxYr.Text == "YYYY" ||
                    string.IsNullOrWhiteSpace(txtBoxCNum.Text) ||
                    txtBoxCode1.Text == "0" ||
                    txtBoxCode2.Text == "0" ||
                    txtBoxCode3.Text == "0")
                {
                    // Show a warning message
                    MessageBox.Show("You need to fill-up all necessary information to proceed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method, preventing further execution
                }
            }
            else if (rdButtonMore.Checked)
            {
                morePaymentMethod morePaymentMethod = new morePaymentMethod();
                morePaymentMethod.Show();
                this.Close();
            }

            // If rdButtonCash is selected or all required textboxes are filled, proceed to the next form
            /*            this.Visible = false;
                        SampleForm sampleForm = new SampleForm();
                        sampleForm.Show();*/
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
