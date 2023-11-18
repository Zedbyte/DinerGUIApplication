namespace DinerGUIApplication
{
    partial class itemMeals
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mealPictureBox = new PictureBox();
            panel1 = new Panel();
            mealPrice = new Label();
            mealName = new Label();
            ((System.ComponentModel.ISupportInitialize)mealPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mealPictureBox
            // 
            mealPictureBox.Location = new Point(0, 0);
            mealPictureBox.Name = "mealPictureBox";
            mealPictureBox.Size = new Size(147, 87);
            mealPictureBox.TabIndex = 0;
            mealPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(mealPrice);
            panel1.Controls.Add(mealName);
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 44);
            panel1.TabIndex = 1;
            // 
            // mealPrice
            // 
            mealPrice.AutoSize = true;
            mealPrice.Location = new Point(12, 24);
            mealPrice.Name = "mealPrice";
            mealPrice.Size = new Size(35, 15);
            mealPrice.TabIndex = 1;
            mealPrice.Text = "P0.00";
            // 
            // mealName
            // 
            mealName.AutoSize = true;
            mealName.Location = new Point(12, 9);
            mealName.Name = "mealName";
            mealName.Size = new Size(37, 15);
            mealName.TabIndex = 0;
            mealName.Text = "name";
            // 
            // itemMeals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(147, 125);
            Controls.Add(panel1);
            Controls.Add(mealPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "itemMeals";
            Text = "itemMeals";
            ((System.ComponentModel.ISupportInitialize)mealPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mealPictureBox;
        private Panel panel1;
        private Label mealPrice;
        private Label mealName;
    }
}