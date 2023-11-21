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
            mealPicturebox = new PictureBox();
            mealName = new Label();
            mealPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)mealPicturebox).BeginInit();
            SuspendLayout();
            // 
            // mealPicturebox
            // 
            mealPicturebox.Location = new Point(-2, 0);
            mealPicturebox.Name = "mealPicturebox";
            mealPicturebox.Size = new Size(150, 101);
            mealPicturebox.SizeMode = PictureBoxSizeMode.CenterImage;
            mealPicturebox.TabIndex = 0;
            mealPicturebox.TabStop = false;
            // 
            // mealName
            // 
            mealName.AutoSize = true;
            mealName.ForeColor = Color.Transparent;
            mealName.Location = new Point(3, 108);
            mealName.Name = "mealName";
            mealName.Size = new Size(37, 21);
            mealName.TabIndex = 0;
            mealName.Text = "label1";
            mealName.UseCompatibleTextRendering = true;
            // 
            // mealPrice
            // 
            mealPrice.AutoSize = true;
            mealPrice.ForeColor = Color.Transparent;
            mealPrice.Location = new Point(3, 129);
            mealPrice.Name = "mealPrice";
            mealPrice.Size = new Size(37, 21);
            mealPrice.TabIndex = 1;
            mealPrice.Text = "label2";
            mealPrice.UseCompatibleTextRendering = true;
            // 
            // itemMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 124, 103);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(mealPrice);
            Controls.Add(mealName);
            Controls.Add(mealPicturebox);
            ForeColor = SystemColors.ControlLightLight;
            Name = "itemMeal";
            Size = new Size(144, 155);
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
