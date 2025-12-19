namespace AppsDevWhispering
{
    partial class AvailableRooms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeDateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.RoomInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.roomAvailabilityPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.RoomsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.receiptButton);
            this.panel1.Controls.Add(this.changeDateBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 134);
            this.panel1.TabIndex = 0;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.receiptButton.FlatAppearance.BorderSize = 0;
            this.receiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.White;
            this.receiptButton.Location = new System.Drawing.Point(1515, 23);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(238, 83);
            this.receiptButton.TabIndex = 5;
            this.receiptButton.Text = "Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // changeDateBtn
            // 
            this.changeDateBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.changeDateBtn.FlatAppearance.BorderSize = 0;
            this.changeDateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.changeDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDateBtn.ForeColor = System.Drawing.Color.White;
            this.changeDateBtn.Location = new System.Drawing.Point(54, 23);
            this.changeDateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeDateBtn.Name = "changeDateBtn";
            this.changeDateBtn.Size = new System.Drawing.Size(238, 83);
            this.changeDateBtn.TabIndex = 3;
            this.changeDateBtn.Text = "Change Date";
            this.changeDateBtn.UseVisualStyleBackColor = false;
            this.changeDateBtn.Click += new System.EventHandler(this.changeDateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "   If room is unavailable, choose another date.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "If room is unavailable, choose another date.";
            // 
            // RoomsFlowLayout
            // 
            this.RoomsFlowLayout.AutoScroll = true;
            this.RoomsFlowLayout.Controls.Add(this.RoomInfoPictureBox);
            this.RoomsFlowLayout.Controls.Add(this.roomAvailabilityPic);
            this.RoomsFlowLayout.Location = new System.Drawing.Point(54, 145);
            this.RoomsFlowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomsFlowLayout.Name = "RoomsFlowLayout";
            this.RoomsFlowLayout.Size = new System.Drawing.Size(1770, 923);
            this.RoomsFlowLayout.TabIndex = 1;
            // 
            // RoomInfoPictureBox
            // 
            this.RoomInfoPictureBox.Image = global::AppsDevWhispering.Properties.Resources.RoomDetailsPic;
            this.RoomInfoPictureBox.Location = new System.Drawing.Point(6, 6);
            this.RoomInfoPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.RoomInfoPictureBox.Name = "RoomInfoPictureBox";
            this.RoomInfoPictureBox.Size = new System.Drawing.Size(80, 409);
            this.RoomInfoPictureBox.TabIndex = 32;
            this.RoomInfoPictureBox.TabStop = false;
            // 
            // roomAvailabilityPic
            // 
            this.roomAvailabilityPic.Image = global::AppsDevWhispering.Properties.Resources.lastRooms;
            this.roomAvailabilityPic.Location = new System.Drawing.Point(98, 6);
            this.roomAvailabilityPic.Margin = new System.Windows.Forms.Padding(6);
            this.roomAvailabilityPic.Name = "roomAvailabilityPic";
            this.roomAvailabilityPic.Size = new System.Drawing.Size(80, 65);
            this.roomAvailabilityPic.TabIndex = 37;
            this.roomAvailabilityPic.TabStop = false;
            // 
            // AvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1820, 1078);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RoomsFlowLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AvailableRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableRooms";
            this.Load += new System.EventHandler(this.AvailableRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RoomsFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeDateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel RoomsFlowLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.PictureBox RoomInfoPictureBox;
        private System.Windows.Forms.PictureBox roomAvailabilityPic;
    }
}