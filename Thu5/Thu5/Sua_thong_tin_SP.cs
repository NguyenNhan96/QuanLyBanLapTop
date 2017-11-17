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
    public partial class Sua_thong_tin_SP : Form
    {
        public Sua_thong_tin_SP()
        {
            InitializeComponent();
        }

        private void Sua_thong_tin_SP_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua thong tin san pham thanh cong!");
            this.Close();
        }
    }
}
