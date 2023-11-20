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
            btnDineIn = new Button();
            btnTakeOut = new Button();
            SuspendLayout();
            // 
            // btnDineIn
            // 
            btnDineIn.Location = new Point(112, 113);
            btnDineIn.Name = "btnDineIn";
            btnDineIn.Size = new Size(208, 205);
            btnDineIn.TabIndex = 0;
            btnDineIn.Text = "Dine in";
            btnDineIn.UseVisualStyleBackColor = true;
            btnDineIn.Click += btnDineIn_Click;
            // 
            // btnTakeOut
            // 
            btnTakeOut.Location = new Point(436, 113);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(205, 205);
            btnTakeOut.TabIndex = 1;
            btnTakeOut.Text = "Take Out";
            btnTakeOut.UseVisualStyleBackColor = true;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // dineOrTake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 548);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineIn);
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