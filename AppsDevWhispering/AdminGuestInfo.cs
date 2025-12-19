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
    public partial class AdminGuestInfo : Form
    {
        public AdminGuestInfo()
        {
            InitializeComponent();

            // Set DataGridView properties for equal column width and font style
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // SQL query to select all columns from the users table
                    string query = "SELECT * FROM users";

                    // Create a SqlDataAdapter to retrieve data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void viewTransactionBtn_Click(object sender, EventArgs e)
        {
            AdminViewGuestTransaction viewGuestTransactionForm = new AdminViewGuestTransaction();
            MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
            mainAdminForm.LoadForm(viewGuestTransactionForm);
        }

        private void GuestInfoForm_Load(object sender, EventArgs e)
        {
            // Any additional setup can be done here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a cell is clicked
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string email = selectedRow.Cells["email"].Value.ToString();

                // Open the UpdatePriceForm and pass the email
                AdminEditGuestForm adminEditGuestForm = new AdminEditGuestForm(email);
                MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
                if (mainAdminForm != null)
                {
                    mainAdminForm.LoadForm(adminEditGuestForm);
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    // SQL query to select all columns from the users table
                    string query = "SELECT * FROM users";

                    // Create a SqlDataAdapter to retrieve data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
