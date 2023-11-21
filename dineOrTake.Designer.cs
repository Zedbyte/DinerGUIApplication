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
            SuspendLayout();
            // 
            // btnDineIn
            // 
            btnDineIn.BackColor = Color.FromArgb(108, 124, 103);
            btnDineIn.Font = new Font("Pink Chicken", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            btnDineIn.ForeColor = Color.White;
            btnDineIn.Location = new Point(118, 113);
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
            btnTakeOut.Location = new Point(442, 113);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(205, 205);
            btnTakeOut.TabIndex = 1;
            btnTakeOut.Text = "Take Out";
            btnTakeOut.UseVisualStyleBackColor = false;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // dineOrTake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 548);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineIn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "dineOrTake";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dineOrTake";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDineIn;
        private Button btnTakeOut;
    }
}