using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class TaiKhoan
    {
        private string tenTK;
        private string matKhau;
        private int cCCDNV;

        public TaiKhoan(string tenTK, string matKhau, int cCCDNV)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.CCCDNV = cCCDNV;
        }
        public TaiKhoan() { }

        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public int CCCDNV { get => cCCDNV; set => cCCDNV = value; }
    }

}
