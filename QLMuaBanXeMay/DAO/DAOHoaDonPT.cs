﻿using QLMuaBanXeMay.Class;
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
        public static int ThemHoaDonPT(HoaDonPT hoaDonPT)
        {
                int maHDPT;
                using (SqlCommand cmd = new SqlCommand("ThemHoaDonPT", MY_DB.getConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    cmd.Parameters.AddWithValue("@KhuyenMai", hoaDonPT.KhuyenMai);
                    cmd.Parameters.AddWithValue("@TongTien", hoaDonPT.TongTien);
                    cmd.Parameters.AddWithValue("@CCCDKH", hoaDonPT.CCCDKH);
                    cmd.Parameters.AddWithValue("@CCCDNV", hoaDonPT.CCCDNV);
                    cmd.Parameters.AddWithValue("@PTTT", hoaDonPT.PTTT);
                    cmd.Parameters.AddWithValue("@NgayXuat", hoaDonPT.NgayXuat);

                MY_DB.openConnection();
                    SqlParameter outputIdParam = new SqlParameter("@MaHDPT", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    // Thực thi lệnh
                    cmd.ExecuteNonQuery();
                MY_DB.closeConnection();
                    // Lấy giá trị MaHDPT vừa thêm
                    maHDPT = Convert.ToInt32(outputIdParam.Value);
                }
        
            return maHDPT;
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
