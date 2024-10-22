using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.WF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_ThanhToanPT : UserControl
    {
        string connstring = @"Data Source=HONGSON;Initial Catalog=QLMuaBanXeMay;Integrated Security=True";
        SqlConnection conn = null;
        Class.PhuTung phuTung_tt = new PhuTung();
        Class.KhachHang khachHang_tt = new KhachHang();
       
        public UC_ThanhToanPT()
        {
            InitializeComponent();
        }
        public UC_ThanhToanPT(PhuTung phuTung, KhachHang khachHang)
        {
            phuTung_tt = phuTung;
            khachHang_tt = khachHang;
            InitializeComponent();
            this.txt_maPT.Text = phuTung.MaPT.ToString();
            this.txt_tenPT.Text = phuTung.TenPT.ToString();
            this.txt_donGia.Text = phuTung.DonGia.ToString();
            this.txt_hangSX.Text = phuTung.HangSX.ToString();
            this.txt_chatLieu.Text = phuTung.ChatLieu.ToString();
            this.txt_soLuong.Text = "1";

            
            
        }
        

        private void UC_ThanhToanPT_Load(PhuTung phuTung, KhachHang khachHang)
        {
            /*InitializeComponent();*/
            this.txt_maPT.Text = phuTung.MaPT.ToString();
            this.txt_tenPT.Text = phuTung.TenPT.ToString();
            this.txt_donGia.Text = phuTung.DonGia.ToString();
            this.txt_hangSX.Text = phuTung.HangSX.ToString();
            this.txt_chatLieu.Text = phuTung.ChatLieu.ToString();
            this.txt_soLuong.Text = "1";

            MessageBox.Show(khachHang.MaLoai.ToString());
            this.txt_cccdKH.Text = khachHang.CCCDKH.ToString();
            this.txt_ten.Text = khachHang.TenKH.ToString();
            this.dt_ngaySinh.Value = khachHang.NgaySinh;
            this.txt_gioiTinh.Text = khachHang.GioiTinh.ToString();
            this.txt_sdt.Text = khachHang.SDT.ToString();
            this.txt_diaChi.Text = khachHang.DiaChi.ToString();
            this.txt_email.Text = khachHang.Email.ToString();
        }

        private void btn_chonKH_Click(object sender, EventArgs e)
        {
            Form_ThongTinKH kh = new Form_ThongTinKH(khachHang_tt);
            khachHang_tt = kh.KhachHang1;

            if (kh.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(khachHang_tt.TenKH.ToString());
                UC_ThanhToanPT_Load(phuTung_tt, khachHang_tt);
            }
                
        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    using (SqlCommand command = new SqlCommand("SELECT dbo.LayKhuyenMaiTuCCCD(@cccd)", connection))
                    {
                        command.Parameters.AddWithValue("@cccd", txt_cccdKH.Text);
                        connection.Open();
                        txt_khuyenMai.Text = command.ExecuteScalar().ToString();
                        connection.Close();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Mở kết nối không thành công");
            }
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            Class.HoaDonPT hoaDonPT = new HoaDonPT();
            hoaDonPT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
            hoaDonPT.KhuyenMai = float.Parse(txt_khuyenMai.Text);
            hoaDonPT.TongTien = float.Parse(txt_thanhTien.Text);
            hoaDonPT.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonPT.CCCDNV = 123456789;
            hoaDonPT.PTTT = cb_pttt.Text;
            hoaDonPT.NgayXuat = dt_ngayXuat.Value;


           /* try
            {
                conn = new SqlConnection(connstring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO HoaDonPT (MaHDPT, KhuyenMai, TongTien, CCCDKH, HangSX, SoLuongTon) " +
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
            }*/
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            int soluong;
            float khuyenmai;
            float thanhTien = 0;
            if (int.TryParse(txt_soLuong.Text, out soluong))
            {
                int donGia = Convert.ToInt32(txt_donGia.Text);
                thanhTien = soluong * donGia;
                
            }
            if(float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            {
                thanhTien = thanhTien - (thanhTien * khuyenmai);
            }    
            
            txt_thanhTien.Text = thanhTien.ToString();

        }
    }
}
