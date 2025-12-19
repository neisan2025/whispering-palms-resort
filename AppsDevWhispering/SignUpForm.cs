using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class SignUpForm : Form
    {
        //DATABASE FUNCTIONS
        private string connectionString = HomeForm.connectionString;
        //END
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void signUpBackBtn_Click_1(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void signUpBackBtn_MouseEnter(object sender, EventArgs e)
        {
            signUpBackBtn.ForeColor = Color.White;
        }

        private void signUpBackBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBackBtn.ForeColor = Color.FromArgb(0x22A2E3);
        }

        //DATABASE 
        private void signUpLoginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameSignIn.Text.Trim();
            string email = emailSignIn.Text.Trim();
            string password = passwordSignIn.Text.Trim();
            bool valid = false;

            if(username == "" ||  email == "" || password == "")
            {
                MessageBox.Show("Fill all the fields.");
                return;
            }

            if (IsValidEmail(email))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("The email address is not valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(username.Length > 10)
            {
                MessageBox.Show("The username length must not exceed over 10 characters.");
                return;
            }

            if (valid)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO users (username, password, email, blocked) VALUES (@Username, @Password, @Email, @Blocked)";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Blocked", 0);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("User registered successfully!");
                            HomeForm.currentEmail = email;
                            userNameSignIn.Clear();
                            emailSignIn.Clear();
                            passwordSignIn.Clear();

                            HomeForm homeForm = new HomeForm();
                            homeForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email already exists");
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        //END
    }
}
