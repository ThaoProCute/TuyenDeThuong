using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    class DanhSachSuDungDichVu
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_DSSDDV;
        SqlDataAdapter tim_DSSDDV;
        public DataTable loadsNHanPhong()
        {
            tb_DSSDDV = new SqlDataAdapter("select * from DANHSACHSUDUNGDICHVU", cnn);
            tb_DSSDDV.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Columns[0];
            QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable MASDDV(string txttk)
        {
            this.QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Clear();
            tim_DSSDDV = new SqlDataAdapter("SELECT * FROM DANHSACHSUDUNGDICHVU WHERE MASDDV = '" + txttk + "'", cnn);
            tim_DSSDDV.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable MADV(string txttk)
        {
            this.QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Clear();
            tim_DSSDDV = new SqlDataAdapter("SELECT * FROM DANHSACHSUDUNGDICHVU WHERE MADV = '" + txttk + "'", cnn);
            tim_DSSDDV.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable MANHANPHONG(string txttk)
        {
            this.QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Clear();
            tim_DSSDDV = new SqlDataAdapter("SELECT * FROM DANHSACHSUDUNGDICHVU WHERE MANHANPHONG = '" + txttk + "'", cnn);
            tim_DSSDDV.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable SL(int txttk)
        {
            this.QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Clear();
            tim_DSSDDV = new SqlDataAdapter("SELECT * FROM DANHSACHSUDUNGDICHVU WHERE SL = '" + txttk + "'", cnn);
            tim_DSSDDV.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
    }

}
