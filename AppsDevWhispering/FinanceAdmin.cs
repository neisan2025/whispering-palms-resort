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
using System.Windows.Forms.DataVisualization.Charting;

namespace AppsDevWhispering
{
    public partial class FinanceAdmin : Form
    {
        public FinanceAdmin()
        {
            InitializeComponent();
            string connectionString = HomeForm.connectionString;
            string query = @"
            SELECT 
                CAST(date_of_booking AS DATE) AS BookingDate,
                SUM(total_cost) AS TotalCost
            FROM 
                bookings
            GROUP BY 
                CAST(date_of_booking AS DATE)
            ORDER BY 
                BookingDate;
        ";

            DataTable dataTable = GetData(connectionString, query);
            PopulateChart(chart1, dataTable);


            query = @"
            SELECT 
                CAST(date_of_booking AS DATE) AS BookingDate,
                SUM(total_cost) AS TotalCost
            FROM 
                food_reservation
            GROUP BY 
                CAST(date_of_booking AS DATE)
            ORDER BY 
                BookingDate;
        ";

            DataTable dataTable2 = GetData(connectionString, query);
            PopulateChart(chart2, dataTable2);


            query = @"
            SELECT 
                CAST(date_of_reservation AS DATE) AS BookingDate,
                SUM(total) AS TotalCost
            FROM 
                diving_reservation
            GROUP BY 
                CAST(date_of_reservation AS DATE)
            ORDER BY 
                BookingDate;
        ";

            DataTable dataTable3 = GetData(connectionString, query);
            PopulateChart(chart3, dataTable3);
        }

        private DataTable GetData(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void PopulateChart(Chart chart, DataTable dataTable)
        {
            chart.Series.Clear();

            Series series = new Series
            {
                Name = "TotalCost",
                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Double,
                ChartType = SeriesChartType.Line
            };

            chart.Series.Add(series);

            foreach (DataRow row in dataTable.Rows)
            {
                series.Points.AddXY((DateTime)row["BookingDate"], (decimal)row["TotalCost"]);
            }

            chart.Invalidate();
        }
    }
}
