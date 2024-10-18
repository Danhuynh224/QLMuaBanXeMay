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
            // Khởi tạo User Control
            UC_QLXe uC_QLXe = new UC_QLXe();

            // Đặt Dock cho User Control (tùy chọn, nếu muốn User Control chiếm toàn bộ diện tích của Panel)
            uC_QLXe.Dock = DockStyle.Fill;

            // Xóa các control cũ (nếu muốn) trong panel
            Main_panel.Controls.Clear();

            // Thêm User Control vào Panel
            Main_panel.Controls.Add(uC_QLXe);

        }
    }
}
