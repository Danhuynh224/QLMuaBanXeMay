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

namespace QLMuaBanXeMay
{
    public partial class UC_QLXe : UserControl
    {
        string connstring = @"Data Source=DANHUYNH\SQLEXPRESS;Initial Catalog=QLMuaBanXeMay;Integrated Security=True";
        SqlConnection conn = null;
        Class.XeMay xeMay = new XeMay();
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

        private void Xe_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != Xe_GridView.Columns["XoaBtn"].Index)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = Xe_GridView.Rows[e.RowIndex];

                // Lấy giá trị từ các cột
                xeMay.MaXe = Convert.ToInt32(row.Cells["MaXe"].Value);
                xeMay.TenXe = row.Cells["TenXe"].Value.ToString(); // hoặc row.Cells[0].Value.ToString()
                xeMay.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                xeMay.LoaiXe = row.Cells["LoaiXe"].Value.ToString();
                xeMay.MauSac = row.Cells["MauSac"].Value.ToString();
                xeMay.PhanKhoi = Convert.ToInt32(row.Cells["PhanKhoi"].Value);

                // Hiển thị giá trị (hoặc xử lý theo yêu cầu)
                /*txt_MaPhuTung.Text = phuTung.MaPT.ToString();
                txt_TenPhuTung.Text = phuTung.TenPT.ToString();
                txt_DonGia.Text = phuTung.DonGia.ToString();
                txt_ChatLieu.Text = phuTung.ChatLieu.ToString();
                txt_HangSX.Text = phuTung.HangSX.ToString();
                txt_SoLuongTon.Text = phuTung.SoLuongTon.ToString();*/

            }
        }
    }
}
