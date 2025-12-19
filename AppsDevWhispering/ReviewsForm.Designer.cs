namespace AppsDevWhispering
{
    partial class ReviewsForm
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
            this.richUserInput = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richUserInput
            // 
            this.richUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richUserInput.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richUserInput.Location = new System.Drawing.Point(38, 22);
            this.richUserInput.Name = "richUserInput";
            this.richUserInput.Size = new System.Drawing.Size(755, 54);
            this.richUserInput.TabIndex = 2;
            this.richUserInput.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.richUserInput);
            this.panel3.Controls.Add(this.btnAddPanel);
            this.panel3.Location = new System.Drawing.Point(1, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 110);
            this.panel3.TabIndex = 7;
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnAddPanel.FlatAppearance.BorderSize = 0;
            this.btnAddPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.btnAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPanel.Font = new System.Drawing.Font("Proxima Nova Rg", 14.25F);
            this.btnAddPanel.ForeColor = System.Drawing.Color.White;
            this.btnAddPanel.Location = new System.Drawing.Point(844, 22);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(146, 54);
            this.btnAddPanel.TabIndex = 1;
            this.btnAddPanel.Text = "Comment";
            this.btnAddPanel.UseVisualStyleBackColor = false;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proxima Nova Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Leave a message";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 453);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewsForm";
            this.Text = "ReviewsForm";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richUserInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}