namespace AppsDevWhispering
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkOutTime = new System.Windows.Forms.ComboBox();
            this.checkInTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOutCalendar = new CustomControls.RJControls.RJDatePicker();
            this.checkInCalendar = new CustomControls.RJControls.RJDatePicker();
            this.guestNumber = new System.Windows.Forms.Label();
            this.subtractGuestBtn = new System.Windows.Forms.Button();
            this.addGuestBtn = new System.Windows.Forms.Button();
            this.cancelInfo = new System.Windows.Forms.Button();
            this.searchRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addGuests = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1213, 701);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 297);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AppsDevWhispering.Properties.Resources.CalendarBookingIntro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkOutTime);
            this.panel2.Controls.Add(this.checkInTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkOutCalendar);
            this.panel2.Controls.Add(this.checkInCalendar);
            this.panel2.Controls.Add(this.guestNumber);
            this.panel2.Controls.Add(this.subtractGuestBtn);
            this.panel2.Controls.Add(this.addGuestBtn);
            this.panel2.Controls.Add(this.cancelInfo);
            this.panel2.Controls.Add(this.searchRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addGuests);
            this.panel2.Location = new System.Drawing.Point(3, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 395);
            this.panel2.TabIndex = 1;
            // 
            // checkOutTime
            // 
            this.checkOutTime.BackColor = System.Drawing.Color.White;
            this.checkOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.checkOutTime.FormattingEnabled = true;
            this.checkOutTime.Items.AddRange(new object[] {
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
            this.checkOutTime.Location = new System.Drawing.Point(760, 78);
            this.checkOutTime.Name = "checkOutTime";
            this.checkOutTime.Size = new System.Drawing.Size(366, 28);
            this.checkOutTime.TabIndex = 16;
            // 
            // checkInTime
            // 
            this.checkInTime.BackColor = System.Drawing.Color.White;
            this.checkInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.checkInTime.FormattingEnabled = true;
            this.checkInTime.Items.AddRange(new object[] {
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
            this.checkInTime.Location = new System.Drawing.Point(325, 78);
            this.checkInTime.Name = "checkInTime";
            this.checkInTime.Size = new System.Drawing.Size(366, 28);
            this.checkInTime.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(45, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prices shown in PHP for 1-day stay";
            // 
            // checkOutCalendar
            // 
            this.checkOutCalendar.BorderColor = System.Drawing.Color.Transparent;
            this.checkOutCalendar.BorderSize = 0;
            this.checkOutCalendar.CustomFormat = "";
            this.checkOutCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutCalendar.Location = new System.Drawing.Point(604, 166);
            this.checkOutCalendar.MinimumSize = new System.Drawing.Size(4, 35);
            this.checkOutCalendar.Name = "checkOutCalendar";
            this.checkOutCalendar.SelectedDate = new System.DateTime(2024, 5, 18, 22, 32, 14, 0);
            this.checkOutCalendar.Size = new System.Drawing.Size(532, 35);
            this.checkOutCalendar.SkinColor = System.Drawing.Color.White;
            this.checkOutCalendar.TabIndex = 13;
            this.checkOutCalendar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.checkOutCalendar.Value = new System.DateTime(2024, 5, 18, 22, 32, 14, 0);
            // 
            // checkInCalendar
            // 
            this.checkInCalendar.BorderColor = System.Drawing.Color.Transparent;
            this.checkInCalendar.BorderSize = 0;
            this.checkInCalendar.CustomFormat = "";
            this.checkInCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInCalendar.Location = new System.Drawing.Point(40, 166);
            this.checkInCalendar.MinimumSize = new System.Drawing.Size(4, 35);
            this.checkInCalendar.Name = "checkInCalendar";
            this.checkInCalendar.SelectedDate = new System.DateTime(2024, 5, 18, 22, 22, 14, 698);
            this.checkInCalendar.Size = new System.Drawing.Size(532, 35);
            this.checkInCalendar.SkinColor = System.Drawing.Color.White;
            this.checkInCalendar.TabIndex = 12;
            this.checkInCalendar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.checkInCalendar.Value = new System.DateTime(2024, 5, 18, 22, 22, 14, 698);
            this.checkInCalendar.ValueChanged += new System.EventHandler(this.checkInCalendar_ValueChanged);
            // 
            // guestNumber
            // 
            this.guestNumber.AutoSize = true;
            this.guestNumber.BackColor = System.Drawing.Color.White;
            this.guestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.guestNumber.Location = new System.Drawing.Point(150, 78);
            this.guestNumber.Name = "guestNumber";
            this.guestNumber.Size = new System.Drawing.Size(25, 25);
            this.guestNumber.TabIndex = 11;
            this.guestNumber.Text = "0";
            // 
            // subtractGuestBtn
            // 
            this.subtractGuestBtn.BackColor = System.Drawing.Color.White;
            this.subtractGuestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.subtractGuestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.subtractGuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractGuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractGuestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.subtractGuestBtn.Location = new System.Drawing.Point(54, 69);
            this.subtractGuestBtn.Name = "subtractGuestBtn";
            this.subtractGuestBtn.Size = new System.Drawing.Size(37, 36);
            this.subtractGuestBtn.TabIndex = 10;
            this.subtractGuestBtn.Text = "-";
            this.subtractGuestBtn.UseVisualStyleBackColor = false;
            this.subtractGuestBtn.Click += new System.EventHandler(this.subtractGuestBtn_Click);
            this.subtractGuestBtn.MouseEnter += new System.EventHandler(this.subtractGuestBtn_MouseEnter_1);
            this.subtractGuestBtn.MouseLeave += new System.EventHandler(this.subtractGuestBtn_MouseLeave_1);
            // 
            // addGuestBtn
            // 
            this.addGuestBtn.BackColor = System.Drawing.Color.White;
            this.addGuestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.addGuestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.addGuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGuestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.addGuestBtn.Location = new System.Drawing.Point(234, 69);
            this.addGuestBtn.Name = "addGuestBtn";
            this.addGuestBtn.Size = new System.Drawing.Size(37, 36);
            this.addGuestBtn.TabIndex = 9;
            this.addGuestBtn.Text = "+";
            this.addGuestBtn.UseVisualStyleBackColor = false;
            this.addGuestBtn.Click += new System.EventHandler(this.addGuestBtn_Click);
            this.addGuestBtn.MouseEnter += new System.EventHandler(this.addGuestBtn_MouseEnter_1);
            this.addGuestBtn.MouseLeave += new System.EventHandler(this.addGuestBtn_MouseLeave_1);
            // 
            // cancelInfo
            // 
            this.cancelInfo.BackColor = System.Drawing.Color.White;
            this.cancelInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.cancelInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.cancelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.cancelInfo.Location = new System.Drawing.Point(695, 256);
            this.cancelInfo.Name = "cancelInfo";
            this.cancelInfo.Size = new System.Drawing.Size(177, 53);
            this.cancelInfo.TabIndex = 8;
            this.cancelInfo.Text = "CANCEL";
            this.cancelInfo.UseVisualStyleBackColor = false;
            this.cancelInfo.Click += new System.EventHandler(this.cancelInfo_Click);
            this.cancelInfo.MouseEnter += new System.EventHandler(this.cancelInfo_MouseEnter_1);
            this.cancelInfo.MouseLeave += new System.EventHandler(this.cancelInfo_MouseLeave_1);
            // 
            // searchRoom
            // 
            this.searchRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.searchRoom.FlatAppearance.BorderSize = 0;
            this.searchRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(95)))), ((int)(((byte)(206)))));
            this.searchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoom.ForeColor = System.Drawing.Color.White;
            this.searchRoom.Location = new System.Drawing.Point(908, 256);
            this.searchRoom.Name = "searchRoom";
            this.searchRoom.Size = new System.Drawing.Size(177, 53);
            this.searchRoom.TabIndex = 7;
            this.searchRoom.Text = "SEARCH";
            this.searchRoom.UseVisualStyleBackColor = false;
            this.searchRoom.Click += new System.EventHandler(this.searchRoom_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(180, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Starting price of ₱1,500 total for 1 day\r\n";
            // 
            // addGuests
            // 
            this.addGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGuests.Image = ((System.Drawing.Image)(resources.GetObject("addGuests.Image")));
            this.addGuests.Location = new System.Drawing.Point(0, 0);
            this.addGuests.Name = "addGuests";
            this.addGuests.Size = new System.Drawing.Size(1190, 395);
            this.addGuests.TabIndex = 0;
            this.addGuests.TabStop = false;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 701);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label guestNumber;
        private System.Windows.Forms.Button subtractGuestBtn;
        private System.Windows.Forms.Button addGuestBtn;
        private System.Windows.Forms.Button cancelInfo;
        private System.Windows.Forms.Button searchRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox addGuests;
        private CustomControls.RJControls.RJDatePicker checkOutCalendar;
        private CustomControls.RJControls.RJDatePicker checkInCalendar;
        private System.Windows.Forms.ComboBox checkInTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox checkOutTime;
    }
}