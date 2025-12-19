using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppsDevWhispering
{
    public partial class EditInformationForm : Form
    {
        private ProfileDashboardForm profileDashboardForm;

        public EditInformationForm(ProfileDashboardForm profileDashboardForm)
        {
            InitializeComponent();
            this.profileDashboardForm = profileDashboardForm;
            txtFirstName.Text = ProfileDashboardForm.firstName;
            txtLastName.Text = ProfileDashboardForm.lastName;
            txtDisplayName.Text = ProfileDashboardForm.displayName;
            txtEmail.Text = ProfileDashboardForm.email;
            txtContact.Text = ProfileDashboardForm.contact;
        }

        private void buttonConfirmInfo_Click(object sender, EventArgs e)
        {
            ProfileDashboardForm.firstName = txtFirstName.Text.Trim();
            ProfileDashboardForm.lastName = txtLastName.Text.Trim();
            ProfileDashboardForm.displayName = txtDisplayName.Text.Trim();
            ProfileDashboardForm.email = txtEmail.Text.Trim();
            ProfileDashboardForm.contact = txtContact.Text.Trim();

            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtDisplayName.Text == "" || txtEmail.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            if(!ProfileDashboardForm.contact.All(char.IsDigit))
            {
                MessageBox.Show("Contact information invalid. Remove any spaces if there any, and all characters must contain numbers");
                return;
            }

            if (txtDisplayName.Text.Length > 10)
            {
                MessageBox.Show("The username/display name length must not exceed over 10 characters.");
                return;
            }

            UpdateUser();

            profileDashboardForm.UpdateProfileInformation(ProfileDashboardForm.firstName, ProfileDashboardForm.lastName, ProfileDashboardForm.displayName, ProfileDashboardForm.email, ProfileDashboardForm.contact);
            profileDashboardForm.UpdateUsernames(ProfileDashboardForm.displayName);
            ProfileInformationForm profileInformationForm = new ProfileInformationForm(ProfileDashboardForm.firstName, ProfileDashboardForm.lastName, ProfileDashboardForm.displayName, ProfileDashboardForm.email, ProfileDashboardForm.contact);
            profileDashboardForm.LoadForm(profileInformationForm);
        }

        private void UpdateUser()
        {
            using (SqlConnection conn = new SqlConnection(HomeForm.connectionString))
            {
                string query = "UPDATE users SET first_name = @FirstName, last_name = @LastName, username = @Username, contact = @Contact WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", ProfileDashboardForm.email);
                cmd.Parameters.AddWithValue("@FirstName", ProfileDashboardForm.firstName);
                cmd.Parameters.AddWithValue("@LastName", ProfileDashboardForm.lastName);
                cmd.Parameters.AddWithValue("@Username", ProfileDashboardForm.displayName);
                cmd.Parameters.AddWithValue("@Contact", ProfileDashboardForm.contact);

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
