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
    public partial class RoomsForm : Form
    {
        //DATABASE
        private string connectionString = HomeForm.connectionString;
        //END
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            loginBtn.Parent = pictureBox1;
            loginBtn.BackColor = Color.Transparent;
            bookBtn.Parent = pictureBox1;
            bookBtn.BackColor = Color.Transparent;
            homeBtn.Parent = pictureBox1;
            homeBtn.BackColor = Color.Transparent;
            roomsBtn.Parent = pictureBox1;
            roomsBtn.BackColor = Color.Transparent;
            diningBtn.Parent = pictureBox1;
            diningBtn.BackColor = Color.Transparent;
            experienceBtn.Parent = pictureBox1;
            experienceBtn.BackColor = Color.Transparent;
            activitiesBtn.Parent = pictureBox1;
            activitiesBtn.BackColor = Color.Transparent;
            updatesBtn.Parent = pictureBox1;
            updatesBtn.BackColor = Color.Transparent;
            button1.Parent = pictureBox1;
            button1.BackColor = Color.Transparent;

            //DATABASE
            pricePictureBox.Visible = false;
            personsPictureBox.Visible = false;

            ReadRoom(pricePictureBox.Image, personsPictureBox.Image);
            //END
        }

        public void AddRoomPanelToFlowLayout(string title, string description, string price, string roomPersons, Image roomImage, Image pricePic, Image personsPic)
        {
            // Create a new panel for each room
            Panel roomPanel = new Panel();
            roomPanel.BackColor = Color.LightGray;
            roomPanel.BorderStyle = BorderStyle.FixedSingle;
            roomPanel.Width = 1190;
            roomPanel.Height = 460;
            roomPanel.BackColor = Color.White;

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Width = 590;
            titleLabel.Height = 50;
            titleLabel.Font = new Font("Proxima Nova", 30, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(100, 92, 92);
            titleLabel.AutoSize = false;

            PictureBox roomPictureBox = new PictureBox();
            roomPictureBox.Width = 500;
            roomPictureBox.Height = 420;
            roomPictureBox.Image = roomImage;
            roomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox priceImage = new PictureBox();
            priceImage.Width = 40;
            priceImage.Height = 30;
            priceImage.Image = pricePic;
            priceImage.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox personsImage = new PictureBox();
            personsImage.Width = 40;
            personsImage.Height = 37;
            personsImage.Image = personsPic;
            personsImage.SizeMode = PictureBoxSizeMode.StretchImage;


            int maxWidth = 580;
            int maxHeight = 150;
            Label descriptionLabel = new Label();
            descriptionLabel.Text = description;
            descriptionLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            descriptionLabel.ForeColor = Color.FromArgb(100, 92, 92);
            descriptionLabel.AutoSize = false;
            descriptionLabel.Width = maxWidth;
            descriptionLabel.Height = maxHeight;

            Label priceLabel = new Label();
            decimal formatted = decimal.Parse(price);
            priceLabel.Text = "₱" + formatted.ToString("N2");
            priceLabel.Width = 400;
            priceLabel.Height = 28;
            priceLabel.Font = new Font("Proxima Nova", 20, FontStyle.Bold);
            priceLabel.ForeColor = Color.DeepSkyBlue;
            priceLabel.AutoSize = false;

            Label personsLabel = new Label();
            personsLabel.Text = roomPersons;
            personsLabel.Width = 200;
            personsLabel.Height = 52;
            personsLabel.Font = new Font("Proxima Nova", 14, FontStyle.Regular);
            personsLabel.ForeColor = Color.FromArgb(100, 92, 92);
            personsLabel.AutoSize = false;

            int paddingAtTop = 20;
            int paddingTitle = 40;
            roomPictureBox.Location = new Point(20, paddingAtTop);
            titleLabel.Location = new Point(roomPictureBox.Right + 46, paddingTitle);
            descriptionLabel.Location = new Point(roomPictureBox.Right + 50, titleLabel.Top + 60);

            personsImage.Location = new Point(roomPictureBox.Right + 50, descriptionLabel.Bottom + 10);
            priceImage.Location = new Point(roomPictureBox.Right + 250, descriptionLabel.Bottom + 10);

            personsLabel.Location = new Point(roomPictureBox.Right + 50, personsImage.Bottom + 10);
            priceLabel.Location = new Point(roomPictureBox.Right + 250, priceImage.Bottom + 15);

            Button bookButton = new Button();
            bookButton.Text = "Book Now";
            bookButton.Width = 230;
            bookButton.Height = 58;
            bookButton.AutoSize = true;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Font = new Font("Proxima Nova", 15, FontStyle.Bold);
            bookButton.Padding = new Padding(10, 5, 10, 5);
            bookButton.ForeColor = Color.White;
            bookButton.BackColor = Color.DeepSkyBlue;

            /*
            Button discoverBtn = new Button();
            discoverBtn.Text = "Discover";
            bookButton.Width = 230;
            bookButton.Height = 58;
            discoverBtn.AutoSize = true;
            discoverBtn.FlatStyle = FlatStyle.Flat;
            discoverBtn.FlatAppearance.BorderSize = 0;
            discoverBtn.Font = new Font("Proxima Nova", 14, FontStyle.Bold);
            discoverBtn.Padding = new Padding(30, 8, 30, 8);
            discoverBtn.ForeColor = Color.DeepSkyBlue;
            discoverBtn.BackColor = Color.White;
            */

            bookButton.Click += (sender, e) =>
            {
                // Create and show the CalendarForm
                CalendarForm calendarForm = new CalendarForm();
                calendarForm.Show();
                this.Hide();
            };

            /*// Event handler for the discoverBtn
            discoverBtn.Click += (sender, e) =>
            {
                // Create and show the RoomsForm
                RoomsForm roomsForm = new RoomsForm();
                roomsForm.Show();
                this.Hide();
            };
            */

            Label lineLabel = new Label();
            lineLabel.Text = "━━━━━━━━━━";
            lineLabel.Font = new Font("Proxima Nova", 16, FontStyle.Regular);
            lineLabel.ForeColor = Color.DeepSkyBlue;
            lineLabel.AutoSize = true;

            //int buttonY = titleLabel.Bottom + 300;
            bookButton.Location = new Point(roomPictureBox.Right + 400, priceLabel.Bottom + 50);
            //discoverBtn.Location = new Point(roomPictureBox.Right + 218, priceLabel.Bottom + 53);
            //lineLabel.Location = new Point(roomPictureBox.Right + 250, discoverBtn.Bottom + 15);

            // Add the button to the room panel
            roomPanel.Controls.Add(titleLabel);
            roomPanel.Controls.Add(roomPictureBox);
            roomPanel.Controls.Add(descriptionLabel);
            roomPanel.Controls.Add(priceImage);
            roomPanel.Controls.Add(personsImage);
            roomPanel.Controls.Add(priceLabel);
            roomPanel.Controls.Add(personsLabel);
            roomPanel.Controls.Add(bookButton);
            roomPanel.Controls.Add(bookButton);
            //roomPanel.Controls.Add(discoverBtn);
            roomPanel.Controls.Add(lineLabel);
            RoomsFlowLayoutHome.Controls.Add(roomPanel);
        }

        private void diningBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningHomeForm = new DiningHomeForm();
            diningHomeForm.Show();
            this.Close();

        }

        private void experienceBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            CalendarForm bookForm = new CalendarForm();
            bookForm.Show();
            this.Hide();
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activitiesForm = new ActivityForm();
            activitiesForm.Show();
            this.Hide();
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            UpdatesMainForm updatesMainForm = new UpdatesMainForm();
            updatesMainForm.Show();
            this.Hide();
        }

        //DATABASE
        public void ReadRoom(Image pricePic, Image personsPic)
        {
            string query = "SELECT room_type, price, max_capacity, number_of_beds, balcony, smoking, bathroom, picture, details FROM rooms";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string roomType = reader["room_type"].ToString();
                        string price = reader["price"].ToString();
                        string max_capacity = reader["max_capacity"].ToString();
                        string number_of_beds = reader["number_of_beds"].ToString();
                        string balcony = reader["balcony"].ToString();
                        string smoking = reader["smoking"].ToString();
                        string bathroom = reader["bathroom"].ToString();

                        Image roomImage = null;
                        byte[] imageData = (byte[])reader["picture"];
                        roomImage = ByteArrayToImage(imageData);

                        string details = reader["details"].ToString();

                        AddRoomPanelToFlowLayout(roomType, details, price, max_capacity, roomImage, pricePic, personsPic);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
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
        //END

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(HomeForm.currentEmail == ""))
            {
                ProfileDashboardForm profile = new ProfileDashboardForm();
                this.Hide();
                profile.Show();
            }
            else
            {
                MessageBox.Show("You must log in!");
            }
        }
        
    }
}
