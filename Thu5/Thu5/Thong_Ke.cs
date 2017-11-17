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
    public partial class Thong_Ke : Form
    {
        public Thong_Ke()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thong_Ke_Load(object sender, EventArgs e)
        {


            dataGridView1.Rows.Add("1", "AS540", "Asus 540XL", "Asus", "10.499.000", "1", "10.499.000","08:30 - 15/11/2017");
            dataGridView1.Rows.Add("2", "AS450", "Asus 450XL", "Asus", "10.000.000", "1", "10.000.000", "08:30 - 16/11/2017");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
