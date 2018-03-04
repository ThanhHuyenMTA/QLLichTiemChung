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
    public partial class Luutrulichsutiem : UserControl
    {
        public Luutrulichsutiem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baocaolichsutiemcua1KH ls = new Baocaolichsutiemcua1KH();
            ls.Show();
        }
    }
}
