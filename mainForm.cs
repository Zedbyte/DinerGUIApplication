using System.Collections;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DinerGUIApplication
{
    public partial class mainForm : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        PrivateFontCollection pfc1 = new PrivateFontCollection();
        PrivateFontCollection pfc2 = new PrivateFontCollection();
        PrivateFontCollection pfc3 = new PrivateFontCollection();

        List<itemMeal> meals = new List<itemMeal>();
        List<orderedMeal> orderedMeal = new List<orderedMeal>();
        List<string> imageFilePaths = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro1.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro2.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\hamncheese100.png"
        };

        string foodGif = "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\foodings.gif";

        int index;
        string orderName;
        double orderPrice;
        int orderQuantity;
        double total;
        double totalToPay;
        double discount;
        string specialRequest;
        string dineOrTake;

        int newQuantity;
        double newTotal;


        public mainForm(string dineOrTake)
        {
            InitializeComponent();
            InitializeMeals();

            this.dineOrTake = dineOrTake;

            InitializeReceipt();
            InitializeCustomFont_Receipt(txtBxReceipt);
            InitializeCustomFont_Label(lblDinerName, 43f);
            changeFoodDetailButtonFont();
            changeFoodDetailPanelLabelFont();
            changeCurrentOrderTotalPanelLabels();
            displayItemMeals();
            mealsListener();

          
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
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

        public void InitializeCustomFont_Label(Label label, float size)
        {

            int fontLength = Properties.Resources.Franchise.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Franchise;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc1.AddMemoryFont(data, fontLength);

            label.Font = new Font(pfc1.Families[0], (float)size);

        }

        public void InitializeCustomFont_Cartoony(Label label, float size)
        {

            int fontLength = Properties.Resources.jellee_roman.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.jellee_roman;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc2.AddMemoryFont(data, fontLength);

            label.Font = new Font(pfc2.Families[0], (float)size);

        }

        public void InitializeCustomFont_CartoonyButtons(Button btn, float size)
        {

            int fontLength = Properties.Resources.jellee_roman.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.jellee_roman;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc3.AddMemoryFont(data, fontLength);

            btn.Font = new Font(pfc3.Families[0], (float)size);

        }

        public void changeFoodDetailPanelLabelFont()
        {
            foreach (Control ctl in foodDetailPanel.Controls)
            {
                if (ctl is Label)
                {
                    InitializeCustomFont_Cartoony((Label)ctl, 12f);
                }
            }
        }

        public void changeFoodDetailButtonFont()
        {
            foreach (Control ctl in foodDetailPanel.Controls)
            {
                if (ctl is Button)
                {
                    InitializeCustomFont_CartoonyButtons((Button)ctl, 12f);
                }
            }
        }

        public void changeCurrentOrderTotalPanelLabels()
        {
            foreach (Control ctl in currentOrderTotalPanel.Controls)
            {
                if (ctl is Label)
                {
                    InitializeCustomFont_Cartoony((Label)ctl, 12f);

                }
            }
        }


        public void InitializeMeals()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePaths[0]), "Miso Soup", "P100"));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePaths[1]), "Egg", "P200"));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePaths[2]), "Sandwich", "P300"));
        }

        public void InitializeDrinks()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePaths[0]), "Iced Tea", "P100"));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePaths[1]), "Coffee", "P200"));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePaths[2]), "Water", "P300"));
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
            setMealIndex(meal);

            quantityForm qtySelector = new quantityForm();
            qtySelector.ShowDialog();

            setMealQuantityVariable(qtySelector);
            setMealQuantityDetail(orderQuantity);

            setSpecialRequestReceipt(qtySelector.SpecialRequest);

            setMealTotal(meal.getMealPrice(), orderQuantity);


        }

        private void setSpecialRequestReceipt(string specialReq)
        {
            this.specialRequest = specialReq;
        }

        private void setMealIndex(itemMeal meal)
        {
            index = meal.getIndex();
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
            index = 0;

            mealPictureDetail.Image = Image.FromFile(foodGif);

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

                totalToPay += total;
                discount = 0;

                if (doesOrderExistsAlready(index) && (getExistingMeal().getSpecialRequest() == specialRequest))
                {
                    //Remove the existing meal in the receipt
                    removeFromReceipt(getExistingMeal(), specialRequest);

                    //Get the quantity of the existing meal, remove the meal, add the new meal.
                    updateExistingMeal(orderQuantity);

                    //Add to receipt the new meal
                    addToReceipt(orderName, newQuantity, newTotal, specialRequest);

                }
                else
                {
                    orderedMeal.Add(new orderedMeal(index, orderName, total, orderQuantity, orderPrice, specialRequest, this));


                    addToReceipt(orderName, orderQuantity, total, specialRequest);
                }
                //Adds the newly added meal to the record
                orderedMealsRecordTablePanel.Controls.Add(orderedMeal[orderedMeal.Count - 1]);




                setOrderedMealTotals();

                clearDetails(true);
            }
            else
            {
                MessageBox.Show("Order Invalid. Please try again.");
            }
        }

        private void updateExistingMeal(int quantity)
        {
            //Get the quantity of the existing meal in list
            //Remove the meal
            //Create a new meal with the added quantity
            orderedMeal existingMeal = getExistingMeal();

            int existingMealIndex = existingMeal.getMealIndex();
            string existingMealName = existingMeal.getMealName();
            int existingQuantity = existingMeal.getQuantity();
            double existingMealTotal = existingMeal.getTotal();

            newQuantity = existingQuantity + quantity;
            newTotal = newQuantity * existingMeal.getMealPrice();

            //remove existingorderedMeal in record panel
            //update receipt
            removeExistingMeal();

            orderedMeal.Add(new orderedMeal(existingMealIndex, existingMealName, newTotal, newQuantity, existingMeal.getMealPrice(), specialRequest, this));
        }

        private orderedMeal getExistingMeal()
        {
            return orderedMeal.Find(m => m.getMealIndex() == index);
        }

        private void removeExistingMeal()
        {
            orderedMealsRecordTablePanel.Controls.Remove(orderedMeal.Find(m => m.getMealIndex() == index));

            orderedMeal.Remove(orderedMeal.Find(m => m.getMealIndex() == index));

            orderedMealsRecordTablePanel.Refresh();
        }

        private bool doesOrderExistsAlready(int index)
        {
            foreach (orderedMeal meal in orderedMeal)
            {
                if (meal.getMealIndex() == index) return true;
            }

            return false;
        }

        public void removeOrder(orderedMeal Order, string specialRequest)
        {
            orderedMeal.Remove(Order);
            orderedMealsRecordTablePanel.Controls.Remove(Order);
            orderedMealsRecordTablePanel.Refresh();

            removeFromReceipt(Order, specialRequest);
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
            txtBxReceipt.Clear();
            DateTime currentDateTime = DateTime.Now;
            string date = currentDateTime.ToString("dddd, dd MMMM yyyy hh:mm tt");

            StringBuilder heading = new StringBuilder();
            heading.Append("\n" +
                "             Diner by the Valley" +
                "\n           Angeles University Corp." +
                "\n                  BSIT 2A" +
                "\n     " + date +
                "\n                 " + dineOrTake +
                "\n              Receipt No. " + RandomNumberGenerator.GetInt32(100000) +
                "\n===========================================");
            string formattedString = String.Format("\n{0,-16} {1,-10} {2,-10}", "     " + "Meal Name", "Quantity", "Total Price");
            heading.Append(formattedString);

            heading.Append("\n-------------------------------------------");

            txtBxReceipt.Text = heading.ToString();
        }
        private void addToReceipt(String orderName, int quantity, double total, string specialReq = "")
        {
            StringBuilder stb = new StringBuilder();
            string formattedString = String.Format("\n{0,-20} {1,-10} {2,-10} {3,-20}", "     " + orderName, quantity, total + "\n", specialReq);
            stb.Append(formattedString);

            txtBxReceipt.AppendText(stb.ToString());
        }

        private void removeFromReceipt(orderedMeal order, string specialReq = "")
        {
            String prev = txtBxReceipt.Text;

            StringBuilder stb = new StringBuilder();
            string formattedString = String.Format("\n{0,-20} {1,-10} {2,-10} {3,-20}", "     " + order.getMealName(), order.getQuantity(), order.getTotal() + "\n", specialReq);

            String removedOrderReceipt = prev.Replace(formattedString, "");

            InitializeReceipt();
            txtBxReceipt.Text = removedOrderReceipt;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogReceipt.Document = printDocumentReceipt;
            printPreviewDialogReceipt.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            meals.Clear();
            InitializeMeals();
            displayItemMeals();
            mealsListener();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            meals.Clear();
            InitializeDrinks();
            displayItemMeals();
            mealsListener();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (orderedMeal.Count > 0)
            {
                paymentForm paymentForm = new paymentForm(totalToPay, txtBxReceipt, dineOrTake);
                paymentForm.Show();
            }
            else
            {
                MessageBox.Show("You currently have no orders.");
            }
        }

        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBxReceipt.Text, new Font(pfc.Families[0], (float)30f), Brushes.Black, new Point(10, 10));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}