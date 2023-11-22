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
        public mealDetailForm() { }
        public mealDetailForm(string name, string foodDetail)
        {
            InitializeComponent();
            mealName.Text = name;
            mealDetailBox.Text = foodDetail;
        }
    }
}
