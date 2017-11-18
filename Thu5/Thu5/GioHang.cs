using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thu5
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật giỏ hàng thành công!");
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            dataGioHang.Rows.Add("1","Asus 540XL", "10.499.000","1", "10.499.000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn hàng đã được gửi. Cửa hàng sẽ liên lạc với bạn ngay!");

        }
    }
}
