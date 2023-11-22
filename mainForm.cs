using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace DinerGUIApplication
{
    public partial class mainForm : Form
    {
        /*        PrivateFontCollection pfc = new PrivateFontCollection();
                PrivateFontCollection pfc1 = new PrivateFontCollection();
                PrivateFontCollection pfc2 = new PrivateFontCollection();
                PrivateFontCollection pfc3 = new PrivateFontCollection();*/

        List<itemMeal> meals = new List<itemMeal>();
        List<itemMeal> drinks = new List<itemMeal>();

        //BETA VERSION
        List<itemMeal> newMeals = new List<itemMeal>();
        List<itemMeal> newDrinks = new List<itemMeal>();

        List<orderedMeal> orderedMeal = new List<orderedMeal>();
        List<string> imageFilePathsMain = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\vegsalad.png",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\chicksalad.png",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\hamncheese.png"
        };

        List<string> imageFilePathsDrinks = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\water.png",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\cola.png",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\FoodResources\\coffee.png"
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
        string mealDetail;

        int newQuantity;
        double newTotal;


        int adminIndex;
        string adminImageFilePath;
        string adminMealName;
        string adminMealPrice;
        string adminMealDetails;

        //BETA VERSION
        string adminCategory;

        fontType ft = new fontType();

        public mainForm(string dineOrTake)
        {
            InitializeComponent();
            InitializeMeals();
            InitializeDrinks();  //BETA VERSION


            this.dineOrTake = dineOrTake;

            InitializeReceipt();
            ft.InitializeCustomFont_Receipt(txtBxReceipt);
            ft.InitializeCustomFont_Label(lblDinerName, 43f);

            changeFoodDetailButtonFont();
            changeFoodDetailPanelLabelFont();
            changeCurrentOrderTotalPanelLabels();

            displayItemMeals(meals);
            mealsListener(meals);


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

        /*    [DllImport("gdi32.dll")]
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

            }*/

        public void changeFoodDetailPanelLabelFont()
        {
            foreach (Control ctl in foodDetailPanel.Controls)
            {
                if (ctl is Label)
                {
                    ft.InitializeCustomFont_Cartoony((Label)ctl, 12f);
                }
            }
        }

        public void changeFoodDetailButtonFont()
        {
            foreach (Control ctl in foodDetailPanel.Controls)
            {
                if (ctl is Button)
                {
                    ft.InitializeCustomFont_CartoonyButtons((Button)ctl, 12f);
                }
            }
        }

        public void changeCurrentOrderTotalPanelLabels()
        {
            foreach (Control ctl in currentOrderTotalPanel.Controls)
            {
                if (ctl is Label)
                {
                    ft.InitializeCustomFont_Cartoony((Label)ctl, 12f);

                }
            }
        }


        public void InitializeMeals()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePathsMain[0]), "Veggie Salad", "P80", "Vegetable with Salad and Dressing"));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePathsMain[1]), "Chick Salad", "P100", "Boiled Egg in 5 minute water."));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePathsMain[2]), "Sandwich", "P30", "Two buns and ham and mayonnaise."));
        }
        //BETA VERSION
        public void InitializeDrinks()
        {
            drinks.Add(new itemMeal(4, Image.FromFile(imageFilePathsDrinks[0]), "Water", "P0", "Free Water for each order!"));
            drinks.Add(new itemMeal(5, Image.FromFile(imageFilePathsDrinks[1]), "Cola", "P15", "Cold Cola from the Himalayans,"));
            drinks.Add(new itemMeal(6, Image.FromFile(imageFilePathsDrinks[2]), "Coffee", "P20", "Tired student? There is coffee for you! Made from fresh cacao beans from the Ifugao Province."));
        }
        //BETA VERSION
        public void displayItemMeals(List<itemMeal> meals)
        {
            /* foreach (itemMeal itemMeals in meals)
             {
                 itemMeals.TopLevel = false;
             }*/
            /*foodFlowLayoutPanel.Controls.Clear();*/  //BETA VERSION
            for (int i = 0; i < meals.Count; i++)
            {
                foodFlowLayoutPanel.Controls.Add(meals[i]);
                /*meals[i].Show();*/
            }
        }
        //BETA VERSION
        public void mealsListener(List<itemMeal> meals)
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
            setMealDetail(meal);

            quantityForm qtySelector = new quantityForm();
            qtySelector.ShowDialog();

            setMealQuantityVariable(qtySelector);
            setMealQuantityDetail(orderQuantity);

            setSpecialRequestReceipt(qtySelector.SpecialRequest);

            setMealTotal(meal.getMealPrice(), orderQuantity);


        }

        private void setMealDetail(itemMeal meal)
        {
            this.mealDetail = meal.getMealDetails();
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
            mealDetail = null;
            orderPrice = 0;
            orderQuantity = 0;
            total = 0;
            index = 0;

            mealPictureDetail.Image = Image.FromFile(foodGif);

            if (addedSuccessfully)
            {
                lblMealName.Text = "Added!";
            }
            else
            {
                lblMealName.Text = "No order yet.";
            }

            lblMealPrice.Text = "";
            lblQuantity.Text = "";
            lblTotal.Text = "";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDetails(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (orderName != null && orderPrice >= 0 && orderQuantity > 0)
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
            lblCategory.Text = "Main Dish";
            foodFlowLayoutPanel.Controls.Clear();  //BETA VERSION
            meals.Clear();
            InitializeMeals();
            displayItemMeals(meals);  //BETA VERSION
            mealsListener(meals);  //BETA VERSION
                                   //BETA VERSION
            if (newMeals.Count > 0)
            {
                displayItemMeals(newMeals);
                mealsListener(newMeals);
            }
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Drinks";
            foodFlowLayoutPanel.Controls.Clear();  //BETA VERSION
            drinks.Clear();
            InitializeDrinks();
            displayItemMeals(drinks);  //BETA VERSION
            mealsListener(drinks);  //BETA VERSION
                                    //BETA VERSION
            if (newDrinks.Count > 0)
            {
                displayItemMeals(newDrinks);
                mealsListener(newDrinks);
            }
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
            e.Graphics.DrawString(txtBxReceipt.Text, new Font(ft.getPFC().Families[0], (float)30f), Brushes.Black, new Point(10, 10));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mealDetailButton_Click(object sender, EventArgs e)
        {
            if (orderName != null && mealDetail != null)
            {
                mealDetailForm mdf = new mealDetailForm(orderName, mealDetail);
                mdf.Show();
            }
            else
            {
                MessageBox.Show("No order yet!");
            }
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string input = Microsoft.VisualBasic.Interaction.InputBox("Authorized Personnel Only.\n\n\nEnter password.",
                       "Enter Password",
                       "Password",
                       x,
                       y);
            if (input == "OOP10")
            {
                adminForm admin = new adminForm();
                admin.ShowDialog();

                adminIndex = admin.Index;
                adminImageFilePath = admin.ImageFilePath;
                adminMealName = admin.MealName;
                adminMealPrice = admin.MealPrice;
                adminMealDetails = admin.MealDetails;
                adminCategory = admin.CategoryBox;

                //BETA VERSION
                if (adminCategory.Equals("Meals"))
                {
                    if (adminIndex != 0 && adminImageFilePath != null && adminMealName != null && adminMealPrice != null && adminMealDetails != null)
                    {
                        newMeals.Add(new itemMeal(adminIndex, Image.FromFile(adminImageFilePath), adminMealName, "P" + adminMealPrice, adminMealDetails));
                    }
                    foodFlowLayoutPanel.Controls.Clear();
                    lblCategory.Text = "Main Dish";
                    displayItemMeals(meals);
                    mealsListener(meals);
                    displayItemMeals(newMeals);
                    mealsListener(newMeals);
                }
                //BETA VERSION
                else if (adminCategory.Equals("Drinks"))
                {
                    if (adminIndex != 0 && adminImageFilePath != null && adminMealName != null && adminMealPrice != null && adminMealDetails != null)
                    {
                        newDrinks.Add(new itemMeal(adminIndex, Image.FromFile(adminImageFilePath), adminMealName, "P" + adminMealPrice, adminMealDetails));
                    }
                    foodFlowLayoutPanel.Controls.Clear();
                    lblCategory.Text = "Drinks";
                    displayItemMeals(drinks);
                    mealsListener(drinks);
                    displayItemMeals(newDrinks);
                    mealsListener(newDrinks);
                }
            }
            else
            {
                MessageBox.Show("Wrong password.");
            }


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diner by the Valley is a vibrant diner nestled in the heart of the valley, " +
                "tailored for students seeking a place to enjoy delicious meals customized to their tastes and needs.\n\n" +
                "Stepping inside, visitors are welcomed by an inviting ambiance and the irresistible aroma of freshly prepared dishes.\n\n" +
                "Our menu at Diner by the Valley is designed with students in mind, offering a diverse range of customizable options and " +
                "happily accommodating special requests. From quick bites between classes to late-night study sessions, " +
                "we provide flavorful meals made from quality ingredients.\n\nWhether it's dietary preferences or unique cravings, " +
                "our goal at Diner by the Valley is to cater to every student's palate, ensuring a memorable dining experience each time you " +
                "visit, \n\n" +
                "" +
                "\tCreated By:\n\n" +
                "\t[BSIT 2-A].\n" +
                "\tMark Jerome Santos\n" +
                "\tMarcus Cariño\n" +
                "\tJaneil Isheen Gonzales");
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}