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
        private DateTime ngaynhap;
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
                    this.soluong = Int32.Parse(this.data_DSSP.Rows[curRow].Cells[6].Value.ToString());
                    this.mota = this.data_DSSP.Rows[curRow].Cells[5].Value.ToString();
                    this.tenhangsx = this.data_DSSP.Rows[curRow].Cells[2].Value.ToString();
                    this.tinhtrang = this.data_DSSP.Rows[curRow].Cells[7].Value.ToString();
                    this.ngaynhap = DateTime.Parse(this.data_DSSP.Rows[curRow].Cells[4].Value.ToString());
                }
                catch
                { }
            }
        }

        public string xinchao
        {
            set { lb_xinchao.Text = value; }
        }
        private void load()
        {
            con.Open();
            string sql = "select * from LAPTOP";
            SqlCommand ds = new SqlCommand(sql, con); //bat dau truy van
            ds.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ds); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            data_DSSP.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void QuanLySP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Sua_thong_tin_SP edit = new Sua_thong_tin_SP(masp,tensp,tenhangsx,gia,ngaynhap,mota,soluong,tinhtrang);
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
            load();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            int CurrentIndex = data_DSSP.CurrentCell.RowIndex;
            string Masv = Convert.ToString(data_DSSP.Rows[CurrentIndex].Cells[0].Value.ToString());
            string deletedStr = "Delete from Sinhvien where Masv='" + Masv + "'";
            SqlCommand deletedCmd = new SqlCommand(deletedStr, con);
            deletedCmd.CommandType = CommandType.Text;
            deletedCmd.ExecuteNonQuery();
            
            MessageBox.Show("Xóa sản phẩm thành công!");
        }
    }
}
