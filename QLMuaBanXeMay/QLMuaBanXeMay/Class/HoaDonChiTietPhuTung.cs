﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class ChiTietHD_PT
    {
        private int maHDPT;
        private int maPT;
        private int soLuong;
        private float donGia;
        public ChiTietHD_PT() { }

        public ChiTietHD_PT(int maHDPT, int maPT, int soLuong, float donGia)
        {
            this.maHDPT = maHDPT;
            this.maPT = maPT;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public int MaHDPT
        {
            get { return maHDPT; }
            set { maHDPT = value; }
        }

        public int MaPT
        {
            get { return maPT; }
            set { maPT = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("SoLuong must be greater than 0.");
                soLuong = value;
            }
        }

        public float DonGia
        {
            get { return donGia; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("DonGia must be greater than 0.");
                donGia = value;
            }
        }
    }

}
