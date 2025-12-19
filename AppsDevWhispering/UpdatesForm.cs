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
    public partial class UpdatesForm : Form
    {
        public UpdatesForm()
        {
            InitializeComponent();
            LoadUpdates();
        }

        public void AddRoomPanelToFlowLayout(string title, string description, Image image, Image logoImage, DateTime date)
        {
            // Create a new panel for each room
            Panel roomPanel = new Panel();
            roomPanel.BackColor = Color.White;
            roomPanel.BorderStyle = BorderStyle.None;
            roomPanel.Width = 920;

            // PictureBox for room image
            PictureBox roomPictureBox = new PictureBox();
            roomPictureBox.Width = 400;
            roomPictureBox.Height = 260;
            roomPictureBox.Image = image;
            roomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // PictureBox for logo
            PictureBox logoPictureBox = new PictureBox();
            logoPictureBox.Width = 172;
            logoPictureBox.Height = 40;
            logoPictureBox.Image = logoImage;

            // Label for current date
            Label currentDateLabel = new Label();
            currentDateLabel.Text = date.ToShortDateString();
            currentDateLabel.Font = new Font("Proxima Nova", 10, FontStyle.Regular);
            currentDateLabel.ForeColor = Color.FromArgb(100, 92, 92);
            currentDateLabel.AutoSize = true;

            // Calculate the position of currentDateLabel
            int currentDateLabelX = logoPictureBox.Right + 630; // Place it to the right of logoPictureBox
            int currentDateLabelY = logoPictureBox.Top + 30;

            currentDateLabel.Location = new Point(currentDateLabelX, currentDateLabelY);

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Proxima Nova", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(100, 92, 92);
            titleLabel.AutoSize = false;
            titleLabel.MaximumSize = new Size(418, 0); // Limit the width to 418
            titleLabel.Width = 418; // Set the initial width
            titleLabel.Height = (int)titleLabel.CreateGraphics().MeasureString(titleLabel.Text, titleLabel.Font, titleLabel.Width).Height; // Calculate the height based on the content

            Label descriptionLabel = new Label();
            descriptionLabel.Text = description;
            descriptionLabel.Font = new Font("Proxima Nova", 12, FontStyle.Regular);
            descriptionLabel.ForeColor = Color.FromArgb(100, 92, 92);
            descriptionLabel.AutoSize = false;
            descriptionLabel.MaximumSize = new Size(418, int.MaxValue); // Allow unlimited width and height
            descriptionLabel.Width = 418; // Set the initial width

            Size preferredSize = descriptionLabel.PreferredSize;
            descriptionLabel.Size = preferredSize;

            logoPictureBox.Location = new Point(40, 20); // Adjust the location as needed
            roomPictureBox.Location = new Point(40, logoPictureBox.Bottom + 15); // Adjust the location as needed
            titleLabel.Location = new Point(roomPictureBox.Right + 30, roomPictureBox.Top);
            descriptionLabel.Location = new Point(roomPictureBox.Right + 30, titleLabel.Bottom + 10); // Place description label below title label

            int bottomPosition = Math.Max(roomPictureBox.Bottom, descriptionLabel.Bottom);
            roomPanel.Height = bottomPosition + 30;

            roomPanel.Controls.Add(logoPictureBox);
            roomPanel.Controls.Add(roomPictureBox);
            roomPanel.Controls.Add(titleLabel);
            roomPanel.Controls.Add(descriptionLabel);

            roomPanel.Controls.Add(currentDateLabel);

            FinalRoomsFlowLayout.Controls.Add(roomPanel);
        }

        private void LoadUpdates()
        {
            string selectQuery = "SELECT * FROM updates ORDER BY posted DESC";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string title = reader["title"].ToString();
                        string description = reader["body"].ToString();
                        DateTime date = (DateTime)reader["posted"];
                        byte[] imageBytes = (byte[])reader["picture"];
                        Image image = ByteArrayToImage(imageBytes);

                        AddRoomPanelToFlowLayout(title, description, image, whisperingLogoPanel.Image, date);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
    }
}