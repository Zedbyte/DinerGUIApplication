using System.Collections;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.DataFormats;

namespace DinerGUIApplication
{
    public partial class mainForm : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        List<itemMeal> meals = new List<itemMeal>();
        List<orderedMeal> orderedMeal = new List<orderedMeal>();
        List<string> imageFilePaths = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro1.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro2.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro3.jpg"
        };

        string orderName;
        double orderPrice;
        int orderQuantity;
        double total;
        double totalToPay;
        double discount;


        public mainForm()
        {
            InitializeComponent();
            InitializeMeals();
            InitializeReceipt();
            InitializeCustomFont_Receipt(txtBxReceipt);
            displayItemMeals();
            mealsListener();
        }

        public void InitializeCustomFont_Receipt(RichTextBox txtBx)
        {

            int fontLength = Properties.Resources.MerchantCopy_GOXq.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.MerchantCopy_GOXq;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            txtBx.Font = new Font(pfc.Families[0], txtBx.Font.Size);

        }


        public void InitializeMeals()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePaths[0]), "Miso Soup", "P100"));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePaths[1]), "Egg", "P200"));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePaths[2]), "Sandwich", "P300"));
            meals.Add(new itemMeal(4, Image.FromFile(imageFilePaths[0]), "Fried Chicken", "P450"));
            meals.Add(new itemMeal(5, Image.FromFile(imageFilePaths[1]), "Ham", "P50"));
            meals.Add(new itemMeal(6, Image.FromFile(imageFilePaths[2]), "Pork Cutlet", "P70"));
            meals.Add(new itemMeal(6, Image.FromFile(imageFilePaths[0]), "Salad", "P70"));
        }

        public void displayItemMeals()
        {
            /* foreach (itemMeal itemMeals in meals)
             {
                 itemMeals.TopLevel = false;
             }*/
            foodFlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < meals.Count; i++)
            {
                foodFlowLayoutPanel.Controls.Add(meals[i]);
                /*meals[i].Show();*/
            }
        }

        public void mealsListener()
        {
            for (int i = 0; i < meals.Count; i++)
            {
                /*   foreach (Control ctl in meals[i].Controls)
                   {
                       ctl.Parent.Click += new System.EventHandler(this.mealsClicked);
                   }*/
                meals[i].Click += new System.EventHandler(this.mealsClicked);
            }

        }

        public void mealsClicked(object sender, EventArgs e)
        {
            clearDetails(false);
            itemMeal meal = (itemMeal)sender;

            setMealNameDetail(meal);
            setMealPriceDetail(meal);
            setMealPictureDetail(meal);

            quantityForm qtySelector = new quantityForm();
            qtySelector.ShowDialog();

            setMealQuantityVariable(qtySelector);
            setMealQuantityDetail(orderQuantity);

            setMealTotal(meal.getMealPrice(), orderQuantity);


        }

        private void setMealNameDetail(itemMeal meal)
        {
            lblMealName.Text = meal.getMealName();
            orderName = meal.getMealName();
        }

        private void setMealPriceDetail(itemMeal meal)
        {
            lblMealPrice.Text = "\u20B1" + meal.getMealPrice().ToString();
            orderPrice = meal.getMealPrice();
        }

        private void setMealPictureDetail(itemMeal meal)
        {
            mealPictureDetail.Image = meal.getImage();
        }

        private void setMealQuantityVariable(quantityForm qty)
        {
            orderQuantity = qty.Quantity;
        }

        private void setMealQuantityDetail(int orderQuantity)
        {
            lblQuantity.Text = orderQuantity.ToString();
        }

        private void setMealTotal(double price, int quantity)
        {
            total = price * quantity;
            lblTotal.Text = "\u20B1" + total.ToString();
        }

        public void clearDetails(bool addedSuccessfully)
        {
            orderName = null;
            orderPrice = 0;
            orderQuantity = 0;
            total = 0;

            mealPictureDetail.Image = null;

            if (addedSuccessfully)
            {
                lblMealName.Text = "Order added!";
            }
            else
            {
                lblMealName.Text = "No order yet.";
            }

            lblMealPrice.Text = "-";
            lblQuantity.Text = "-";
            lblTotal.Text = "-";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDetails(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (orderName != null && orderPrice > 0 && orderQuantity > 0)
            {

                orderedMeal.Add(new orderedMeal(orderName, total, orderQuantity, this));

                orderedMealsRecordTablePanel.Controls.Add(orderedMeal[orderedMeal.Count - 1]);

                totalToPay += total;
                discount = 0;


                setOrderedMealTotals();
                addToReceipt(orderName, orderQuantity, total);
                clearDetails(true);
            }
            else
            {
                MessageBox.Show("Order Invalid. Please try again.");
            }

        }

        public void removeOrder(orderedMeal Order)
        {
            orderedMeal.Remove(Order);
            orderedMealsRecordTablePanel.Controls.Remove(Order);
            orderedMealsRecordTablePanel.Refresh();

            removeFromReceipt(Order);
            subtractTotalWhenOrderRemoved(Order.getTotal());
        }


        private void subtractTotalWhenOrderRemoved(double mealTotal)
        {
            totalToPay -= mealTotal;
            lblTotalNoDiscount.Text = "\u20B1" + totalToPay.ToString();
            lblTotalWDiscount.Text = "\u20B1" + (totalToPay - discount).ToString();

            setOrderedMealTotals();

        }


        private void setOrderedMealTotals()
        {
            lblTotalNoDiscount.Text = "\u20B1" + totalToPay.ToString();
            lblDiscountApplied.Text = "\u20B1" + discount.ToString();

            lblTotalWDiscount.Text = "\u20B1" + (totalToPay - discount).ToString();

        }


        public void InitializeReceipt()
        {
            DateTime currentDateTime = DateTime.Now;

            StringBuilder heading = new StringBuilder();
            heading.Append("\n\n                  Diner by the Valley     " +
                "\n                                 DELHI INDIA AUF      " +
                "\n                                     BSIT 2A" +
                "\n                         " +     RandomNumberGenerator.GetInt32(100000) +
                "\n                         " +    currentDateTime.ToString());


            txtBxReceipt.Text = heading.ToString();
        }
        private void addToReceipt(String orderName, int quantity, double total)
        {
            StringBuilder stb = new StringBuilder();
            stb.Append("\n          " + orderName + "    " + quantity + "     " + total);

            txtBxReceipt.AppendText(stb.ToString());
        }

        private void removeFromReceipt(orderedMeal order)
        {
            String prev = txtBxReceipt.Text;
            String removedOrderReceipt = prev.Replace("\n          " + order.getMealName() + "    " + order.getQuantity() + "     " + order.getTotal(), "");

            InitializeReceipt();
            txtBxReceipt.Text += removedOrderReceipt;
        }
    }
}