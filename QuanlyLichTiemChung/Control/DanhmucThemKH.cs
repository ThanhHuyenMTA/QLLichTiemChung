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
    public partial class DanhmucThemKH : UserControl
    {
        Ketnoi a = new Ketnoi();
      
        public DanhmucThemKH()
        {
            InitializeComponent();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            DataTable data = a.khachhang();
            datakh.DataSource = data;
        }

        private void DanhmucThemKH_Load(object sender, EventArgs e)
        {
            DataTable data = a.khachhang();
            datakh.DataSource = data;
        }

        private void datakh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = datakh.Rows[e.RowIndex];
                
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                 date1.Text = row.Cells[3].Value.ToString();

                 if (row.Cells[4].Value.ToString()=="NAM")
                 {
                     radioButton1.Checked =false;
                     radioButton2.Checked = true;
                 }
                 else
                 {
                     radioButton1.Checked = true;
                     radioButton2.Checked = false;
                 }
                textBox8.Text = row.Cells[5].Value.ToString();
                textBox5.Text = row.Cells[6].Value.ToString();
                textBox3.Text = row.Cells[7].Value.ToString();
                textBox6.Text = row.Cells[8].Value.ToString();
                comboBox1.Text = row.Cells[9].Value.ToString();

            }
            catch (Exception)
            {
            }
        }
    }
}
