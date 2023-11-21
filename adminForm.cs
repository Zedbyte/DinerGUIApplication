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
    public partial class adminForm : Form
    {

        public int Index { get; private set; }
        public string ImageFilePath { get; private set; }
        public string MealName { get; private set; }
        public string MealPrice { get; private set; }

        public string MealDetails { get; private set; }

        public adminForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (indexBox.Value > 0)
            {
                Index = Convert.ToInt32(indexBox.Value);
            }
            else
            {
                MessageBox.Show("Index must not be empty");
            }

            if (imageFilePathBox.Text != null)
            {
                ImageFilePath = imageFilePathBox.Text;
            }
            if (imageFilePathBox.Text == "")
            {
                ImageFilePath = "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\noImage.png";
            }
            else
            {
                ImageFilePath = "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\noImage.png";
            }

            if (mealNameBox.Text != null)
            {
                MealName = mealNameBox.Text;
            }
            else
            {
                MessageBox.Show("Meal Name must not be empty");
            }

            if (mealPriceBox.Text != null)
            {
                MealPrice = mealPriceBox.Text;
            }
            else
            {
                MessageBox.Show("Meal Price must not be empty");
            }

            if (mealDetailsBox.Text != null)
            {
                MealDetails = mealDetailsBox.Text;
            }
            else
            {
                MessageBox.Show("Meal Detail must not be empty");
            }


            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Index = 0;
            ImageFilePath = null;
            MealName = null;
            MealPrice = null;
            MealDetails = null;

            this.Close();
        }
    }
}
