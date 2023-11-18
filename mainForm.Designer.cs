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
            orderPanelTitle = new Panel();
            receiptParentPanel = new Panel();
            receiptPanelTitle = new Panel();
            foodParentPanel = new Panel();
            foodFlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            foodDetailPanel = new Panel();
            lblTotal = new Label();
            lblQuantity = new Label();
            addButton = new FontAwesome.Sharp.IconButton();
            lblMealPrice = new Label();
            lblMealName = new Label();
            mealPictureDetail = new PictureBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            parentPanel.SuspendLayout();
            orderParentPanel.SuspendLayout();
            receiptParentPanel.SuspendLayout();
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
            orderParentPanel.BackColor = Color.FromArgb(255, 255, 192);
            orderParentPanel.Controls.Add(orderPanelTitle);
            orderParentPanel.Location = new Point(541, 14);
            orderParentPanel.Name = "orderParentPanel";
            orderParentPanel.Size = new Size(332, 566);
            orderParentPanel.TabIndex = 2;
            // 
            // orderPanelTitle
            // 
            orderPanelTitle.BackColor = Color.FromArgb(253, 151, 103);
            orderPanelTitle.Location = new Point(15, 12);
            orderPanelTitle.Name = "orderPanelTitle";
            orderPanelTitle.Size = new Size(302, 61);
            orderPanelTitle.TabIndex = 0;
            // 
            // receiptParentPanel
            // 
            receiptParentPanel.BackColor = Color.FromArgb(255, 255, 192);
            receiptParentPanel.Controls.Add(richTextBox1);
            receiptParentPanel.Controls.Add(receiptPanelTitle);
            receiptParentPanel.Location = new Point(878, 14);
            receiptParentPanel.Name = "receiptParentPanel";
            receiptParentPanel.Size = new Size(332, 566);
            receiptParentPanel.TabIndex = 1;
            // 
            // receiptPanelTitle
            // 
            receiptPanelTitle.BackColor = Color.FromArgb(253, 151, 103);
            receiptPanelTitle.Location = new Point(14, 12);
            receiptPanelTitle.Name = "receiptPanelTitle";
            receiptPanelTitle.Size = new Size(305, 61);
            receiptPanelTitle.TabIndex = 1;
            // 
            // foodParentPanel
            // 
            foodParentPanel.BackColor = Color.FromArgb(255, 255, 192);
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
            foodFlowLayoutPanel.BackColor = Color.FromArgb(255, 255, 128);
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
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Lime;
            lblTotal.Location = new Point(175, 116);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(175, 83);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 21);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addButton.IconColor = Color.Black;
            addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addButton.IconSize = 30;
            addButton.ImageAlign = ContentAlignment.MiddleRight;
            addButton.Location = new Point(370, 109);
            addButton.Name = "addButton";
            addButton.Size = new Size(108, 32);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // lblMealPrice
            // 
            lblMealPrice.AutoSize = true;
            lblMealPrice.Location = new Point(175, 46);
            lblMealPrice.Name = "lblMealPrice";
            lblMealPrice.Size = new Size(44, 21);
            lblMealPrice.TabIndex = 2;
            lblMealPrice.Text = "Price";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Location = new Point(175, 14);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(52, 21);
            lblMealName.TabIndex = 1;
            lblMealName.Text = "Name";
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
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(14, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(305, 480);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 107, 117);
            ClientSize = new Size(1289, 651);
            Controls.Add(label2);
            Controls.Add(parentPanel);
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner of the Valley";
            parentPanel.ResumeLayout(false);
            orderParentPanel.ResumeLayout(false);
            receiptParentPanel.ResumeLayout(false);
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
        private RichTextBox richTextBox1;
        private Label label2;
    }
}