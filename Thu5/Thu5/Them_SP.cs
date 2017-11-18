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
    public partial class Them_SP : Form
    {
        public Them_SP()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();



        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if ((txt_MASP.Text != "") && (txt_TenSP.Text != "") && (txt_hang.Text != "") && (txt_gia.Text != "") && (txt_soluong.Text != "") && (cbb_tinhtrang.Text != ""))
            {
                
                
                    try
                    {
                        con.Open();
                        string add_SP = "insert into LAPTOP values (@MASP,@TenSP,@TenHang,@DonGia,@mota,@soluong,@tinhtrang)";
                        SqlCommand cmd = new SqlCommand(add_SP, con);
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
                        MessageBox.Show("Thêm sản phầm thành công!");
                        this.Close();
                    }
                    catch { MessageBox.Show("Không thể thêm sản phẩm! Vui lòng nhập lại."); }
                }
            
            else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
        }

        private void Them_SP_Load(object sender, EventArgs e)
        {

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
