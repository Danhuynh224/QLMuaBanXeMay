using QLMuaBanXeMay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.WF
{
    public partial class Form_ThongTinPhuTung : Form
    {
        private PhuTung phuTung;

        public Form_ThongTinPhuTung(PhuTung phuTung)
        {
            InitializeComponent();
            this.phuTung = phuTung;
        }

        public PhuTung PhuTung { get => phuTung; set => phuTung = value; }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            phuTung.MaPT = Convert.ToInt32(MaPT_textBox.Text);
            phuTung.TenPT= TenPT_textBox.Text;
            phuTung.ChatLieu=ChatLieutextBox.Text;
            phuTung.HangSX=HangSXtextBox.Text;
            phuTung.DonGia= float.Parse(DonGiatextBox.Text);
            phuTung.SoLuongTon = Convert.ToInt32(SLTontextBox.Text);
            this.DialogResult = DialogResult.OK; // Thiết lập kết quả đối thoại
            this.Close(); // Đóng Form2
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
