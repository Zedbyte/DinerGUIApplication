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
    public partial class startScreen : Form
    {
        int count = 0;

        List<string> imageFilePaths = new List<string>
        {
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro1.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro2.jpg",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Resources\\retro3.jpg"
        };

        List<Image> images = new List<Image>();


        public startScreen()
        {
            InitializeComponent();
            this.images = assignImages(images);
        }

        private List<Image> assignImages(List<Image> images)
        {
            foreach (string filePath in imageFilePaths)
            {
                Image img = Image.FromFile(filePath);
                images.Add(img);
            }

            return images;
        }


        private void timeIntervalTick(object sender, EventArgs e)
        {
            timeInterval.Interval = 100;
            if (count < 3)
            {
                timeInterval.Interval = 1000;
                slideShowContainer.Image = images[count];
                count++;
            }
            else { count = 0; }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            mainForm MainForm = new mainForm();
            MainForm.Show();
            this.Close();
        }
    }
}
