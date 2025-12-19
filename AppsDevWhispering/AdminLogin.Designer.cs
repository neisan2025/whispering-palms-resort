namespace AppsDevWhispering
{
    partial class AdminLogin
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminPassword = new System.Windows.Forms.MaskedTextBox();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.adminLoginBtn = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adminLoginBtn);
            this.panel1.Controls.Add(this.loginPic);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 740);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.adminUserName);
            this.panel3.Location = new System.Drawing.Point(372, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 65);
            this.panel3.TabIndex = 10;
            // 
            // adminUserName
            // 
            this.adminUserName.BackColor = System.Drawing.Color.White;
            this.adminUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminUserName.Font = new System.Drawing.Font("Proxima Nova Rg", 15.75F);
            this.adminUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.adminUserName.Location = new System.Drawing.Point(5, 20);
            this.adminUserName.Name = "adminUserName";
            this.adminUserName.Size = new System.Drawing.Size(435, 21);
            this.adminUserName.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.adminPassword);
            this.panel2.Location = new System.Drawing.Point(372, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 65);
            this.panel2.TabIndex = 9;
            // 
            // adminPassword
            // 
            this.adminPassword.BackColor = System.Drawing.Color.White;
            this.adminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPassword.Font = new System.Drawing.Font("Proxima Nova Rg", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.adminPassword.Location = new System.Drawing.Point(5, 21);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.Size = new System.Drawing.Size(435, 17);
            this.adminPassword.TabIndex = 6;
            this.adminPassword.UseSystemPasswordChar = true;
            // 
            // loginPic
            // 
            this.loginPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPic.Image = global::AppsDevWhispering.Properties.Resources.admingLogin;
            this.loginPic.Location = new System.Drawing.Point(0, 0);
            this.loginPic.Name = "loginPic";
            this.loginPic.Size = new System.Drawing.Size(1190, 740);
            this.loginPic.TabIndex = 0;
            this.loginPic.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 45);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.adminLoginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.adminLoginBtn.BorderColor = System.Drawing.Color.White;
            this.adminLoginBtn.BorderRadius = 25;
            this.adminLoginBtn.BorderSize = 2;
            this.adminLoginBtn.FlatAppearance.BorderSize = 0;
            this.adminLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.adminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginBtn.Font = new System.Drawing.Font("Proxima Nova Rg", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.adminLoginBtn.Location = new System.Drawing.Point(507, 608);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(172, 55);
            this.adminLoginBtn.TabIndex = 7;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.TextColor = System.Drawing.Color.White;
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPic;
        private CustomControls.RJControls.RJButton adminLoginBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox adminUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox adminPassword;
        private System.Windows.Forms.Button backBtn;
    }
}