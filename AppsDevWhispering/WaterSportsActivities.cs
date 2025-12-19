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
    public partial class WaterSportsActivities : Form
    {
        public WaterSportsActivities()
        {
            InitializeComponent();
        }

        private void WaterSportsActivities_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = waterSportsHome;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = waterSportsHome;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = waterSportsHome;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = waterSportsHome;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = waterSportsHome;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = waterSportsHome;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = waterSportsHome;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = waterSportsHome;
            bookBtn.BackColor = Color.Transparent;

            button1.Parent = waterSportsHome;
            button1.BackColor = Color.Transparent;
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void islandHoppingPic_MouseEnter(object sender, EventArgs e)
        {
            islandHoppingPic.Image = Properties.Resources.islandHoppingFinalEdit;
        }

        private void islandHoppingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.islandHoppingFinal;
        }

        private void snorkelingPic_MouseEnter(object sender, EventArgs e)
        {
            snorkelingPic.Image = Properties.Resources.snorklingFinalEdit;
        }

        private void snorkelingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.snorklingFinal;
        }

        private void kayakingPic_MouseEnter(object sender, EventArgs e)
        {
            kayakingPic.Image = Properties.Resources.kayakingFinalEdit;
        }

        private void kayakingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.kayakingFinal;
        }

        private void divingPic_MouseEnter(object sender, EventArgs e)
        {
            divingPic.Image = Properties.Resources.divingFinalEdit;
        }

        private void divingPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.divingFinal;
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1;
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2;
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3;
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void label32_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            divingPackage1Pic.Image = Properties.Resources.divingPackage1cover;
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void label38_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            divingPackage2Pic.Image = Properties.Resources.divingPackage2Cover;
        }

        private void label39_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void label41_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void label40_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void label43_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            divingPackage3Pic.Image = Properties.Resources.divingPackage3Cover;
        }

        private void package1Book_Click(object sender, EventArgs e)
        {
            DivingReceipt divingReceipt = new DivingReceipt();
            divingReceipt.Show();
            this.Hide();
        }

        private void package2Book_Click(object sender, EventArgs e)
        {
            DivingReceipt divingReceipt = new DivingReceipt();
            divingReceipt.Show();
            this.Hide();
        }

        private void package3Book_Click(object sender, EventArgs e)
        {
            DivingReceipt divingReceipt = new DivingReceipt();
            divingReceipt.Show();
            this.Hide();
        }

        private void pool1Pic_MouseEnter(object sender, EventArgs e)
        {
            pool1Pic.Image = Properties.Resources.pool1Edit;
        }

        private void pool1Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.pool1;
        }

        private void pool2Pic_MouseEnter(object sender, EventArgs e)
        {
            pool2Pic.Image = Properties.Resources.pool2Edit;
        }

        private void pool2Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.pool2;
        }

        private void pool3Pic_MouseEnter(object sender, EventArgs e)
        {
            pool3Pic.Image = Properties.Resources.pool3Edit;
        }

        private void pool3Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.pool3;
        }

        private void beachPic_MouseEnter(object sender, EventArgs e)
        {
            beachPic.Image = Properties.Resources.beachEdit;
        }

        private void beachPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.beach;
        }

        private void fivehousesPic_MouseEnter(object sender, EventArgs e)
        {
            fivehousesPic.Image = Properties.Resources.fiveHousesEdit;
        }

        private void fivehousesPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.fivehouses;
        }

        private void sipawayPic_MouseEnter(object sender, EventArgs e)
        {
            sipawayPic.Image = Properties.Resources.sipawayEdit;
        }

        private void sipawayPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.sipaway;
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

        private void diningBtn_Click(object sender, EventArgs e)
        {
            DiningHomeForm diningHomeForm = new DiningHomeForm();
            diningHomeForm.Show();
            this.Hide();
        }
    }
}
