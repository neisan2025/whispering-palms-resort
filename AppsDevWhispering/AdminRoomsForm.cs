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
    public partial class AdminRoomsForm : Form
    {
        //DATABASE
        private string connectionString = HomeForm.connectionString;
        private byte[] imageBytes = null;
        //END
        
        public AdminRoomsForm()
        {
            InitializeComponent();
            LoadImageButton.Visible = true;
            roomAvailabilityPic.Visible = false;
        }

        private void viewRoomBtn_Click(object sender, EventArgs e)
        {
            AdminViewRoomDetails viewRoomDetailsForm = new AdminViewRoomDetails();
            MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
            mainAdminForm.LoadForm(viewRoomDetailsForm);
        }


        //DATABASE
        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UploadImgPic.Image = Image.FromFile(openFileDialog.FileName);
                LoadImageButton.Visible = true;

                string filePath = openFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
                LoadImageButton.Visible = true;
            }
        }

        //DATABASE
        private void UploadRoomBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string roomType = TitleTextBox.Text;
                int numberOfRooms = Convert.ToInt32(roomNumberText.Text);
                decimal price = Convert.ToDecimal(PriceTextBox.Text);
                string maxCapacity = PersonsTextBox.Text;
                string numberOfBeds = RoomsTextBox.Text;
                string roomSize = RoomSizeTextBox.Text;
                string balcony = BalconyTextBox.Text;
                string smoking = SmokingTextBox.Text;
                string bathroom = BathTabTextBox.Text;
                string details = descriptionTextBox.Text;
                AddRoom(roomType, numberOfRooms, price, maxCapacity, numberOfBeds, roomSize, balcony, smoking, bathroom, imageBytes, details);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill in the fields correctly");
            }
        }
        //END



        //DATABASE
        public void AddRoom(string roomType, int numberOfRooms, decimal price, string maxCapacity, string numberOfBeds, string roomSize, string balcony, string smoking, string bathroom, byte[] picture, string details)
        {
            bool found = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM rooms WHERE room_type = @room_type";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@room_type", roomType);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader["room_type"].ToString();
                        MessageBox.Show("Room already existed!");
                    }
                    else
                    {
                        found = false;
                    }

                    reader.Close();

                    if (!found)
                    {
                        query = @"INSERT INTO rooms (room_type, number_of_rooms, price, max_capacity, number_of_beds, room_size, 
                             balcony, smoking, bathroom, picture, details) 
                             VALUES (@room_type, @number_of_rooms, @price, @max_capacity, @number_of_beds, @room_size, 
                             @balcony, @smoking, @bathroom, @picture, @details)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);

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
                                MessageBox.Show("Room added successfully.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Fill in the fields correctly");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured!");
                }

            }
        }

        private void viewRoom_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
        }

        private void viewBooking_Click(object sender, EventArgs e)
        {
            AvailableRooms availableRooms = new AvailableRooms();
            availableRooms.Show();
        }
        //END
    }
}
