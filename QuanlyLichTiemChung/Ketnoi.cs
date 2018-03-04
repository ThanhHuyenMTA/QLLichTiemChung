using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyLichTiemChung
{
    class Ketnoi
    {
        public SqlConnection KetnoiData()
        {
            string strConection = @"Data Source=THANHHUYEN\SQLEXPRESS;Initial Catalog=LICHTIEMCHUNG;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConection);
            return conn;
        }
        SqlCommand cmd;
        SqlConnection con;

        //load khách hàng
        public DataTable khachhang()
        {
            con = KetnoiData();
            string str = "SELECT *FROM KHACHHANG";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ketqua = new DataTable("KH");
            da.Fill(ketqua);
            return ketqua;
         
        }
        //hiện thị lịch và vắc xin
        public DataTable lichchung()
        {
            con = KetnoiData();
            string str = "SELECT *FROM LICHTIEMCHUNG";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ketqua = new DataTable("LC");
            da.Fill(ketqua);
            return ketqua;

        }
        public DataTable vacxin()
        {
            con = KetnoiData();
            string str = "SELECT *FROM LOAIVACXIN";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ketqua = new DataTable("VX");
            da.Fill(ketqua);
            return ketqua;
        }

        //hiện thị lịch theo đối tượng
        public DataTable lichtheodt(string TENDT)
        {
            con = KetnoiData();
            cmd = new SqlCommand("LOADLICHCHUNG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter adapter = new SqlParameter("@TENDT",TENDT);
            cmd.Parameters.Add(adapter);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Ketqua = new DataTable("lichDT");
            da.Fill(Ketqua);
            return Ketqua;
        }
    }
}
