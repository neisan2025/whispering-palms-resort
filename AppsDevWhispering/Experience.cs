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
    public partial class Experience : Form
    {
        public Experience()
        {
            InitializeComponent();
        }

        private void Experience_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = ExperienceHomePic;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = ExperienceHomePic;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = ExperienceHomePic;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = ExperienceHomePic;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = ExperienceHomePic;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = ExperienceHomePic;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = ExperienceHomePic;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = ExperienceHomePic;
            bookBtn.BackColor = Color.Transparent;

            button1.Parent = ExperienceHomePic;
            button1.BackColor = Color.Transparent;
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void BeachEXPPic_MouseEnter(object sender, EventArgs e)
        {
            BeachEXPPic.Image = Properties.Resources.Beach2EXP;
        }

        private void BeachEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.BeachEXP;
        }

        private void WatchTowerEXPPic_MouseEnter(object sender, EventArgs e)
        {
            WatchTowerEXPPic.Image = Properties.Resources.WatchTower2EXP;
        }

        private void WatchTowerEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.WatchTowerEXPnew;
        }

        private void SpaExpPic_MouseEnter(object sender, EventArgs e)
        {
            SpaExpPic.Image = Properties.Resources.Spa2EXP;
        }

        private void SpaExpPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.SpaEXP;
        }

        private void RestaurantEXPPic_MouseEnter(object sender, EventArgs e)
        {
            RestaurantEXPPic.Image = Properties.Resources.Restaurant2EXP;
        }

        private void RestaurantEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.RestaurantEXP;
        }

        private void MIniZooEXPPic_MouseEnter(object sender, EventArgs e)
        {
            MIniZooEXPPic.Image = Properties.Resources.MiniZoo2EXP;
        }

        private void MIniZooEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.MiniZooEXP;
        }

        private void ActivitiesEXPPic_MouseEnter(object sender, EventArgs e)
        {
            ActivitiesEXPPic.Image = Properties.Resources.Activities2EXP;
        }

        private void ActivitiesEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.ActivitiesEXP;
        }

        private void DivingEXPPic_MouseEnter(object sender, EventArgs e)
        {
            DivingEXPPic.Image = Properties.Resources.Diving2EXP;
        }

        private void DivingEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.DivingEXP;
        }

        private void RoomsEXPPic_MouseEnter(object sender, EventArgs e)
        {
            RoomsEXPPic.Image = Properties.Resources.Rooms2EXP;
        }

        private void RoomsEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.RoomsEXP;
        }

        private void MiniBarEXPPic_MouseEnter(object sender, EventArgs e)
        {
            MiniBarEXPPic.Image = Properties.Resources.MiniBar2EXP;
        }

        private void MiniBarEXPPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.MiniBarEXP;
        }

        private void RestaurantEXPBtn_MouseEnter(object sender, EventArgs e)
        {
            RestaurantEXPBtn.ForeColor = Color.White;
        }

        private void RestaurantEXPBtn_MouseLeave(object sender, EventArgs e)
        {
            RestaurantEXPBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void MiniZooEXPbtn_MouseEnter(object sender, EventArgs e)
        {
            MiniZooEXPbtn.ForeColor = Color.White;
        }

        private void MiniZooEXPbtn_MouseLeave(object sender, EventArgs e)
        {
            MiniZooEXPbtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void ActivitiesEXPbtn_MouseEnter(object sender, EventArgs e)
        {
            ActivitiesEXPbtn.ForeColor = Color.White;
        }

        private void ActivitiesEXPbtn_MouseLeave(object sender, EventArgs e)
        {
            ActivitiesEXPbtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void divingEXPbtn_MouseEnter(object sender, EventArgs e)
        {
            divingEXPbtn.ForeColor = Color.White;
        }

        private void divingEXPbtn_MouseLeave(object sender, EventArgs e)
        {
            divingEXPbtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void RoomsEXPbtn_MouseEnter(object sender, EventArgs e)
        {
            RoomsEXPbtn.ForeColor = Color.White;
        }

        private void RoomsEXPbtn_MouseLeave(object sender, EventArgs e)
        {
            RoomsEXPbtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void MiniBarEXPbtn_MouseEnter(object sender, EventArgs e)
        {
            MiniBarEXPbtn.ForeColor = Color.White;

        }

        private void MiniBarEXPbtn_MouseLeave(object sender, EventArgs e)
        {
            MiniBarEXPbtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void MiniZooEXPbtn_Click(object sender, EventArgs e)
        {
            MiniZooForm miniZooForm = new MiniZooForm();
            miniZooForm.Show();
            this.Hide();
        }

        private void ActivitiesEXPbtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();

        }

        private void divingEXPbtn_Click(object sender, EventArgs e)
        {
            WaterSportsActivities waterSportsActivities = new WaterSportsActivities();
            waterSportsActivities.Show();
            this.Hide();
        }

        private void ratingBtn_Click(object sender, EventArgs e)
        {
            UpdatesMainForm updates = new UpdatesMainForm();
            updates.Show();
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void diningBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningHomeForm = new DiningHomeForm();
            diningHomeForm.Show();
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

        private void RestaurantEXPBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningHomeForm=new DiningHomeForm();
            diningHomeForm.Show();
            this.Hide();
        }

        private void RoomsEXPbtn_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void MiniBarEXPbtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm bookForm = new DiningHomeForm();
            bookForm.Show();
            this.Hide();
        }
    }
}
