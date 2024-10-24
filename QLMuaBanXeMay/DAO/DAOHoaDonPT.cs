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
    public partial class DAOHoaDonPT
    {
        public static void ThemHoaDonPT(HoaDonPT hoaDonPT)
        {
            using (SqlCommand command = new SqlCommand("ThemHoaDonPT", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaHDPT", hoaDonPT.MaHDPT);
                    command.Parameters.AddWithValue("@KhuyenMai", hoaDonPT.KhuyenMai);
                    command.Parameters.AddWithValue("@TongTien", hoaDonPT.TongTien);
                    command.Parameters.AddWithValue("@CCCDKH", hoaDonPT.CCCDKH);
                    command.Parameters.AddWithValue("@CCCDNV", hoaDonPT.CCCDNV);
                    command.Parameters.AddWithValue("@PTTT", hoaDonPT.PTTT);
                    command.Parameters.AddWithValue("@NgayXuat", hoaDonPT.NgayXuat);
                    MY_DB.openConnection();

                    command.ExecuteNonQuery();

                    MY_DB.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        public static void ThemChiTietHDPT(ChiTietHD_PT chiTietHD_PT)
        {
            using (SqlCommand command = new SqlCommand("ThemChiTietHDPT", MY_DB.getConnection()))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaHDPT", chiTietHD_PT.MaHDPT);
                    command.Parameters.AddWithValue("@MaPT", chiTietHD_PT.MaPT);
                    command.Parameters.AddWithValue("@SoLuong", chiTietHD_PT.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", chiTietHD_PT.DonGia);

                    MY_DB.openConnection();

                    command.ExecuteNonQuery();

                    MY_DB.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
        }
        public static DataTable Load_ViewHD()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetHoaDonPT()", MY_DB.getConnection()))
            {
                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }
        public static DataTable LayThongTinTheoMaHDPT(string maHD)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetHoaDonPTByMaHDPT(@maHD)", MY_DB.getConnection()))
            {
                command.Parameters.AddWithValue("@maHD", maHD); // Truyền tham số cho hàm

                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }
        public static DataTable Load_ViewChiTietHD(int maHD)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetChiTietHDPT(@maHD)", MY_DB.getConnection()))
            {
                command.Parameters.AddWithValue("@maHD", maHD); // Truyền tham số cho hàm

                MY_DB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MY_DB.closeConnection();

                return dt;
            }
        }

        public static String LayThongTinKhuyenMai(int cccd)
        {
            
            using (SqlCommand command = new SqlCommand("SELECT dbo.LayKhuyenMaiTuCCCD(@cccd)", MY_DB.getConnection()))
            {
                try
                {
                    command.Parameters.AddWithValue("@cccd", cccd);
                    MY_DB.openConnection();
                    string khuyenmai = command.ExecuteScalar().ToString();

                    MY_DB.closeConnection();

                    return khuyenmai;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return "0";
                }
             
            }
        }
    }
}
