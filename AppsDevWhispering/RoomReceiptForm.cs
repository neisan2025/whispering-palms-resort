using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static AppsDevWhispering.AvailableRooms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AppsDevWhispering
{
    public partial class RoomReceiptForm : Form
    {
        private const int PanelBorderSize = 2;
        private const int RoomPanelWidth = 423;
        private const int RoomPanelHeight = 700;
        private const int MaxLabelWidth = 380;
        private const int LabelHeight = 30;
        private const int VerticalSpacing = 10;
        private const int StartY = 20;
        private static readonly Color BorderColor = ColorTranslator.FromHtml("#F4F4F4");
        private static readonly Color LabelForeColor = Color.FromArgb(100, 92, 92);
        private static readonly Font LabelFont = new Font("Proxima Nova", 15, FontStyle.Regular);

        private Panel borderPanel;
        private Panel roomPanel;

        public List<BookedRoomDetails> bookedRooms = AvailableRooms.bookedRooms;
        public static double totalPrice = 0.0;
        string cardNumber = "";

        public RoomReceiptForm()
        {
            InitializeComponent();
            CreateBorderPanel();
            ReadUser();
        }

        private void CreateBorderPanel()
        {
            borderPanel = CreatePanel(RoomPanelWidth + PanelBorderSize * 2, RoomPanelHeight + PanelBorderSize * 2, BorderColor, BorderStyle.None);
            roomPanel = CreatePanel(RoomPanelWidth, RoomPanelHeight, Color.White, BorderStyle.None);
            roomPanel.BackColor = ColorTranslator.FromHtml("#F4F4F4"); // Change the background color here
            borderPanel.Controls.Add(roomPanel);
            roomPanel.Location = new Point(PanelBorderSize, PanelBorderSize);
            this.Controls.Add(borderPanel);
            borderPanel.Location = new Point(10, 10);
        }


        private Panel CreatePanel(int width, int height, Color backColor, BorderStyle borderStyle)
        {
            return new Panel
            {
                Width = width,
                Height = height,
                BackColor = backColor,
                BorderStyle = borderStyle
            };
        }
        private Label CreateLabel(string text, int yPos)
        {
            return new Label
            {
                Text = text,
                Font = LabelFont,
                ForeColor = LabelForeColor,
                AutoSize = false,
                Width = MaxLabelWidth,
                Height = LabelHeight,
                Location = new Point(10, yPos)
            };
        }

        public void ShowBookedRoomDetails()
        {
            receiptFlowLayout.Controls.Clear();
            RoomReceiptForm.totalPrice = 0.0;
            foreach (var room in bookedRooms)
            {
                RoomReceiptForm.totalPrice += Convert.ToDouble(room.Subtotal);
            }
            foreach (var room in bookedRooms)
            {
                Panel roomDetailPanel = CreatePanel(400, 430, Color.FromArgb(244, 244, 244), BorderStyle.FixedSingle);
                roomDetailPanel.Margin = new Padding(0, 5, 0, 5);

                int labelY = 10;
                decimal formatted = decimal.Parse(room.Price);
                roomDetailPanel.Controls.Add(CreateLabel("Room: " + room.Title, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Price: ₱" + formatted.ToString("N2"), labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Check-In Date: " + room.CheckInDate, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Check-Out Date: " + room.CheckOutDate, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Check-In Time: " + room.CheckInTime, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Check-Out Time: " + room.CheckOutTime, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Guest Number: " + room.GuestNumber, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Days: " + room.Days, labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Subtotal: " + Convert.ToDouble(room.Subtotal).ToString("C2"), labelY));
                labelY += LabelHeight + VerticalSpacing;
                roomDetailPanel.Controls.Add(CreateLabel("Total Price: " + RoomReceiptForm.totalPrice.ToString("C2"), labelY));

                Button cancelButton = new Button();
                cancelButton.Text = "Cancel";
                cancelButton.Size = new Size(80, 30);
                cancelButton.Location = new Point(roomDetailPanel.Width - cancelButton.Width - 10, roomDetailPanel.Height - cancelButton.Height - 10);
                cancelButton.Click += (sender, e) =>
                {
                    // Remove the panel from the layout when cancel button is clicked
                    AvailableRooms.bookedRooms.Remove(room);
                    receiptFlowLayout.Controls.Remove(roomDetailPanel);
                    RoomReceiptForm.totalPrice -= Convert.ToDouble(room.Subtotal);
                    ShowBookedRoomDetails();
                };
                roomDetailPanel.Controls.Add(cancelButton);

                receiptFlowLayout.Controls.Add(roomDetailPanel);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (AvailableRooms.bookedRooms.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to change the exit? Your booking receipt will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    AvailableRooms.bookedRooms.Clear();
                    AvailableRooms availableRooms = new AvailableRooms();
                    availableRooms.Show();
                    this.Hide();
                }
            }
            else
            {
                AvailableRooms.bookedRooms.Clear();
                AvailableRooms availableRooms = new AvailableRooms();
                availableRooms.Show();
                this.Hide();
            }
        }

        private void BackBtn_MouseEnter(object sender, EventArgs e)
        {
            BackBtn.ForeColor = Color.White;
        }

        private void BackBtn_ContextMenuStripChanged(object sender, EventArgs e)
        {
            BackBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void continueBookBtn_Click(object sender, EventArgs e)
        {
            if(label11.Text == "" || label12.Text == "" || label13.Text == "")
            {
                MessageBox.Show("Please completely fill in your information in the profile dashboard");
                return;
            }

            if(bookedRooms.Count == 0)
            {
                MessageBox.Show("Please book a room.");
                return;
            }

            while (true)
            {
                cardNumber = Prompt.ShowDialog("Card number:", "Card Number Prompt");
                if (!string.IsNullOrEmpty(cardNumber) && ValidateCardNumber(cardNumber))
                {
                    Console.WriteLine(cardNumber);
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid card number");
                    return;
                }
            }
            AddBook();

            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
            this.Hide();

            


            ConfirmationReceiptForm confirmationReceiptForm = new ConfirmationReceiptForm();
            confirmationReceiptForm.Show();

            try
            {
                // Configure SMTP client
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("whisperproject24@gmail.com", "gqhg nvcw oaga yfrm");

                // Create MailMessage object
                MailMessage message = new MailMessage();
                message.From = new MailAddress("whisperproject24@gmail.com");
                message.To.Add(HomeForm.currentEmail); //EMAIL SA USER
                message.Subject = "Booked Successfully";
                message.Body = "You have successfully book a reservation. Please sign in to your account to see your reservation details.";

                client.Send(message);

                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The email you entered does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadUser()
        {
            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", HomeForm.currentEmail);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label10.Text = reader["first_name"].ToString();
                        label11.Text = reader["last_name"].ToString();
                        label12.Text = reader["contact"].ToString();
                        label13.Text = reader["email"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddBook()
        {
            foreach (var room in bookedRooms)
            {
                using (SqlConnection conn = new SqlConnection(HomeForm.connectionString))
                {
                    string query = "INSERT INTO bookings (email, room_id, number_of_guests, check_in, check_out, card_number, total_cost, date_of_booking, notes) " +
                                   "VALUES (@Email, @RoomId, @NumberOfGuests, @CheckIn, @CheckOut, @CardNumber, @TotalCost, @DateOfBooking, @Notes)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", HomeForm.currentEmail);
                    cmd.Parameters.AddWithValue("@RoomId", ReadRoom(room.Title));
                    cmd.Parameters.AddWithValue("@NumberOfGuests", Convert.ToInt32(room.GuestNumber));
                    cmd.Parameters.AddWithValue("@CheckIn", room.CheckInDateTime);
                    cmd.Parameters.AddWithValue("@CheckOut", room.CheckOutDateWithBreak);
                    cmd.Parameters.AddWithValue("@CardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(room.Subtotal));
                    cmd.Parameters.AddWithValue("@DateOfBooking", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Notes", textBox4.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Booking inserted successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private int ReadRoom(string roomType)
        {
            int roomId = -1;
            string query = "SELECT room_id FROM rooms WHERE room_type = @room_type";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@room_type", roomType);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        roomId = (int)reader["room_id"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return roomId;
        }

        public static bool ValidateCardNumber(string cardNumber)
        {
            // Remove any non-digit characters
            cardNumber = Regex.Replace(cardNumber, @"\D", "");

            // Check if the card number has between 13 and 19 digits
            if (cardNumber.Length < 13 || cardNumber.Length > 19)
            {
                return false;
            }

            // Perform Luhn check
            return true;
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
                Button confirmation = new Button() { Text = "OK", Left = 190, Width = 70, Top = 80, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                prompt.AutoSize = true;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
            }
        }
    }
}