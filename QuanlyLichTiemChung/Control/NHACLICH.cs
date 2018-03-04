using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyLichTiemChung
{
    public partial class NHACLICH : UserControl
    {
        public NHACLICH()
        {
            InitializeComponent();
        }

        private void NHACLICH_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maunhaclich frm = new Maunhaclich();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
