using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class LoginForm : Form
    {
        //DATABASE FUNCTIONS
        private string connectionString = HomeForm.connectionString;
        //END
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBackBtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void loginSignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        //DATABASE
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = userEmailLoginText.Text;
            string password = userPasswordLoginText.Text;

            incorrectPasswordLabel.Text = "You have entered an invalid account. Please enter again.";
            incorrectPasswordLabel.Visible = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader["email"].ToString();
                        reader["password"].ToString();
                        if ((int)reader["blocked"] == 1)
                        {
                            MessageBox.Show("This user has been blocked.");
                            return;
                        }
                        MessageBox.Show("Authentication successful!");
                        HomeForm.currentEmail = email;
                        Console.WriteLine(email);
                        userEmailLoginText.Clear();
                        userPasswordLoginText.Clear();

                        HomeForm homeForm = new HomeForm();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        incorrectPasswordLabel.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured");
                }
            }
        }
        //END

        private void loginBackBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBackBtn.ForeColor = Color.White;
        }

        private void loginBackBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBackBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void loginAdminBtn_MouseEnter(object sender, EventArgs e)
        {
            loginAdminBtn.ForeColor = Color.FromArgb(0x3A69FF);
        }

        private void loginAdminBtn_MouseLeave(object sender, EventArgs e)
        {
            loginAdminBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        private void loginAdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
