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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            parentPanel = new Panel();
            orderParentPanel = new Panel();
            panel3 = new Panel();
            currentOrderTotalPanel = new Panel();
            lblTotalNoDiscount = new Label();
            lblDiscountApplied = new Label();
            lblTotalWDiscount = new Label();
            discountLABELONLY = new Label();
            totalNoDiscLABELONLY = new Label();
            totalWDiscountLABELONLY = new Label();
            panel4 = new Panel();
            btnPlaceOrder = new Button();
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
            lblCategory = new Label();
            foodDetailPanel = new Panel();
            mealDetailButton = new FontAwesome.Sharp.IconButton();
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
            panel6 = new Panel();
            btnFood = new Button();
            btnDrinks = new Button();
            lblDinerName = new Label();
            printReceipt = new PrintDialog();
            printPreviewDialogReceipt = new PrintPreviewDialog();
            printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            btnExits = new FontAwesome.Sharp.IconButton();
            settingsIcon = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            parentPanel.SuspendLayout();
            orderParentPanel.SuspendLayout();
            currentOrderTotalPanel.SuspendLayout();
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
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // parentPanel
            // 
            parentPanel.BackColor = Color.FromArgb(236, 236, 236);
            parentPanel.Controls.Add(orderParentPanel);
            parentPanel.Controls.Add(receiptParentPanel);
            parentPanel.Controls.Add(foodParentPanel);
            parentPanel.Controls.Add(panel6);
            parentPanel.Location = new Point(98, 92);
            parentPanel.Name = "parentPanel";
            parentPanel.Size = new Size(1248, 622);
            parentPanel.TabIndex = 0;
            // 
            // orderParentPanel
            // 
            orderParentPanel.BackColor = Color.FromArgb(255, 250, 245);
            orderParentPanel.Controls.Add(panel3);
            orderParentPanel.Controls.Add(currentOrderTotalPanel);
            orderParentPanel.Controls.Add(panel4);
            orderParentPanel.Controls.Add(panel1);
            orderParentPanel.Controls.Add(orderedMealsRecordTablePanel);
            orderParentPanel.Controls.Add(orderPanelTitle);
            orderParentPanel.Location = new Point(552, 30);
            orderParentPanel.Name = "orderParentPanel";
            orderParentPanel.Size = new Size(332, 566);
            orderParentPanel.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(1, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 2);
            panel3.TabIndex = 3;
            // 
            // currentOrderTotalPanel
            // 
            currentOrderTotalPanel.Controls.Add(lblTotalNoDiscount);
            currentOrderTotalPanel.Controls.Add(lblDiscountApplied);
            currentOrderTotalPanel.Controls.Add(lblTotalWDiscount);
            currentOrderTotalPanel.Controls.Add(discountLABELONLY);
            currentOrderTotalPanel.Controls.Add(totalNoDiscLABELONLY);
            currentOrderTotalPanel.Controls.Add(totalWDiscountLABELONLY);
            currentOrderTotalPanel.Location = new Point(0, 382);
            currentOrderTotalPanel.Name = "currentOrderTotalPanel";
            currentOrderTotalPanel.Size = new Size(332, 112);
            currentOrderTotalPanel.TabIndex = 10;
            // 
            // lblTotalNoDiscount
            // 
            lblTotalNoDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalNoDiscount.Location = new Point(197, 5);
            lblTotalNoDiscount.Name = "lblTotalNoDiscount";
            lblTotalNoDiscount.Size = new Size(95, 21);
            lblTotalNoDiscount.TabIndex = 7;
            lblTotalNoDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiscountApplied
            // 
            lblDiscountApplied.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscountApplied.Location = new Point(197, 33);
            lblDiscountApplied.Name = "lblDiscountApplied";
            lblDiscountApplied.Size = new Size(95, 21);
            lblDiscountApplied.TabIndex = 8;
            lblDiscountApplied.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalWDiscount
            // 
            lblTotalWDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalWDiscount.Location = new Point(197, 81);
            lblTotalWDiscount.Name = "lblTotalWDiscount";
            lblTotalWDiscount.Size = new Size(95, 21);
            lblTotalWDiscount.TabIndex = 9;
            lblTotalWDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // discountLABELONLY
            // 
            discountLABELONLY.AutoSize = true;
            discountLABELONLY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            discountLABELONLY.Location = new Point(15, 33);
            discountLABELONLY.Name = "discountLABELONLY";
            discountLABELONLY.Size = new Size(128, 21);
            discountLABELONLY.TabIndex = 4;
            discountLABELONLY.Text = "Discount Applied";
            // 
            // totalNoDiscLABELONLY
            // 
            totalNoDiscLABELONLY.AutoSize = true;
            totalNoDiscLABELONLY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalNoDiscLABELONLY.Location = new Point(15, 5);
            totalNoDiscLABELONLY.Name = "totalNoDiscLABELONLY";
            totalNoDiscLABELONLY.Size = new Size(42, 21);
            totalNoDiscLABELONLY.TabIndex = 3;
            totalNoDiscLABELONLY.Text = "Total";
            // 
            // totalWDiscountLABELONLY
            // 
            totalWDiscountLABELONLY.AutoSize = true;
            totalWDiscountLABELONLY.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalWDiscountLABELONLY.ForeColor = Color.Green;
            totalWDiscountLABELONLY.Location = new Point(15, 77);
            totalWDiscountLABELONLY.Name = "totalWDiscountLABELONLY";
            totalWDiscountLABELONLY.Size = new Size(52, 25);
            totalWDiscountLABELONLY.TabIndex = 5;
            totalWDiscountLABELONLY.Text = "Total";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(108, 124, 103);
            panel4.Controls.Add(btnPlaceOrder);
            panel4.Location = new Point(9, 497);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 60);
            panel4.TabIndex = 6;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.White;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Pink Chicken", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlaceOrder.ForeColor = Color.Black;
            btnPlaceOrder.Location = new Point(53, 7);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(212, 45);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
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
            panel2.Location = new Point(0, -2);
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
            orderPanelTitle.BackColor = Color.FromArgb(108, 124, 103);
            orderPanelTitle.Controls.Add(label3);
            orderPanelTitle.Location = new Point(15, 12);
            orderPanelTitle.Name = "orderPanelTitle";
            orderPanelTitle.Size = new Size(302, 61);
            orderPanelTitle.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(58, 10);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 14;
            label3.Text = "Current Order";
            // 
            // receiptParentPanel
            // 
            receiptParentPanel.BackColor = Color.FromArgb(255, 250, 245);
            receiptParentPanel.Controls.Add(panel5);
            receiptParentPanel.Controls.Add(txtBxReceipt);
            receiptParentPanel.Controls.Add(receiptPanelTitle);
            receiptParentPanel.Location = new Point(889, 30);
            receiptParentPanel.Name = "receiptParentPanel";
            receiptParentPanel.Size = new Size(332, 566);
            receiptParentPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Controls.Add(menuStrip1);
            panel5.Location = new Point(14, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(307, 34);
            panel5.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(108, 124, 103);
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(307, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem, placeOrderToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
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
            placeOrderToolStripMenuItem.Click += placeOrderToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(68, 25);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // txtBxReceipt
            // 
            txtBxReceipt.BackColor = Color.White;
            txtBxReceipt.BorderStyle = BorderStyle.None;
            txtBxReceipt.Location = new Point(14, 113);
            txtBxReceipt.Name = "txtBxReceipt";
            txtBxReceipt.ReadOnly = true;
            txtBxReceipt.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBxReceipt.Size = new Size(306, 438);
            txtBxReceipt.TabIndex = 2;
            txtBxReceipt.Text = "";
            // 
            // receiptPanelTitle
            // 
            receiptPanelTitle.BackColor = Color.FromArgb(221, 214, 203);
            receiptPanelTitle.Controls.Add(label4);
            receiptPanelTitle.Location = new Point(14, 12);
            receiptPanelTitle.Name = "receiptPanelTitle";
            receiptPanelTitle.Size = new Size(307, 61);
            receiptPanelTitle.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(101, 10);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 15;
            label4.Text = "Receipt";
            // 
            // foodParentPanel
            // 
            foodParentPanel.BackColor = Color.FromArgb(255, 250, 245);
            foodParentPanel.Controls.Add(foodFlowLayoutPanel);
            foodParentPanel.Controls.Add(lblCategory);
            foodParentPanel.Controls.Add(foodDetailPanel);
            foodParentPanel.Location = new Point(27, 30);
            foodParentPanel.Name = "foodParentPanel";
            foodParentPanel.Size = new Size(520, 566);
            foodParentPanel.TabIndex = 0;
            // 
            // foodFlowLayoutPanel
            // 
            foodFlowLayoutPanel.AutoScroll = true;
            foodFlowLayoutPanel.BackColor = Color.FromArgb(255, 250, 245);
            foodFlowLayoutPanel.Location = new Point(13, 237);
            foodFlowLayoutPanel.Name = "foodFlowLayoutPanel";
            foodFlowLayoutPanel.Padding = new Padding(10, 10, 0, 0);
            foodFlowLayoutPanel.Size = new Size(494, 314);
            foodFlowLayoutPanel.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.FromArgb(255, 250, 245);
            lblCategory.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(13, 189);
            lblCategory.Name = "lblCategory";
            lblCategory.Padding = new Padding(0, 0, 0, 3);
            lblCategory.Size = new Size(118, 35);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Main Dish";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodDetailPanel
            // 
            foodDetailPanel.BackColor = Color.FromArgb(108, 124, 103);
            foodDetailPanel.Controls.Add(mealDetailButton);
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
            foodDetailPanel.ForeColor = Color.White;
            foodDetailPanel.Location = new Point(13, 12);
            foodDetailPanel.Name = "foodDetailPanel";
            foodDetailPanel.Size = new Size(494, 161);
            foodDetailPanel.TabIndex = 1;
            // 
            // mealDetailButton
            // 
            mealDetailButton.FlatAppearance.BorderSize = 0;
            mealDetailButton.FlatStyle = FlatStyle.Flat;
            mealDetailButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            mealDetailButton.IconColor = Color.White;
            mealDetailButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mealDetailButton.IconSize = 36;
            mealDetailButton.Location = new Point(12, 15);
            mealDetailButton.Name = "mealDetailButton";
            mealDetailButton.Size = new Size(28, 34);
            mealDetailButton.TabIndex = 14;
            mealDetailButton.UseVisualStyleBackColor = true;
            mealDetailButton.Click += mealDetailButton_Click;
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
            btnClear.BackColor = Color.Firebrick;
            btnClear.FlatAppearance.BorderSize = 0;
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
            lblTotal.Location = new Point(253, 114);
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
            addButton.BackColor = Color.FromArgb(108, 124, 103);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.Black;
            addButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addButton.IconColor = Color.White;
            addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addButton.IconSize = 27;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(441, 106);
            addButton.Name = "addButton";
            addButton.Size = new Size(37, 34);
            addButton.TabIndex = 3;
            addButton.TextAlign = ContentAlignment.MiddleLeft;
            addButton.UseVisualStyleBackColor = false;
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
            mealPictureDetail.BackColor = Color.Transparent;
            mealPictureDetail.Image = (Image)resources.GetObject("mealPictureDetail.Image");
            mealPictureDetail.Location = new Point(12, 14);
            mealPictureDetail.Name = "mealPictureDetail";
            mealPictureDetail.Size = new Size(135, 127);
            mealPictureDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            mealPictureDetail.TabIndex = 0;
            mealPictureDetail.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(108, 124, 103);
            panel6.Location = new Point(765, -4);
            panel6.Name = "panel6";
            panel6.Size = new Size(483, 640);
            panel6.TabIndex = 3;
            // 
            // btnFood
            // 
            btnFood.BackColor = Color.FromArgb(108, 124, 103);
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Image = (Image)resources.GetObject("btnFood.Image");
            btnFood.Location = new Point(4, 263);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(81, 90);
            btnFood.TabIndex = 2;
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += btnFood_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(108, 124, 103);
            btnDrinks.FlatAppearance.BorderSize = 0;
            btnDrinks.FlatStyle = FlatStyle.Flat;
            btnDrinks.Image = (Image)resources.GetObject("btnDrinks.Image");
            btnDrinks.Location = new Point(4, 359);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(81, 90);
            btnDrinks.TabIndex = 3;
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // lblDinerName
            // 
            lblDinerName.AutoSize = true;
            lblDinerName.BackColor = Color.Transparent;
            lblDinerName.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblDinerName.ForeColor = Color.Black;
            lblDinerName.Location = new Point(110, 29);
            lblDinerName.Name = "lblDinerName";
            lblDinerName.Size = new Size(239, 37);
            lblDinerName.TabIndex = 1;
            lblDinerName.Text = "Diner by the Valley";
            // 
            // printReceipt
            // 
            printReceipt.UseEXDialog = true;
            // 
            // printPreviewDialogReceipt
            // 
            printPreviewDialogReceipt.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogReceipt.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogReceipt.ClientSize = new Size(400, 300);
            printPreviewDialogReceipt.Enabled = true;
            printPreviewDialogReceipt.Icon = (Icon)resources.GetObject("printPreviewDialogReceipt.Icon");
            printPreviewDialogReceipt.Name = "printPreviewDialogReceipt";
            printPreviewDialogReceipt.Visible = false;
            // 
            // printDocumentReceipt
            // 
            printDocumentReceipt.PrintPage += printDocumentReceipt_PrintPage;
            // 
            // btnExits
            // 
            btnExits.BackColor = Color.FromArgb(108, 124, 103);
            btnExits.FlatAppearance.BorderSize = 0;
            btnExits.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnExits.IconColor = Color.White;
            btnExits.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExits.Location = new Point(1197, 12);
            btnExits.Name = "btnExits";
            btnExits.Size = new Size(67, 54);
            btnExits.TabIndex = 5;
            btnExits.UseVisualStyleBackColor = false;
            btnExits.Click += btnExit_Click;
            // 
            // settingsIcon
            // 
            settingsIcon.BackColor = Color.FromArgb(108, 124, 103);
            settingsIcon.IconChar = FontAwesome.Sharp.IconChar.Gear;
            settingsIcon.IconColor = Color.White;
            settingsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsIcon.Location = new Point(1280, 12);
            settingsIcon.Name = "settingsIcon";
            settingsIcon.Size = new Size(66, 54);
            settingsIcon.TabIndex = 7;
            settingsIcon.UseVisualStyleBackColor = false;
            settingsIcon.Click += settingsIcon_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(108, 124, 103);
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(-6, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(98, 745);
            panel7.TabIndex = 8;
            panel7.Paint += panel7_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 124, 103);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 740);
            Controls.Add(settingsIcon);
            Controls.Add(btnExits);
            Controls.Add(btnFood);
            Controls.Add(lblDinerName);
            Controls.Add(btnDrinks);
            Controls.Add(parentPanel);
            Controls.Add(panel7);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner of the Valley";
            parentPanel.ResumeLayout(false);
            orderParentPanel.ResumeLayout(false);
            currentOrderTotalPanel.ResumeLayout(false);
            currentOrderTotalPanel.PerformLayout();
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
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblCategory;
        private FlowLayoutPanel foodFlowLayoutPanel;
        private Panel foodDetailPanel;
        private Label lblTotal;
        private Label lblQuantity;
        private FontAwesome.Sharp.IconButton addButton;
        private Label lblMealPrice;
        private Label lblMealName;
        private PictureBox mealPictureDetail;
        private RichTextBox txtBxReceipt;
        private Label lblDinerName;
        private Button btnClear;
        private TableLayoutPanel orderedMealsRecordTablePanel;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button btnPlaceOrder;
        private Panel panel5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label LBLTTL;
        private Label LBLQTY;
        private Label LBLPRICE;
        private Label LBLNAME;
        private Label label3;
        private Label label4;
        private PrintDialog printReceipt;
        private Button btnFood;
        private Button btnDrinks;
        private PrintPreviewDialog printPreviewDialogReceipt;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
        private FontAwesome.Sharp.IconButton btnExits;
        private Panel currentOrderTotalPanel;
        private Label lblTotalNoDiscount;
        private Label lblDiscountApplied;
        private Label lblTotalWDiscount;
        private Label discountLABELONLY;
        private Label totalNoDiscLABELONLY;
        private Label totalWDiscountLABELONLY;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton mealDetailButton;
        private FontAwesome.Sharp.IconButton settingsIcon;
        private Panel panel7;
        private PictureBox pictureBox1;
    }
}