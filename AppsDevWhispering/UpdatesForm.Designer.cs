namespace AppsDevWhispering
{
    partial class UpdatesForm
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
            this.FinalRoomsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.whisperingLogoPanel = new System.Windows.Forms.PictureBox();
            this.FinalRoomsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whisperingLogoPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalRoomsFlowLayout
            // 
            this.FinalRoomsFlowLayout.AutoScroll = true;
            this.FinalRoomsFlowLayout.Controls.Add(this.whisperingLogoPanel);
            this.FinalRoomsFlowLayout.Location = new System.Drawing.Point(46, 18);
            this.FinalRoomsFlowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinalRoomsFlowLayout.Name = "FinalRoomsFlowLayout";
            this.FinalRoomsFlowLayout.Size = new System.Drawing.Size(1428, 934);
            this.FinalRoomsFlowLayout.TabIndex = 0;
            // 
            // whisperingLogoPanel
            // 
            this.whisperingLogoPanel.Image = global::AppsDevWhispering.Properties.Resources.LogoUpdatesPanel2;
            this.whisperingLogoPanel.Location = new System.Drawing.Point(4, 3);
            this.whisperingLogoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.whisperingLogoPanel.Name = "whisperingLogoPanel";
            this.whisperingLogoPanel.Size = new System.Drawing.Size(352, 80);
            this.whisperingLogoPanel.TabIndex = 47;
            this.whisperingLogoPanel.TabStop = false;
            this.whisperingLogoPanel.Visible = false;
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 971);
            this.Controls.Add(this.FinalRoomsFlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(190, 103);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdatesForm";
            this.Text = "UpdatesForm";
            this.FinalRoomsFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.whisperingLogoPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FinalRoomsFlowLayout;
        private System.Windows.Forms.PictureBox whisperingLogoPanel;
    }
}