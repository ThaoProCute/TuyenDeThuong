using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class DanhSachNhanPhong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_DSNhanPhong;
        SqlDataAdapter Tim_DSNhanPhong;
        public DataTable loadsNHanPhong()
        {
            tb_DSNhanPhong = new SqlDataAdapter("select * from NHANPHONG", cnn);
            tb_DSNhanPhong.Fill(QLKHACHSAN, "NHANPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANPHONG"].Columns[0];
            QLKHACHSAN.Tables["NHANPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public DataTable TimTheoMaNP(string txttk)
        {
            this.QLKHACHSAN.Tables["NHANPHONG"].Clear();
            Tim_DSNhanPhong = new SqlDataAdapter("SELECT * FROM NHANPHONG WHERE MANHANPHONG = '" + txttk + "'", cnn);
            Tim_DSNhanPhong.Fill(QLKHACHSAN, "NHANPHONG");
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public DataTable TimMaDP(string txttk)
        {
            this.QLKHACHSAN.Tables["NHANPHONG"].Clear();
            Tim_DSNhanPhong = new SqlDataAdapter("SELECT * FROM NHANPHONG WHERE MADAT = '" + txttk + "'", cnn);
            Tim_DSNhanPhong.Fill(QLKHACHSAN, "NHANPHONG");
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public DataTable TimMaKhachHang(string txttk)
        {
            this.QLKHACHSAN.Tables["NHANPHONG"].Clear();
            Tim_DSNhanPhong = new SqlDataAdapter("SELECT * FROM NHANPHONG WHERE MAKHACH = '" + txttk + "'", cnn);
            Tim_DSNhanPhong.Fill(QLKHACHSAN, "NHANPHONG");
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
    }
}
