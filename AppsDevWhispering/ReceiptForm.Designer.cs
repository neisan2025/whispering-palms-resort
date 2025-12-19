namespace AppsDevWhispering
{
    partial class ReceiptForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.bookNowBtn = new System.Windows.Forms.Button();
            this.grandTotal = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPesoSign = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diningFinalReceiptPic = new System.Windows.Forms.PictureBox();
            this.rjDatePicker1 = new CustomControls.RJControls.RJDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningFinalReceiptPic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.button1.Location = new System.Drawing.Point(217, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 41;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookNowBtn
            // 
            this.bookNowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.bookNowBtn.FlatAppearance.BorderSize = 0;
            this.bookNowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.bookNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookNowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNowBtn.ForeColor = System.Drawing.Color.White;
            this.bookNowBtn.Location = new System.Drawing.Point(757, 527);
            this.bookNowBtn.Name = "bookNowBtn";
            this.bookNowBtn.Size = new System.Drawing.Size(149, 51);
            this.bookNowBtn.TabIndex = 40;
            this.bookNowBtn.Text = "Confirm";
            this.bookNowBtn.UseVisualStyleBackColor = false;
            this.bookNowBtn.Click += new System.EventHandler(this.bookNowBtn_Click);
            // 
            // grandTotal
            // 
            this.grandTotal.BackColor = System.Drawing.Color.White;
            this.grandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.grandTotal.Location = new System.Drawing.Point(784, 477);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(211, 24);
            this.grandTotal.TabIndex = 37;
            this.grandTotal.Text = "0.00";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.BackColor = System.Drawing.Color.White;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.labelGrandTotal.Location = new System.Drawing.Point(577, 477);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(172, 25);
            this.labelGrandTotal.TabIndex = 36;
            this.labelGrandTotal.Text = "GRAND TOTAL";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.BackColor = System.Drawing.Color.White;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.labelQty.Location = new System.Drawing.Point(641, 245);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(126, 25);
            this.labelQty.TabIndex = 26;
            this.labelQty.Text = "QUANTITY";
            this.labelQty.Visible = false;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.BackColor = System.Drawing.Color.White;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.labelItem.Location = new System.Drawing.Point(306, 244);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(66, 25);
            this.labelItem.TabIndex = 25;
            this.labelItem.Text = "ITEM";
            this.labelItem.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.labelTotal.Location = new System.Drawing.Point(821, 244);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(85, 25);
            this.labelTotal.TabIndex = 42;
            this.labelTotal.Text = "TOTAL";
            this.labelTotal.Visible = false;
            // 
            // labelPesoSign
            // 
            this.labelPesoSign.BackColor = System.Drawing.Color.White;
            this.labelPesoSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesoSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.labelPesoSign.Location = new System.Drawing.Point(755, 476);
            this.labelPesoSign.Name = "labelPesoSign";
            this.labelPesoSign.Size = new System.Drawing.Size(23, 24);
            this.labelPesoSign.TabIndex = 44;
            this.labelPesoSign.Text = "₱";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(592, 184);
            this.dataGridView1.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6:00 AM",
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM"});
            this.comboBox1.Location = new System.Drawing.Point(429, 531);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "6:00 AM",
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM"});
            this.comboBox2.Location = new System.Drawing.Point(429, 562);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 48;
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.BackColor = System.Drawing.Color.White;
            this.labelTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.labelTimeIn.Location = new System.Drawing.Point(308, 531);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(97, 25);
            this.labelTimeIn.TabIndex = 49;
            this.labelTimeIn.Text = "Time-In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(308, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Time-Out:";
            // 
            // diningFinalReceiptPic
            // 
            this.diningFinalReceiptPic.Image = global::AppsDevWhispering.Properties.Resources.divingFinalReceipt;
            this.diningFinalReceiptPic.Location = new System.Drawing.Point(164, 92);
            this.diningFinalReceiptPic.Name = "diningFinalReceiptPic";
            this.diningFinalReceiptPic.Size = new System.Drawing.Size(885, 516);
            this.diningFinalReceiptPic.TabIndex = 24;
            this.diningFinalReceiptPic.TabStop = false;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.rjDatePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker1.Location = new System.Drawing.Point(298, 476);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.SelectedDate = new System.DateTime(2024, 5, 19, 16, 52, 43, 958);
            this.rjDatePicker1.Size = new System.Drawing.Size(237, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.White;
            this.rjDatePicker1.TabIndex = 46;
            this.rjDatePicker1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.rjDatePicker1.Value = new System.DateTime(2024, 5, 19, 16, 52, 43, 958);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(537, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Guests:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(636, 527);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 31);
            this.textBox1.TabIndex = 52;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 701);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTimeIn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grandTotal);
            this.Controls.Add(this.labelPesoSign);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookNowBtn);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.diningFinalReceiptPic);
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningFinalReceiptPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bookNowBtn;
        private System.Windows.Forms.Label grandTotal;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.PictureBox diningFinalReceiptPic;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPesoSign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}