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
    public partial class QuanLySP : Form
    {
        public QuanLySP()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private object da;
        private object ds;
        private string masp, tensp, tenhangsx, mota, tinhtrang;
        private int gia, soluong;
        private string ngaynhap;
        private void loadToTextBox(Boolean check)
        {
            if (check)
            {
                int curRow;
                try
                {
                    curRow = this.data_DSSP.CurrentRow.Index;
                    //txtMaSach.Text = this.dsSach.Rows[curRow].Cells[0].Value.ToString();
                    this.masp = this.data_DSSP.Rows[curRow].Cells[0].Value.ToString();
                    this.gia = Int32.Parse(this.data_DSSP.Rows[curRow].Cells[3].Value.ToString());
                    this.tensp = this.data_DSSP.Rows[curRow].Cells[1].Value.ToString();
                    this.soluong = Int32.Parse(this.data_DSSP.Rows[curRow].Cells[5].Value.ToString());
                    this.mota = this.data_DSSP.Rows[curRow].Cells[4].Value.ToString();
                    this.tenhangsx = this.data_DSSP.Rows[curRow].Cells[2].Value.ToString();
                    this.tinhtrang = this.data_DSSP.Rows[curRow].Cells[6].Value.ToString();
                }
                catch
                { }
            }
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
        private void load()
        {
            con.Open();
            string sql = "select * from LAPTOP";
            SqlCommand ds = new SqlCommand(sql, con); 
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds); 
            DataTable dt = new DataTable();
            da.Fill(dt);  
            con.Close();  
            data_DSSP.DataSource = dt; 
        }
        private void QuanLySP_Load(object sender, EventArgs e)
        {
            loadToComboBox();
            load();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void bt_timkiem_Click_1(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            if (cbb_hang.Text == "Hãng")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LAPTOP where TENSP like'%" + txt_timkiem.Text + "%'", con);
                da.Fill(dt);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LAPTOP where TENHANGSX like '%"+cbb_hang.Text+"%' and TENSP like'%" + txt_timkiem.Text + "%'", con);
                da.Fill(dt);
            }
            data_DSSP.DataSource = dt;
            con.Close();
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            loadToTextBox(true);
            Sua_thong_tin_SP edit = new Sua_thong_tin_SP(masp, tensp, tenhangsx, gia, mota, soluong, tinhtrang);
            edit.FormClosed += new FormClosedEventHandler(add_formclose);
            edit.Show();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Them_SP add = new Them_SP();
            add.FormClosed += new FormClosedEventHandler(add_formclose);
            add.Show();
        }

        private void add_formclose(object sender, FormClosedEventArgs e)
        {
            loadToComboBox();
            load();
        }
        private void edit_formclose(object sender, FormClosedEventArgs e)
        {
            loadToComboBox();
            load();
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            int curRow = this.data_DSSP.CurrentRow.Index;
            string del_SP = "delete from LAPTOP where MASP=@MASP";
            SqlCommand cmd = new SqlCommand(del_SP, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@MASP", this.masp = this.data_DSSP.Rows[curRow].Cells[0].Value.ToString()));
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                load();
                loadToComboBox();
                
            }
            else con.Close();
        }
    }
}
