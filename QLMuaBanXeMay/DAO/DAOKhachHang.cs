using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.DAO
{
    internal class DAOKhachHang
    {
        public static DataTable LayDanhSachKhachHang()
        {
            using (SqlCommand command = new SqlCommand("LayDanhSachKhachHang", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                MY_DB.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MY_DB.closeConnection();

                return dt;
            }
        }

        public static void ThemKhachHang(KhachHang khachHang)
        {
            using (SqlCommand command = new SqlCommand("ThemKhachHang", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CCCDKH", khachHang.CCCDKH);
                command.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                command.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", khachHang.GioiTinh);
                command.Parameters.AddWithValue("@SDT", khachHang.SDT);
                command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                command.Parameters.AddWithValue("@Email", khachHang.Email);
                command.Parameters.AddWithValue("@MaLoai", khachHang.MaLoai);
                command.Parameters.AddWithValue("@TongChiTieu", khachHang.TongChiTieu);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }

        public static void SuaKhachHang(KhachHang khachHang)
        {
            using (SqlCommand command = new SqlCommand("SuaKhachHang", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CCCDKH", khachHang.CCCDKH);
                command.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                command.Parameters.AddWithValue("@NgaySinh", khachHang.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", khachHang.GioiTinh);
                command.Parameters.AddWithValue("@SDT", khachHang.SDT);
                command.Parameters.AddWithValue("@DiaChi", khachHang.DiaChi);
                command.Parameters.AddWithValue("@Email", khachHang.Email);
                command.Parameters.AddWithValue("@MaLoai", khachHang.MaLoai);
                command.Parameters.AddWithValue("@TongChiTieu", khachHang.TongChiTieu);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }

        public static void XoaKhachHang(int cccdKH)
        {
            using (SqlCommand command = new SqlCommand("XoaKhachHang", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CCCDKH", cccdKH);

                MY_DB.openConnection();
                command.ExecuteNonQuery();
                MY_DB.closeConnection();
            }
        }

        public static DataTable TimKhachHangTheoCCCD(int cccdKH)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE CCCDKH = @CCCDKH", MY_DB.getConnection()))
            {
                MY_DB.openConnection();
                command.Parameters.AddWithValue("@CCCDKH", cccdKH);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MY_DB.closeConnection();

                return dt;
            }
        }
    }
}
