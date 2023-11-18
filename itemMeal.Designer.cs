namespace DinerGUIApplication
{
    partial class itemMeal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemMeal));
            mealPicturebox = new PictureBox();
            mealName = new Label();
            mealPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)mealPicturebox).BeginInit();
            SuspendLayout();
            // 
            // mealPicturebox
            // 
            mealPicturebox.Image = (Image)resources.GetObject("mealPicturebox.Image");
            mealPicturebox.Location = new Point(0, 0);
            mealPicturebox.Name = "mealPicturebox";
            mealPicturebox.Size = new Size(148, 90);
            mealPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            mealPicturebox.TabIndex = 0;
            mealPicturebox.TabStop = false;
            // 
            // mealName
            // 
            mealName.AutoSize = true;
            mealName.Location = new Point(14, 93);
            mealName.Name = "mealName";
            mealName.Size = new Size(38, 15);
            mealName.TabIndex = 0;
            mealName.Text = "label1";
            // 
            // mealPrice
            // 
            mealPrice.AutoSize = true;
            mealPrice.Location = new Point(14, 117);
            mealPrice.Name = "mealPrice";
            mealPrice.Size = new Size(38, 15);
            mealPrice.TabIndex = 1;
            mealPrice.Text = "label2";
            // 
            // itemMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 107, 117);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(mealPrice);
            Controls.Add(mealName);
            Controls.Add(mealPicturebox);
            ForeColor = SystemColors.ControlLightLight;
            Name = "itemMeal";
            Size = new Size(146, 139);
            MouseEnter += itemMeal_MouseEnter;
            MouseLeave += itemMeal_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)mealPicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mealPicturebox;
        private Label mealName;
        private Label mealPrice;
    }
}
