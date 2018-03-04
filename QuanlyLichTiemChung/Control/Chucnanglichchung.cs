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
    public partial class Chucnanglichchung : UserControl
    {
        Ketnoi a = new Ketnoi();
        public Chucnanglichchung()
        {
            InitializeComponent();
        }
        private void Chucnanglichchung_Load(object sender, EventArgs e)
        {
            DataTable dataltc = a.lichchung();
            datalc.DataSource = dataltc;
            DataTable vacx = a.vacxin();
            datavacxin.DataSource = vacx;
        }
        private void btnhienthiLC_Click(object sender, EventArgs e)
        {
            DataTable dataltc = a.lichchung();
            datalc.DataSource = dataltc;
            DataTable vacx = a.vacxin();
            datavacxin.DataSource = vacx;
        }

        private void datavacxin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = datavacxin.Rows[e.RowIndex];

                textBox3.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[1].Value.ToString();
                richTextBox2.Text = row.Cells[2].Value.ToString();
                richTextBox1.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception)
            {
            }
        }

        private void datalc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = datalc.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
                richTextBox3.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception)
            {
            }
        }
    }
}
