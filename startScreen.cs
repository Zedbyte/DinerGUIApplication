using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
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
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Slideshow\\s1.gif",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Slideshow\\s2.gif",
            "C:\\Users\\ADMIN\\Desktop\\Program\\C#\\DinerGUIApplication\\Slideshow\\s3.gif"
        };

        List<Image> images = new List<Image>();

        //Create your private font collection object.
        PrivateFontCollection pfc = new PrivateFontCollection();
        double[] fontSizes = new double[2];
        int currentFontSizeIndex;


        public startScreen()
        {
            InitializeComponent();
            InitializeCustomFont_MagicRetro(startButton);
            this.images = assignImages(images);
        }

        public void InitializeCustomFont_MagicRetro(Button btn)
        {
            int fontLength = Properties.Resources.Franchise.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Franchise;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            btn.Font = new Font(pfc.Families[0], btn.Font.Size);
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
                timeInterval.Interval = 2000;
                slideShowContainer.Image = images[count];
                count++;
            }
            else { count = 0; }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            dineOrTake dineOrTake = new dineOrTake();
            dineOrTake.Show();
            this.Close();
        }

        private void timeLabel_Tick(object sender, EventArgs e)
        {
            fontSizes[0] = 30.0;
            fontSizes[1] = 35.0;

            currentFontSizeIndex = (currentFontSizeIndex + 1) % fontSizes.Length;

            startButton.Font = new Font(pfc.Families[0], (float)fontSizes[currentFontSizeIndex]);
            Thread.Sleep(20);
            startButton.Font = new Font(pfc.Families[0], (float)fontSizes[currentFontSizeIndex]);

        }
    }
}
