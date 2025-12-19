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
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = ActivityPic;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = ActivityPic;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = ActivityPic;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = ActivityPic;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = ActivityPic;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = ActivityPic;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = ActivityPic;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = ActivityPic;
            bookBtn.BackColor = Color.Transparent;

            button1.Parent = ActivityPic;
            button1.BackColor = Color.Transparent;

        }

        /*private void discoverBtn(object sender, EventArgs e)
        {
        }
        */

        private void discoverBtn_Leave(object sender, EventArgs e)
        {
            discoverBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void discoverBtn_Enter(object sender, EventArgs e)
        {
            discoverBtn.ForeColor = Color.White;
        }

        private void discoverBtn2_MouseEnter(object sender, EventArgs e)
        {
            discoverBtn2.ForeColor = Color.White;
        }

        private void discoverBtn2_MouseLeave(object sender, EventArgs e)
        {
            discoverBtn2.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void discoverBtn3_MouseEnter(object sender, EventArgs e)
        {
            discoverBtn3.ForeColor = Color.White;
        }

        private void discoverBtn3_MouseLeave(object sender, EventArgs e)
        {
            discoverBtn3.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void discoverBtn2_Click(object sender, EventArgs e)
        {
            MiniZooForm miniZooForm = new MiniZooForm();
            miniZooForm.Show();
            this.Hide();
        }

        private void deerPic_MouseEnter(object sender, EventArgs e)
        {
            deerPic2.Image = Properties.Resources.deerEdit2;
        }

        private void deerPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.deer2;
        }

        private void monkeyPic_MouseEnter(object sender, EventArgs e)
        {
            monkeyPic2.Image = Properties.Resources.monkeyEdit2;
        }

        private void monkeyPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.monkey2;
        }

        private void crocodilePic_MouseEnter(object sender, EventArgs e)
        {
            crocodilePic2.Image = Properties.Resources.crocodileEdit2;
        }

        private void crocodilePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.crocodile2;
        }

        private void discoverBtn3_Click(object sender, EventArgs e)
        {
            WaterSportsActivities waterSportsActivities = new WaterSportsActivities();
            waterSportsActivities.Show();
            this.Hide();
        }

        private void discoverBtn_Click(object sender, EventArgs e)
        {
            LandActivities landActivities = new LandActivities();
            landActivities.Show();
            this.Hide();

        }
       
        private void golfPic_MouseEnter(object sender, EventArgs e)
        {
            golfPic.Image = Properties.Resources.newGolfEdit2;
        }

        private void golfPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.newGolf;
        }

        private void archeryPic_MouseEnter(object sender, EventArgs e)
        {
            archeryPic.Image = Properties.Resources.newArcheryEdit2;
        }

        private void archeryPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.newArchery;
        }

        private void bikingPic_MouseEnter(object sender, EventArgs e)
        {
            bikingPic.Image = Properties.Resources.newBikingEdit2;
        }

        private void bikingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.newBiking;
        }

        private void experienceBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void ratingBtn_Click(object sender, EventArgs e)
        {
            UpdatesMainForm updates = new UpdatesMainForm();
            updates.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void bookBtn_Click(object sender, EventArgs e)
        {
            CalendarForm bookForm = new CalendarForm();
            bookForm.Show();
            this.Hide();
        }

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

        private void bookNowBtn3_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
            this.Hide();
        }
    }
}
