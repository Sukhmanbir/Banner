namespace banner
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenPictureBox
            // 
            this.splashScreenPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("splashScreenPictureBox.ErrorImage")));
            this.splashScreenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("splashScreenPictureBox.Image")));
            this.splashScreenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("splashScreenPictureBox.InitialImage")));
            this.splashScreenPictureBox.Location = new System.Drawing.Point(12, 12);
            this.splashScreenPictureBox.Name = "splashScreenPictureBox";
            this.splashScreenPictureBox.Size = new System.Drawing.Size(497, 280);
            this.splashScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashScreenPictureBox.TabIndex = 0;
            this.splashScreenPictureBox.TabStop = false;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Location = new System.Drawing.Point(135, 322);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(265, 23);
            this.loadingProgressBar.TabIndex = 1;
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 15;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 368);
            this.Controls.Add(this.loadingProgressBar);
            this.Controls.Add(this.splashScreenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashScreenPictureBox;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Timer splashScreenTimer;
    }
}