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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace AppsDevWhispering
{
    public partial class UpdatesMainForm : Form
    {
        private readonly UpdatesForm updatesForm = new UpdatesForm();
        private readonly ReviewsForm reviewsForm = new ReviewsForm();
        public UpdatesMainForm()
        {
            InitializeComponent();

            string user = "";
            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT username, picture FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", HomeForm.currentEmail);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user = reader["username"].ToString();
                        byte[] imageData = (byte[])reader["picture"];
                        ProfilePicUpdates.Image = ByteArrayToImage(imageData);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (HomeForm.currentEmail == "")
            {
                UserNameUpdates.Text = "Guest";
            }
            else
            {
                UserNameUpdates.Text = user;
            }

            

        }

        private void UpdatesMainForm_Load(object sender, EventArgs e)
        {
            LoadForm(updatesForm);

            ReviewsBtn.Parent = LongPicUpdates;
            ReviewsBtn.BackColor = Color.Transparent;

            ProfilePicUpdates.Parent = LongPicUpdates;
            ProfilePicUpdates.BackColor = Color.Transparent;

            UserNameUpdates.Parent = LongPicUpdates;
            UserNameUpdates.BackColor = Color.Transparent;
        }

        public void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            updatesMainPanel.Controls.Clear();
            updatesMainPanel.Controls.Add(form);
            form.Show();
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void experienceBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void diningBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningForm = new DiningHomeForm();
            diningForm.Show();
            this.Hide();
        }

        private void updatesBtn_Click_1(object sender, EventArgs e)
        {
            LoadForm(updatesForm);
        }

        private void ReviewsBtn_Click_1(object sender, EventArgs e)
        {
            LoadForm(reviewsForm);
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
