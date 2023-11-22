namespace DinerGUIApplication
{
    partial class startScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startScreen));
            slideShowContainer = new PictureBox();
            startButton = new Button();
            timeInterval = new System.Windows.Forms.Timer(components);
            timeLabel = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)slideShowContainer).BeginInit();
            SuspendLayout();
            // 
            // slideShowContainer
            // 
            slideShowContainer.Image = (Image)resources.GetObject("slideShowContainer.Image");
            slideShowContainer.Location = new Point(-2, -1);
            slideShowContainer.Name = "slideShowContainer";
            slideShowContainer.Size = new Size(1163, 563);
            slideShowContainer.SizeMode = PictureBoxSizeMode.StretchImage;
            slideShowContainer.TabIndex = 0;
            slideShowContainer.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(108, 124, 103);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Pink Chicken", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.ForeColor = SystemColors.ControlLightLight;
            startButton.Location = new Point(-2, 558);
            startButton.Name = "startButton";
            startButton.Size = new Size(1163, 95);
            startButton.TabIndex = 1;
            startButton.Text = "Click here to start!";
            startButton.UseCompatibleTextRendering = true;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timeInterval
            // 
            timeInterval.Enabled = true;
            timeInterval.Tick += timeIntervalTick;
            // 
            // timeLabel
            // 
            timeLabel.Enabled = true;
            timeLabel.Interval = 800;
            timeLabel.Tick += timeLabel_Tick;
            // 
            // startScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 651);
            Controls.Add(startButton);
            Controls.Add(slideShowContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "startScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diner by the Valley";
            ((System.ComponentModel.ISupportInitialize)slideShowContainer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox slideShowContainer;
        private Button startButton;
        private System.Windows.Forms.Timer timeInterval;
        private System.Windows.Forms.Timer timeLabel;
    }
}