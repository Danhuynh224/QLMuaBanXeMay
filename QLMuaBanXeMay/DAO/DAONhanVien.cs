using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.DAO
{
    internal class DAONhanVien
    {
        public static void ThemNhanVien(NhanVien nhanVien)
        {
            using (SqlCommand command = new SqlCommand("ThemNhanVien", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCCDNV", nhanVien.CCCDNV);
                    command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                    command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                    command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                    command.Parameters.AddWithValue("@Email", nhanVien.Email);
                    command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);

                    MY_DB.openConnection();
                    command.ExecuteNonQuery();
                    MY_DB.closeConnection();
                }
                catch
                {
                    MessageBox.Show("Thông tin không hợp lệ");
                }
            }
        }


        public static DataTable LayThongTinNhanVien()
        {
            using (SqlCommand command = new SqlCommand("SELECT NhanVien.CCCDNV, TenNV, NgaySinh, GioiTinh, SDT, DiaChi, Email, ChucVu, TenTK, MatKhau " +
                                                       "FROM NhanVien " +
                                                       "INNER JOIN TaiKhoan ON NhanVien.CCCDNV = TaiKhoan.CCCDNV", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        public static void SuaNhanVien(NhanVien nhanVien)
        {
            using (SqlCommand command = new SqlCommand("SuaNhanVien", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CCCDNV", nhanVien.CCCDNV);
                command.Parameters.AddWithValue("@TenNV", nhanVien.TenNV);
                command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@Email", nhanVien.Email);
                command.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }

        public static void XoaNhanVien(int cccdNV)
        {
            using (SqlCommand command = new SqlCommand("XoaNhanVien", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CCCDNV", cccdNV);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }
    }
}
