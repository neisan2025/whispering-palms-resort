namespace AppsDevWhispering
{
    partial class AdminEditRoomDetails
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
            this.roomIDText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.personsPictureBox = new System.Windows.Forms.PictureBox();
            this.pricePictureBox = new System.Windows.Forms.PictureBox();
            this.roomAvailabilityPic = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BathTabTextBox = new System.Windows.Forms.TextBox();
            this.SmokingTextBox = new System.Windows.Forms.TextBox();
            this.BalconyTextBox = new System.Windows.Forms.TextBox();
            this.PersonsTextBox = new System.Windows.Forms.TextBox();
            this.RoomSizeTextBox = new System.Windows.Forms.TextBox();
            this.BedsTextBox = new System.Windows.Forms.TextBox();
            this.RoomPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomImgPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateRoomBTN = new CustomControls.RJControls.RJButton();
            this.DeleteRoomBtn = new CustomControls.RJControls.RJButton();
            this.importPicBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // roomIDText
            // 
            this.roomIDText.BackColor = System.Drawing.Color.White;
            this.roomIDText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.roomIDText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.roomIDText.Location = new System.Drawing.Point(77, 411);
            this.roomIDText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomIDText.Name = "roomIDText";
            this.roomIDText.ReadOnly = true;
            this.roomIDText.Size = new System.Drawing.Size(518, 37);
            this.roomIDText.TabIndex = 62;
            this.roomIDText.TextChanged += new System.EventHandler(this.roomIDText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(73, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 61;
            this.label7.Text = "Room ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // RoomInfoPictureBox
            // 
            this.RoomInfoPictureBox.Image = global::AppsDevWhispering.Properties.Resources.RoomDetailsPic;
            this.RoomInfoPictureBox.Location = new System.Drawing.Point(659, 68);
            this.RoomInfoPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RoomInfoPictureBox.Name = "RoomInfoPictureBox";
            this.RoomInfoPictureBox.Size = new System.Drawing.Size(71, 327);
            this.RoomInfoPictureBox.TabIndex = 58;
            this.RoomInfoPictureBox.TabStop = false;
            // 
            // personsPictureBox
            // 
            this.personsPictureBox.Image = global::AppsDevWhispering.Properties.Resources.maxPersonsPic;
            this.personsPictureBox.Location = new System.Drawing.Point(1217, 405);
            this.personsPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.personsPictureBox.Name = "personsPictureBox";
            this.personsPictureBox.Size = new System.Drawing.Size(71, 57);
            this.personsPictureBox.TabIndex = 57;
            this.personsPictureBox.TabStop = false;
            // 
            // pricePictureBox
            // 
            this.pricePictureBox.Image = global::AppsDevWhispering.Properties.Resources.pricePic;
            this.pricePictureBox.Location = new System.Drawing.Point(1136, 411);
            this.pricePictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pricePictureBox.Name = "pricePictureBox";
            this.pricePictureBox.Size = new System.Drawing.Size(71, 46);
            this.pricePictureBox.TabIndex = 56;
            this.pricePictureBox.TabStop = false;
            // 
            // roomAvailabilityPic
            // 
            this.roomAvailabilityPic.Image = global::AppsDevWhispering.Properties.Resources.lastRooms;
            this.roomAvailabilityPic.Location = new System.Drawing.Point(1055, 410);
            this.roomAvailabilityPic.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roomAvailabilityPic.Name = "roomAvailabilityPic";
            this.roomAvailabilityPic.Size = new System.Drawing.Size(71, 52);
            this.roomAvailabilityPic.TabIndex = 55;
            this.roomAvailabilityPic.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(659, 475);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(633, 208);
            this.descriptionTextBox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(652, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "Details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(652, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 31);
            this.label5.TabIndex = 49;
            this.label5.Text = "Description:";
            // 
            // BathTabTextBox
            // 
            this.BathTabTextBox.BackColor = System.Drawing.Color.White;
            this.BathTabTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BathTabTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.BathTabTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.BathTabTextBox.Location = new System.Drawing.Point(739, 358);
            this.BathTabTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BathTabTextBox.Name = "BathTabTextBox";
            this.BathTabTextBox.Size = new System.Drawing.Size(549, 37);
            this.BathTabTextBox.TabIndex = 48;
            // 
            // SmokingTextBox
            // 
            this.SmokingTextBox.BackColor = System.Drawing.Color.White;
            this.SmokingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SmokingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.SmokingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.SmokingTextBox.Location = new System.Drawing.Point(739, 299);
            this.SmokingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SmokingTextBox.Name = "SmokingTextBox";
            this.SmokingTextBox.Size = new System.Drawing.Size(549, 37);
            this.SmokingTextBox.TabIndex = 47;
            // 
            // BalconyTextBox
            // 
            this.BalconyTextBox.BackColor = System.Drawing.Color.White;
            this.BalconyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BalconyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.BalconyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.BalconyTextBox.Location = new System.Drawing.Point(739, 242);
            this.BalconyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BalconyTextBox.Name = "BalconyTextBox";
            this.BalconyTextBox.Size = new System.Drawing.Size(549, 37);
            this.BalconyTextBox.TabIndex = 46;
            // 
            // PersonsTextBox
            // 
            this.PersonsTextBox.BackColor = System.Drawing.Color.White;
            this.PersonsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.PersonsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.PersonsTextBox.Location = new System.Drawing.Point(739, 185);
            this.PersonsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonsTextBox.Name = "PersonsTextBox";
            this.PersonsTextBox.Size = new System.Drawing.Size(549, 37);
            this.PersonsTextBox.TabIndex = 45;
            // 
            // RoomSizeTextBox
            // 
            this.RoomSizeTextBox.BackColor = System.Drawing.Color.White;
            this.RoomSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.RoomSizeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.RoomSizeTextBox.Location = new System.Drawing.Point(739, 126);
            this.RoomSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomSizeTextBox.Name = "RoomSizeTextBox";
            this.RoomSizeTextBox.Size = new System.Drawing.Size(549, 37);
            this.RoomSizeTextBox.TabIndex = 44;
            // 
            // BedsTextBox
            // 
            this.BedsTextBox.BackColor = System.Drawing.Color.White;
            this.BedsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BedsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.BedsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.BedsTextBox.Location = new System.Drawing.Point(739, 68);
            this.BedsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BedsTextBox.Name = "BedsTextBox";
            this.BedsTextBox.Size = new System.Drawing.Size(549, 37);
            this.BedsTextBox.TabIndex = 43;
            // 
            // RoomPriceTextBox
            // 
            this.RoomPriceTextBox.BackColor = System.Drawing.Color.White;
            this.RoomPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.RoomPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.RoomPriceTextBox.Location = new System.Drawing.Point(77, 570);
            this.RoomPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomPriceTextBox.Name = "RoomPriceTextBox";
            this.RoomPriceTextBox.Size = new System.Drawing.Size(518, 37);
            this.RoomPriceTextBox.TabIndex = 41;
            this.RoomPriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(72, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Room Price:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RoomTypeTextBox
            // 
            this.RoomTypeTextBox.BackColor = System.Drawing.Color.White;
            this.RoomTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.RoomTypeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.RoomTypeTextBox.Location = new System.Drawing.Point(77, 489);
            this.RoomTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomTypeTextBox.Name = "RoomTypeTextBox";
            this.RoomTypeTextBox.Size = new System.Drawing.Size(518, 37);
            this.RoomTypeTextBox.TabIndex = 39;
            this.RoomTypeTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(72, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "Room Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoomImgPic
            // 
            this.RoomImgPic.BackColor = System.Drawing.Color.White;
            this.RoomImgPic.Location = new System.Drawing.Point(76, 85);
            this.RoomImgPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomImgPic.Name = "RoomImgPic";
            this.RoomImgPic.Size = new System.Drawing.Size(519, 220);
            this.RoomImgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoomImgPic.TabIndex = 37;
            this.RoomImgPic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Room";
            // 
            // roomNumberText
            // 
            this.roomNumberText.BackColor = System.Drawing.Color.White;
            this.roomNumberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.roomNumberText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.roomNumberText.Location = new System.Drawing.Point(76, 652);
            this.roomNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomNumberText.Name = "roomNumberText";
            this.roomNumberText.ReadOnly = true;
            this.roomNumberText.Size = new System.Drawing.Size(518, 37);
            this.roomNumberText.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(71, 622);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Number of Rooms:";
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
            this.UpdateRoomBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRoomBTN.ForeColor = System.Drawing.Color.White;
            this.UpdateRoomBTN.Location = new System.Drawing.Point(788, 706);
            this.UpdateRoomBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateRoomBTN.Name = "UpdateRoomBTN";
            this.UpdateRoomBTN.Size = new System.Drawing.Size(243, 50);
            this.UpdateRoomBTN.TabIndex = 54;
            this.UpdateRoomBTN.Text = "Update Room";
            this.UpdateRoomBTN.TextColor = System.Drawing.Color.White;
            this.UpdateRoomBTN.UseVisualStyleBackColor = false;
            this.UpdateRoomBTN.Click += new System.EventHandler(this.UpdateRoomBTN_Click);
            // 
            // DeleteRoomBtn
            // 
            this.DeleteRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteRoomBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteRoomBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.DeleteRoomBtn.BorderRadius = 9;
            this.DeleteRoomBtn.BorderSize = 0;
            this.DeleteRoomBtn.FlatAppearance.BorderSize = 0;
            this.DeleteRoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.DeleteRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoomBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteRoomBtn.Location = new System.Drawing.Point(1048, 706);
            this.DeleteRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteRoomBtn.Name = "DeleteRoomBtn";
            this.DeleteRoomBtn.Size = new System.Drawing.Size(243, 50);
            this.DeleteRoomBtn.TabIndex = 53;
            this.DeleteRoomBtn.Text = "Delete Room";
            this.DeleteRoomBtn.TextColor = System.Drawing.Color.White;
            this.DeleteRoomBtn.UseVisualStyleBackColor = false;
            this.DeleteRoomBtn.Click += new System.EventHandler(this.DeleteRoomBtn_Click);
            // 
            // importPicBtn
            // 
            this.importPicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.importPicBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.importPicBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.importPicBtn.BorderRadius = 9;
            this.importPicBtn.BorderSize = 0;
            this.importPicBtn.FlatAppearance.BorderSize = 0;
            this.importPicBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.importPicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importPicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importPicBtn.ForeColor = System.Drawing.Color.White;
            this.importPicBtn.Location = new System.Drawing.Point(228, 322);
            this.importPicBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.importPicBtn.Name = "importPicBtn";
            this.importPicBtn.Size = new System.Drawing.Size(216, 50);
            this.importPicBtn.TabIndex = 42;
            this.importPicBtn.Text = "Import Picture";
            this.importPicBtn.TextColor = System.Drawing.Color.White;
            this.importPicBtn.UseVisualStyleBackColor = false;
            this.importPicBtn.Click += new System.EventHandler(this.importPicBtn_Click_1);
            // 
            // AdminEditRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1352, 815);
            this.Controls.Add(this.roomNumberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomIDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RoomInfoPictureBox);
            this.Controls.Add(this.personsPictureBox);
            this.Controls.Add(this.pricePictureBox);
            this.Controls.Add(this.roomAvailabilityPic);
            this.Controls.Add(this.UpdateRoomBTN);
            this.Controls.Add(this.DeleteRoomBtn);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BathTabTextBox);
            this.Controls.Add(this.SmokingTextBox);
            this.Controls.Add(this.BalconyTextBox);
            this.Controls.Add(this.PersonsTextBox);
            this.Controls.Add(this.RoomSizeTextBox);
            this.Controls.Add(this.BedsTextBox);
            this.Controls.Add(this.importPicBtn);
            this.Controls.Add(this.RoomPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomTypeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomImgPic);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminEditRoomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRoomDetailsForm";
            this.Load += new System.EventHandler(this.EditRoomDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImgPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomIDText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox RoomInfoPictureBox;
        private System.Windows.Forms.PictureBox personsPictureBox;
        private System.Windows.Forms.PictureBox pricePictureBox;
        private System.Windows.Forms.PictureBox roomAvailabilityPic;
        private CustomControls.RJControls.RJButton UpdateRoomBTN;
        private CustomControls.RJControls.RJButton DeleteRoomBtn;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BathTabTextBox;
        private System.Windows.Forms.TextBox SmokingTextBox;
        private System.Windows.Forms.TextBox BalconyTextBox;
        private System.Windows.Forms.TextBox PersonsTextBox;
        private System.Windows.Forms.TextBox RoomSizeTextBox;
        private System.Windows.Forms.TextBox BedsTextBox;
        private CustomControls.RJControls.RJButton importPicBtn;
        private System.Windows.Forms.TextBox RoomPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RoomTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox RoomImgPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomNumberText;
        private System.Windows.Forms.Label label1;
    }
}