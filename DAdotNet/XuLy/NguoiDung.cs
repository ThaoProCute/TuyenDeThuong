using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class NguoiDung
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_NguoiDung;
        public DataTable loadNguoiDung()
        {
            tb_NguoiDung = new SqlDataAdapter("SELECT * FROM QLIDANGNHAP",cnn);
            tb_NguoiDung.Fill(QLKHACHSAN, "QLIDANGNHAP");
            return QLKHACHSAN.Tables["QLIDANGNHAP"];
        }
        public bool DangNhap(string ptk,string pmk, string pphanquyen)
        {
            try
            {
                string kt = QLKHACHSAN.Tables["QLIDANGNHAP"].Rows[0]["TENDN"].ToString();
                string kt1 = QLKHACHSAN.Tables["QLIDANGNHAP"].Rows[0]["MKDN"].ToString();
                string kt2 = QLKHACHSAN.Tables["QLIDANGNHAP"].Rows[0]["LOAINGUOIDUNG"].ToString();
                if (kt == ptk && kt1 == pmk && kt2 == pphanquyen)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
