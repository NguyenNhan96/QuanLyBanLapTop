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
        public void loadToComboBox()
        {
            con.Open();
            string sql = "select DISTINCT TENHANGSX from LAPTOP";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbb_hang.DataSource = dt;
            cbb_hang.DisplayMember = "TENHANGSX";
            cbb_hang.ValueMember = "TENHANGSX";
            cbb_hang.Text = "Hãng";
            con.Close();
        }

        public string xinchao
        {
            set { lb_xinchao.Text = value; }
        }
        string tensp, mota, tenhangsx, tinhtrang;
        int gia;
        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    curRow = this.data_DSSP.CurrentRow.Index;
                    //txtMaSach.Text = this.dsSach.Rows[curRow].Cells[0].Value.ToString();
                    this.gia = Int32.Parse(this.data_DSSP.Rows[curRow].Cells[2].Value.ToString());
                    this.tensp = this.data_DSSP.Rows[curRow].Cells[0].Value.ToString();
                    this.mota = this.data_DSSP.Rows[curRow].Cells[3].Value.ToString();
                    this.tenhangsx = this.data_DSSP.Rows[curRow].Cells[1].Value.ToString();
                    this.tinhtrang = this.data_DSSP.Rows[curRow].Cells[4].Value.ToString();
                }
                catch
                { }
            }
        }
        private void bt_xem_sp_Click(object sender, EventArgs e)
        {
            loadToTextBox(true);
            ChiTietSP sp = new ChiTietSP(tensp,tenhangsx,gia,mota,tinhtrang);
            sp.Show();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            if (cbb_hang.Text == "Hãng")
            {
                SqlDataAdapter da = new SqlDataAdapter("select TENSP,TENHANGSX,GIA,MOTA,TINHTRANG from LAPTOP where TENSP like'%" + txt_timkiem.Text + "%'", con);
                da.Fill(dt);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select TENSP,TENHANGSX,GIA,MOTA,TINHTRANG from LAPTOP where TENHANGSX like '%" + cbb_hang.Text + "%' and TENSP like'%" + txt_timkiem.Text + "%'", con);
                da.Fill(dt);
            }
            data_DSSP.DataSource = dt;
            con.Close();
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
            SqlCommand da = new SqlCommand(sql, con); 
            da.CommandType = CommandType.Text;
            SqlDataAdapter db = new SqlDataAdapter(da); 
            DataTable dt = new DataTable();
            db.Fill(dt); 
            con.Close();  
            data_DSSP.DataSource = dt;
            loadToComboBox();

        }


    }
}
