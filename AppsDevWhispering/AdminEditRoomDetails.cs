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
    public partial class AdminEditRoomDetails : Form
    {
        //DATABASE
        private string connectionString = HomeForm.connectionString;
        private byte[] imageBytes = null;
        private int rowNumber = -1;
        //END

        public AdminEditRoomDetails(int rowNumber)
        {
            InitializeComponent();
            Console.WriteLine(rowNumber.ToString());
            this.rowNumber = rowNumber;
            ReadRoom(rowNumber);
            roomAvailabilityPic.Visible = false;
            pricePictureBox.Visible = false;
            personsPictureBox.Visible = false;
        }

        private void importPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RoomImgPic.Image = Image.FromFile(openFileDialog.FileName);
                importPicBtn.Visible = true;
            }
        }

        private void EditRoomDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //DATABASE
        public void ReadRoom(int rowNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM rooms WHERE room_id = @room_id";
                    SqlCommand cmd;
                    SqlDataReader reader;

                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@room_id", rowNumber);
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            roomIDText.Text = reader["room_id"].ToString();
                            RoomTypeTextBox.Text = reader["room_type"].ToString();
                            roomNumberText.Text = reader["number_of_rooms"].ToString();
                            RoomPriceTextBox.Text = reader["price"].ToString();
                            PersonsTextBox.Text = reader["max_capacity"].ToString();
                            BedsTextBox.Text = reader["number_of_beds"].ToString();
                            RoomSizeTextBox.Text = reader["room_size"].ToString();
                            BalconyTextBox.Text = reader["balcony"].ToString();
                            SmokingTextBox.Text = reader["smoking"].ToString();
                            BathTabTextBox.Text = reader["bathroom"].ToString();


                            //Image
                            Image roomImage = null;
                            byte[] imageData = (byte[])reader["picture"];
                            RoomImgPic.Image = ByteArrayToImage(imageData);

                            descriptionTextBox.Text = reader["details"].ToString();
                        }
                        else
                        {
                        Console.WriteLine("Room not found!");
                        }
                        reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured!");
                }
            }
        }

        public void UpdateRoom(int rowNumber, string roomType, int numberOfRooms, decimal price, string maxCapacity, string numberOfBeds, string roomSize, string balcony, string smoking, string bathroom, byte[] picture, string details)
        {
            string query = "UPDATE rooms SET room_type = @room_type, number_of_rooms = @number_of_rooms, price = @price, max_capacity = @max_capacity, number_of_beds = @number_of_beds, room_size = @room_size, balcony = @balcony, smoking = @smoking, bathroom = @bathroom, picture = @picture, details = @details WHERE room_id = @room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@room_id", rowNumber);
                command.Parameters.AddWithValue("@room_type", roomType);
                command.Parameters.AddWithValue("@number_of_rooms", numberOfRooms);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@max_capacity", maxCapacity);
                command.Parameters.AddWithValue("@number_of_beds", numberOfBeds);
                command.Parameters.AddWithValue("@room_size", roomSize);
                command.Parameters.AddWithValue("@balcony", balcony);
                command.Parameters.AddWithValue("@smoking", smoking);
                command.Parameters.AddWithValue("@bathroom", bathroom);
                command.Parameters.AddWithValue("@picture", picture);
                command.Parameters.AddWithValue("@details", details);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Room updated successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private void DeleteRoom(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Rooms WHERE room_id = @RoomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", roomId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room deleted successfully.");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Room with the specified ID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete room since there are reservations.");
                    }
                }
            }
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void UpdateRoomBTN_Click(object sender, EventArgs e)
        {
            string roomType = RoomTypeTextBox.Text;
            int numberOfRooms = Convert.ToInt32(roomNumberText.Text);
            decimal price = Convert.ToDecimal(RoomPriceTextBox.Text);
            string maxCapacity = PersonsTextBox.Text;
            string numberOfBeds = BedsTextBox.Text;
            string roomSize = RoomSizeTextBox.Text;
            string balcony = BalconyTextBox.Text;
            string smoking = SmokingTextBox.Text;
            string bathroom = BathTabTextBox.Text;
            byte[] picture = ImagetoByteArray();
            string details = descriptionTextBox.Text;

            UpdateRoom(this.rowNumber, roomType, numberOfRooms, price, maxCapacity, numberOfBeds, roomSize, balcony, smoking, bathroom, picture, details);
        }

        private void importPicBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RoomImgPic.Image = Image.FromFile(openFileDialog.FileName);

                string filePath = openFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
            }
        }

        private byte[] ImagetoByteArray()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    RoomImgPic.Image.Save(ms, RoomImgPic.Image.RawFormat);
                    return ms.ToArray();
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }

        private void DeleteRoomBtn_Click(object sender, EventArgs e)
        {
            DeleteRoom(this.rowNumber);
        }
        //END
    }
}
