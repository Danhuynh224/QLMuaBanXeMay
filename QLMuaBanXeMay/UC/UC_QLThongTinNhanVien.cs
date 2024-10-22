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
    public partial class UC_QLThongTinNhanVien : UserControl
    {
        public UC_QLThongTinNhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgv_thongTinNV.DataSource = DAONhanVien.LayThongTinNhanVien();
            dgv_thongTinNV.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng NhanVien từ các giá trị nhập vào
                NhanVien nhanVien = new NhanVien();

                nhanVien.CCCDNV = int.Parse(txtCCCD.Text);
                nhanVien.TenNV = txtTenNV.Text;
                nhanVien.NgaySinh = dtpNgaySinh.Value;
                nhanVien.GioiTinh = txtGioiTinh.Text;
                nhanVien.SDT = txtSDT.Text;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.ChucVu = txtChucVu.Text;


                // Tạo đối tượng TaiKhoan từ các giá trị nhập vào
                TaiKhoan taiKhoan = new TaiKhoan();

                taiKhoan.TenTK = txtTenTK.Text;
                taiKhoan.MatKhau = txtMatKhau.Text;
                taiKhoan.CCCDNV = nhanVien.CCCDNV;


                // Thêm nhân viên và tài khoản
                DAONhanVien.ThemNhanVien(nhanVien);
                DAOTaiKhoan.ThemTaiKhoan(taiKhoan);

                MessageBox.Show("Thêm mới nhân viên thành công!");

                // Tải lại dữ liệu vào DataGridView
                LoadData();
                clearTextBox()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các textbox
                NhanVien nhanVien = new NhanVien();
                nhanVien.CCCDNV = int.Parse(txtCCCD.Text);
                nhanVien.TenNV = txtTenNV.Text;
                nhanVien.NgaySinh = dtpNgaySinh.Value;
                nhanVien.GioiTinh = txtGioiTinh.Text;
                nhanVien.SDT = txtSDT.Text;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.ChucVu = txtChucVu.Text;

                TaiKhoan taiKhoan = new TaiKhoan();

                taiKhoan.TenTK = txtTenTK.Text;
                taiKhoan.MatKhau = txtMatKhau.Text;
                taiKhoan.CCCDNV = nhanVien.CCCDNV;

                // Cập nhật thông tin
                DAONhanVien.SuaNhanVien(nhanVien);
                DAOTaiKhoan.SuaTaiKhoan(taiKhoan);

                MessageBox.Show("Cập nhật thông tin thành công!");

                // Tải lại dữ liệu lên DataGridView
                LoadData();
                clearTextBox()
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int cccdNV = int.Parse(txtCCCD.Text);

                // Xóa thông tin trong bảng TaiKhoan và NhanVien
                DAOTaiKhoan.XoaTaiKhoan(cccdNV);
                DAONhanVien.XoaNhanVien(cccdNV);

                MessageBox.Show("Xóa nhân viên thành công!");

                // Tải lại dữ liệu lên DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void UC_QLThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void clearTextBox()
        {
            txtCCCD.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtGioiTinh.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.ResetText();
            txtChucVu.Clear();
        }

        private void dgv_thongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_thongTinNV.Rows[e.RowIndex];

                txtCCCD.Text = row.Cells["CCCDNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());

                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();

                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();

                txtTenTK.Text = row.Cells["TenTK"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }
    }
}
