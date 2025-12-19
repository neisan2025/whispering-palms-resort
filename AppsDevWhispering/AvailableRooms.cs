using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class AvailableRooms : Form
    {
        //DATABASE
        private string connectionString = HomeForm.connectionString;
        private DateTime checkInDate = CalendarForm.checkInDate;
        private DateTime checkOutDate = CalendarForm.checkOutDate;
        private string checkInTime = CalendarForm.checkInTimeComboBox;
        private string checkOutTime = CalendarForm.checkOutTimeComboBox;
        private DateTime checkOutDateWithBreak = CalendarForm.checkOutDateWithBreak;
        private int guestNumber = CalendarForm.totalGuest;

        bool notAvail = true;
        //END
        public AvailableRooms()
        {
            InitializeComponent();
            AvailableRooms.bookedRooms.Clear();
        }
        public void GetBookingDetails()
        {
            // Call ReadRoom to populate the rooms based on the booking details
        }
        public void AddRoomPanelToFlowLayout(string title, string price, string roomBed, string roomSize, string roomPersons, string roomBalcony, string roomSmoking, string roomBathtub, Image roomImage, Image roomInfoImage, Image availabiltyPic)
        {
            int occupied = 0;
            int roomId = -1;
            int numberOfRooms = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT room_id, number_of_rooms FROM rooms WHERE room_type = @room_type";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@room_type", title);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        roomId = (int)reader["room_id"];
                        numberOfRooms = (int)reader["number_of_rooms"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            occupied = checkAvailability(roomId, CalendarForm.checkInDate, CalendarForm.checkOutDate);
            Console.WriteLine("Room ID: " + roomId + "; Occupied: " + occupied);

            // Create a new panel for each room
            Panel roomPanel = new Panel();
            roomPanel.BackColor = Color.LightGray;
            roomPanel.BorderStyle = BorderStyle.FixedSingle;
            roomPanel.Width = 1132;
            roomPanel.Height = 400;
            roomPanel.BackColor = Color.White;

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Width = 1100;
            titleLabel.Height = 30;
            titleLabel.Font = new Font("Proxima Nova", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(100, 92, 92);
            titleLabel.AutoSize = false;

            PictureBox roomPictureBox = new PictureBox();
            roomPictureBox.Width = 392;
            roomPictureBox.Height = 300;
            roomPictureBox.Image = roomImage;
            roomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox roomInfoPics = new PictureBox();
            roomInfoPics.Width = 40;
            roomInfoPics.Height = 262;
            roomInfoPics.Image = roomInfoImage;


            PictureBox availableRoomsPic = new PictureBox();
            availableRoomsPic.Width = 40;
            availableRoomsPic.Height = 34;
            availableRoomsPic.Image = availabiltyPic;

            int maxLabelWidth = 380;

            Label roomsLabel = new Label();
            roomsLabel.Text = roomBed;
            roomsLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            roomsLabel.ForeColor = Color.FromArgb(100, 92, 92);
            roomsLabel.AutoSize = false;
            roomsLabel.Width = maxLabelWidth;

            Label roomSizeLabel = new Label();
            roomSizeLabel.Text = roomSize;
            roomSizeLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            roomSizeLabel.ForeColor = Color.FromArgb(100, 92, 92);
            roomSizeLabel.AutoSize = false;
            roomSizeLabel.Width = maxLabelWidth;

            Label personsLabel = new Label();
            personsLabel.Text = roomPersons;
            personsLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            personsLabel.ForeColor = Color.FromArgb(100, 92, 92);
            personsLabel.AutoSize = false;
            personsLabel.Width = maxLabelWidth;

            Label balconyLabel = new Label();
            balconyLabel.Text = roomBalcony;
            balconyLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            balconyLabel.ForeColor = Color.FromArgb(100, 92, 92);
            balconyLabel.AutoSize = false;
            balconyLabel.Width = maxLabelWidth;

            Label smokingLabel = new Label();
            smokingLabel.Text = roomSmoking;
            smokingLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            smokingLabel.ForeColor = Color.FromArgb(100, 92, 92);
            smokingLabel.AutoSize = false;
            smokingLabel.Width = maxLabelWidth;


            Label bathTubLabel = new Label();
            bathTubLabel.Text = roomBathtub;
            bathTubLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            bathTubLabel.ForeColor = Color.FromArgb(100, 92, 92);
            bathTubLabel.AutoSize = false;
            bathTubLabel.Width = maxLabelWidth;

            Label priceLabel = new Label();
            decimal formatted = decimal.Parse(price);
            priceLabel.Text = "₱" + formatted.ToString("N2");
            priceLabel.Width = 200;
            priceLabel.Height = 30;
            priceLabel.Font = new Font("Proxima Nova", 18, FontStyle.Bold);
            priceLabel.ForeColor = Color.DeepSkyBlue;
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            priceLabel.AutoSize = false;


            Label pricePerNightLabel = new Label();
            pricePerNightLabel.Text = "Price per night: ";
            pricePerNightLabel.Font = new Font("Proxima Nova", 15, FontStyle.Bold);
            pricePerNightLabel.ForeColor = Color.FromArgb(100, 92, 92);
            pricePerNightLabel.AutoSize = true;

            Label availableRoomsLabel = new Label();
            availableRoomsLabel.Text = "Our last 1 room!";
            availableRoomsLabel.Font = new Font("Proxima Nova", 14, FontStyle.Bold);
            availableRoomsLabel.ForeColor = Color.Red;
            availableRoomsLabel.AutoSize = false;
            availableRoomsLabel.Width = maxLabelWidth;

            if(occupied != numberOfRooms-1)
            {
                availableRoomsLabel.Visible = false;
                availableRoomsPic.Visible = false;
            }

            int paddingAtTop = 20;

            titleLabel.Location = new Point(25, paddingAtTop);
            roomPictureBox.Location = new Point(30, titleLabel.Bottom + 20);
            roomInfoPics.Location = new Point(roomPictureBox.Right + 20, roomPictureBox.Top);
            availableRoomsPic.Location = new Point(roomPictureBox.Right + 20, roomInfoPics.Bottom + 10);
            roomsLabel.Location = new Point(roomInfoPics.Right + 10, roomInfoPics.Top + 5);
            roomSizeLabel.Location = new Point(roomInfoPics.Right + 10, roomsLabel.Bottom + 25);
            personsLabel.Location = new Point(roomInfoPics.Right + 10, roomSizeLabel.Bottom + 25);
            balconyLabel.Location = new Point(roomInfoPics.Right + 10, personsLabel.Bottom + 23);
            smokingLabel.Location = new Point(roomInfoPics.Right + 10, balconyLabel.Bottom + 23);
            bathTubLabel.Location = new Point(roomInfoPics.Right + 10, smokingLabel.Bottom + 23);
            availableRoomsLabel.Location = new Point(availableRoomsPic.Right + 10, bathTubLabel.Bottom + 20);

            Button bookButton = new Button();
            bookButton.Text = "BOOK NOW";
            bookButton.Width = 200;
            bookButton.Height = 58;
            bookButton.AutoSize = false;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Font = new Font("Proxima Nova", 12, FontStyle.Bold);
            bookButton.Padding = new Padding(10, 5, 10, 5);
            bookButton.ForeColor = Color.White;
            bookButton.BackColor = Color.DeepSkyBlue;

            bookButton.Click += (sender, e) =>
            {
                if (occupied >= numberOfRooms)
                {
                    MessageBox.Show("Fully occuppied.");
                    return;
                }
                occupied++;

                // Call the method to add booked room details
                int numdays = CountNights(checkInDate, checkOutDate);
                if (numdays == 0)
                {
                    numdays = 1;
                }
                double subtotal = Convert.ToDouble(price) * numdays;
                

                AddBookedRoomDetails(title, price, checkInDate.ToShortDateString(), checkOutDate.ToShortDateString(), checkInTime, checkOutTime, guestNumber.ToString(), numdays.ToString(), subtotal.ToString(), checkInDate, checkOutDate, checkOutDateWithBreak);
                MessageBox.Show("Successfully added " + title + " to Booking.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Console.WriteLine("Occupied: " + occupied);
                Console.WriteLine("Number of rooms " + numberOfRooms);
            };

            // Add the button to the room panel
            roomPanel.Controls.Add(bookButton);
            RoomsFlowLayout.Controls.Add(roomPanel);

            int buttonY = titleLabel.Bottom + 265;
            bookButton.Location = new Point(roomPictureBox.Right + 460, buttonY);
            pricePerNightLabel.Location = new Point(personsLabel.Right + 8, roomPictureBox.Top + 150);
            priceLabel.Location = new Point(smokingLabel.Right + 8, roomPictureBox.Top + 200);

            // Add the button to the room panel
            roomPanel.Controls.Add(titleLabel);
            roomPanel.Controls.Add(roomPictureBox);
            roomPanel.Controls.Add(roomInfoPics);
            roomPanel.Controls.Add(availableRoomsPic);
            roomPanel.Controls.Add(roomsLabel);
            roomPanel.Controls.Add(roomSizeLabel);
            roomPanel.Controls.Add(personsLabel);
            roomPanel.Controls.Add(balconyLabel);
            roomPanel.Controls.Add(smokingLabel);
            roomPanel.Controls.Add(bathTubLabel);
            roomPanel.Controls.Add(availableRoomsLabel);
            roomPanel.Controls.Add(priceLabel);
            roomPanel.Controls.Add(bookButton);
            roomPanel.Controls.Add(pricePerNightLabel);
            RoomsFlowLayout.Controls.Add(roomPanel);
        }

        private void changeDateBtn_Click(object sender, EventArgs e)
        {
            
            if(AvailableRooms.bookedRooms.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to change the date? Your booking receipt will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    AvailableRooms.bookedRooms.Clear();
                    CalendarForm calendarForm = new CalendarForm();
                    calendarForm.Show();
                    this.Hide();
                }
            }
            else
            {
                CalendarForm calendarForm = new CalendarForm();
                calendarForm.Show();
                this.Hide();
            }

        }
        //DATABASE
        private void AvailableRooms_Load(object sender, EventArgs e)
        {
            RoomInfoPictureBox.Visible = false;
            roomAvailabilityPic.Visible = false;

            ReadRoom(RoomInfoPictureBox.Image, roomAvailabilityPic.Image);
            if(notAvail)
            {
                MessageBox.Show("No available rooms for this date. Please change date.");
                this.Close();
                CalendarForm calendarForm = new CalendarForm();
                calendarForm.Show();
            }
        }
        //END

        //DATABASE
        public void ReadRoom(Image roomInfoImage, Image availabiltyPic)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM rooms";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int roomId = (int)reader["room_id"];
                        string roomType = reader["room_type"].ToString();
                        int number_of_rooms = (int)reader["number_of_rooms"];
                        string price = reader["price"].ToString();
                        string max_capacity = reader["max_capacity"].ToString();
                        string number_of_beds = reader["number_of_beds"].ToString();
                        string room_size = reader["room_size"].ToString();
                        string balcony = reader["balcony"].ToString();
                        string smoking = reader["smoking"].ToString();
                        string bathroom = reader["bathroom"].ToString();

                        Image roomImage = null;
                        byte[] imageData = (byte[])reader["picture"];
                        roomImage = ByteArrayToImage(imageData);

                        string details = reader["details"].ToString();

                        //Console.WriteLine(roomType);
                        //Console.WriteLine(CalendarForm.checkInDate);
                        //Console.WriteLine(CalendarForm.checkOutDate);
                        //Console.WriteLine("occupied: " + checkAvailability(roomId, CalendarForm.checkInDate, CalendarForm.checkOutDate));
                        //Console.WriteLine("number of room: " + number_of_rooms);

                        //string numberString = max_capacity.Substring(0, 1);
                        //int number = int.Parse(numberString);
                        //Console.WriteLine("Max: " + number);

                        if (!(checkAvailability(roomId, CalendarForm.checkInDate, CalendarForm.checkOutDate) >= number_of_rooms))
                        {
                            Console.WriteLine(roomId + "!" + (checkAvailability(roomId, CalendarForm.checkInDate, CalendarForm.checkOutDate) + " >= " + number_of_rooms));
                            notAvail = false;
                            AddRoomPanelToFlowLayout(roomType, price, number_of_beds, room_size, max_capacity, balcony, smoking, bathroom, roomImage, roomInfoImage, availabiltyPic);
                        }                    
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public int checkAvailability(int roomId, DateTime checkIn, DateTime checkOut)
        {
            int occupied = 0;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT check_in, check_out FROM bookings WHERE room_id = @roomId";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        DateTime din1 = (DateTime)reader["check_in"];
                        DateTime dout1 = (DateTime)reader["check_out"];
                        DateTime din2 = checkIn;
                        DateTime dout2 = checkOut;
                        if (isOverlapping(din1, dout1, din2, dout2))
                        {
                            occupied++;
                        }
                        Console.WriteLine(occupied);
                    }

                }
                catch (Exception ex)
                {

                }
            }

            return occupied;
            
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public class BookedRoomDetails
        {
            public string Title { get; set; }
            public string Price { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public string CheckInTime { get; set; }
            public string CheckOutTime { get; set; }
            public string GuestNumber { get; set; }
            public string Days { get; set; }
            public string Subtotal { get; set; }
            public string TotalPrice { get; set; }
            public DateTime CheckInDateTime { get; set; }
            public DateTime CheckOutDateTime { get; set;}
            public DateTime CheckOutDateWithBreak { get; set; }
        }

        public static List<BookedRoomDetails> bookedRooms = new List<BookedRoomDetails>();

        // Method to add booked room details to the list
        private void AddBookedRoomDetails(string title, string price, string checkInDate, string checkOutDate, string checkInTime, string checkOutTime, string guestNumber, string days, string subtotal, DateTime checkInDateTime, DateTime checkOutDateTime, DateTime checkOutDateWithBreak)
        {
            bookedRooms.Add(new BookedRoomDetails
            {
                Title = title,
                Price = price,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                CheckInTime = checkInTime,
                CheckOutTime = checkOutTime,
                GuestNumber = guestNumber,
                Days = days,
                Subtotal = subtotal,
                CheckInDateTime = checkInDateTime,
                CheckOutDateTime = checkOutDateTime,
                CheckOutDateWithBreak = checkOutDateWithBreak,
            });
            ;
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            RoomReceiptForm roomReceiptForm = new RoomReceiptForm();
            roomReceiptForm.ShowBookedRoomDetails();
            roomReceiptForm.Show();
            this.Hide();
        }

        static bool isOverlapping(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            // If one range is completely before or after the other, there's no overlap
            if (end1 <= start2 || end2 <= start1)
                return false;

            // Otherwise, there's overlap
            return true;
        }

        static int CountNights(DateTime start, DateTime end)
        {
            // Ensure the end date and time is after the start date and time
            if (end <= start)
            {
                return 0;
            }

            // Calculate the total difference in days
            int totalDays = (end.Date - start.Date).Days;

            // Adjust for the time component
            // If the start time is later in the day than the end time, subtract one day
            if (start.TimeOfDay > end.TimeOfDay)
            {
                totalDays -= 1;
            }

            return totalDays;
        }

        //END
    }
}
