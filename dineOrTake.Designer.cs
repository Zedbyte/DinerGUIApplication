namespace DinerGUIApplication
{
    partial class dineOrTake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dineOrTake));
            btnDineIn = new Button();
            btnTakeOut = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDineIn
            // 
            btnDineIn.BackColor = Color.FromArgb(108, 124, 103);
            btnDineIn.Font = new Font("Pink Chicken", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            btnDineIn.ForeColor = Color.White;
            btnDineIn.Location = new Point(110, 136);
            btnDineIn.Name = "btnDineIn";
            btnDineIn.Size = new Size(208, 205);
            btnDineIn.TabIndex = 0;
            btnDineIn.Text = "Dine in";
            btnDineIn.UseVisualStyleBackColor = false;
            btnDineIn.Click += btnDineIn_Click;
            // 
            // btnTakeOut
            // 
            btnTakeOut.BackColor = Color.FromArgb(108, 124, 103);
            btnTakeOut.Font = new Font("Pink Chicken", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            btnTakeOut.ForeColor = Color.White;
            btnTakeOut.Location = new Point(436, 136);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(205, 205);
            btnTakeOut.TabIndex = 1;
            btnTakeOut.Text = "Take Out";
            btnTakeOut.UseVisualStyleBackColor = false;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Pink Chicken", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(236, 77);
            label1.Name = "label1";
            label1.Size = new Size(286, 44);
            label1.TabIndex = 2;
            label1.Text = "Diner by the Valley";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pink Chicken", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(297, 364);
            label2.Name = "label2";
            label2.Size = new Size(147, 44);
            label2.TabIndex = 3;
            label2.Text = "Welcome!";
            // 
            // dineOrTake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 548);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineIn);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "dineOrTake";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner by the Valley";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDineIn;
        private Button btnTakeOut;
        private Label label1;
        private Label label2;
    }
}