using System.Collections;

namespace DinerGUIApplication
{
    public partial class mainForm : Form
    {

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


        public mainForm()
        {
            InitializeComponent();
            InitializeMeals();
            displayItemMeals();
            mealsListener();
        }


        public void InitializeMeals()
        {
            meals.Add(new itemMeal(1, Image.FromFile(imageFilePaths[0]), "A", "P100"));
            meals.Add(new itemMeal(2, Image.FromFile(imageFilePaths[1]), "Egg", "P200"));
            meals.Add(new itemMeal(3, Image.FromFile(imageFilePaths[2]), "Sandwich", "P300"));
            meals.Add(new itemMeal(4, Image.FromFile(imageFilePaths[0]), "A", "P450"));
            meals.Add(new itemMeal(5, Image.FromFile(imageFilePaths[1]), "A", "P50"));
            meals.Add(new itemMeal(6, Image.FromFile(imageFilePaths[2]), "A", "P70"));
            meals.Add(new itemMeal(6, Image.FromFile(imageFilePaths[0]), "A", "P70"));
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
            clearDetails();
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
            lblMealPrice.Text = meal.getMealPrice().ToString();
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
            lblTotal.Text = total.ToString();
        }

        public void clearDetails()
        {
            orderName = null;
            orderPrice = 0;
            orderQuantity = 0;
            total = 0;

            mealPictureDetail.Image = null;
            lblMealName.Text = "No order yet.";
            lblMealPrice.Text = "-";
            lblQuantity.Text = "-";
            lblTotal.Text = "-";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (orderName != null && orderPrice > 0 && orderQuantity > 0)
            {
                orderedMeal.Add(new orderedMeal(orderName, total, orderQuantity));

                orderedMealsRecordTablePanel.Controls.Add(orderedMeal[orderedMeal.Count - 1]);

            }
            else
            {
                MessageBox.Show("Order Invalid. Please try again.");
            }

        }

    }
}