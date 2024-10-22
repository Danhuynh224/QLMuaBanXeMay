using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.WF;
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
        Class.PhuTung phuTung = new PhuTung();
        public UC_QLPhuTung()
        {
            InitializeComponent();
            Load_GridView();
            
        }
        private void Load_GridView()
        {
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


        private void PhuTung_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != PhuTung_GridView.Columns["XoaBtn"].Index)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = PhuTung_GridView.Rows[e.RowIndex];
               
                // Lấy giá trị từ các cột
                phuTung.MaPT = Convert.ToInt32(row.Cells["MaPT"].Value);
                phuTung.TenPT = row.Cells["TenPT"].Value.ToString(); // hoặc row.Cells[0].Value.ToString()
                phuTung.DonGia = float.Parse(row.Cells["DonGia"].Value.ToString()); 
                phuTung.ChatLieu = row.Cells["ChatLieu"].Value.ToString();
                phuTung.HangSX = row.Cells["HangSX"].Value.ToString();
                phuTung.SoLuongTon = Convert.ToInt32(row.Cells["SoLuongTon"].Value);

                // Hiển thị giá trị (hoặc xử lý theo yêu cầu)
                MaPhuTung_textBox.Text = phuTung.MaPT.ToString();
                TenPhuTung_textBox.Text =phuTung.TenPT.ToString();  
                DonGia_textBox.Text=phuTung.DonGia.ToString();
                ChatLieu_textBox.Text=phuTung.ChatLieu.ToString();
                HangSX_textBox.Text = phuTung.HangSX.ToString();
                SoLuongTon_textBox.Text= phuTung.SoLuongTon.ToString();
                
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string timkiem= search_textBox.Text;
            conn = new SqlConnection(connstring);
            try
            {              
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string query = string.Format("SELECT * FROM PhuTung WHERE TenPT LIKE N'%{0}%'; ", timkiem);
                    MessageBox.Show(query);
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

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            phuTung = new PhuTung();
            Form_ThongTinPhuTung form = new Form_ThongTinPhuTung(phuTung);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Nhận giá trị từ Form2
                phuTung = form.PhuTung;
                try
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string query = string.Format("INSERT INTO PhuTung (MaPT, TenPT, DonGia, ChatLieu, HangSX, SoLuongTon) " +
                            "VALUES ({0}, N'{1}', {2}, N'{3}', N'{4}', {5}); ",
                            phuTung.MaPT, phuTung.TenPT, phuTung.DonGia, phuTung.ChatLieu, phuTung.HangSX, phuTung.SoLuongTon);
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            int rowsAffected = command.ExecuteNonQuery(); // Thực thi câu lệnh
                            MessageBox.Show($"{rowsAffected} bản ghi đã được xử lý thành công.");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Mở kết nối không thành công");
                }
                Load_GridView();

            }

        }

        private void PhuTung_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == PhuTung_GridView.Columns["XoaBtn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = PhuTung_GridView.Rows[e.RowIndex];
                // Lấy các giá trị của các cột trong hàng được chọn
                int maPhuTung = Convert.ToInt32(row.Cells["MaPT"].Value);
                try
                {
                    conn = new SqlConnection(connstring);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string query = string.Format("DELETE  FROM PhuTung  WHERE MaPT={0};",
                            phuTung.MaPT);
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            int rowsAffected = command.ExecuteNonQuery(); // Thực thi câu lệnh
                            MessageBox.Show("Xóa thành công");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Mở kết nối không thành công");
                }
                Load_GridView();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            phuTung.MaPT = Convert.ToInt32(MaPhuTung_textBox.Text);
            phuTung.TenPT = TenPhuTung_textBox.Text; // hoặc row.Cells[0].Value.ToString()
            phuTung.DonGia = float.Parse(DonGia_textBox.Text);
            phuTung.ChatLieu = ChatLieu_textBox.Text;
            phuTung.HangSX = HangSX_textBox.Text;
            phuTung.SoLuongTon = Convert.ToInt32(SoLuongTon_textBox.Text);
            try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string query = string.Format("UPDATE PhuTung SET TenPT = N'{1}', DonGia = {2}, ChatLieu =N'{3}', HangSX = N'{4}', SoLuongTon = {5} WHERE MaPT = {0};",
                        phuTung.MaPT, phuTung.TenPT, phuTung.DonGia, phuTung.ChatLieu, phuTung.HangSX, phuTung.SoLuongTon);
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery(); // Thực thi câu lệnh
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mở kết nối không thành công");
            }
            Load_GridView();
        }
    }
}
