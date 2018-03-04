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
    public partial class Lichtiemchung : UserControl
    {
        Ketnoi a = new Ketnoi();
        public Lichtiemchung()
        {
            InitializeComponent();
        }

        private void Lichtiemchung_Load(object sender, EventArgs e)
        {
            string tendt = combDT.Text;
            DataTable datalc = a.lichtheodt(tendt);
            dataThLich.DataSource = datalc;
        }

        private void btnloadlich_Click(object sender, EventArgs e)
        {
            string tendt=combDT.Text;
            DataTable datalc = a.lichtheodt(tendt);
            dataThLich.DataSource = datalc;
        }

       
    }
}
