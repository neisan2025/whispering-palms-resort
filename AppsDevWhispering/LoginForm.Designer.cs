namespace AppsDevWhispering
{
    partial class LoginForm
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
            this.loginAdminBtn = new System.Windows.Forms.Button();
            this.incorrectPasswordLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userEmailLoginText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userPasswordLoginText = new System.Windows.Forms.MaskedTextBox();
            this.loginBackBtn = new CustomControls.RJControls.RJButton();
            this.loginSignUpBtn = new CustomControls.RJControls.RJButton();
            this.loginBtn = new CustomControls.RJControls.RJButton();
            this.loginPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginAdminBtn);
            this.panel1.Controls.Add(this.incorrectPasswordLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loginBackBtn);
            this.panel1.Controls.Add(this.loginSignUpBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.loginPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 701);
            this.panel1.TabIndex = 0;
            // 
            // loginAdminBtn
            // 
            this.loginAdminBtn.BackColor = System.Drawing.Color.White;
            this.loginAdminBtn.FlatAppearance.BorderSize = 0;
            this.loginAdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginAdminBtn.Location = new System.Drawing.Point(188, 631);
            this.loginAdminBtn.Name = "loginAdminBtn";
            this.loginAdminBtn.Size = new System.Drawing.Size(216, 35);
            this.loginAdminBtn.TabIndex = 10;
            this.loginAdminBtn.Text = "Login As Admin";
            this.loginAdminBtn.UseVisualStyleBackColor = false;
            this.loginAdminBtn.Click += new System.EventHandler(this.loginAdminBtn_Click);
            this.loginAdminBtn.MouseEnter += new System.EventHandler(this.loginAdminBtn_MouseEnter);
            this.loginAdminBtn.MouseLeave += new System.EventHandler(this.loginAdminBtn_MouseLeave);
            // 
            // incorrectPasswordLabel
            // 
            this.incorrectPasswordLabel.AutoSize = true;
            this.incorrectPasswordLabel.BackColor = System.Drawing.Color.White;
            this.incorrectPasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incorrectPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectPasswordLabel.Location = new System.Drawing.Point(74, 482);
            this.incorrectPasswordLabel.Name = "incorrectPasswordLabel";
            this.incorrectPasswordLabel.Size = new System.Drawing.Size(0, 20);
            this.incorrectPasswordLabel.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.userEmailLoginText);
            this.panel3.Location = new System.Drawing.Point(77, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 65);
            this.panel3.TabIndex = 8;
            // 
            // userEmailLoginText
            // 
            this.userEmailLoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.userEmailLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmailLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.userEmailLoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.userEmailLoginText.Location = new System.Drawing.Point(5, 20);
            this.userEmailLoginText.Name = "userEmailLoginText";
            this.userEmailLoginText.Size = new System.Drawing.Size(435, 24);
            this.userEmailLoginText.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.userPasswordLoginText);
            this.panel2.Location = new System.Drawing.Point(77, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 65);
            this.panel2.TabIndex = 7;
            // 
            // userPasswordLoginText
            // 
            this.userPasswordLoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.userPasswordLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPasswordLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.userPasswordLoginText.Location = new System.Drawing.Point(5, 21);
            this.userPasswordLoginText.Name = "userPasswordLoginText";
            this.userPasswordLoginText.Size = new System.Drawing.Size(435, 20);
            this.userPasswordLoginText.TabIndex = 6;
            this.userPasswordLoginText.UseSystemPasswordChar = true;
            // 
            // loginBackBtn
            // 
            this.loginBackBtn.BackColor = System.Drawing.Color.White;
            this.loginBackBtn.BackgroundColor = System.Drawing.Color.White;
            this.loginBackBtn.BorderColor = System.Drawing.Color.PapayaWhip;
            this.loginBackBtn.BorderRadius = 0;
            this.loginBackBtn.BorderSize = 0;
            this.loginBackBtn.FlatAppearance.BorderSize = 0;
            this.loginBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.loginBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginBackBtn.Location = new System.Drawing.Point(12, 12);
            this.loginBackBtn.Name = "loginBackBtn";
            this.loginBackBtn.Size = new System.Drawing.Size(88, 45);
            this.loginBackBtn.TabIndex = 5;
            this.loginBackBtn.Text = "Back";
            this.loginBackBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginBackBtn.UseVisualStyleBackColor = false;
            this.loginBackBtn.Click += new System.EventHandler(this.loginBackBtn_Click);
            this.loginBackBtn.MouseEnter += new System.EventHandler(this.loginBackBtn_MouseEnter);
            this.loginBackBtn.MouseLeave += new System.EventHandler(this.loginBackBtn_MouseLeave);
            // 
            // loginSignUpBtn
            // 
            this.loginSignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginSignUpBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginSignUpBtn.BorderColor = System.Drawing.Color.White;
            this.loginSignUpBtn.BorderRadius = 25;
            this.loginSignUpBtn.BorderSize = 2;
            this.loginSignUpBtn.FlatAppearance.BorderSize = 0;
            this.loginSignUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.loginSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginSignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSignUpBtn.ForeColor = System.Drawing.Color.White;
            this.loginSignUpBtn.Location = new System.Drawing.Point(813, 452);
            this.loginSignUpBtn.Name = "loginSignUpBtn";
            this.loginSignUpBtn.Size = new System.Drawing.Size(172, 55);
            this.loginSignUpBtn.TabIndex = 4;
            this.loginSignUpBtn.Text = "Sign in";
            this.loginSignUpBtn.TextColor = System.Drawing.Color.White;
            this.loginSignUpBtn.UseVisualStyleBackColor = false;
            this.loginSignUpBtn.Click += new System.EventHandler(this.loginSignUpBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.loginBtn.BorderColor = System.Drawing.Color.PapayaWhip;
            this.loginBtn.BorderRadius = 25;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(208, 530);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(172, 55);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginPic
            // 
            this.loginPic.Image = global::AppsDevWhispering.Properties.Resources.Login;
            this.loginPic.Location = new System.Drawing.Point(1, 0);
            this.loginPic.Name = "loginPic";
            this.loginPic.Size = new System.Drawing.Size(1190, 740);
            this.loginPic.TabIndex = 0;
            this.loginPic.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private CustomControls.RJControls.RJButton loginBtn;
        private CustomControls.RJControls.RJButton loginSignUpBtn;
        private CustomControls.RJControls.RJButton loginBackBtn;
        private System.Windows.Forms.MaskedTextBox userPasswordLoginText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox userEmailLoginText;
        private System.Windows.Forms.Label incorrectPasswordLabel;
        private System.Windows.Forms.Button loginAdminBtn;
    }
}