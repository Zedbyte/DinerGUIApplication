namespace DinerGUIApplication
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            rdButtonMasterCard = new RadioButton();
            rdButtonVisa = new RadioButton();
            rdButtonMore = new RadioButton();
            txtBoxCName = new TextBox();
            txtBoxCNum = new TextBox();
            txtBoxMonth = new TextBox();
            txtBoxYr = new TextBox();
            txtBoxCode1 = new TextBox();
            txtBoxCode2 = new TextBox();
            txtBoxCode3 = new TextBox();
            btnReturn = new Button();
            btnCompleteOrder = new Button();
            pBoxMastercard = new PictureBox();
            pBoxVisa = new PictureBox();
            pBoxMore = new PictureBox();
            LBLCARDHOLDERNAME = new Label();
            LBLCARDNUM = new Label();
            LBLEXPIRATION = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxMastercard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxVisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMore).BeginInit();
            SuspendLayout();
            // 
            // rdButtonMasterCard
            // 
            rdButtonMasterCard.AutoSize = true;
            rdButtonMasterCard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonMasterCard.Location = new Point(65, 110);
            rdButtonMasterCard.Name = "rdButtonMasterCard";
            rdButtonMasterCard.Size = new Size(150, 36);
            rdButtonMasterCard.TabIndex = 0;
            rdButtonMasterCard.TabStop = true;
            rdButtonMasterCard.Text = "Mastercard";
            rdButtonMasterCard.UseVisualStyleBackColor = true;
            // 
            // rdButtonVisa
            // 
            rdButtonVisa.AutoSize = true;
            rdButtonVisa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonVisa.Location = new Point(336, 110);
            rdButtonVisa.Name = "rdButtonVisa";
            rdButtonVisa.Size = new Size(75, 36);
            rdButtonVisa.TabIndex = 1;
            rdButtonVisa.TabStop = true;
            rdButtonVisa.Text = "Visa";
            rdButtonVisa.UseVisualStyleBackColor = true;
            // 
            // rdButtonMore
            // 
            rdButtonMore.AutoSize = true;
            rdButtonMore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rdButtonMore.Location = new Point(578, 110);
            rdButtonMore.Name = "rdButtonMore";
            rdButtonMore.Size = new Size(89, 36);
            rdButtonMore.TabIndex = 2;
            rdButtonMore.TabStop = true;
            rdButtonMore.Text = "More";
            rdButtonMore.UseVisualStyleBackColor = true;
            // 
            // txtBoxCName
            // 
            txtBoxCName.Location = new Point(122, 357);
            txtBoxCName.Name = "txtBoxCName";
            txtBoxCName.Size = new Size(354, 23);
            txtBoxCName.TabIndex = 3;
            // 
            // txtBoxCNum
            // 
            txtBoxCNum.Location = new Point(122, 412);
            txtBoxCNum.Name = "txtBoxCNum";
            txtBoxCNum.Size = new Size(354, 23);
            txtBoxCNum.TabIndex = 4;
            // 
            // txtBoxMonth
            // 
            txtBoxMonth.Location = new Point(502, 357);
            txtBoxMonth.Name = "txtBoxMonth";
            txtBoxMonth.PlaceholderText = "MM";
            txtBoxMonth.Size = new Size(42, 23);
            txtBoxMonth.TabIndex = 5;
            txtBoxMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxYr
            // 
            txtBoxYr.Location = new Point(550, 357);
            txtBoxYr.Name = "txtBoxYr";
            txtBoxYr.PlaceholderText = "YYYY";
            txtBoxYr.Size = new Size(60, 23);
            txtBoxYr.TabIndex = 6;
            txtBoxYr.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxCode1
            // 
            txtBoxCode1.Location = new Point(502, 412);
            txtBoxCode1.Name = "txtBoxCode1";
            txtBoxCode1.PlaceholderText = "0";
            txtBoxCode1.Size = new Size(32, 23);
            txtBoxCode1.TabIndex = 7;
            txtBoxCode1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxCode2
            // 
            txtBoxCode2.Location = new Point(540, 412);
            txtBoxCode2.Name = "txtBoxCode2";
            txtBoxCode2.PlaceholderText = "0";
            txtBoxCode2.Size = new Size(32, 23);
            txtBoxCode2.TabIndex = 8;
            txtBoxCode2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxCode3
            // 
            txtBoxCode3.Location = new Point(578, 412);
            txtBoxCode3.Name = "txtBoxCode3";
            txtBoxCode3.PlaceholderText = "0";
            txtBoxCode3.Size = new Size(32, 23);
            txtBoxCode3.TabIndex = 9;
            txtBoxCode3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(154, 464);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(177, 51);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return Button";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.Location = new Point(371, 464);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(188, 51);
            btnCompleteOrder.TabIndex = 11;
            btnCompleteOrder.Text = "Complete Order";
            btnCompleteOrder.UseVisualStyleBackColor = true;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // pBoxMastercard
            // 
            pBoxMastercard.BackColor = Color.White;
            pBoxMastercard.Image = (Image)resources.GetObject("pBoxMastercard.Image");
            pBoxMastercard.Location = new Point(65, 152);
            pBoxMastercard.Name = "pBoxMastercard";
            pBoxMastercard.Size = new Size(150, 130);
            pBoxMastercard.SizeMode = PictureBoxSizeMode.CenterImage;
            pBoxMastercard.TabIndex = 12;
            pBoxMastercard.TabStop = false;
            // 
            // pBoxVisa
            // 
            pBoxVisa.BackColor = Color.White;
            pBoxVisa.Image = (Image)resources.GetObject("pBoxVisa.Image");
            pBoxVisa.Location = new Point(301, 152);
            pBoxVisa.Name = "pBoxVisa";
            pBoxVisa.Size = new Size(150, 130);
            pBoxVisa.SizeMode = PictureBoxSizeMode.CenterImage;
            pBoxVisa.TabIndex = 13;
            pBoxVisa.TabStop = false;
            // 
            // pBoxMore
            // 
            pBoxMore.Location = new Point(540, 152);
            pBoxMore.Name = "pBoxMore";
            pBoxMore.Size = new Size(150, 130);
            pBoxMore.TabIndex = 14;
            pBoxMore.TabStop = false;
            // 
            // LBLCARDHOLDERNAME
            // 
            LBLCARDHOLDERNAME.AutoSize = true;
            LBLCARDHOLDERNAME.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LBLCARDHOLDERNAME.ForeColor = Color.DimGray;
            LBLCARDHOLDERNAME.Location = new Point(122, 333);
            LBLCARDHOLDERNAME.Name = "LBLCARDHOLDERNAME";
            LBLCARDHOLDERNAME.Size = new Size(136, 21);
            LBLCARDHOLDERNAME.TabIndex = 15;
            LBLCARDHOLDERNAME.Text = "Cardholder Name";
            // 
            // LBLCARDNUM
            // 
            LBLCARDNUM.AutoSize = true;
            LBLCARDNUM.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LBLCARDNUM.ForeColor = Color.DimGray;
            LBLCARDNUM.Location = new Point(122, 388);
            LBLCARDNUM.Name = "LBLCARDNUM";
            LBLCARDNUM.Size = new Size(106, 21);
            LBLCARDNUM.TabIndex = 16;
            LBLCARDNUM.Text = "Card Number";
            // 
            // LBLEXPIRATION
            // 
            LBLEXPIRATION.AutoSize = true;
            LBLEXPIRATION.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LBLEXPIRATION.ForeColor = Color.DimGray;
            LBLEXPIRATION.Location = new Point(498, 333);
            LBLEXPIRATION.Name = "LBLEXPIRATION";
            LBLEXPIRATION.Size = new Size(117, 21);
            LBLEXPIRATION.TabIndex = 17;
            LBLEXPIRATION.Text = "Expiration Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(517, 388);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 18;
            label1.Text = "CVC Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(222, 52);
            label2.Name = "label2";
            label2.Size = new Size(312, 32);
            label2.TabIndex = 19;
            label2.Text = "Choose a payment method";
            // 
            // paymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 562);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBLEXPIRATION);
            Controls.Add(LBLCARDNUM);
            Controls.Add(LBLCARDHOLDERNAME);
            Controls.Add(pBoxMore);
            Controls.Add(pBoxVisa);
            Controls.Add(pBoxMastercard);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnReturn);
            Controls.Add(txtBoxCode3);
            Controls.Add(txtBoxCode2);
            Controls.Add(txtBoxCode1);
            Controls.Add(txtBoxYr);
            Controls.Add(txtBoxMonth);
            Controls.Add(txtBoxCNum);
            Controls.Add(txtBoxCName);
            Controls.Add(rdButtonMore);
            Controls.Add(rdButtonVisa);
            Controls.Add(rdButtonMasterCard);
            Name = "paymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "paymentForm";
            ((System.ComponentModel.ISupportInitialize)pBoxMastercard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxVisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxMore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdButtonMasterCard;
        private RadioButton rdButtonVisa;
        private RadioButton rdButtonMore;
        private TextBox txtBoxCName;
        private TextBox txtBoxCNum;
        private TextBox txtBoxMonth;
        private TextBox txtBoxYr;
        private TextBox txtBoxCode1;
        private TextBox txtBoxCode2;
        private TextBox txtBoxCode3;
        private Button btnReturn;
        private Button btnCompleteOrder;
        private PictureBox pBoxMastercard;
        private PictureBox pBoxVisa;
        private PictureBox pBoxMore;
        private Label LBLCARDHOLDERNAME;
        private Label LBLCARDNUM;
        private Label LBLEXPIRATION;
        private Label label1;
        private Label label2;
    }
}