namespace DinerGUIApplication
{
    partial class orderedMeal
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
            orderedMealQuantity = new Label();
            orderedMealName = new Label();
            orderedMealTotal = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // orderedMealQuantity
            // 
            orderedMealQuantity.BackColor = Color.FromArgb(238, 232, 213);
            orderedMealQuantity.Location = new Point(4, 4);
            orderedMealQuantity.Name = "orderedMealQuantity";
            orderedMealQuantity.Size = new Size(61, 58);
            orderedMealQuantity.TabIndex = 0;
            orderedMealQuantity.Text = "Qty";
            orderedMealQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderedMealName
            // 
            orderedMealName.AutoSize = true;
            orderedMealName.Location = new Point(91, 10);
            orderedMealName.Name = "orderedMealName";
            orderedMealName.Size = new Size(33, 15);
            orderedMealName.TabIndex = 1;
            orderedMealName.Text = "Meal";
            // 
            // orderedMealTotal
            // 
            orderedMealTotal.AutoSize = true;
            orderedMealTotal.Location = new Point(92, 33);
            orderedMealTotal.Name = "orderedMealTotal";
            orderedMealTotal.Size = new Size(13, 15);
            orderedMealTotal.TabIndex = 2;
            orderedMealTotal.Text = "0";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Maroon;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(238, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 16);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // orderedMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 154, 41);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(iconButton1);
            Controls.Add(orderedMealTotal);
            Controls.Add(orderedMealName);
            Controls.Add(orderedMealQuantity);
            Name = "orderedMeal";
            Size = new Size(300, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderedMealQuantity;
        private Label orderedMealName;
        private Label orderedMealTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
