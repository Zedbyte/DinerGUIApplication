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
            btnRemoveOrder = new FontAwesome.Sharp.IconButton();
            lblSpecialReq = new Label();
            SuspendLayout();
            // 
            // orderedMealQuantity
            // 
            orderedMealQuantity.BackColor = Color.FromArgb(108, 124, 103);
            orderedMealQuantity.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            orderedMealQuantity.ForeColor = Color.White;
            orderedMealQuantity.Location = new Point(4, 3);
            orderedMealQuantity.Name = "orderedMealQuantity";
            orderedMealQuantity.Size = new Size(61, 58);
            orderedMealQuantity.TabIndex = 0;
            orderedMealQuantity.Text = "Qty";
            orderedMealQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderedMealName
            // 
            orderedMealName.AutoSize = true;
            orderedMealName.BackColor = Color.Transparent;
            orderedMealName.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderedMealName.Location = new Point(69, 9);
            orderedMealName.Name = "orderedMealName";
            orderedMealName.Size = new Size(43, 23);
            orderedMealName.TabIndex = 1;
            orderedMealName.Text = "Meal";
            // 
            // orderedMealTotal
            // 
            orderedMealTotal.AutoSize = true;
            orderedMealTotal.Font = new Font("Pink Chicken", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            orderedMealTotal.Location = new Point(71, 33);
            orderedMealTotal.Name = "orderedMealTotal";
            orderedMealTotal.Size = new Size(19, 19);
            orderedMealTotal.TabIndex = 2;
            orderedMealTotal.Text = "0";
            // 
            // btnRemoveOrder
            // 
            btnRemoveOrder.BackColor = Color.Maroon;
            btnRemoveOrder.FlatStyle = FlatStyle.Flat;
            btnRemoveOrder.ForeColor = SystemColors.ControlLightLight;
            btnRemoveOrder.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnRemoveOrder.IconColor = Color.White;
            btnRemoveOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoveOrder.IconSize = 25;
            btnRemoveOrder.Location = new Point(222, 24);
            btnRemoveOrder.Name = "btnRemoveOrder";
            btnRemoveOrder.Size = new Size(48, 18);
            btnRemoveOrder.TabIndex = 3;
            btnRemoveOrder.UseVisualStyleBackColor = false;
            btnRemoveOrder.Click += btnRemoveOrder_Click;
            // 
            // lblSpecialReq
            // 
            lblSpecialReq.BackColor = Color.Transparent;
            lblSpecialReq.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecialReq.Location = new Point(185, 4);
            lblSpecialReq.Name = "lblSpecialReq";
            lblSpecialReq.Size = new Size(100, 19);
            lblSpecialReq.TabIndex = 4;
            // 
            // orderedMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 250, 245);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblSpecialReq);
            Controls.Add(btnRemoveOrder);
            Controls.Add(orderedMealTotal);
            Controls.Add(orderedMealName);
            Controls.Add(orderedMealQuantity);
            Name = "orderedMeal";
            Size = new Size(288, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderedMealQuantity;
        private Label orderedMealName;
        private Label orderedMealTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnRemoveOrder;
        private Label lblSpecialReq;
    }
}
