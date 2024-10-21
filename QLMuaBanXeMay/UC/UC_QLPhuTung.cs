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

namespace QLMuaBanXeMay
{
    public partial class UC_QLPhuTung : UserControl
    {
        string connstring = @"Data Source=DANHUYNH\SQLEXPRESS;Initial Catalog=QLMuaBanXeMay;Integrated Security=True";
        SqlConnection conn = null;
        public UC_QLPhuTung()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string query = "Select * From PhuTung";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    PhuTung_GridView.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Mở kết nối không thành công");
            }
        }
    }
}
