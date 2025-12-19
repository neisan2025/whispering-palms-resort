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
    public partial class AdminEditGuestForm : Form
    {
        string email = "";
        public AdminEditGuestForm(string email)
        {
            this.email = email;
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox4.Text = reader["email"].ToString();
                        textBox1.Text = reader["first_name"].ToString();
                        textBox2.Text = reader["last_name"].ToString();
                        textBox3.Text = reader["username"].ToString();
                        textBox5.Text = reader["contact"].ToString();
                        byte[] imageData = (byte[])reader["picture"];
                        pictureBox1.Image = ByteArrayToImage(imageData);
                        //password = reader["password"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            LoadDataGridView(dataGridView1, "SELECT * FROM bookings WHERE email = @Email", email);
            LoadDataGridView(dataGridView2, "SELECT * FROM food_reservation WHERE email = @Email", email);
            LoadDataGridView(dataGridView3, "SELECT * FROM diving_reservation WHERE email = @Email", email);
        }

        private void EditGuestForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataGridView(DataGridView dataGridView, string query, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Email", email);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Set DataGridView properties for equal column width and font style
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // Open the connection to the database
                    connection.Open();

                    // SQL query to delete a user based on email
                    string query = "DELETE FROM users WHERE email = @Email";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified email.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            int flag = -1;
            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT blocked FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        flag = (int)reader["blocked"];
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (flag == 1)
            {
                MessageBox.Show("This user is already blocked.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // Open the connection to the database
                    connection.Open();

                    // SQL query to update the availability for a specific user
                    string query = "UPDATE users SET blocked = @Blocked WHERE email = @Email";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Blocked", 1);
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Blocked successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            int flag = -1;
            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT blocked FROM users WHERE email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        flag = (int)reader["blocked"];
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("This user is already unblocked.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // Open the connection to the database
                    connection.Open();

                    // SQL query to update the availability for a specific user
                    string query = "UPDATE users SET blocked = @Blocked WHERE email = @Email";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Blocked", 0);
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Unblocked successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
