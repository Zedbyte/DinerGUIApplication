namespace DinerGUIApplication
{
    partial class splashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            splashScreenPictureBox = new PictureBox();
            splashScreenProgBar = new ProgressBar();
            lblNum = new Label();
            lblLoading = new Label();
            timerProgress = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splashScreenPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splashScreenPictureBox
            // 
            splashScreenPictureBox.ErrorImage = null;
            splashScreenPictureBox.Image = (Image)resources.GetObject("splashScreenPictureBox.Image");
            splashScreenPictureBox.Location = new Point(0, 0);
            splashScreenPictureBox.Name = "splashScreenPictureBox";
            splashScreenPictureBox.Size = new Size(1174, 690);
            splashScreenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            splashScreenPictureBox.TabIndex = 0;
            splashScreenPictureBox.TabStop = false;
            splashScreenPictureBox.Click += splashScreenPictureBox_Click;
            // 
            // splashScreenProgBar
            // 
            splashScreenProgBar.Location = new Point(0, 663);
            splashScreenProgBar.Name = "splashScreenProgBar";
            splashScreenProgBar.Size = new Size(1174, 27);
            splashScreenProgBar.Style = ProgressBarStyle.Continuous;
            splashScreenProgBar.TabIndex = 1;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.BackColor = Color.FromArgb(239, 187, 75);
            lblNum.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.ForeColor = Color.Black;
            lblNum.Location = new Point(1105, 625);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(53, 25);
            lblNum.TabIndex = 5;
            lblNum.Text = "label1";
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = Color.FromArgb(239, 187, 75);
            lblLoading.Font = new Font("Pink Chicken", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.ForeColor = Color.Black;
            lblLoading.Location = new Point(12, 625);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(53, 25);
            lblLoading.TabIndex = 4;
            lblLoading.Text = "label1";
            // 
            // timerProgress
            // 
            timerProgress.Enabled = true;
            timerProgress.Tick += timerTick;
            // 
            // splashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 690);
            Controls.Add(lblNum);
            Controls.Add(lblLoading);
            Controls.Add(splashScreenProgBar);
            Controls.Add(splashScreenPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner by the Valley";
            ((System.ComponentModel.ISupportInitialize)splashScreenPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox splashScreenPictureBox;
        private ProgressBar splashScreenProgBar;
        private Label lblNum;
        private Label lblLoading;
        private System.Windows.Forms.Timer timerProgress;
    }
}