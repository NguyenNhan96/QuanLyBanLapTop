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
    public partial class Sua_thong_tin_SP : Form
    {
        public Sua_thong_tin_SP()
        {
            InitializeComponent();
        }
        public Sua_thong_tin_SP(string masp, string tensp, string tenhangsx, int gia, DateTime ngaynhap, string mota, int soluong, string tinhtrang)
            : this()
        {
            txt_MASP.Text = masp; txt_TenSP.Text = tensp; txt_hang.Text = tenhangsx;
            txt_gia.Text = gia.ToString(); date_ngaynhap.Value = ngaynhap.Date; txt_soluong.Text = soluong.ToString();
            txt_mota.Text = mota;
        }

        private void Sua_thong_tin_SP_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua thong tin san pham thanh cong!");
            this.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thông tin sản phẩm thành công!");
            this.Close();
        }
    }
}
