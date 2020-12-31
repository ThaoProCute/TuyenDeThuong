using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    class DangNhap
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter dn_TaiKhoan;
        public DataTable LoadCTHoaDon()
        {
            dn_TaiKhoan = new SqlDataAdapter("select * from QLIDANGNHAP", cnn);
            dn_TaiKhoan.Fill(QLKHACHSAN, "QLIDANGNHAP");
            return QLKHACHSAN.Tables["QLIDANGNHAP"];
        }
        public int LoadCTHoaDon1(string tk,string mk,string nd)
        {
            int kqint = 0;
            dn_TaiKhoan = new SqlDataAdapter("select COUNT(*) from QLIDANGNHAP where TENDN='" + tk + "' AND MKDN='" + mk + "' AND LOAINGUOIDUNG='" + nd + "'", cnn);
            dn_TaiKhoan.Fill(QLKHACHSAN, "QLIDANGNHAP");
            DataTable ds = QLKHACHSAN.Tables["QLIDANGNHAP"];
            foreach (DataRow row in ds.Rows)
            {
                kqint = int.Parse(row[0].ToString());
            }
            return kqint;
        }
        //public string KiemTraTinhtrang(string map)
        //{
        //    string kq = "";
        //    tb_TKPhong = new SqlDataAdapter("SELECT TINHTRANG FROM PHONG WHERE MAPHONG='" + map + "'", cnn);
        //    tb_TKPhong.Fill(QLKHACHSAN, "TT");
        //    DataTable ds = QLKHACHSAN.Tables["TT"];
        //    foreach (DataRow row in ds.Rows)
        //    {
        //        kq = row[0].ToString();
        //    }
        //    return kq;
        //}

        
    }
}
