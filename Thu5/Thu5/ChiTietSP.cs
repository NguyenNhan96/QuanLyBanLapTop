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
    public partial class ChiTietSP : Form
    {
        public ChiTietSP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang giohang = new GioHang();
            giohang.Show();
        }
        public ChiTietSP( string tensp, string tenhangsx, int gia, string mota, string tinhtrang)
            : this()
        {
            txt_tensp.Text = tensp; txt_hang.Text = tenhangsx;
            txt_gia.Text = gia.ToString();
            txt_mota.Text = mota; txt_tinhtrang.Text = tinhtrang;
        }
        private void ChiTietSP_Load(object sender, EventArgs e)
        {

        }
    }
}
