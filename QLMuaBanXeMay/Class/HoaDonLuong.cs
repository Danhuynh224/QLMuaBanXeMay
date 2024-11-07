using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class HoaDonLuong
    {
        private int maHDL;
        private string cCCDQL;
        private string cCCDNV;
        private int soGioLam;
        private DateTime ngayXuat;
        private decimal tongTien;

        public HoaDonLuong() { }

        public HoaDonLuong(int maHDL, string cCCDNV, int soGioLam, DateTime ngayXuat, decimal tongTien)
        {
            this.MaHDL = maHDL;
            this.CCCDNV = cCCDNV;
            this.SoGioLam = soGioLam;
            this.NgayXuat = ngayXuat;
            this.TongTien = tongTien;
        }

        public int MaHDL { get => maHDL; set => maHDL = value; }
        public string CCCDQL { get => cCCDQL; set => cCCDQL = value; }
        public string CCCDNV { get => cCCDNV; set => cCCDNV = value; }
        public int SoGioLam { get => soGioLam; set => soGioLam = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
    }
}
