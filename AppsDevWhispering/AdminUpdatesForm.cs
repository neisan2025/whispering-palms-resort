using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevWhispering
{
    public partial class AdminUpdatesForm : Form
    {
        private UpdatesForm updatesForm;
        private byte[] imageBytes = null;
        //private UpdatesMainForm updatesMainForm;
        public AdminUpdatesForm()
        {
            InitializeComponent();
            LoadImageButton.Visible = true;
            updatesForm = new UpdatesForm();
            //updatesMainForm = new UpdatesMainForm();
            LoadData();
        }

        private void importPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UploadImgPic.Image = Image.FromFile(openFileDialog.FileName);
                LoadImageButton.Visible = true;

                string filePath = openFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
                LoadImageButton.Visible = true;
            }
        }

        private void UploadRoomBTN_Click(object sender, EventArgs e)
        {
            if (imageBytes == null || TitleTextBox.Text == "" || DescriptionTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all the details!");
                return;
            }
            string insertQuery = "INSERT INTO updates (title, body, picture, posted) VALUES (@Title, @Body, @Picture, @Posted)";

            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Create command with parameters
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Title", TitleTextBox.Text);
                        command.Parameters.AddWithValue("@Body", DescriptionTextBox.Text);
                        command.Parameters.AddWithValue("@Picture", imageBytes);
                        command.Parameters.AddWithValue("@Posted", DateTime.Now);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            TitleTextBox.Clear();
                            DescriptionTextBox.Clear();
                            MessageBox.Show("Update inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error1: " + ex.Message);
            }

            LoadData();
            //updatesForm.AddRoomPanelToFlowLayout(TitleTextBox.Text, DescriptionTextBox.Text, UploadImgPic.Image, whisperingLogoPanel.Image);
        }

        private void viewPostBtn_Click(object sender, EventArgs e)
        {
            MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
            if (mainAdminForm != null)
            {
                mainAdminForm.LoadForm(updatesForm);
            }
        }

        private void postDetailsBtn_Click(object sender, EventArgs e)
        {
            AdminUpdateDetails adminUpdateDetails = new AdminUpdateDetails();
            MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
            mainAdminForm.LoadForm(adminUpdateDetails);
        }

        private void viewReviewBtn_Click(object sender, EventArgs e)
        {
            ReviewsForm reviewsForm = new ReviewsForm();
            MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
            mainAdminForm.LoadForm(reviewsForm);
        }

        private void DeleteUpdate(int updateId)
        {
            string deleteQuery = "DELETE FROM updates WHERE update_id = @updateId";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@updateId", updateId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error2: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int updateId = Convert.ToInt32(selectedRow.Cells["update_id"].Value);
                string updateTitle = selectedRow.Cells["title"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Do you want to delete the update: " + updateTitle + "?", "Delete Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUpdate(updateId);
                    LoadData(); // Refresh the data grid view
                }
            }
        }

        private void LoadData()
        {
            string selectQuery = "SELECT update_id, title, body, posted FROM updates";
            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Set DataGridView properties for equal column width and font style
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error3: " + ex.Message);
                }
            }
        }
    }
}
