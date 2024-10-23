using QLMuaBanXeMay.Class;
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

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThongKeTheoThang : UserControl
    {
        public UC_ThongKeTheoThang()
        {
            InitializeComponent();
        }

        private void UC_ThongKeTheoThang_Load(object sender, EventArgs e)
        {
            cbbNam.SelectedItem = 2024;
            ThongKeTheoThang(2024);
        }

        private void ThongKeTheoThang(int selectedYear)
        {
            using (SqlCommand cmd = new SqlCommand("sp_TongDoanhThuTheoThang", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", selectedYear);

                MY_DB.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing series
                chartThongKeTheoThang.Series.Clear();
                chartThongKeTheoThang.Titles.Clear();

                // Add a title to the chart
                chartThongKeTheoThang.Titles.Add("Tổng doanh thu theo tháng năm " + selectedYear);

                // Create a new series for the column chart
                Series series = new Series("TongDoanhThu");
                series.ChartType = SeriesChartType.Column;  // Set the chart type to Column

                // Populate the chart with data
                foreach (DataRow row in dt.Rows)
                {
                    int month = Convert.ToInt32(row["Thang"]);
                    double totalRevenue = Convert.ToDouble(row["TongDoanhThu"]);
                    series.Points.AddXY("Tháng " + month, totalRevenue); // Month and total revenue
                }

                // Add the series to the chart
                chartThongKeTheoThang.Series.Add(series);

                // Customize the chart appearance
                series.Color = Color.Blue; // Change the color of the columns
                chartThongKeTheoThang.ChartAreas[0].AxisX.Title = "Tháng";  // Label the X-axis
                chartThongKeTheoThang.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";  // Label the Y-axis
                chartThongKeTheoThang.ChartAreas[0].AxisX.Interval = 1;  // Ensure all months are shown on the axis
                chartThongKeTheoThang.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";  // Format Y-axis as currency
            }


        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = Convert.ToInt32(cbbNam.SelectedItem);

            ThongKeTheoThang(selectedYear);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
