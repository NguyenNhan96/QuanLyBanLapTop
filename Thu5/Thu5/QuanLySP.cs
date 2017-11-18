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
    public partial class QuanLySP : Form
    {
        public QuanLySP()
        {
            InitializeComponent();
        }

        private void QuanLySP_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sua_thong_tin_SP sp = new Sua_thong_tin_SP();
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Them_SP sp = new Them_SP();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xoa san pham thanh cong!");
        }

 
    }
}
