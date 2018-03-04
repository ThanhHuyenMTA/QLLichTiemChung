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
    public partial class QLKhachHang : UserControl
    {
       
        public QLKhachHang()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelkh.Controls.Clear();
            Lichtiemrieng lr = new Lichtiemrieng();
            panelkh.Controls.Add(lr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelkh.Controls.Clear();
            Luutrulichsutiem lt = new Luutrulichsutiem();
            panelkh.Controls.Add(lt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelkh.Controls.Clear();
            DanhmucThemKH kh = new DanhmucThemKH();
            panelkh.Controls.Add(kh);          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelkh.Controls.Clear();
            NHACLICH kh = new NHACLICH();
            panelkh.Controls.Add(kh);
        }

    }
}
