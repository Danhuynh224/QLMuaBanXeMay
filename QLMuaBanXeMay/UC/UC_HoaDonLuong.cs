using QLMuaBanXeMay.Class;
using QLMuaBanXeMay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.UC
{
    public partial class UC_HoaDonLuong : UserControl
    {
        public UC_HoaDonLuong()
        {
            InitializeComponent();
        }

        private void UC_HoaDonLuong_Load(object sender, EventArgs e)
        {
            //LoadNhanVienCaLamViec();
        }
        private void LoadHoaDonLuongList()
        {
            
        }

        private void LoadNhanVienCaLamViec()
        {
            //try
            //{
            //    DataTable dt = DAOHoaDonLuong.Load_ViewDSNhanVien();

            //    dgvDSNV.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //}
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string cccdNV = txtCCCD.Text;
            //    int soGioLam = int.Parse(txtSoGioLam.Text);

            //    decimal luongCoBan = decimal.Parse(txtLuongCoBan.Text);
            //    decimal tongTien = soGioLam * luongCoBan;

            //    txtTongLuong.Text = tongTien.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi " + ex.Message);
            //}
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    HoaDonLuong hoaDonLuong = new HoaDonLuong
            //    {
            //        CCCDNV = txtCCCD.Text,
            //        SoGioLam = int.Parse(txtSoGioLam.Text),
            //        NgayXuat = DateTime.Now,
            //        TongTien = decimal.Parse(txtTongLuong.Text)
            //    };

            //    bool success = daoHoaDonLuong.InsertHoaDonLuong(hoaDonLuong);
            //    if (success)
            //    {
            //        MessageBox.Show("Salary invoice added successfully.");
            //        LoadHoaDonLuongList(); // Refresh DataGridView
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to add salary invoice.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error adding invoice: " + ex.Message);
            //}
        }
    }
}
