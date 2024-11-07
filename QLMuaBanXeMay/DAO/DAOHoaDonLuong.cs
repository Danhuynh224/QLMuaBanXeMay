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
    public class DAOHoaDonLuong
    {
        public bool InsertHoaDonLuong(HoaDonLuong hoaDonLuong)
        {
            using (SqlCommand cmd = new SqlCommand("InsertSalaryInvoice", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CCCDNV", hoaDonLuong.CCCDNV);
                cmd.Parameters.AddWithValue("@SoGioLam", hoaDonLuong.SoGioLam);
                cmd.Parameters.AddWithValue("@NgayXuat", hoaDonLuong.NgayXuat);
                cmd.Parameters.AddWithValue("@TongTien", hoaDonLuong.TongTien);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result > 0;
            }
        }


        public List<HoaDonLuong> GetAllHoaDonLuong()
        {
            List<HoaDonLuong> hoaDonLuongList = new List<HoaDonLuong>();

            using (SqlCommand cmd = new SqlCommand("GetSalaryInvoices", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HoaDonLuong hoaDonLuong = new HoaDonLuong
                    {
                        MaHDL = Convert.ToInt32(reader["MaHDL"]),
                        CCCDNV = reader["CCCDNV"].ToString(),
                        SoGioLam = Convert.ToInt32(reader["SoGioLam"]),
                        NgayXuat = Convert.ToDateTime(reader["NgayXuat"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"])
                    };
                    hoaDonLuongList.Add(hoaDonLuong);
                }
                reader.Close();
                cmd.Connection.Close();
            }

            return hoaDonLuongList;
        }

        
        public decimal CalculateSalary(string cccdNV, int soGioLam)
        {
            using (SqlCommand cmd = new SqlCommand("CalculateSalary", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CCCDNV", cccdNV);
                cmd.Parameters.AddWithValue("@SoGioLam", soGioLam);

                SqlParameter outputParam = new SqlParameter("@TongTien", SqlDbType.Decimal) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(outputParam);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (decimal)outputParam.Value;
            }
        }

        
        public bool UpdateHoaDonLuong(HoaDonLuong hoaDonLuong)
        {
            using (SqlCommand cmd = new SqlCommand("UpdateSalaryInvoice", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHDL", hoaDonLuong.MaHDL);
                cmd.Parameters.AddWithValue("@CCCDNV", hoaDonLuong.CCCDNV);
                cmd.Parameters.AddWithValue("@SoGioLam", hoaDonLuong.SoGioLam);
                cmd.Parameters.AddWithValue("@NgayXuat", hoaDonLuong.NgayXuat);
                cmd.Parameters.AddWithValue("@TongTien", hoaDonLuong.TongTien);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result > 0;
            }
        }

        
        public HoaDonLuong GetHoaDonLuongById(int maHDL)
        {
            HoaDonLuong hoaDonLuong = null;

            using (SqlCommand cmd = new SqlCommand("GetSalaryInvoiceById", MY_DB.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHDL", maHDL);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hoaDonLuong = new HoaDonLuong
                    {
                        MaHDL = Convert.ToInt32(reader["MaHDL"]),
                        CCCDNV = reader["CCCDNV"].ToString(),
                        SoGioLam = Convert.ToInt32(reader["SoGioLam"]),
                        NgayXuat = Convert.ToDateTime(reader["NgayXuat"]),
                        TongTien = Convert.ToDecimal(reader["TongTien"])
                    };
                }
                reader.Close();
                cmd.Connection.Close();
            }

            return hoaDonLuong;
        }
    }
}
