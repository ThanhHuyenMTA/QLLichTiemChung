using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanlyLichTiemChung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lICHTIEMCHUNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Lichchung lc = new Lichchung();
            panel1.Controls.Add(lc);
            panel1.Dock = DockStyle.Fill;
        }
        private void qLKHACHHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            QLKhachHang Qlkh = new QLKhachHang();
            panel1.Controls.Add(Qlkh);
            panel1.Dock = DockStyle.Fill;      
        }

        private void bAOCAOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NHACLICH nl = new NHACLICH();
            panel1.Controls.Add(nl);
            panel1.Dock = DockStyle.Fill;
        }

    }
}
