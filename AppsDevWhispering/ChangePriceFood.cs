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
    public partial class ChangePriceFood : Form
    {
        int foodId;
        public ChangePriceFood(int foodId)
        {
            InitializeComponent();
            this.foodId = foodId;
        }

        private void UpdateRoomBTN_Click(object sender, EventArgs e)
        {
            decimal newPrice = 0;
            try
            {
                newPrice = decimal.Parse(txtNewPrice.Text);
                if(newPrice <= 0 )
                {
                    MessageBox.Show("Invalid price.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format.");
                return;
            }

            UpdatePriceInDatabase(newPrice);
            this.Close();
        }

        private void UpdatePriceInDatabase(decimal newPrice)
        {
            string updateQuery = "UPDATE foods SET food_price = @NewPrice WHERE food_id = @FoodID";

            using (SqlConnection connection = new SqlConnection(HomeForm.connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewPrice", newPrice);
                command.Parameters.AddWithValue("@FoodID", foodId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Food details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

   
    }
}
