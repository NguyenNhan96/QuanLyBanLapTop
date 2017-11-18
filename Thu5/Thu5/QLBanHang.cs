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
    public partial class QLBanHang : Form
    {
        public QLBanHang()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private void search_Click(object sender, EventArgs e)
        {

        }

        public string xinchao
        {
            set { lb_xinchao.Text = value; }
        }

        private void bt_xem_sp_Click(object sender, EventArgs e)
        {
            ChiTietSP sp = new ChiTietSP();
            sp.Show();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_giohang_Click(object sender, EventArgs e)
        {
            GioHang giohang = new GioHang();
            giohang.Show();
        }

        private void QLBanHang_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select TENSP,TENHANGSX,GIA,MOTA,TINHTRANG from LAPTOP";
            SqlCommand da = new SqlCommand(sql, con); //bat dau truy van
            da.CommandType = CommandType.Text;
            SqlDataAdapter db = new SqlDataAdapter(da); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            db.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            data_DSSP.DataSource = dt; //đổ dữ liệu vào datagridview
        }


    }
}
