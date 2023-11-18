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
        public orderedMeal()
        {

        }

        public orderedMeal(string mealName, double total, int quantity)
        {
            InitializeComponent();
            this.orderedMealName.Text = mealName;
            this.orderedMealTotal.Text = total.ToString();
            this.orderedMealQuantity.Text = quantity.ToString();
        }
    }
}
