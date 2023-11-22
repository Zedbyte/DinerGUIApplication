﻿using System;
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
    public partial class quantityForm : Form
    {
        public int Quantity { get; private set; }

        public string SpecialRequest { get; private set; }

        fontType ft = new fontType();

        public quantityForm()
        {
            InitializeComponent();

            ft.InitializeCustomFont_Cartoony(lblQuantity, 15f);
            ft.InitializeCustomFont_Cartoony(lblSpecialReq, 15f);
            /* ft.InitializeCustomFont_NumericUpDown(quantityUpDown, 16f);
             ft.InitializeCustomFont_TextBox(txtBxSpecialReq, 12f);*/
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (quantityUpDown.Value > 0)
            {
                Quantity = Convert.ToInt32(quantityUpDown.Value);

                if (txtBxSpecialReq.Text.Length > 0)
                {
                    SpecialRequest = txtBxSpecialReq.Text.ToUpper();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a quantity.");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Quantity = 0;
            this.Close();
        }
    }
}
