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
    public partial class TransactionsForm : Form
    {
        private ProfileDashboardForm profileDashboardForm;

        public TransactionsForm(ProfileDashboardForm profileDashboardForm)
        {
            InitializeComponent();
            this.profileDashboardForm = profileDashboardForm;
            this.BringToFront();

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    string query = "SELECT * FROM bookings WHERE email = " + "'" + HomeForm.currentEmail + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView2.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    string query = "SELECT * FROM food_reservation WHERE email = " + "'" + HomeForm.currentEmail + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
                {
                    string query = "SELECT * FROM diving_reservation WHERE email = " + "'" + HomeForm.currentEmail + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView3.DefaultCellStyle.Font = new Font("Proxima Nova", 12, FontStyle.Regular);

                    dataGridView3.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
