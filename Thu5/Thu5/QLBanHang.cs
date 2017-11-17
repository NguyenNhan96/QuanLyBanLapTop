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




private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GioHang giohang = new GioHang();
            giohang.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thong_Ke thongke = new Thong_Ke();
            thongke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLySP quanly = new QuanLySP();
            quanly.Show();
        }
    }
}
