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
    public partial class AdminDiningInfo : Form
    {
        public AdminDiningInfo()
        {
            InitializeComponent();
            LoadDiningInfo();
        }

        private void LoadDiningInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    connection.Open();
                    string query = "SELECT food_id, food_name, food_price FROM foods"; // Change this query according to your database structure
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DiningInfoForm_Load(object sender, EventArgs e)
        {
            // Any additional setup can be done here
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event if needed
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDiningInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int foodID = Convert.ToInt32(selectedRow.Cells["food_id"].Value);
                string foodName = selectedRow.Cells["food_name"].Value.ToString();
                string currentPrice = selectedRow.Cells["food_price"].Value.ToString();

                // Open the UpdatePriceForm and pass the foodID
                ChangePriceFood updatePriceForm = new ChangePriceFood(foodID);
                updatePriceForm.ShowDialog();
            }
        }
    }
}
