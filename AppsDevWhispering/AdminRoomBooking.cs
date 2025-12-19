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
    public partial class AdminRoomBooking : Form
    {
        public AdminRoomBooking()
        {
            InitializeComponent();
        }

        private void RoomBookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    string query = "SELECT * FROM bookings";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);
                    dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int booking_id = Convert.ToInt32(selectedRow.Cells["booking_id"].Value);

                DialogResult dialogResult = MessageBox.Show("Do you want to delete the reservation id: " + booking_id + "?", "Delete reservtion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUpdate(booking_id);
                    LoadData(); // Refresh the data grid view
                }
            }
        }

        private void DeleteUpdate(int booking_id)
        {
            string deleteQuery = "DELETE FROM bookings WHERE booking_id = @booking_id";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@booking_id", booking_id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error2: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM bookings";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
