using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.DAO
{
    public partial  class DAOHoaDonXe
    {
        public static String LayThongTinKhuyenMai(int cccd)
        {

            using (SqlCommand command = new SqlCommand("SELECT dbo.LayKhuyenMaiTuCCCD(@cccd)", MY_DB.getConnection()))
            {
                command.Parameters.AddWithValue("@cccd", cccd);
                MY_DB.openConnection();
                string khuyenmai = command.ExecuteScalar().ToString();

                MY_DB.closeConnection();

                return khuyenmai;

            }


        }
        public static DataTable LayThongTinTheoMaHDXe(string maHD)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM View_HoaDonXe WHERE MaHDXe LIKE @maHD", MY_DB.getConnection()))
            {
                MY_DB.openConnection();
                command.Parameters.AddWithValue("@maHD", "%" + maHD + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        internal static void ThemHoaDonXe(HoaDonXe hoaDonXe)
        {
            using (SqlCommand command = new SqlCommand("ThemHoaDonXe", MY_DB.getConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaHDXe", hoaDonXe.MaHDXe);
                command.Parameters.AddWithValue("@MaXe", hoaDonXe.MaXe);
                command.Parameters.AddWithValue("@KhuyenMai", hoaDonXe.KhuyenMai);
                command.Parameters.AddWithValue("@TongTien", hoaDonXe.TongTien);
                command.Parameters.AddWithValue("@CCCDKH", hoaDonXe.CCCDKH);
                command.Parameters.AddWithValue("@CCCDNV", hoaDonXe.CCCDNV);
                command.Parameters.AddWithValue("@PTTT", hoaDonXe.PTTT);
                command.Parameters.AddWithValue("@NgayXuat", hoaDonXe.NgayXuat);
                MY_DB.openConnection();

                command.ExecuteNonQuery();

                MY_DB.closeConnection();
            }
        }
        public static DataTable Load_ViewHD()
        {
            using (SqlCommand command = new SqlCommand("Select * From View_HoaDonXe", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }
    }
}
