using System.Collections;

namespace DinerGUIApplication
{
    public partial class mainForm : Form
    {

        List<itemMeal> meals = new List<itemMeal>();
        List<string> imageFilePaths = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro1.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro2.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro3.jpg"
        };


        public mainForm()
        {
            InitializeComponent();
            InitializeMeals();

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
                foreach (Control ctl in meals[i].Controls)
                {
                    ctl.Parent.Click += new System.EventHandler(this.mealsClicked);
                }
                meals[i].Click += new System.EventHandler(this.mealsClicked);
            }

        }

        public void mealsClicked(object sender, EventArgs e)
        {
            clearDetails();
            itemMeal obj = (itemMeal)sender;

            lblMealName.Text = obj.getMealName();
            lblMealPrice.Text = obj.getMealPrice().ToString();
            mealPictureDetail.Image = obj.getImage();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            displayItemMeals();
        }

        public void clearDetails()
        {
            mealPictureDetail.Image = null;
            lblMealName.Text = null;
            lblMealPrice.Text = null;
        }
    }
}