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
    public partial class ChangePasswordForm : Form
    {
        private ProfileDashboardForm profileDashboardForm;

        public ChangePasswordForm(ProfileDashboardForm profileDashboardForm)
        {
            InitializeComponent();
            this.profileDashboardForm = profileDashboardForm;
        }

        private void buttonConfirmPass_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPass.Text;
            if (currentPass != ProfileDashboardForm.password) 
            {
                MessageBox.Show("Your current password is incorrect");
                return;
            }

            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            if(newPass != confirmPass)
            {
                MessageBox.Show("Your new password do not match");
                return;
            }
            else
            {
                UpdatePassword();
                ProfileDashboardForm.password = newPass;
            }

            UpdatedPasswordForm updatedPasswordForm = new UpdatedPasswordForm(currentPass, newPass, confirmPass);
            profileDashboardForm.LoadForm(updatedPasswordForm);
        }

        private void UpdatePassword()
        {
            using (SqlConnection conn = new SqlConnection(HomeForm.connectionString))
            {
                string query = "UPDATE users SET password = @Password WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", ProfileDashboardForm.email);
                cmd.Parameters.AddWithValue("@Password", txtConfirmPass.Text);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
