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
    public partial class UC_ThongKeTheoNhanVien : UserControl
    {
        public UC_ThongKeTheoNhanVien()
        {
            InitializeComponent();
        }

        private void UC_ThongKeTheoNhanVien_Load(object sender, EventArgs e)
        {
            cbbThang.SelectedIndex = 0;
            ThongKeTheoNV();
        }

        private void ThongKeTheoNV()
        {
            int selectedMonth = int.Parse(cbbThang.SelectedItem.ToString());
            int selectedYear = DateTime.Now.Year;

            using (SqlCommand cmd = new SqlCommand("sp_DoanhThuTheoNhanVien", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Month", selectedMonth);
                cmd.Parameters.AddWithValue("@Year", selectedYear);

                MY_DB.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing series and data
                chartTKTheoNV.Series.Clear();
                chartTKTheoNV.Titles.Clear();

                // Add title to the chart
                chartTKTheoNV.Titles.Add("Doanh thu theo nhân viên tháng " + selectedMonth + "/" + selectedYear);

                // Create a new series for the bar chart
                Series series = new Series("DoanhThu");
                series.ChartType = SeriesChartType.Column;  // Use 'Bar' for horizontal bars
                series.XValueType = ChartValueType.String;
                series.YValueType = ChartValueType.Double;

                // Populate the chart with data
                foreach (DataRow row in dt.Rows)
                {
                    string employeeName = row["TenNV"].ToString();
                    double revenue = Convert.ToDouble(row["DoanhThu"]);
                    series.Points.AddXY(employeeName, revenue);
                }

                // Add the series to the chart
                chartTKTheoNV.Series.Add(series);


                series.Color = Color.Blue;  // Change the color of the bars
                chartTKTheoNV.ChartAreas[0].AxisX.Title = "Nhân viên";  // Label the X-axis
                chartTKTheoNV.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";  // Label the Y-axis
                chartTKTheoNV.ChartAreas[0].AxisX.Interval = 1;  // Ensure all employee names are shown on the axis
                chartTKTheoNV.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C0}";
            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeTheoNV();
        }
    }
}
