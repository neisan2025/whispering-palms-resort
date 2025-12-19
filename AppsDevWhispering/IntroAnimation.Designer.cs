namespace AppsDevWhispering
{
    partial class IntroAnimation
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
            this.animationPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animationPic)).BeginInit();
            this.SuspendLayout();
            // 
            // animationPic
            // 
            this.animationPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationPic.Image = global::AppsDevWhispering.Properties.Resources.WhisperingLogoAnimation;
            this.animationPic.Location = new System.Drawing.Point(0, 0);
            this.animationPic.Name = "animationPic";
            this.animationPic.Size = new System.Drawing.Size(1213, 701);
            this.animationPic.TabIndex = 0;
            this.animationPic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntroAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 701);
            this.Controls.Add(this.animationPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IntroAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroAnimation";
            ((System.ComponentModel.ISupportInitialize)(this.animationPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox animationPic;
        private System.Windows.Forms.Timer timer1;
    }
}