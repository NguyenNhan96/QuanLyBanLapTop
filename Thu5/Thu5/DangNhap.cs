using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thu5
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap
        {
            get { return lblThongBao.Text; }
        }
        SqlConnection con = DBConnecter.sqlConnector();
        private FormClosedEventHandler dangky_FormClosed;

        private void DangNhap_Load(object sender, EventArgs e)
        {
            con.Open();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.FormClosed += new FormClosedEventHandler(dangky_formclosed);
            dangky.Show();
            this.Hide();
        }

        private void dangky_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("selectOne_TaiKhoan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userName", txtTenDangNhap.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@passWord", txtMatKhau.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                SqlCommand com2 = new SqlCommand("select HOTEN from TAIKHOAN where USERNAME = @USERNAME ", con);
                com2.Parameters.AddWithValue("USERNAME", txtTenDangNhap.Text);
                com2.CommandType = CommandType.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(com2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    lblThongBao.Text = "Xin chào: "+ dt2.Rows[0][0].ToString();
                    if(txtTenDangNhap.Text=="admin")
                    {
                        QuanLySP quanly = new QuanLySP();
                        quanly.xinchao = tendangnhap;
                        quanly.FormClosed += new FormClosedEventHandler(quanly_formclosed);
                        quanly.Show();
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        lblThongBao.Text = "";
                        this.Hide();
                        
                    }
                    else
                    {
                        QLBanHang quanly = new QLBanHang();
                        quanly.xinchao = tendangnhap;
                        quanly.FormClosed += new FormClosedEventHandler(quanly_formclosed);
                        quanly.Show();
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        lblThongBao.Text = "";
                        this.Hide();
                    }
                }
                else
                {
                    lblThongBao.Text = "Username or password is not correct.";
                    txtMatKhau.Text = txtMatKhau.Tag.ToString();
                    txtTenDangNhap.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.Close();
        }

        private void quanly_formclosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == txtTenDangNhap.Tag.ToString())
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "") //Trim() -> tra ve ban sao
            {
                txtTenDangNhap.Text = txtTenDangNhap.Tag.ToString();
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtMatKhau.Tag.ToString())
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                txtMatKhau.Text = txtMatKhau.Tag.ToString();
                txtMatKhau.ForeColor = Color.Silver;
            }
        }
    }
}
