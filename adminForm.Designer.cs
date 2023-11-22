namespace DinerGUIApplication
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            imageFilePathBox = new RichTextBox();
            mealNameBox = new RichTextBox();
            mealPriceBox = new RichTextBox();
            btnDone = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            indexBox = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            mealDetailsBox = new RichTextBox();
            btnClose = new Button();
            categoryBox = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)indexBox).BeginInit();
            SuspendLayout();
            // 
            // imageFilePathBox
            // 
            imageFilePathBox.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            imageFilePathBox.Location = new Point(117, 98);
            imageFilePathBox.Name = "imageFilePathBox";
            imageFilePathBox.Size = new Size(408, 33);
            imageFilePathBox.TabIndex = 1;
            imageFilePathBox.Text = "";
            // 
            // mealNameBox
            // 
            mealNameBox.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            mealNameBox.Location = new Point(44, 211);
            mealNameBox.Name = "mealNameBox";
            mealNameBox.Size = new Size(224, 38);
            mealNameBox.TabIndex = 2;
            mealNameBox.Text = "";
            // 
            // mealPriceBox
            // 
            mealPriceBox.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            mealPriceBox.Location = new Point(301, 211);
            mealPriceBox.Name = "mealPriceBox";
            mealPriceBox.Size = new Size(224, 38);
            mealPriceBox.TabIndex = 3;
            mealPriceBox.Text = "";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(108, 124, 103);
            btnDone.Font = new Font("Pink Chicken", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(301, 452);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 43);
            btnDone.TabIndex = 4;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 5;
            label1.Text = "Index";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 69);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 6;
            label2.Text = "Image File Path";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 180);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 7;
            label3.Text = "Meal Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(301, 180);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 8;
            label4.Text = "Meal Price";
            // 
            // indexBox
            // 
            indexBox.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            indexBox.Location = new Point(49, 98);
            indexBox.Name = "indexBox";
            indexBox.Size = new Size(49, 33);
            indexBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 19);
            label5.Name = "label5";
            label5.Size = new Size(129, 29);
            label5.TabIndex = 10;
            label5.Text = "Add an Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(236, 273);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 11;
            label6.Text = "Meal Details";
            // 
            // mealDetailsBox
            // 
            mealDetailsBox.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            mealDetailsBox.Location = new Point(42, 314);
            mealDetailsBox.Name = "mealDetailsBox";
            mealDetailsBox.Size = new Size(483, 102);
            mealDetailsBox.TabIndex = 12;
            mealDetailsBox.Text = "";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.Font = new Font("Pink Chicken", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(173, 452);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 43);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // categoryBox
            // 
            categoryBox.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Meals", "Drinks" });
            categoryBox.Location = new Point(404, 19);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(121, 31);
            categoryBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 19);
            label7.Name = "label7";
            label7.Size = new Size(94, 29);
            label7.TabIndex = 15;
            label7.Text = "Category";
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(564, 539);
            Controls.Add(label7);
            Controls.Add(categoryBox);
            Controls.Add(btnClose);
            Controls.Add(mealDetailsBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(indexBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDone);
            Controls.Add(mealPriceBox);
            Controls.Add(mealNameBox);
            Controls.Add(imageFilePathBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)indexBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox imageFilePathBox;
        private RichTextBox mealNameBox;
        private RichTextBox mealPriceBox;
        private Button btnDone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown indexBox;
        private Label label5;
        private Label label6;
        private RichTextBox mealDetailsBox;
        private Button btnClose;
        private ComboBox categoryBox;
        private Label label7;
    }
}