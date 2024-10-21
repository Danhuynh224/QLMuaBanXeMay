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
    public partial class UC_QLXe : UserControl
    {
        string connstring = @"Data Source=HONGSON;Initial Catalog=QLMuaBanXeMay;Integrated Security=True";
        SqlConnection conn = null;
        public UC_QLXe()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string query = "Select * From XeMay";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    Xe_GridView.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Mở kết nối không thành công");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Xe_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Xe_GridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Xe_GridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
