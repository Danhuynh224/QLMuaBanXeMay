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

        Class.PhuTung phuTung_tt = new PhuTung();
        Class.KhachHang khachHang_tt = new KhachHang();
        List<PhuTung> ListPT = new List<PhuTung>();
        public UC_ThanhToanPT()
        {
            
        }
        public UC_ThanhToanPT(List<PhuTung> listPT, KhachHang khachHang)
        {
            InitializeComponent();
            ListPT = listPT;
            dataGridViewPT.DataSource = null; // Xóa dữ liệu hiện có (nếu có)
            dataGridViewPT.DataSource = listPT;
            
        }
        

        private void UC_ThanhToanPT_Load(PhuTung phuTung, KhachHang khachHang)
        {
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
                tinhThanhTien();
            }
            
        }

        private void txt_cccdKH_TextChanged(object sender, EventArgs e)
        {
            txt_khuyenMai.Text = DAO.DAOHoaDonPT.LayThongTinKhuyenMai(Convert.ToInt32(txt_cccdKH.Text));
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

            DAO.DAOHoaDonPT.ThemHoaDonPT(hoaDonPT);
            

            Class.ChiTietHD_PT chiTietHD_PT = new ChiTietHD_PT();
            chiTietHD_PT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
            foreach (PhuTung phuTung in ListPT)
            {
                
            chiTietHD_PT.MaPT = phuTung.MaPT;
            chiTietHD_PT.SoLuong = phuTung.SoLuongTon;
            chiTietHD_PT.DonGia = phuTung.DonGia;

            DAO.DAOHoaDonPT.ThemChiTietHDPT(chiTietHD_PT);


            }
            
            MessageBox.Show("Done");



        }
        private void tinhThanhTien()
        {
            int soluong;
            float khuyenmai;
            float thanhTien = 0;
            foreach (PhuTung phuTung in ListPT)
            {
                thanhTien += phuTung.DonGia * phuTung.SoLuongTon;
            }
            if (float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            {
                thanhTien = thanhTien - (thanhTien * khuyenmai);
            }

            txt_thanhTien.Text = thanhTien.ToString();

        }


        private void UC_ThanhToanPT_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
