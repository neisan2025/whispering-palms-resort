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
    public partial class DiningHomeForm : Form
    {

        public DiningHomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = pbDiningLayout;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = pbDiningLayout;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = pbDiningLayout;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = pbDiningLayout;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = pbDiningLayout;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = pbDiningLayout;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = pbDiningLayout;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = pbDiningLayout;
            bookBtn.BackColor = Color.Transparent;

            buttonUserProfileDashboard.Parent = pbDiningLayout;
            buttonUserProfileDashboard.BackColor = Color.Transparent;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            MenuRestaurantFINAL menuRestaurantFINAL = new MenuRestaurantFINAL();
            menuRestaurantFINAL.Show();
            this.Hide();
        }

        private void pbInternational_MouseEnter(object sender, EventArgs e)
        {
            pbInternational.Image = Properties.Resources.finalPlatterBlue;
        }

        private void pbInternational_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.finalInternational;
        }

        private void pbPizza_MouseEnter(object sender, EventArgs e)
        {
            pbPizza.Image = Properties.Resources.finalSnacksBlue;
        }

        private void pbPizza_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.finalPizza;
        }

        private void pbDessert_MouseEnter(object sender, EventArgs e)
        {
            pbDessert.Image = Properties.Resources.finalPorkBlue;
        }

        private void pbDessert_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.finalDesserts;
        }

        private void pbSizzlers_MouseEnter_1(object sender, EventArgs e)
        {
            pbSizzlers.Image = Properties.Resources.finalFishBlue;
        }

        private void pbSizzlers_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.finalSizzlers;
        }

        private void pbSpecials_MouseEnter(object sender, EventArgs e)
        {
            pbSpecials.Image = Properties.Resources.finalCocktailsBlue;
        }

        private void pbSpecials_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.finalSpecials;
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

        private void experienceBtn_Click(object sender, EventArgs e)
        {
            Experience experience = new Experience();
            experience.Show();
            this.Hide();
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activitiesForm = new ActivityForm();
            activitiesForm.Show();
            this.Hide();
        }

        private void ratingBtn_Click(object sender, EventArgs e)
        {
            UpdatesMainForm updatesMainForm = new UpdatesMainForm();
            updatesMainForm.Show();
            this.Hide();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            CalendarForm bookForm = new CalendarForm();
            bookForm.Show();
            this.Hide();
        }

        private void buttonUserProfileDashboard_Click(object sender, EventArgs e)
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
