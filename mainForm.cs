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
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\vegsalad.png",
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\chicksalad.png",
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\hamncheese.png"
        };

        List<string> imageFilePathsDrinks = new List<string>
        {
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\water.png",
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\cola.png",
            "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\coffee.png"
        };

        string foodGif = "C:\\Users\\User\\Desktop\\BSIT 2A\\Diner\\FoodResources\\foodings.gif";

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

            //Add the meals and drinks to the list
            InitializeMeals();
            InitializeDrinks();  //BETA VERSION


            this.dineOrTake = dineOrTake;
            //Initialize the receipt and font
            InitializeReceipt();
            ft.InitializeCustomFont_Receipt(txtBxReceipt);
            ft.InitializeCustomFont_Label(lblDinerName, 43f);

            //Change fonts of the panels
            changeFoodDetailButtonFont();
            changeFoodDetailPanelLabelFont();
            changeCurrentOrderTotalPanelLabels();

            //Display the meals in the panel
            displayItemMeals(meals);
            mealsListener(meals);


        }
        //Disable the close button
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
        //Change Food Detail Panel Labels Fonts
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
        //Change the font of the food detail buttons
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
        //Change the font of the total Panel label
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

        //Initialize the Meals
        public void InitializeMeals()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePathsMain[0]), "Veggie Salad", "P80", "A colorful mix of crisp lettuce, juicy cherry tomatoes, and \ncrunchy cucumbers tossed in a zesty vinaigrette creates a refreshing and delightful salad, perfect for any meal."));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePathsMain[1]), "Chick Salad", "P100", "A classic chicken salad combines tender, shredded chicken with crisp celery, diced apples, and toasted almonds, all dressed in a creamy blend of mayonnaise and a \nhint of tangy Dijon mustard, delivering a satisfying balance of flavors and textures in every bite.\r\n"));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePathsMain[2]), "Sandwich", "P30", "Layer slices of roasted turkey breast, creamy avocado, crispy bacon, and fresh spinach between slices of whole-grain bread spread with a zesty garlic aioli for a \nflavorful and satisfying sandwich experience."));
        }
        //BETA VERSION
        //Initialize the Drinks
        public void InitializeDrinks()
        {
            drinks.Add(new itemMeal(4, Image.FromFile(imageFilePathsDrinks[0]), "Water", "P0", "Free Water for each order!"));
            drinks.Add(new itemMeal(5, Image.FromFile(imageFilePathsDrinks[1]), "Cola", "P15", "Cola, the iconic carbonated beverage, boasts a bubbly blend of caramel sweetness and a hint of citrus, delivering a fizzy, refreshing drink that's enjoyed worldwide."));
            drinks.Add(new itemMeal(6, Image.FromFile(imageFilePathsDrinks[2]), "Coffee", "P20", "Tired student? There is coffee for you! Made from fresh cacao beans from the Ifugao Province."));
        }
        //BETA VERSION
        //Display the meals based in the list
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
        //Craete listeners (Click) for the meals
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
        //When a meal is clicked, add the meal details on the detail panel
        public void mealsClicked(object sender, EventArgs e)
        {   
            //Clear the detail panel
            clearDetails(false);
            itemMeal meal = (itemMeal)sender;

            //Set the details
            setMealNameDetail(meal);
            setMealPriceDetail(meal);
            setMealPictureDetail(meal);
            setMealIndex(meal);
            setMealDetail(meal);

            //Open the quantity Selector 
            quantityForm qtySelector = new quantityForm();
            qtySelector.ShowDialog();

            //The quantity will be saved on the variable (orderQuantity)
            setMealQuantityVariable(qtySelector);
            setMealQuantityDetail(orderQuantity);

            //If there is a special request, add it to the variable  (SpecialReq) 
            setSpecialRequestReceipt(qtySelector.SpecialRequest);

            //Set the total of the meal
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
            //If the variable orderName is not null, orderPrice is equal to 0, orderQuantity is greater than 0 then execute
            if (orderName != null && orderPrice >= 0 && orderQuantity > 0)
            {
                //Add the total of the meal to the total of the whole orders
                totalToPay += total;
                discount = 0;

                //If an order exists already in the order panel, and the special request is equal to the new special request then edit the current order
                if (doesOrderExistsAlready(index) && (getExistingMeal().getSpecialRequest() == specialRequest))
                {
                    //Remove the existing meal in the receipt
                    removeFromReceipt(getExistingMeal(), specialRequest);

                    //Get the quantity of the existing meal, remove the meal, add the new meal.
                    updateExistingMeal(orderQuantity);

                    //Add to receipt the new meal (Update)
                    addToReceipt(orderName, newQuantity, newTotal, specialRequest);

                }
                //Else, treat the new order as a separate order
                else
                {
                    //Add the new order to the panel
                    orderedMeal.Add(new orderedMeal(index, orderName, total, orderQuantity, orderPrice, specialRequest, this));

                    //Add it to the receipt (Post)
                    addToReceipt(orderName, orderQuantity, total, specialRequest);
                }
                //Adds the newly added meal to the record
                orderedMealsRecordTablePanel.Controls.Add(orderedMeal[orderedMeal.Count - 1]);



                //Set the total
                setOrderedMealTotals();

                //Clear the details in the detail panel
                clearDetails(true);
            }
            //If the order is invalid (not containing a quantity, show an error)
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

        //Find the new meal in the list
        private orderedMeal getExistingMeal()
        {
            return orderedMeal.Find(m => m.getMealIndex() == index);
        }

        //Remove the existing meal (The existing meals are already saved once this is called, so we will append the details of the existing meal to the new meal)
        private void removeExistingMeal()
        {
            orderedMealsRecordTablePanel.Controls.Remove(orderedMeal.Find(m => m.getMealIndex() == index));

            orderedMeal.Remove(orderedMeal.Find(m => m.getMealIndex() == index));

            orderedMealsRecordTablePanel.Refresh();
        }

        //Iterates through the list, if it exists, return true, else return false.
        private bool doesOrderExistsAlready(int index)
        {
            foreach (orderedMeal meal in orderedMeal)
            {
                if (meal.getMealIndex() == index) return true;
            }

            return false;
        }
        //This method will be called by the orderedMeal user control (It removes the order in the order panel)
        public void removeOrder(orderedMeal Order, string specialRequest)
        {
            orderedMeal.Remove(Order);
            orderedMealsRecordTablePanel.Controls.Remove(Order);
            orderedMealsRecordTablePanel.Refresh();

            removeFromReceipt(Order, specialRequest);
            subtractTotalWhenOrderRemoved(Order.getTotal());
        }

        //If the order is removed, subtract that order to the total
        private void subtractTotalWhenOrderRemoved(double mealTotal)
        {
            totalToPay -= mealTotal;
            lblTotalNoDiscount.Text = "\u20B1" + totalToPay.ToString();
            lblTotalWDiscount.Text = "\u20B1" + (totalToPay - discount).ToString();

            setOrderedMealTotals();

        }

        //Set the total labels
        private void setOrderedMealTotals()
        {
            lblTotalNoDiscount.Text = "\u20B1" + totalToPay.ToString();
            lblDiscountApplied.Text = "\u20B1" + discount.ToString();

            lblTotalWDiscount.Text = "\u20B1" + (totalToPay - discount).ToString();

        }

        //Initializes the look of the receipt
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
        //Add an item to the receipt
        private void addToReceipt(String orderName, int quantity, double total, string specialReq = "")
        {
            StringBuilder stb = new StringBuilder();
            string formattedString = String.Format("\n{0,-20} {1,-10} {2,-10} {3,-20}", "     " + orderName, quantity, total + "\n", specialReq);
            stb.Append(formattedString);

            txtBxReceipt.AppendText(stb.ToString());
        }
        //Remove an item from the receipt (Get the text of the receipt and replace it with a new one)
        private void removeFromReceipt(orderedMeal order, string specialReq = "")
        {
            String prev = txtBxReceipt.Text;

            StringBuilder stb = new StringBuilder();
            string formattedString = String.Format("\n{0,-20} {1,-10} {2,-10} {3,-20}", "     " + order.getMealName(), order.getQuantity(), order.getTotal() + "\n", specialReq);

            String removedOrderReceipt = prev.Replace(formattedString, "");

            InitializeReceipt();
            txtBxReceipt.Text = removedOrderReceipt;
        }
        //Print 
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogReceipt.Document = printDocumentReceipt;
            printPreviewDialogReceipt.ShowDialog();
        }
        //If the button for Food (category) is clicked, change the items in the panel
        private void btnFood_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Main Dish";
            foodFlowLayoutPanel.Controls.Clear();  //BETA VERSION
            meals.Clear();
            InitializeMeals();
            displayItemMeals(meals);  //BETA VERSION
            mealsListener(meals);  //BETA VERSION
                                   //BETA VERSION

            //If there is an item in the newDrink list (added by the admin) add it to the panel as well
            if (newMeals.Count > 0)
            {
                displayItemMeals(newMeals);
                mealsListener(newMeals);
            }
        }
        //If the button for Drink (category) is clicked, change the items in the panel
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            lblCategory.Text = "Drinks";
            foodFlowLayoutPanel.Controls.Clear();  //BETA VERSION
            drinks.Clear();
            InitializeDrinks();
            displayItemMeals(drinks);  //BETA VERSION
            mealsListener(drinks);  //BETA VERSION
                                    //BETA VERSION

            //If there is an item in the newDrink list (added by the admin) add it to the panel as well
            if (newDrinks.Count > 0)
            {
                displayItemMeals(newDrinks);
                mealsListener(newDrinks);
            }
        }

        //Initialize payment form
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
        //Print Recceipt
        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtBxReceipt.Text, new Font(ft.getPFC().Families[0], (float)30f), Brushes.Black, new Point(10, 10));
        }
        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Click the question mark!!
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
        //Settings (admin)
        private void settingsIcon_Click(object sender, EventArgs e)
        {
            //Center the input box
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string input = Microsoft.VisualBasic.Interaction.InputBox("Authorized Personnel Only.\n\n\nEnter password.",
                       "Enter Password",
                       "Password",
                       x,
                       y);
            //If the password is OOP10 open the admin form
            if (input == "OOP10")
            {
                adminForm admin = new adminForm();
                admin.ShowDialog();

                //Once admin is closed, get all the details
                adminIndex = admin.Index;
                adminImageFilePath = admin.ImageFilePath;
                adminMealName = admin.MealName;
                adminMealPrice = admin.MealPrice;
                adminMealDetails = admin.MealDetails;
                adminCategory = admin.CategoryBox;

                //BETA VERSION
                //If the category is equal to Meals
                if (adminCategory.Equals("Meals"))
                {   //If all the details are filled
                    if (adminIndex != 0 && adminImageFilePath != null && adminMealName != null && adminMealPrice != null && adminMealDetails != null)
                    {
                        newMeals.Add(new itemMeal(adminIndex, Image.FromFile(adminImageFilePath), adminMealName, "P" + adminMealPrice, adminMealDetails));
                    }
                    //Clear the existing foods
                    foodFlowLayoutPanel.Controls.Clear();
                    lblCategory.Text = "Main Dish";

                    //Display again the hard coded meals
                    displayItemMeals(meals);
                    mealsListener(meals);
                    //Dispaly the new meal added by the admin
                    displayItemMeals(newMeals);
                    mealsListener(newMeals);
                }
                //BETA VERSION
                //If the category is equal to Drinks
                else if (adminCategory.Equals("Drinks"))
                {
                    //If all the details are filled
                    if (adminIndex != 0 && adminImageFilePath != null && adminMealName != null && adminMealPrice != null && adminMealDetails != null)
                    {
                        newDrinks.Add(new itemMeal(adminIndex, Image.FromFile(adminImageFilePath), adminMealName, "P" + adminMealPrice, adminMealDetails));
                    }
                    //Clear the existing foods
                    foodFlowLayoutPanel.Controls.Clear();
                    lblCategory.Text = "Drinks";

                    //Display again the hard coded meals
                    displayItemMeals(drinks);
                    mealsListener(drinks);
                    //Dispaly the new meal added by the admin
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
        //About Section
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
        //Place order inside the receipt
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