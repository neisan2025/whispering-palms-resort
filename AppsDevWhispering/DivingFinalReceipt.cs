using Org.BouncyCastle.Asn1.X509;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class DivingFinalReceipt : Form
    {
        string packages = "";
        string prices = "";

        public static string[] pack = new string[3];
        public static string[] pric = new string[3];

        public static string total = "";
        string cardNumber = "";

        public DivingFinalReceipt()
        {
            InitializeComponent();
            InitializeForm();
        }

        public DivingFinalReceipt(string package1Qnt, string package1FinalSubTotal, string package2Qnt, string package2FinalSubTotal, string package3Qnt, string package3FinalSubTotal, string overallFinalTotal)
        {
            int i = 0;
            InitializeComponent();
            InitializeForm();
            label14.Text = DivingReceipt.reservation.ToShortDateString();
            package1FinalQnt.Text = "";
            package1SubTotal.Text = "";
            packages = "";
            if (package1Qnt != "")
            {
                packages += package1Qnt + "\n";
                pack[i] = package1Qnt;
                pric[i] = package1FinalSubTotal;
                i++;
            }
            if (package2Qnt != "")
            {
                packages += package2Qnt + "\n";
                pack[i] = package2Qnt;
                pric[i] = package2FinalSubTotal;
                i++;
            }
            if (package3Qnt != "")
            {
                packages += package3Qnt + "\n";
                pack[i] = package3Qnt;
                pric[i] = package3FinalSubTotal;
                i++;
            }
            package1FinalQnt.Text = packages;

            prices = "";
            if (package1FinalSubTotal != "")
            {
                prices += package1FinalSubTotal + "\n";
            }
            if (package2FinalSubTotal != "")
            {
                prices += package2FinalSubTotal + "\n";
            }
            if (package3FinalSubTotal != "")
            {
                prices += package3FinalSubTotal + "\n";
            }
            package1SubTotal.Text = prices;

            divingoverallTotal.Text = overallFinalTotal;
            DivingFinalReceipt.total = overallFinalTotal;
        }

        private void DivingFinalReceipt_Load(object sender, EventArgs e)
        {

        }

        private void InitializeForm()
        {
            BackColor = Color.Green; // An uncommon color
            TransparencyKey = Color.Green;
            FormBorderStyle = FormBorderStyle.None; // Optional: Remove borders
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bookNowBtn_Click(object sender, EventArgs e)
        {
            if(packages == "")
            {
                MessageBox.Show("Please book a diving reservation.");
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

            this.Hide();
            //WaterSportsActivities waterSportsActivities = new WaterSportsActivities();
            //waterSportsActivities.Show();

            ConfirmationReceiptForm confirmationReceiptForm = new ConfirmationReceiptForm("Diving");
            confirmationReceiptForm.ShowDialog();

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

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                connection.Open();

                string query = "INSERT INTO diving_reservation (email, package, reservation_date, date_of_reservation, card_number, total) " +
                               "VALUES (@Email, @Package, @ReservationDate, @DateOfReservation, @CardNumber, @Total)";

                for (int i = 0; i < 3; i++)
                {
                    if (!string.IsNullOrEmpty(pack[i]) && !string.IsNullOrEmpty(pric[i]))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", HomeForm.currentEmail);
                        command.Parameters.AddWithValue("@Package", pack[i]);
                        command.Parameters.AddWithValue("@ReservationDate", DivingReceipt.reservation);
                        command.Parameters.AddWithValue("@DateOfReservation", DateTime.Now);
                        command.Parameters.AddWithValue("@CardNumber", cardNumber);
                        command.Parameters.AddWithValue("@Total", Convert.ToDouble(pric[i].Substring(1)));

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted for package {i + 1}.");
                    }
                }

                connection.Close();
            }
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
