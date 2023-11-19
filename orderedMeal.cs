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
        string mealName;
        int quantity;
        double total;
        int index;
        double price;
        string specialRequest;

        public orderedMeal()
        {

        }

        public orderedMeal(int index, string mealName, double total, int quantity, double price, string specialReq, mainForm Main)
        {
            InitializeComponent();
            this.orderedMealName.Text = mealName;
            this.orderedMealTotal.Text = total.ToString();
            this.orderedMealQuantity.Text = quantity.ToString();

            this.mealName = mealName;
            this.quantity = quantity;
            this.total = total;
            this.Main = Main;
            this.index = index;
            this.price = price;

            if (specialReq != null && specialReq.Length > 0)
            {
                this.specialRequest = specialReq.ToUpper();
                lblSpecialReq.Text = "Special Request";
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            callToRemove();
        }

        private void callToRemove()
        {
            Main.removeOrder(this, specialRequest);
        }


        public double getTotal()
        {
            return total;
        }

        public string getMealName()
        {
            return mealName;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public int getMealIndex()
        {
            return index;
        }

        public double getMealPrice()
        {
            return price;
        }

        public string getSpecialRequest()
        {
            return specialRequest;
        }
    }
}
