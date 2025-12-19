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
    public partial class AdminDiningBooking : Form
    {
        public static int numberOfTables = 0;
        public static int numberOfGuestPerTable = 0;

        public AdminDiningBooking()
        {
            InitializeComponent();
            LoadFoodReservations();

            string filePath = "tables.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read content from the file
                    string contentFromFile = File.ReadAllText(filePath);
                    numberOfTables = Convert.ToInt32(contentFromFile);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading from the file: " + ex.Message);
            }

            filePath = "guests.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read content from the file
                    string contentFromFile = File.ReadAllText(filePath);
                    numberOfGuestPerTable = Convert.ToInt32(contentFromFile);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading from the file: " + ex.Message);
            }

            tables.Value = numberOfTables;
            numericUpDown1.Value = numberOfGuestPerTable;
        }

        private void tables_ValueChanged(object sender, EventArgs e)
        {
            numberOfTables = Convert.ToInt32(tables.Value);

            string filePath = "tables.txt";
            string contentToSave = numberOfTables.ToString();

            try
            {
                // Write content to the file
                File.WriteAllText(filePath, contentToSave);
                Console.WriteLine("Content successfully saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving to the file: " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfGuestPerTable = Convert.ToInt32(numericUpDown1.Value);

            string filePath = "guests.txt";
            string contentToSave = numberOfGuestPerTable.ToString();

            try
            {
                // Write content to the file
                File.WriteAllText(filePath, contentToSave);
                Console.WriteLine("Content successfully saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving to the file: " + ex.Message);
            }
        }

        private void LoadFoodReservations()
        {
            string query = "SELECT * FROM food_reservation";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Set DataGridView properties for equal column width and font style
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int food_reservation_id = Convert.ToInt32(selectedRow.Cells["food_reservation_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Do you want to delete the reservation id: " + food_reservation_id + "?", "Delete reservation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUpdate(food_reservation_id);
                    LoadFoodReservations(); // Refresh the data grid view
                }
            }
        }

        private void DeleteUpdate(int food_reservation_id)
        {
            string deleteQuery = "DELETE FROM food_reservation WHERE food_reservation_id = @food_reservation_id";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@food_reservation_id", food_reservation_id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error2: " + ex.Message);
                }
            }
        }
    }
}
