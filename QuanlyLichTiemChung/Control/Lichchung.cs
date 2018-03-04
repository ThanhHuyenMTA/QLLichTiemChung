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
    public partial class Lichchung : UserControl
    {
        public Lichchung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            panelc.Controls.Clear();
            Lichtiemchung lc = new Lichtiemchung();
            panelc.Controls.Add(lc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelc.Controls.Clear();
            Chucnanglichchung cn = new Chucnanglichchung();
            panelc.Controls.Add(cn);
        }
    }
}
