using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppsDevWhispering.MenuRestaurantFINAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppsDevWhispering
{
    public partial class ReceiptForm : Form
    {
        public int numberOfTables = 0;
        public int numberOfGuestPerTable = 0;
        public static decimal total;
        string cardNumber = "";
        DateTimePicker timePicker;
        public static DateTime checkInDate;

        public ReceiptForm(decimal total)
        {
            InitializeComponent();
            InitializeForm();
            ReceiptForm.total = total;

            grandTotal.Text = total.ToString("N", new CultureInfo("en-US"));

            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "hh:mm tt"; 
            timePicker.ShowUpDown = true;
            int x = (this.ClientSize.Width - timePicker.Width) / 2;
            timePicker.Location = new System.Drawing.Point(x, 100);
            timePicker.BringToFront();
            this.Controls.Add(timePicker);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.DataSource = null; // Clear previous data source
            dataGridView1.DataSource = foodOrders;

            rjDatePicker1.MinDate = DateTime.Now;
            rjDatePicker1.SelectedDate = DateTime.Now;

            string filePath = "tables.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read content from the file
                    string contentFromFile = File.ReadAllText(filePath);
                    numberOfTables = Convert.ToInt32(contentFromFile);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading from the file: " + ex.Message);
            }

            filePath = "guests.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read content from the file
                    string contentFromFile = File.ReadAllText(filePath);
                    numberOfGuestPerTable = Convert.ToInt32(contentFromFile);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading from the file: " + ex.Message);
            }

            Console.WriteLine(numberOfTables);
            Console.WriteLine(numberOfGuestPerTable);
        }

        private void InitializeForm()
        {
            BackColor = Color.Green;
            TransparencyKey = Color.Green;
            FormBorderStyle = FormBorderStyle.None; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuRestaurantFINAL.foodOrders.Clear();
            this.Hide();
        }

        private void bookNowBtn_Click(object sender, EventArgs e)
        {
            DateTime date = rjDatePicker1.SelectedDate;

            int checkInYear = date.Year;
            int checkInMonth = date.Month;
            int checkInDay = date.Day;

            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in the time reservation.");
                return;
            }

            DateTime dateTime1 = DateTime.ParseExact(comboBox1.Text, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime dateTime2 = DateTime.ParseExact(comboBox2.Text, "h:mm tt", CultureInfo.InvariantCulture);

            // Calculate the time difference
            TimeSpan timeDifference = dateTime2 - dateTime1;

            // Check if the time difference is more than 2 hours
            if (timeDifference.TotalHours > 2)
            {
                MessageBox.Show("Time range must not exceed 2 hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continue with your existing code
            string militaryTime1 = dateTime1.ToString("HH:mm:ss");
            string[] split1 = militaryTime1.Split(':');

            string militaryTime2 = dateTime2.ToString("HH:mm:ss");
            string[] split2 = militaryTime2.Split(':');

            int checkInHour = Convert.ToInt32(split1[0]);
            int checkInMinute = Convert.ToInt32(split1[1]);
            int checkInSecond = Convert.ToInt32(split1[2]);

            int checkOutHour = Convert.ToInt32(split2[0]);
            int checkOutMinute = Convert.ToInt32(split2[1]);
            int checkOutSecond = Convert.ToInt32(split2[2]);

            if (dateTime1 > dateTime2)
            {
                MessageBox.Show("Time in must be lower than time out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dateTime1 == dateTime2)
            {
                MessageBox.Show("Time in must be not be equal to time out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ReceiptForm.checkInDate = new DateTime(checkInYear, checkInMonth, checkInDay, checkInHour, checkInMinute, checkInSecond);
            DateTime checkOutDate = new DateTime(checkInYear, checkInMonth, checkInDay, checkOutHour, checkOutMinute, checkOutSecond);

            if(ReceiptForm.checkInDate < DateTime.Now)
            {
                MessageBox.Show("Please reserve a time slot in the future.");
                return;
            }

            int numOfGuests;
            if (int.TryParse(textBox1.Text, out numOfGuests) && numOfGuests > 0)
            {
                Console.WriteLine("Valid input: " + numOfGuests);
            }
            else
            {
                MessageBox.Show("Please enter a positive integer value for the number of guests.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tablesNeeded = 0;
            for(int i = numOfGuests; i > 0; i-=numberOfGuestPerTable)
            {
                tablesNeeded++;
            }

            if (!(numberOfTables - checkAvailability(checkInDate, checkOutDate) >= tablesNeeded))
            {
                Console.WriteLine((numberOfTables - checkAvailability(checkInDate, checkOutDate)) + ">=" + tablesNeeded);
                MessageBox.Show("This time slot is fully occupied");
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

            string orders = "";

            foreach(FoodOrder order in MenuRestaurantFINAL.foodOrders)
            {
                orders += order.ToString();
            }

            Console.WriteLine(orders);

            //DateTime selectedTime = timePicker.Value;
            //string selectedTimeString = selectedTime.ToString("hh:mm tt", CultureInfo.InvariantCulture);

            ConfirmationReceiptForm confirmationReceiptForm = new ConfirmationReceiptForm("Dining");
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
                MessageBox.Show("The email you entered does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                string query = "INSERT INTO food_reservation (email, food_order, number_of_tables, reservation_date_in, reservation_date_out, card_number, date_of_booking, total_cost) " +
                               "VALUES (@Email, @FoodOrder, @NumberOfTables, @ReservationDateIn, @ReservationDateOut, @CardNumber, @DateOfBookiing, @TotalCost)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", HomeForm.currentEmail);
                    command.Parameters.AddWithValue("@FoodOrder", orders);
                    command.Parameters.AddWithValue("@NumberOfTables", tablesNeeded);
                    command.Parameters.AddWithValue("@ReservationDateIn", checkInDate);
                    command.Parameters.AddWithValue("@ReservationDateOut", checkOutDate);
                    command.Parameters.AddWithValue("@CardNumber", cardNumber);
                    command.Parameters.AddWithValue("@DateOfBookiing", DateTime.Now);
                    command.Parameters.AddWithValue("@TotalCost", ReceiptForm.total);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            this.Close();
        }

        public int checkAvailability(DateTime checkIn, DateTime checkOut)
        {
            int occupied = 0;

            using (SqlConnection conn = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT reservation_date_in, reservation_date_out, number_of_tables FROM food_reservation";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime din1 = (DateTime)reader["reservation_date_in"];
                        DateTime dout1 = (DateTime)reader["reservation_date_out"];
                        int numberOfTables = (int)reader["number_of_tables"];
                        DateTime din2 = checkIn;
                        DateTime dout2 = checkOut;
                        if (isOverlapping(din1, dout1, din2, dout2))
                        {
                            for(int i = 0; i < numberOfTables; i++)
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

        static bool isOverlapping(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            // If one range is completely before or after the other, there's no overlap
            if (end1 <= start2 || end2 <= start1)
                return false;

            // Otherwise, there's overlap
            return true;
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
