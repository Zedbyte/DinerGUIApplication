namespace DinerGUIApplication
{
    partial class quantitySelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quantitySelector));
            quantityUpDown = new NumericUpDown();
            txtBxSpecialReq = new TextBox();
            lblQuantity = new Label();
            lblSpecialReq = new Label();
            btnDone = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // quantityUpDown
            // 
            quantityUpDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quantityUpDown.Location = new Point(70, 99);
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(219, 35);
            quantityUpDown.TabIndex = 0;
            // 
            // txtBxSpecialReq
            // 
            txtBxSpecialReq.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxSpecialReq.Location = new Point(70, 186);
            txtBxSpecialReq.Multiline = true;
            txtBxSpecialReq.Name = "txtBxSpecialReq";
            txtBxSpecialReq.Size = new Size(219, 135);
            txtBxSpecialReq.TabIndex = 1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblQuantity.Location = new Point(70, 60);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 25);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblSpecialReq
            // 
            lblSpecialReq.AutoSize = true;
            lblSpecialReq.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblSpecialReq.Location = new Point(70, 158);
            lblSpecialReq.Name = "lblSpecialReq";
            lblSpecialReq.Size = new Size(145, 25);
            lblSpecialReq.TabIndex = 3;
            lblSpecialReq.Text = "Special Requests";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.Green;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnDone.IconColor = Color.White;
            btnDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDone.IconSize = 40;
            btnDone.Location = new Point(189, 327);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(100, 40);
            btnDone.TabIndex = 4;
            btnDone.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 35;
            btnClose.Location = new Point(70, 327);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 412);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // quantitySelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClose);
            Controls.Add(btnDone);
            Controls.Add(lblSpecialReq);
            Controls.Add(lblQuantity);
            Controls.Add(txtBxSpecialReq);
            Controls.Add(quantityUpDown);
            Controls.Add(pictureBox1);
            Name = "quantitySelector";
            Size = new Size(363, 412);
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown quantityUpDown;
        private TextBox txtBxSpecialReq;
        private Label lblQuantity;
        private Label lblSpecialReq;
        private FontAwesome.Sharp.IconButton btnDone;
        private FontAwesome.Sharp.IconButton btnClose;
        private PictureBox pictureBox1;
    }
}
