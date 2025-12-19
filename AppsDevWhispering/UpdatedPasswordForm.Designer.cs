namespace AppsDevWhispering
{
    partial class UpdatedPasswordForm
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
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelCurrentPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelConfirmPass);
            this.panel1.Controls.Add(this.labelNewPass);
            this.panel1.Controls.Add(this.labelCurrentPass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 599);
            this.panel1.TabIndex = 0;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.BackColor = System.Drawing.Color.White;
            this.labelConfirmPass.Font = new System.Drawing.Font("Proxima Nova Rg", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelConfirmPass.Location = new System.Drawing.Point(43, 406);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(211, 24);
            this.labelConfirmPass.TabIndex = 3;
            this.labelConfirmPass.Text = "Confirm Password";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.BackColor = System.Drawing.Color.White;
            this.labelNewPass.Font = new System.Drawing.Font("Proxima Nova Rg", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelNewPass.Location = new System.Drawing.Point(43, 303);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(173, 24);
            this.labelNewPass.TabIndex = 2;
            this.labelNewPass.Text = "New password";
            // 
            // labelCurrentPass
            // 
            this.labelCurrentPass.AutoSize = true;
            this.labelCurrentPass.BackColor = System.Drawing.Color.White;
            this.labelCurrentPass.Font = new System.Drawing.Font("Proxima Nova Rg", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelCurrentPass.Location = new System.Drawing.Point(43, 196);
            this.labelCurrentPass.Name = "labelCurrentPass";
            this.labelCurrentPass.Size = new System.Drawing.Size(209, 24);
            this.labelCurrentPass.TabIndex = 1;
            this.labelCurrentPass.Text = "Current Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AppsDevWhispering.Properties.Resources.pbChangePasswordForm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 599);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpdatedPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatedPasswordForm";
            this.Text = "UpdatedPasswordForm";
            this.Load += new System.EventHandler(this.UpdatedPasswordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelCurrentPass;
    }
}