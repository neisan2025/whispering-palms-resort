using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CustomControls;
using System.Data.SqlClient;
using System.IO;

namespace AppsDevWhispering
{
    public partial class ProfileDashboardForm : Form
    {
        public static string firstName;
        public static string lastName;
        public static string displayName;
        public static string email;
        public static string contact;
        public static string password;

        private string connectionString = HomeForm.connectionString;
        private byte[] imageBytes = null;

        public ProfileDashboardForm()
        {
            InitializeComponent();
            load();
            labelFirstName.Text = firstName;
            labelLastName.Text = lastName;
            labelDisplayName.Text = displayName;
            labelContact.Text = contact;
            labelEmail.Text = email;
        }

        public void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelProfile.Controls.Clear();
            panelProfile.Controls.Add(form);
            form.Show();
        }

        public void UpdateProfileInformation(string firstName, string lastName, string displayName, string email, string contact)
        {
            ProfileDashboardForm.firstName = firstName;
            ProfileDashboardForm.lastName = lastName;
            ProfileDashboardForm.displayName = displayName;
            ProfileDashboardForm.email = email;
            ProfileDashboardForm.contact = contact;
        }

        public void UpdateUsernames(string displayName)
        {
            lblUsername1.Text = displayName;
            lblUsername2.Text = displayName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbMyProfile.Image = Image.FromFile(openFileDialog.FileName);
                pbProfile.Image = Image.FromFile(openFileDialog.FileName);

                string filePath = openFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
            }
            UpdateUser();
        }

        private void buttonMyProfile_MouseEnter(object sender, EventArgs e)
        {
            buttonMyProfile.Image = Properties.Resources.btnProfileMyprofileBlue;
        }

        private void buttonMyProfile_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = Properties.Resources.btnProfileMyprofile;
        }

        private void buttonTransactions_MouseEnter(object sender, EventArgs e)
        {
            buttonTransactions.Image = Properties.Resources.btnProfileTransactionBlue;
        }

        private void buttonTransactions_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = Properties.Resources.btnProfileTransaction;
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            ProfileInformationForm profileInformationForm = new ProfileInformationForm(firstName, lastName, displayName, email, contact);
            LoadForm(profileInformationForm);
            panel2.Show();
            panel2.Visible = true;
        }

        private void buttonLogout_MouseEnter(object sender, EventArgs e)
        {
            buttonLogout.Image = Properties.Resources.btnProfileLogoutBlue;
        }

        private void buttonLogout_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = Properties.Resources.btnProfileLogout;
        }

        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm transactionsForm = new TransactionsForm(this);
            LoadForm(transactionsForm);
            panel2.Hide();
            panel2.Visible = false;
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(this);
            LoadForm(changePasswordForm);
        }

        private void buttonEditInfo_Click(object sender, EventArgs e)
        {
            EditInformationForm editInfoForm = new EditInformationForm(this);
            LoadForm(editInfoForm);
        }

        public void pbSizeMode()
        {
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMyProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void load()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", HomeForm.currentEmail);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        email = reader["email"].ToString();
                        firstName = reader["first_name"].ToString();
                        lastName = reader["last_name"].ToString();
                        displayName = reader["username"].ToString();
                        contact = reader["contact"].ToString();
                        ProfileDashboardForm.password = reader["password"].ToString();
                        lblUsername1.Text = displayName;
                        lblUsername2.Text = displayName;


                        byte[] imageData = (byte[])reader["picture"];
                        pbMyProfile.Image = ByteArrayToImage(imageData);
                        pbProfile.Image = ByteArrayToImage(imageData);
                        
                    }

                    Console.WriteLine(email);
                    UpdateProfileInformation(firstName, lastName, displayName, email, contact);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void UpdateUser()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE users SET first_name = @FirstName, last_name = @LastName, username = @Username, contact = @Contact, picture = @Picture WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", ProfileDashboardForm.email);
                cmd.Parameters.AddWithValue("@FirstName", ProfileDashboardForm.firstName);
                cmd.Parameters.AddWithValue("@LastName", ProfileDashboardForm.lastName);
                cmd.Parameters.AddWithValue("@Username", ProfileDashboardForm.displayName);
                cmd.Parameters.AddWithValue("@Contact", ProfileDashboardForm.contact);
                cmd.Parameters.AddWithValue("@Picture", ImagetoByteArray());

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private byte[] ImagetoByteArray()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pbMyProfile.Image.Save(ms, pbMyProfile.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }


        internal class RoundPictureBox : PictureBox
        {
            public void RoundPictureBorder()
            {
                this.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                GraphicsPath grpath = new GraphicsPath();
                grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(grpath);
                base.OnPaint(pe);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                HomeForm.currentEmail = "";
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            
        }
    }
}
