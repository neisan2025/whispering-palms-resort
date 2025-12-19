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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            string email = adminUserName.Text;
            string password = adminPassword.Text;

            //incorrectPasswordLabel.Text = "You have entered an invalid account. Please enter again.";
            //incorrectPasswordLabel.Visible = false;

            if (email == ".\\admin" && password == "admin")
            {
                HomeForm.currentEmail = ".\\admin";

                MainAdminForm mainAdminForm = new MainAdminForm();
                mainAdminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials.");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            backBtn.Parent = loginPic;
            backBtn.BackColor = Color.Transparent;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
