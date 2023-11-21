using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinerGUIApplication
{
    public partial class itemMeal : UserControl
    {
        int index;
        PrivateFontCollection pfc4 = new PrivateFontCollection();

        public itemMeal()
        {
        }
        fontType ft = new fontType();

        public itemMeal(int index, Image image, String mealNameParam, String mealPriceParam)
        {
            InitializeComponent();

            /*this.mealPictureBox = mealPictureBoxParam;*/
            /*mealPictureBox.Image = mealPictureBoxParam.Image;*/

            this.mealName.Text = mealNameParam;
            this.mealPrice.Text = mealPriceParam;
            this.mealPicturebox.Image = image;

            this.index = index;

    
            ft.InitializeCustomFont_Cartoony(mealName, 10f);
            ft.InitializeCustomFont_Cartoony(mealPrice, 10f);


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

        public Image getImage()
        {
            return mealPicturebox.Image;
        }

        private void itemMeal_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(88, 101, 84);
        }

        private void itemMeal_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(108, 124, 103);
        }
    }
}
