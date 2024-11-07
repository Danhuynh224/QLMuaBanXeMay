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


        Class.KhachHang khachHang_tt = new KhachHang();
        NhanVien user;
        List<ChiTietHD_PT> ListHDPT = new List<ChiTietHD_PT>();
        public UC_ThanhToanPT()
        {
            
        }
        public UC_ThanhToanPT(List<ChiTietHD_PT> listHDPT, KhachHang khachHang, NhanVien user)
        {
            InitializeComponent();
            ListHDPT = listHDPT;
            this.user = user;
            dataGridViewPT.DataSource = null; 
            dataGridViewPT.DataSource = listHDPT;
            dataGridViewPT.Columns[0].Visible = false;
        }
        

        private void UC_ThanhToanPT_Load(KhachHang khachHang)
        {
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
            if (kh.ShowDialog() == DialogResult.OK)
            {
                khachHang_tt = kh.KhachHang1;
                UC_ThanhToanPT_Load(khachHang_tt);
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
            hoaDonPT.KhuyenMai = (double)Math.Round(double.Parse(txt_khuyenMai.Text), 2, MidpointRounding.AwayFromZero);
            hoaDonPT.TongTien = float.Parse(txt_thanhTien.Text);
            hoaDonPT.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonPT.CCCDNV = user.CCCDNV;
            hoaDonPT.PTTT = cb_pttt.Text;
            hoaDonPT.NgayXuat = dt_ngayXuat.Value;

            int maHDPT=DAO.DAOHoaDonPT.ThemHoaDonPT(hoaDonPT);
            


            foreach (ChiTietHD_PT chiTietHDPT in ListHDPT)
            {
                chiTietHDPT.MaHDPT = maHDPT;
                DAO.DAOHoaDonPT.ThemChiTietHDPT(chiTietHDPT);

            }
            
            MessageBox.Show("Xuất hóa đơn thành công");



        }
        private void tinhThanhTien()
        {
            int soluong;
            float khuyenmai;
            double thanhTien = 0;
            foreach (ChiTietHD_PT chiTietHDPT in ListHDPT)
            {
                thanhTien += chiTietHDPT.DonGia * chiTietHDPT.SoLuong;
            }
            if (float.TryParse(txt_khuyenMai.Text, out khuyenmai))
            {
                thanhTien = thanhTien - (thanhTien * khuyenmai);
            }
            thanhTien = Math.Ceiling(thanhTien);
            txt_thanhTien.Text = thanhTien.ToString();

        }

    }
}
