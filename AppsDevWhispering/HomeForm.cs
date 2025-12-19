using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class HomeForm : Form
    {
        //DATABASE
        public static string connectionString = "Data Source=LAPTOP-8MROJAEH\\SQLEXPRESS;Initial Catalog=WhisperingPalmsResort;Integrated Security=True;Encrypt=False";
        public static string currentEmail = "";
        //END

        private static bool hasAnimationPlayed = false;
        public HomeForm()
        {
            InitializeComponent();
            this.Shown += new EventHandler(HomeForm_Shown);

        }
        private void HomeForm_Shown(object sender, EventArgs e)
        {
            if (!hasAnimationPlayed)
            {
                this.Hide();
                using (IntroAnimation introAnimation = new IntroAnimation())
                {
                    introAnimation.ShowDialog();
                }
                hasAnimationPlayed = true;

                this.Show();
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loginBtn.Parent = homePicture;
            loginBtn.BackColor = Color.Transparent;
            bookBtn.Parent = homePicture;
            bookBtn.BackColor = Color.Transparent;
            homeBtn.Parent = homePicture;
            homeBtn.BackColor = Color.Transparent;
            roomsBtn.Parent = homePicture;
            roomsBtn.BackColor = Color.Transparent;
            diningBtn.Parent = homePicture;
            diningBtn.BackColor = Color.Transparent;
            experienceBtn.Parent = homePicture;
            experienceBtn.BackColor = Color.Transparent;
            activitiesBtn.Parent = homePicture;
            activitiesBtn.BackColor = Color.Transparent;
            updatesBtn.Parent = homePicture;
            updatesBtn.BackColor = Color.Transparent;
            button1.Parent = homePicture;
            button1.BackColor = Color.Transparent;
        }
        private void swimmingPic_MouseEnter(object sender, EventArgs e)
        {
            swimmingPic.Image = Properties.Resources.swimmingPoolEdit;
        }

        private void swimmingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.swimmingPool;
        }

        private void fiveHousePic_MouseEnter(object sender, EventArgs e)
        {
            fiveHousePic.Image = Properties.Resources.fiveHouseEdit;
        }

        private void fiveHousePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.fiveHouse;
        }

        private void divingPic_MouseEnter(object sender, EventArgs e)
        {
            divingPic.Image = Properties.Resources.divingEdit;
        }

        private void divingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.diving;
        }

        private void bungalowPic_MouseEnter(object sender, EventArgs e)
        {
            bungalowPic.Image = Properties.Resources.bungalowEdit;
        }

        private void bungalowPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.bungalow;
        }

        private void standardRoomPic_MouseEnter(object sender, EventArgs e)
        {
            standardRoomPic.Image = Properties.Resources.standardRoomEdit;
        }

        private void standardRoomPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.standardRoom;
        }

        private void treeHousePic_MouseEnter(object sender, EventArgs e)
        {
            treeHousePic.Image = Properties.Resources.treeHouseEdit;
        }

        private void treeHousePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.treeHouse;
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void discoverRoomBtn_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            discoverExBtn.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            discoverExBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void discoverRoomBtn_MouseEnter(object sender, EventArgs e)
        {
            discoverRoomBtn.ForeColor = Color.White;
        }

        private void discoverRoomBtn_MouseLeave(object sender, EventArgs e)
        {
            discoverRoomBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
            this.Hide();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
            this.Hide();
        }

        private void experienceBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            UpdatesMainForm updatesMainForm = new UpdatesMainForm();
            updatesMainForm.Show();
            this.Hide();
        }

        private void discoverExBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void diningBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningHomeForm = new DiningHomeForm();
            diningHomeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(HomeForm.currentEmail == ""))
            {
                ProfileDashboardForm profile = new ProfileDashboardForm();
                this.Hide();
                profile.Show();
            } else
            {
                MessageBox.Show("You must log in!");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
