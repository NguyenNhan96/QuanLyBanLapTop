using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thu5
{
    public partial class Sua_thong_tin_SP : Form
    {
        public Sua_thong_tin_SP()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        public Sua_thong_tin_SP(string masp, string tensp, string tenhangsx, int gia, string mota, int soluong, string tinhtrang)
            : this()
        {
            txt_MASP.Text = masp; txt_TenSP.Text = tensp; txt_hang.Text = tenhangsx;
            txt_gia.Text = gia.ToString(); txt_soluong.Text = soluong.ToString();
            txt_mota.Text = mota; cbb_tinhtrang.Text = tinhtrang;
        }

        private void Sua_thong_tin_SP_Load(object sender, EventArgs e)
        {
            
        }


        private void bt_ok_Click_1(object sender, EventArgs e)
        {
            if ((txt_TenSP.Text != "") && (txt_hang.Text != "") && (txt_gia.Text != "") && (txt_soluong.Text != "") && (cbb_tinhtrang.Text != ""))
            {
                    try
                    {
                        con.Open();
                        string edit_SP = "update LAPTOP set TENSP=@TenSP,TENHANGSX=@TenHang,GIA=@DonGia,MOTA=@mota,SOLUONG=@soluong,TINHTRANG=@tinhtrang where MASP=@MASP";
                        SqlCommand cmd = new SqlCommand(edit_SP, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@MASP", txt_MASP.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@TenSP", txt_TenSP.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@TenHang", txt_hang.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@DonGia", txt_gia.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@mota", txt_mota.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@soluong", txt_soluong.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@tinhtrang", cbb_tinhtrang.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sửa thông tin sản phẩm thành công!");
                        this.Close();
                    }
                    catch { MessageBox.Show("Không thể thêm sản phẩm! Vui lòng nhập lại."); }
            }
            else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
        }

        private void bt_huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
