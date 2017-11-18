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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Them san pham thanh cong!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            con.Open();
            string add_SP = "insert into LAPTOP values (@MASP,@TenSP,@TenHang,@DonGia,@ngaynhap,@mota,@soluong,@tinhtrang)";
            SqlCommand cmd = new SqlCommand(add_SP, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@MASP", txt_MASP.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TenSP", txt_TenSP.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@TenHang", txt_hang.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@DonGia", txt_gia.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", date_ngaynhap.Value));
            cmd.Parameters.Add(new SqlParameter("@mota", txt_mota.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@soluong", txt_soluong.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@tinhtrang", cbb_tinhtrang.Text.Trim()));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phầm thành công!");
            this.Close();
        }

        private void Them_SP_Load(object sender, EventArgs e)
        {

        }
    }
}
