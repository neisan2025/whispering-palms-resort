namespace AppsDevWhispering
{
    partial class ChangePriceFood
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
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.UpdateRoomBTN = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(38, 114);
            this.txtNewPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(340, 35);
            this.txtNewPrice.TabIndex = 66;
            // 
            // UpdateRoomBTN
            // 
            this.UpdateRoomBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.UpdateRoomBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.UpdateRoomBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.UpdateRoomBTN.BorderRadius = 9;
            this.UpdateRoomBTN.BorderSize = 0;
            this.UpdateRoomBTN.FlatAppearance.BorderSize = 0;
            this.UpdateRoomBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.UpdateRoomBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRoomBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UpdateRoomBTN.ForeColor = System.Drawing.Color.White;
            this.UpdateRoomBTN.Location = new System.Drawing.Point(139, 173);
            this.UpdateRoomBTN.Name = "UpdateRoomBTN";
            this.UpdateRoomBTN.Size = new System.Drawing.Size(150, 44);
            this.UpdateRoomBTN.TabIndex = 65;
            this.UpdateRoomBTN.Text = "Update";
            this.UpdateRoomBTN.TextColor = System.Drawing.Color.White;
            this.UpdateRoomBTN.UseVisualStyleBackColor = false;
            this.UpdateRoomBTN.Click += new System.EventHandler(this.UpdateRoomBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "Change Price:";
            // 
            // ChangePriceFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.UpdateRoomBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePriceFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Food Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPrice;
        private CustomControls.RJControls.RJButton UpdateRoomBTN;
        private System.Windows.Forms.Label label2;
    }
}