using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class DoanhThu
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_HoaDon;
        public DataTable LoadHoaDon()
        {
            tb_HoaDon = new SqlDataAdapter("select * from HOADON", cnn);
            tb_HoaDon.Fill(QLKHACHSAN, "HOADON");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["HOADON"].Columns[0];
            QLKHACHSAN.Tables["HOADON"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["HOADON"];
        }
        public float LoadHoaDon(DateTime a, DateTime b)
        {
            float tongtien=0;
            tb_HoaDon = new SqlDataAdapter("select sum(TONGTIEN) from HOADON where '"+a+"'< NGAYLAP and NGAYLAP <'"+b+"'", cnn);
            tb_HoaDon.Fill(QLKHACHSAN, "HOADON");
            DataTable ds = QLKHACHSAN.Tables["HOADON"];
            foreach (DataRow row in ds.Rows)
            {
                tongtien = float.Parse(row[0].ToString());
            }
            return tongtien;
        }
    }
}
