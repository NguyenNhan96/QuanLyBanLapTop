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
    public partial class QLBanHang : Form
    {
        public QLBanHang()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GioHang giohang = new GioHang();
            giohang.Show();
        }

        private void bt_xem_sp_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }
    }
}
