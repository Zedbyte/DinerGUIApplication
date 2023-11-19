namespace DinerGUIApplication
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parentPanel = new Panel();
            orderParentPanel = new Panel();
            lblTotalWDiscount = new Label();
            lblDiscountApplied = new Label();
            lblTotalNoDiscount = new Label();
            panel4 = new Panel();
            btnPlaceOrder = new Button();
            totalWDiscountLABELONLY = new Label();
            panel3 = new Panel();
            discountLABELONLY = new Label();
            totalNoDiscLABELONLY = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            orderedMealsRecordTablePanel = new TableLayoutPanel();
            orderPanelTitle = new Panel();
            label3 = new Label();
            receiptParentPanel = new Panel();
            panel5 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            placeOrderToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            txtBxReceipt = new RichTextBox();
            receiptPanelTitle = new Panel();
            label4 = new Label();
            foodParentPanel = new Panel();
            foodFlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            foodDetailPanel = new Panel();
            LBLTTL = new Label();
            LBLQTY = new Label();
            LBLPRICE = new Label();
            LBLNAME = new Label();
            btnClear = new Button();
            lblTotal = new Label();
            lblQuantity = new Label();
            addButton = new FontAwesome.Sharp.IconButton();
            lblMealPrice = new Label();
            lblMealName = new Label();
            mealPictureDetail = new PictureBox();
            label2 = new Label();
            printReceipt = new PrintDialog();
            btnFood = new Button();
            btnDrinks = new Button();
            parentPanel.SuspendLayout();
            orderParentPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            orderPanelTitle.SuspendLayout();
            receiptParentPanel.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            receiptPanelTitle.SuspendLayout();
            foodParentPanel.SuspendLayout();
            foodDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mealPictureDetail).BeginInit();
            SuspendLayout();
            // 
            // parentPanel
            // 
            parentPanel.BackColor = Color.FromArgb(234, 209, 181);
            parentPanel.Controls.Add(orderParentPanel);
            parentPanel.Controls.Add(receiptParentPanel);
            parentPanel.Controls.Add(foodParentPanel);
            parentPanel.Location = new Point(66, 59);
            parentPanel.Name = "parentPanel";
            parentPanel.Size = new Size(1225, 596);
            parentPanel.TabIndex = 0;
            // 
            // orderParentPanel
            // 
            orderParentPanel.BackColor = Color.White;
            orderParentPanel.Controls.Add(lblTotalWDiscount);
            orderParentPanel.Controls.Add(lblDiscountApplied);
            orderParentPanel.Controls.Add(lblTotalNoDiscount);
            orderParentPanel.Controls.Add(panel4);
            orderParentPanel.Controls.Add(totalWDiscountLABELONLY);
            orderParentPanel.Controls.Add(panel3);
            orderParentPanel.Controls.Add(discountLABELONLY);
            orderParentPanel.Controls.Add(totalNoDiscLABELONLY);
            orderParentPanel.Controls.Add(panel1);
            orderParentPanel.Controls.Add(orderedMealsRecordTablePanel);
            orderParentPanel.Controls.Add(orderPanelTitle);
            orderParentPanel.Location = new Point(541, 14);
            orderParentPanel.Name = "orderParentPanel";
            orderParentPanel.Size = new Size(332, 566);
            orderParentPanel.TabIndex = 2;
            // 
            // lblTotalWDiscount
            // 
            lblTotalWDiscount.AutoSize = true;
            lblTotalWDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalWDiscount.Location = new Point(250, 463);
            lblTotalWDiscount.Name = "lblTotalWDiscount";
            lblTotalWDiscount.Size = new Size(42, 21);
            lblTotalWDiscount.TabIndex = 9;
            lblTotalWDiscount.Text = "Total";
            // 
            // lblDiscountApplied
            // 
            lblDiscountApplied.AutoSize = true;
            lblDiscountApplied.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscountApplied.Location = new Point(250, 415);
            lblDiscountApplied.Name = "lblDiscountApplied";
            lblDiscountApplied.Size = new Size(42, 21);
            lblDiscountApplied.TabIndex = 8;
            lblDiscountApplied.Text = "Total";
            // 
            // lblTotalNoDiscount
            // 
            lblTotalNoDiscount.AutoSize = true;
            lblTotalNoDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalNoDiscount.Location = new Point(250, 387);
            lblTotalNoDiscount.Name = "lblTotalNoDiscount";
            lblTotalNoDiscount.Size = new Size(42, 21);
            lblTotalNoDiscount.TabIndex = 7;
            lblTotalNoDiscount.Text = "Total";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(253, 151, 103);
            panel4.Controls.Add(btnPlaceOrder);
            panel4.Location = new Point(1, 500);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 66);
            panel4.TabIndex = 6;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(244, 192, 149);
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlaceOrder.Location = new Point(57, 11);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(212, 45);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // totalWDiscountLABELONLY
            // 
            totalWDiscountLABELONLY.AutoSize = true;
            totalWDiscountLABELONLY.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalWDiscountLABELONLY.ForeColor = Color.FromArgb(0, 192, 0);
            totalWDiscountLABELONLY.Location = new Point(15, 460);
            totalWDiscountLABELONLY.Name = "totalWDiscountLABELONLY";
            totalWDiscountLABELONLY.Size = new Size(52, 25);
            totalWDiscountLABELONLY.TabIndex = 5;
            totalWDiscountLABELONLY.Text = "Total";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(1, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 2);
            panel3.TabIndex = 3;
            // 
            // discountLABELONLY
            // 
            discountLABELONLY.AutoSize = true;
            discountLABELONLY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            discountLABELONLY.Location = new Point(46, 415);
            discountLABELONLY.Name = "discountLABELONLY";
            discountLABELONLY.Size = new Size(128, 21);
            discountLABELONLY.TabIndex = 4;
            discountLABELONLY.Text = "Discount Applied";
            // 
            // totalNoDiscLABELONLY
            // 
            totalNoDiscLABELONLY.AutoSize = true;
            totalNoDiscLABELONLY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalNoDiscLABELONLY.Location = new Point(47, 387);
            totalNoDiscLABELONLY.Name = "totalNoDiscLABELONLY";
            totalNoDiscLABELONLY.Size = new Size(42, 21);
            totalNoDiscLABELONLY.TabIndex = 3;
            totalNoDiscLABELONLY.Text = "Total";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 2);
            panel2.TabIndex = 3;
            // 
            // orderedMealsRecordTablePanel
            // 
            orderedMealsRecordTablePanel.AutoScroll = true;
            orderedMealsRecordTablePanel.ColumnCount = 1;
            orderedMealsRecordTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderedMealsRecordTablePanel.Location = new Point(15, 79);
            orderedMealsRecordTablePanel.Name = "orderedMealsRecordTablePanel";
            orderedMealsRecordTablePanel.RowCount = 4;
            orderedMealsRecordTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            orderedMealsRecordTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            orderedMealsRecordTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            orderedMealsRecordTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            orderedMealsRecordTablePanel.Size = new Size(302, 294);
            orderedMealsRecordTablePanel.TabIndex = 1;
            // 
            // orderPanelTitle
            // 
            orderPanelTitle.BackColor = Color.FromArgb(253, 151, 103);
            orderPanelTitle.Controls.Add(label3);
            orderPanelTitle.Location = new Point(15, 12);
            orderPanelTitle.Name = "orderPanelTitle";
            orderPanelTitle.Size = new Size(302, 61);
            orderPanelTitle.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(10, 11);
            label3.Name = "label3";
            label3.Size = new Size(181, 37);
            label3.TabIndex = 14;
            label3.Text = "Current Order";
            // 
            // receiptParentPanel
            // 
            receiptParentPanel.BackColor = Color.FromArgb(244, 192, 149);
            receiptParentPanel.Controls.Add(panel5);
            receiptParentPanel.Controls.Add(txtBxReceipt);
            receiptParentPanel.Controls.Add(receiptPanelTitle);
            receiptParentPanel.Location = new Point(878, 14);
            receiptParentPanel.Name = "receiptParentPanel";
            receiptParentPanel.Size = new Size(332, 566);
            receiptParentPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Controls.Add(menuStrip1);
            panel5.Location = new Point(14, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 34);
            panel5.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(305, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem, placeOrderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(65, 25);
            fileToolStripMenuItem.Text = "Order";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(165, 26);
            orderToolStripMenuItem.Text = "Print";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // placeOrderToolStripMenuItem
            // 
            placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            placeOrderToolStripMenuItem.Size = new Size(165, 26);
            placeOrderToolStripMenuItem.Text = "Place Order";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(68, 25);
            aboutToolStripMenuItem.Text = "About";
            // 
            // txtBxReceipt
            // 
            txtBxReceipt.BackColor = Color.White;
            txtBxReceipt.BorderStyle = BorderStyle.None;
            txtBxReceipt.Location = new Point(14, 100);
            txtBxReceipt.Name = "txtBxReceipt";
            txtBxReceipt.ReadOnly = true;
            txtBxReceipt.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBxReceipt.Size = new Size(305, 451);
            txtBxReceipt.TabIndex = 2;
            txtBxReceipt.Text = "";
            // 
            // receiptPanelTitle
            // 
            receiptPanelTitle.BackColor = Color.FromArgb(253, 151, 103);
            receiptPanelTitle.Controls.Add(label4);
            receiptPanelTitle.Location = new Point(14, 12);
            receiptPanelTitle.Name = "receiptPanelTitle";
            receiptPanelTitle.Size = new Size(305, 61);
            receiptPanelTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(7, 8);
            label4.Name = "label4";
            label4.Size = new Size(102, 37);
            label4.TabIndex = 15;
            label4.Text = "Receipt";
            // 
            // foodParentPanel
            // 
            foodParentPanel.BackColor = Color.FromArgb(244, 192, 149);
            foodParentPanel.Controls.Add(foodFlowLayoutPanel);
            foodParentPanel.Controls.Add(label1);
            foodParentPanel.Controls.Add(foodDetailPanel);
            foodParentPanel.Location = new Point(16, 14);
            foodParentPanel.Name = "foodParentPanel";
            foodParentPanel.Size = new Size(520, 566);
            foodParentPanel.TabIndex = 0;
            // 
            // foodFlowLayoutPanel
            // 
            foodFlowLayoutPanel.AutoScroll = true;
            foodFlowLayoutPanel.BackColor = Color.FromArgb(255, 255, 192);
            foodFlowLayoutPanel.Location = new Point(13, 237);
            foodFlowLayoutPanel.Name = "foodFlowLayoutPanel";
            foodFlowLayoutPanel.Padding = new Padding(10, 10, 0, 0);
            foodFlowLayoutPanel.Size = new Size(494, 314);
            foodFlowLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 107, 117);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 188);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 3);
            label1.Size = new Size(138, 35);
            label1.TabIndex = 2;
            label1.Text = "Placeholder";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodDetailPanel
            // 
            foodDetailPanel.BackColor = Color.FromArgb(253, 151, 103);
            foodDetailPanel.Controls.Add(LBLTTL);
            foodDetailPanel.Controls.Add(LBLQTY);
            foodDetailPanel.Controls.Add(LBLPRICE);
            foodDetailPanel.Controls.Add(LBLNAME);
            foodDetailPanel.Controls.Add(btnClear);
            foodDetailPanel.Controls.Add(lblTotal);
            foodDetailPanel.Controls.Add(lblQuantity);
            foodDetailPanel.Controls.Add(addButton);
            foodDetailPanel.Controls.Add(lblMealPrice);
            foodDetailPanel.Controls.Add(lblMealName);
            foodDetailPanel.Controls.Add(mealPictureDetail);
            foodDetailPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foodDetailPanel.Location = new Point(13, 12);
            foodDetailPanel.Name = "foodDetailPanel";
            foodDetailPanel.Size = new Size(494, 161);
            foodDetailPanel.TabIndex = 1;
            // 
            // LBLTTL
            // 
            LBLTTL.AutoSize = true;
            LBLTTL.Location = new Point(159, 114);
            LBLTTL.Name = "LBLTTL";
            LBLTTL.Size = new Size(42, 21);
            LBLTTL.TabIndex = 13;
            LBLTTL.Text = "Total";
            // 
            // LBLQTY
            // 
            LBLQTY.AutoSize = true;
            LBLQTY.Location = new Point(159, 81);
            LBLQTY.Name = "LBLQTY";
            LBLQTY.Size = new Size(70, 21);
            LBLQTY.TabIndex = 12;
            LBLQTY.Text = "Quantity";
            // 
            // LBLPRICE
            // 
            LBLPRICE.AutoSize = true;
            LBLPRICE.Location = new Point(159, 47);
            LBLPRICE.Name = "LBLPRICE";
            LBLPRICE.Size = new Size(44, 21);
            LBLPRICE.TabIndex = 11;
            LBLPRICE.Text = "Price";
            // 
            // LBLNAME
            // 
            LBLNAME.AutoSize = true;
            LBLNAME.Location = new Point(159, 15);
            LBLNAME.Name = "LBLNAME";
            LBLNAME.Size = new Size(52, 21);
            LBLNAME.TabIndex = 10;
            LBLNAME.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Maroon;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(408, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 28);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblTotal
            // 
            lblTotal.ForeColor = Color.Lime;
            lblTotal.Location = new Point(249, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 21);
            lblTotal.TabIndex = 8;
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(249, 81);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(97, 21);
            lblQuantity.TabIndex = 4;
            lblQuantity.TextAlign = ContentAlignment.TopRight;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addButton.IconColor = Color.Black;
            addButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            addButton.IconSize = 25;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(381, 109);
            addButton.Name = "addButton";
            addButton.Size = new Size(97, 32);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.TextAlign = ContentAlignment.TopCenter;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // lblMealPrice
            // 
            lblMealPrice.Location = new Point(249, 47);
            lblMealPrice.Name = "lblMealPrice";
            lblMealPrice.Size = new Size(96, 21);
            lblMealPrice.TabIndex = 2;
            lblMealPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMealName
            // 
            lblMealName.Location = new Point(249, 15);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(96, 21);
            lblMealName.TabIndex = 1;
            lblMealName.TextAlign = ContentAlignment.TopRight;
            // 
            // mealPictureDetail
            // 
            mealPictureDetail.BackColor = Color.White;
            mealPictureDetail.Location = new Point(12, 14);
            mealPictureDetail.Name = "mealPictureDetail";
            mealPictureDetail.Size = new Size(135, 127);
            mealPictureDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            mealPictureDetail.TabIndex = 0;
            mealPictureDetail.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(233, 37);
            label2.TabIndex = 1;
            label2.Text = "Diner of the Valley";
            // 
            // printReceipt
            // 
            printReceipt.UseEXDialog = true;
            // 
            // btnFood
            // 
            btnFood.Location = new Point(4, 185);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(57, 53);
            btnFood.TabIndex = 2;
            btnFood.Text = "button1";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.Location = new Point(4, 258);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(57, 51);
            btnDrinks.TabIndex = 3;
            btnDrinks.Text = "button2";
            btnDrinks.UseVisualStyleBackColor = true;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 107, 117);
            ClientSize = new Size(1289, 651);
            Controls.Add(btnDrinks);
            Controls.Add(btnFood);
            Controls.Add(label2);
            Controls.Add(parentPanel);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner of the Valley";
            parentPanel.ResumeLayout(false);
            orderParentPanel.ResumeLayout(false);
            orderParentPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            orderPanelTitle.ResumeLayout(false);
            orderPanelTitle.PerformLayout();
            receiptParentPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            receiptPanelTitle.ResumeLayout(false);
            receiptPanelTitle.PerformLayout();
            foodParentPanel.ResumeLayout(false);
            foodParentPanel.PerformLayout();
            foodDetailPanel.ResumeLayout(false);
            foodDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mealPictureDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel parentPanel;
        private Panel orderParentPanel;
        private Panel orderPanelTitle;
        private Panel receiptParentPanel;
        private Panel foodParentPanel;
        private Panel receiptPanelTitle;
        private Label label1;
        private FlowLayoutPanel foodFlowLayoutPanel;
        private Panel foodDetailPanel;
        private Label lblTotal;
        private Label lblQuantity;
        private FontAwesome.Sharp.IconButton addButton;
        private Label lblMealPrice;
        private Label lblMealName;
        private PictureBox mealPictureDetail;
        private RichTextBox txtBxReceipt;
        private Label label2;
        private Button btnClear;
        private TableLayoutPanel orderedMealsRecordTablePanel;
        private Panel panel1;
        private Label totalWDiscountLABELONLY;
        private Panel panel3;
        private Label discountLABELONLY;
        private Label totalNoDiscLABELONLY;
        private Panel panel2;
        private Panel panel4;
        private Button btnPlaceOrder;
        private Panel panel5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblTotalWDiscount;
        private Label lblDiscountApplied;
        private Label lblTotalNoDiscount;
        private Label LBLTTL;
        private Label LBLQTY;
        private Label LBLPRICE;
        private Label LBLNAME;
        private Label label3;
        private Label label4;
        private PrintDialog printReceipt;
        private Button btnFood;
        private Button btnDrinks;
    }
}