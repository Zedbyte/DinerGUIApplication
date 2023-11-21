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
    public partial class mealDetailForm : Form
    {
        Image img;
        string name;
        string foodDetail;
        public mealDetailForm() { }
        public mealDetailForm(Image img, string name, string foodDetail)
        {
            InitializeComponent();
            this.img = img;
            this.name = name;
            this.foodDetail = foodDetail;
        }
    }
}
