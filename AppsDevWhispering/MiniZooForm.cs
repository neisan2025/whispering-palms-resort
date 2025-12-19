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
    public partial class MiniZooForm : Form
    {
        public MiniZooForm()
        {
            InitializeComponent();
        }

        private void MiniZooForm_Load(object sender, EventArgs e)
        {
            LoginBtn.Parent = miniZooPic;
            LoginBtn.BackColor = Color.Transparent;

            homeBtn.Parent = miniZooPic;
            homeBtn.BackColor = Color.Transparent;

            roomsBtn.Parent = miniZooPic;
            roomsBtn.BackColor = Color.Transparent;

            diningBtn.Parent = miniZooPic;
            diningBtn.BackColor = Color.Transparent;

            experienceBtn.Parent = miniZooPic;
            experienceBtn.BackColor = Color.Transparent;

            activitiesBtn.Parent = miniZooPic;
            activitiesBtn.BackColor = Color.Transparent;

            ratingBtn.Parent = miniZooPic;
            ratingBtn.BackColor = Color.Transparent;

            bookBtn.Parent = miniZooPic;
            bookBtn.BackColor = Color.Transparent;

            button1.Parent = miniZooPic;
            button1.BackColor = Color.Transparent;
        }

        private void activitiesBtn_Click(object sender, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void deerPic_MouseEnter(object sender, EventArgs e)
        {
            deerPic.Image = Properties.Resources.deerEdit;
        }

        private void deerPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.deer;
        }

        private void monkeyPic_MouseEnter(object sender, EventArgs e)
        {
            monkeyPic.Image = Properties.Resources.monkeyEdit;
        }

        private void monkeyPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.monkey;
        }

        private void crocodilePic_MouseEnter(object sender, EventArgs e)
        {
            crocodilePic.Image = Properties.Resources.crocodileEdit;
        }

        private void crocodilePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.crocodile;
        }

        private void pigPic_MouseEnter(object sender, EventArgs e)
        {
            pigPic.Image = Properties.Resources.pigEdit;
        }

        private void pigPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.pig;
        }

        private void cacaduPic_MouseEnter(object sender, EventArgs e)
        {
            cacaduPic.Image = Properties.Resources.cacaduEdit;
        }

        private void cacaduPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.cacadu;
        }

        private void loriesPic_MouseEnter(object sender, EventArgs e)
        {
            loriesPic.Image = Properties.Resources.loriesEdit;
        }

        private void loriesPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.lories;
        }

        private void sanConurePic_MouseEnter(object sender, EventArgs e)
        {
            sanConurePic.Image = Properties.Resources.sunConureEdit;
        }

        private void sanConurePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.sunConure;
        }

        private void cockatielpic_MouseEnter(object sender, EventArgs e)
        {
            cockatielpic.Image = Properties.Resources.cockateilEdit;
        }

        private void cockatielpic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.cockateil;
        }

        private void loveBirdsPic_MouseEnter(object sender, EventArgs e)
        {
            loveBirdsPic.Image = Properties.Resources.loveBirdsEdit;
        }

        private void loveBirdsPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.loveBirds;
        }

        private void budgiePic_MouseEnter(object sender, EventArgs e)
        {
            budgiePic.Image = Properties.Resources.budgiesEdit;
        }

        private void budgiePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.budgies;
        }

        private void eduanaPic_MouseEnter(object sender, EventArgs e)
        {
            eduanaPic.Image = Properties.Resources.eguanaEdit;
        }

        private void eduanaPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.eguana;
        }

        private void snakePic_MouseEnter(object sender, EventArgs e)
        {
            snakePic.Image = Properties.Resources.snakeEdit;
        }

        private void snakePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.snake;
        }

        private void turtlePic_MouseEnter(object sender, EventArgs e)
        {
            turtlePic.Image = Properties.Resources.turtleEdit;
        }

        private void koiPic_MouseEnter(object sender, EventArgs e)
        {
            koiPic.Image = Properties.Resources.koiEdit;
        }

        private void koiPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.koi;
        }

        private void turtlePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.turtle;
        }

        private void feedMonkeyPic_MouseEnter(object sender, EventArgs e)
        {
            feedMonkeyPic.Image = Properties.Resources.feedMonkeyEdit;
        }

        private void feedMonkeyPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.feedMonkey;
        }

        private void feedBirdsPic_MouseEnter(object sender, EventArgs e)
        {
            feedBirdsPic.Image = Properties.Resources.feedBirdsEdit;

        }

        private void feedBirdsPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.feedBirds;
        }

        private void feedCrocodilePic_MouseEnter(object sender, EventArgs e)
        {
            feedCrocodilePic.Image = Properties.Resources.feedCrocodileEdit;
        }

        private void feedCrocodilePic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.feedCrocodile;
        }

        private void interactSnowbiPic_MouseEnter(object sender, EventArgs e)
        {
            interactSnowbiPic.Image = Properties.Resources.interactSnowbiEdit;
        }

        private void interactSnowbiPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.interactSnowbi;
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
            ProfileDashboardForm profile = new ProfileDashboardForm();
            this.Hide();
            profile.Show();
        }
    }
}
