﻿using QLMuaBanXeMay.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnMotobike_Click(object sender, EventArgs e)
        {
            UC_QLXe uc = new UC_QLXe();
            uc.Dock = DockStyle.Fill;
            uC_MainScreen.Controls.Add(uc);
        }

        private void btnTool_Click(object sender, EventArgs e)
        {

        }

        private void btnBillBike_Click(object sender, EventArgs e)
        {
            
            UC_HoaDonXee uc = new UC_HoaDonXee();
            panel5.Controls.Clear();
            panel5.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            
        }

        private void btnBillTool_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }

        private void uC_MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
