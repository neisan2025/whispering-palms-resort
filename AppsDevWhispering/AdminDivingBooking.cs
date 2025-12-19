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
    public partial class AdminDivingBooking : Form
    {
        public AdminDivingBooking()
        {
            InitializeComponent();
            LoadData();
        }

        private void DivingBookingForm_Load(object sender, EventArgs e)
        {
            // Any additional setup can be done here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int diving_reservation_id = Convert.ToInt32(selectedRow.Cells["diving_reservation_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Do you want to delete the reservation id: " + diving_reservation_id + "?", "Delete reservation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUpdate(diving_reservation_id);
                    LoadData(); // Refresh the data grid view
                }
            }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM diving_reservation"; // Change this query according to your database structure
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Set DataGridView properties for equal column width and font style
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void DeleteUpdate(int diving_reservation_id)
        {
            string deleteQuery = "DELETE FROM diving_reservation WHERE diving_reservation_id = @diving_reservation_id";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@diving_reservation_id", diving_reservation_id);
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
