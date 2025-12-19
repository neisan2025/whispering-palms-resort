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
    public partial class AdminViewRoomDetails : Form
    {
        //DATABASE
        private string connectionString = HomeForm.connectionString;
        //END
        public AdminViewRoomDetails()
        {
            InitializeComponent();
        }

        private void ViewRoomDetailsForm_Load(object sender, EventArgs e)
        {
            //DATABASE
            LoadData();
            //END
        }

        //DATABASE
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM rooms";

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


        //DATABASE
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    object cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    int rowNumber = (int)cellValue;
                    AdminEditRoomDetails detailsForm = new AdminEditRoomDetails(rowNumber);
                    MainAdminForm mainAdminForm = this.ParentForm as MainAdminForm;
                    if (mainAdminForm != null)
                    {
                        mainAdminForm.LoadForm(detailsForm);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
                return;
            }
        }

        /*private void rjButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }*/

        private void rjButton3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //END


    }
}
