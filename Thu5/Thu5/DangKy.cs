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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();

        private void DangKy_Load(object sender, EventArgs e)
        {
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if ((txt_tendn.Text != "") && (txt_hoten.Text != "") && (txt_mk.Text != "") && (txt_rmk.Text != ""))
            {
                if (txt_mk.Text != txt_rmk.Text)
                { MessageBox.Show("Nhập lại mật khẩu không đúng. Vui lòng kiểm tra lại!"); }
                else
                {
                    try
                    {
                        con.Open();
                        string add_TK = "insert into TAIKHOAN values (@username,@pass,@hoten)";
                        SqlCommand cmd = new SqlCommand(add_TK, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@username", txt_tendn.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@pass", txt_mk.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@hoten", txt_hoten.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Tạo tài khoản thành công!");
                        this.Close();
                    }
                    catch { MessageBox.Show("Không thể thêm sản phẩm! Vui lòng nhập lại."); }
                }
            }
            else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
