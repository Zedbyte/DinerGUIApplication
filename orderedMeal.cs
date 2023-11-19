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
    public partial class orderedMeal : UserControl
    {

        mainForm Main;
        double total;

        public orderedMeal()
        {

        }

        public orderedMeal(string mealName, double total, int quantity, mainForm Main)
        {
            InitializeComponent();
            this.orderedMealName.Text = mealName;
            this.orderedMealTotal.Text = total.ToString();
            this.orderedMealQuantity.Text = quantity.ToString();


            this.total = total;
            this.Main = Main;
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            callToRemove();
        }

        private void callToRemove()
        {
            Main.removeOrder(this);
        }


        public double getTotal()
        {
            return total;
        }
    }
}
