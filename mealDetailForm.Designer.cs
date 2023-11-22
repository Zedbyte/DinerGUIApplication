namespace DinerGUIApplication
{
    partial class mealDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mealDetailForm));
            mealName = new Label();
            mealDetailBox = new RichTextBox();
            SuspendLayout();
            // 
            // mealName
            // 
            mealName.BackColor = Color.Transparent;
            mealName.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            mealName.Location = new Point(61, 59);
            mealName.Name = "mealName";
            mealName.Size = new Size(298, 60);
            mealName.TabIndex = 0;
            mealName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mealDetailBox
            // 
            mealDetailBox.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mealDetailBox.Location = new Point(61, 133);
            mealDetailBox.Name = "mealDetailBox";
            mealDetailBox.Size = new Size(298, 267);
            mealDetailBox.TabIndex = 1;
            mealDetailBox.Text = "";
            // 
            // mealDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(446, 503);
            Controls.Add(mealDetailBox);
            Controls.Add(mealName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mealDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meal Detail";
            ResumeLayout(false);
        }

        #endregion

        private Label mealName;
        private RichTextBox mealDetailBox;
    }
}