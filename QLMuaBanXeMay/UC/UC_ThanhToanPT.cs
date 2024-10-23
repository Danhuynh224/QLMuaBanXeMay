﻿using QLMuaBanXeMay.Class;
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
        List<ChiTietHD_PT> ListHDPT = new List<ChiTietHD_PT>();
        public UC_ThanhToanPT()
        {
            
        }
        public UC_ThanhToanPT(List<ChiTietHD_PT> listHDPT, KhachHang khachHang)
        {
            InitializeComponent();
            ListHDPT = listHDPT;
            dataGridViewPT.DataSource = null; 
            dataGridViewPT.DataSource = listHDPT;
            dataGridViewPT.Columns[0].Visible = false;
        }
        

        private void UC_ThanhToanPT_Load(KhachHang khachHang)
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
            hoaDonPT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
            hoaDonPT.KhuyenMai = float.Parse(txt_khuyenMai.Text);
            hoaDonPT.TongTien = float.Parse(txt_thanhTien.Text);
            hoaDonPT.CCCDKH = Convert.ToInt32(txt_cccdKH.Text);
            hoaDonPT.CCCDNV = 123456789;
            hoaDonPT.PTTT = cb_pttt.Text;
            hoaDonPT.NgayXuat = dt_ngayXuat.Value;

            DAO.DAOHoaDonPT.ThemHoaDonPT(hoaDonPT);
            


            foreach (ChiTietHD_PT chiTietHDPT in ListHDPT)
            {
                chiTietHDPT.MaHDPT = Convert.ToInt32(txt_maHD.Text);
                DAO.DAOHoaDonPT.ThemChiTietHDPT(chiTietHDPT);

            }
            
            MessageBox.Show("Done");



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

            txt_thanhTien.Text = thanhTien.ToString();

        }

    }
}
