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
    public partial class itemMeals : Form
    {
        int index;

        public itemMeals() { }

        public itemMeals(int index, String mealNameParam, String mealPriceParam)
        {
            InitializeComponent();

            /*this.mealPictureBox = mealPictureBoxParam;*/
            /*mealPictureBox.Image = mealPictureBoxParam.Image;*/

            this.mealPictureBox.Parent = this;

            this.mealName.Text = mealNameParam;
            this.mealPrice.Text = mealPriceParam;

            this.index = index;

        }

        private void mealPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

        public string getMealName()
        {
            return mealName.Text;
        }

        public int getIndex()
        {
            return index;
        }

        public double getMealPrice()
        {
            return Convert.ToDouble(mealPrice.Text.Replace("P", ""));
        }
    }
}
