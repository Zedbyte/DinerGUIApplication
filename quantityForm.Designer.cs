namespace DinerGUIApplication
{
    partial class quantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quantityForm));
            btnClose = new FontAwesome.Sharp.IconButton();
            btnDone = new FontAwesome.Sharp.IconButton();
            lblSpecialReq = new Label();
            lblQuantity = new Label();
            txtBxSpecialReq = new TextBox();
            quantityUpDown = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 35;
            btnClose.Location = new Point(59, 323);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 12;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.Green;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnDone.IconColor = Color.White;
            btnDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDone.IconSize = 40;
            btnDone.Location = new Point(178, 323);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(100, 40);
            btnDone.TabIndex = 11;
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // lblSpecialReq
            // 
            lblSpecialReq.BackColor = Color.Gray;
            lblSpecialReq.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblSpecialReq.ForeColor = SystemColors.ControlLightLight;
            lblSpecialReq.Location = new Point(59, 154);
            lblSpecialReq.Margin = new Padding(3, 0, 0, 0);
            lblSpecialReq.Name = "lblSpecialReq";
            lblSpecialReq.Size = new Size(219, 25);
            lblSpecialReq.TabIndex = 10;
            lblSpecialReq.Text = "Special Requests";
            lblSpecialReq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.Gray;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblQuantity.ForeColor = SystemColors.ControlLightLight;
            lblQuantity.Location = new Point(59, 56);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(219, 25);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBxSpecialReq
            // 
            txtBxSpecialReq.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxSpecialReq.Location = new Point(59, 182);
            txtBxSpecialReq.Multiline = true;
            txtBxSpecialReq.Name = "txtBxSpecialReq";
            txtBxSpecialReq.Size = new Size(219, 135);
            txtBxSpecialReq.TabIndex = 8;
            // 
            // quantityUpDown
            // 
            quantityUpDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quantityUpDown.Location = new Point(59, 95);
            quantityUpDown.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(219, 35);
            quantityUpDown.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // quantityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 404);
            Controls.Add(btnClose);
            Controls.Add(btnDone);
            Controls.Add(lblSpecialReq);
            Controls.Add(lblQuantity);
            Controls.Add(txtBxSpecialReq);
            Controls.Add(quantityUpDown);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "quantityForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "quantityForm";
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnDone;
        private Label lblSpecialReq;
        private Label lblQuantity;
        private TextBox txtBxSpecialReq;
        private NumericUpDown quantityUpDown;
        private PictureBox pictureBox1;
    }
}