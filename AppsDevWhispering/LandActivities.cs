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
    public partial class LandActivities : Form
    {
        public LandActivities()
        {
            InitializeComponent();
        }

        private void LandActivities_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = LandActivitiesHome;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = LandActivitiesHome;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = LandActivitiesHome;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = LandActivitiesHome;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = LandActivitiesHome;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = LandActivitiesHome;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = LandActivitiesHome;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = LandActivitiesHome;
            bookBtn.BackColor = Color.Transparent;

            button1.Parent = LandActivitiesHome;
            button1.BackColor = Color.Transparent;
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void volleyballPic_MouseEnter(object sender, EventArgs e)
        {
            volleyballPic.Image = Properties.Resources.volleyballEdit;
        }

        private void volleyballPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.volleyball;
        }

        private void PingPongPic_MouseEnter(object sender, EventArgs e)
        {
            PingPongPic.Image = Properties.Resources.pingpongEdit;

        }

        private void PingPongPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.pingpong;
        }

        private void BilliardsPic_MouseEnter(object sender, EventArgs e)
        {
            BilliardsPic.Image = Properties.Resources.billiardsEdit;
        }

        private void BilliardsPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.billiards;
        }

        private void BikingPic_MouseEnter(object sender, EventArgs e)
        {
            BikingPic.Image = Properties.Resources.bikingEdit;
        }

        private void BikingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.biking;
        }

        private void BadmintonPic_MouseEnter(object sender, EventArgs e)
        {
            BadmintonPic.Image = Properties.Resources.badmintonEdit;
        }

        private void BadmintonPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.badminton;
        }

        private void MiniGolfPic_MouseEnter(object sender, EventArgs e)
        {
            MiniGolfPic.Image = Properties.Resources.minigolfEdit;
        }

        private void MiniGolfPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.minigolf;
        }

        private void ArcheryPic_MouseEnter(object sender, EventArgs e)
        {
            ArcheryPic.Image = Properties.Resources.archeryEdit;
        }

        private void ArcheryPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.archery;
        }

        private void playgroundPic_MouseEnter(object sender, EventArgs e)
        {
            playgroundPic.Image = Properties.Resources.playgroundEdit;
        }

        private void playgroundPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.playground;
        }

        private void firedancePic_MouseEnter(object sender, EventArgs e)
        {
            firedancePic.Image = Properties.Resources.firedanceEdit;
        }

        private void firedancePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.firedance;
        }

        private void gymPic_MouseEnter(object sender, EventArgs e)
        {
            gymPic.Image = Properties.Resources.gymEdit;
        }

        private void gymPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.gym;
        }

        private void chessPic_MouseEnter(object sender, EventArgs e)
        {
            chessPic.Image = Properties.Resources.chessEdit;
        }

        private void chessPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.chess;
        }

        private void dartsPic_MouseEnter(object sender, EventArgs e)
        {
            dartsPic.Image = Properties.Resources.dartsEdit;
        }

        private void dartsPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.darts;
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
