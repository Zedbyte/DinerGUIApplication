namespace DinerGUIApplication
{
    partial class morePaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(morePaymentMethod));
            btnGcash = new Button();
            btnCash = new Button();
            btnCrypto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGcash
            // 
            btnGcash.BackColor = Color.Transparent;
            btnGcash.Image = (Image)resources.GetObject("btnGcash.Image");
            btnGcash.Location = new Point(30, 141);
            btnGcash.Name = "btnGcash";
            btnGcash.Size = new Size(218, 200);
            btnGcash.TabIndex = 0;
            btnGcash.UseVisualStyleBackColor = false;
            btnGcash.Click += btnGcash_Click;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.Transparent;
            btnCash.BackgroundImage = (Image)resources.GetObject("btnCash.BackgroundImage");
            btnCash.Location = new Point(292, 141);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(218, 200);
            btnCash.TabIndex = 1;
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // btnCrypto
            // 
            btnCrypto.BackColor = Color.Transparent;
            btnCrypto.BackgroundImage = (Image)resources.GetObject("btnCrypto.BackgroundImage");
            btnCrypto.Location = new Point(562, 141);
            btnCrypto.Name = "btnCrypto";
            btnCrypto.Size = new Size(218, 200);
            btnCrypto.TabIndex = 2;
            btnCrypto.UseVisualStyleBackColor = false;
            btnCrypto.Click += btnCrypto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(221, 82);
            label1.Name = "label1";
            label1.Size = new Size(369, 32);
            label1.TabIndex = 3;
            label1.Text = "Choose other payment methods";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 350);
            label2.Name = "label2";
            label2.Size = new Size(66, 29);
            label2.TabIndex = 4;
            label2.Text = "Gcash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(366, 350);
            label3.Name = "label3";
            label3.Size = new Size(55, 29);
            label3.TabIndex = 5;
            label3.Text = "Cash";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Pink Chicken", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(597, 349);
            label4.Name = "label4";
            label4.Size = new Size(150, 29);
            label4.TabIndex = 6;
            label4.Text = "Cryptocurrency";
            // 
            // morePaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 551);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrypto);
            Controls.Add(btnCash);
            Controls.Add(btnGcash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "morePaymentMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Other Payment Methods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGcash;
        private Button btnCash;
        private Button btnCrypto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}