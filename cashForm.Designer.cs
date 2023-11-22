namespace DinerGUIApplication
{
    partial class cashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashForm));
            txtBxReceipt = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            calculatorPanel = new TableLayoutPanel();
            btnClear = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnPrintReceipt = new Button();
            panel2 = new Panel();
            txtBxCalculator = new Label();
            lblTotalToPay = new Label();
            LBLTOPAYLBLONLY = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            panel6 = new Panel();
            receiptStrip = new MenuStrip();
            printToolStripMenuItem = new ToolStripMenuItem();
            panel5 = new Panel();
            label4 = new Label();
            printPreviewReceipt = new PrintPreviewDialog();
            printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            calculatorPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            receiptStrip.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtBxReceipt
            // 
            txtBxReceipt.BackColor = Color.White;
            txtBxReceipt.BorderStyle = BorderStyle.None;
            txtBxReceipt.Location = new Point(381, 122);
            txtBxReceipt.Name = "txtBxReceipt";
            txtBxReceipt.ReadOnly = true;
            txtBxReceipt.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBxReceipt.Size = new Size(305, 419);
            txtBxReceipt.TabIndex = 0;
            txtBxReceipt.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 214, 203);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(381, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 11);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 0;
            label1.Text = "Receipt";
            // 
            // calculatorPanel
            // 
            calculatorPanel.ColumnCount = 3;
            calculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            calculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            calculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            calculatorPanel.Controls.Add(btnClear, 2, 0);
            calculatorPanel.Controls.Add(btnDot, 0, 3);
            calculatorPanel.Controls.Add(btn0, 1, 3);
            calculatorPanel.Controls.Add(btn1, 2, 3);
            calculatorPanel.Controls.Add(btn2, 0, 2);
            calculatorPanel.Controls.Add(btn3, 1, 2);
            calculatorPanel.Controls.Add(btn4, 2, 2);
            calculatorPanel.Controls.Add(btn5, 0, 1);
            calculatorPanel.Controls.Add(btn6, 1, 1);
            calculatorPanel.Controls.Add(btn7, 2, 1);
            calculatorPanel.Controls.Add(btn9, 1, 0);
            calculatorPanel.Controls.Add(btn8, 0, 0);
            calculatorPanel.Location = new Point(35, 143);
            calculatorPanel.Name = "calculatorPanel";
            calculatorPanel.RowCount = 4;
            calculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            calculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            calculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            calculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            calculatorPanel.Size = new Size(239, 230);
            calculatorPanel.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(159, 1);
            btnClear.Margin = new Padding(1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 55);
            btnClear.TabIndex = 12;
            btnClear.Text = "Del";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDot.Location = new Point(1, 172);
            btnDot.Margin = new Padding(1);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 55);
            btnDot.TabIndex = 1;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += button_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(80, 172);
            btn0.Margin = new Padding(1);
            btn0.Name = "btn0";
            btn0.Size = new Size(77, 55);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += button_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(159, 172);
            btn1.Margin = new Padding(1);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 55);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(1, 115);
            btn2.Margin = new Padding(1);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 55);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(80, 115);
            btn3.Margin = new Padding(1);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 55);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(159, 115);
            btn4.Margin = new Padding(1);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 55);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(1, 58);
            btn5.Margin = new Padding(1);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 55);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(80, 58);
            btn6.Margin = new Padding(1);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 55);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += button_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(159, 58);
            btn7.Margin = new Padding(1);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 55);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(80, 1);
            btn9.Margin = new Padding(1);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 55);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += button_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(1, 1);
            btn8.Margin = new Padding(1);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 55);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += button_Click;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.FromArgb(64, 64, 64);
            btnPrintReceipt.Font = new Font("Pink Chicken", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintReceipt.ForeColor = Color.White;
            btnPrintReceipt.Location = new Point(35, 379);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(239, 55);
            btnPrintReceipt.TabIndex = 3;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(txtBxCalculator);
            panel2.Controls.Add(lblTotalToPay);
            panel2.Controls.Add(LBLTOPAYLBLONLY);
            panel2.Controls.Add(btnPrintReceipt);
            panel2.Controls.Add(calculatorPanel);
            panel2.Location = new Point(35, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 451);
            panel2.TabIndex = 4;
            // 
            // txtBxCalculator
            // 
            txtBxCalculator.BackColor = Color.WhiteSmoke;
            txtBxCalculator.Font = new Font("Pink Chicken", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtBxCalculator.Location = new Point(36, 85);
            txtBxCalculator.Name = "txtBxCalculator";
            txtBxCalculator.Size = new Size(235, 44);
            txtBxCalculator.TabIndex = 7;
            txtBxCalculator.Text = "0";
            txtBxCalculator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalToPay
            // 
            lblTotalToPay.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalToPay.Location = new Point(115, 41);
            lblTotalToPay.Name = "lblTotalToPay";
            lblTotalToPay.Size = new Size(159, 25);
            lblTotalToPay.TabIndex = 6;
            lblTotalToPay.Text = "0";
            lblTotalToPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LBLTOPAYLBLONLY
            // 
            LBLTOPAYLBLONLY.AutoSize = true;
            LBLTOPAYLBLONLY.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTOPAYLBLONLY.Location = new Point(35, 41);
            LBLTOPAYLBLONLY.Name = "LBLTOPAYLBLONLY";
            LBLTOPAYLBLONLY.Size = new Size(73, 25);
            LBLTOPAYLBLONLY.TabIndex = 5;
            LBLTOPAYLBLONLY.Text = "To Pay:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(251, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 6;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 41);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 5;
            label3.Text = "To Pay:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 59);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 379);
            button1.Name = "button1";
            button1.Size = new Size(239, 55);
            button1.TabIndex = 3;
            button1.Text = "Print Receipt";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(133, 1);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(66, 55);
            button2.TabIndex = 12;
            button2.Text = "Del";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1, 58);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(64, 55);
            button3.TabIndex = 1;
            button3.Text = ".";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 250, 245);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(368, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 532);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(receiptStrip);
            panel6.Location = new Point(13, 67);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 30);
            panel6.TabIndex = 0;
            // 
            // receiptStrip
            // 
            receiptStrip.BackColor = Color.FromArgb(108, 124, 103);
            receiptStrip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            receiptStrip.Items.AddRange(new ToolStripItem[] { printToolStripMenuItem });
            receiptStrip.Location = new Point(0, 0);
            receiptStrip.Name = "receiptStrip";
            receiptStrip.Size = new Size(305, 27);
            receiptStrip.TabIndex = 0;
            receiptStrip.Text = "menu";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Font = new Font("Pink Chicken", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            printToolStripMenuItem.ForeColor = Color.White;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(54, 23);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(108, 124, 103);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(35, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(309, 58);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pink Chicken", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 10);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 0;
            label4.Text = "Payment";
            // 
            // printPreviewReceipt
            // 
            printPreviewReceipt.AutoScrollMargin = new Size(0, 0);
            printPreviewReceipt.AutoScrollMinSize = new Size(0, 0);
            printPreviewReceipt.ClientSize = new Size(400, 300);
            printPreviewReceipt.Enabled = true;
            printPreviewReceipt.Icon = (Icon)resources.GetObject("printPreviewReceipt.Icon");
            printPreviewReceipt.Name = "printPreviewReceipt";
            printPreviewReceipt.Visible = false;
            printPreviewReceipt.Load += printPreviewReceipt_Load;
            // 
            // printDocumentReceipt
            // 
            printDocumentReceipt.PrintPage += printDocumentReceipt_PrintPage;
            // 
            // cashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(722, 585);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(txtBxReceipt);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "cashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cash";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            calculatorPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            receiptStrip.ResumeLayout(false);
            receiptStrip.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtBxReceipt;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel calculatorPanel;
        private Button btnPrintReceipt;
        private Button btn9;
        private Panel panel2;
        private Label lblTotalToPay;
        private Label LBLTOPAYLBLONLY;
        private Button btnClear;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnDot;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label txtBxCalculator;
        private Panel panel6;
        private MenuStrip receiptStrip;
        private ToolStripMenuItem printToolStripMenuItem;
        private PrintPreviewDialog printPreviewReceipt;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
    }
}