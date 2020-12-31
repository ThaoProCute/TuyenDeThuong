using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    class TraPhong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_NhanPhong;
        SqlDataAdapter tb_Khachhang;
        SqlDataAdapter tb_TraPHong;
        SqlDataAdapter tb_HoaDon;
        SqlDataAdapter tb_MaPhong;
        SqlDataAdapter tb_MaSuDungDichVu;
        SqlDataAdapter tb_LoadLoaiPhong;
        public DataTable ThemMaTP()
        {
            tb_TraPHong = new SqlDataAdapter("SELECT * FROM TRAPHONG", cnn);
            tb_TraPHong.Fill(QLKHACHSAN, "TRAPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["TRAPHONG"].Columns[0];
            QLKHACHSAN.Tables["TRAPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["TRAPHONG"];
        }
        public DataTable ThemMaNhanPhong()
        {
            tb_NhanPhong = new SqlDataAdapter("SELECT * FROM NHANPHONG", cnn);
            tb_NhanPhong.Fill(QLKHACHSAN, "NHANPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANPHONG"].Columns[0];
            QLKHACHSAN.Tables["NHANPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public string LayTheoNhanPhong(string map)
        {
            string kq = "";
            tb_NhanPhong = new SqlDataAdapter("select TENKHACH from KHACHHANG , NHANPHONG where KHACHHANG.MAKHACH=NHANPHONG.MAKHACH and NHANPHONG.MANHANPHONG='" + map + "'", cnn);
            tb_NhanPhong.Fill(QLKHACHSAN, "TT");
            DataTable ds = QLKHACHSAN.Tables["TT"];
            foreach (DataRow row in ds.Rows)
            {
                kq = row[0].ToString();
            }
            return kq;
        }
        public string LayTheoNhanPhong1(string map)
        {
            string kq1 = "";
            tb_NhanPhong = new SqlDataAdapter("select Phong.MAPHONG  from  NHANPHONG,CHITIETNHANPHONG,PHONG Where NHANPHONG.MANHANPHONG=CHITIETNHANPHONG.MANHANPHONG AND CHITIETNHANPHONG.MAPHONG=PHONG.MAPHONG AND NHANPHONG.MANHANPHONG = '"+map+"' ", cnn);
            tb_NhanPhong.Fill(QLKHACHSAN, "TT1");
            DataTable ds = QLKHACHSAN.Tables["TT1"];
            foreach (DataRow row in ds.Rows)
            {
                kq1 = row[0].ToString();
            }
            return kq1;
        }
        public DataTable loadKhachHang()
        {
            // load
            tb_Khachhang = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            tb_Khachhang.Fill(QLKHACHSAN, "KHACHHANG");
            //kiem tra khoa chinh
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
            QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            //update
            //SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
            //tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable loadDSSDDV()
        {
            tb_MaSuDungDichVu = new SqlDataAdapter("select * from DANHSACHSUDUNGDICHVU", cnn);
            tb_MaSuDungDichVu.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Columns[0];
            QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable LoadHoaDon()
        {
            tb_HoaDon = new SqlDataAdapter("select * from HOADON", cnn);
            tb_HoaDon.Fill(QLKHACHSAN, "HOADON");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["HOADON"].Columns[0];
            QLKHACHSAN.Tables["HOADON"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable loaPhong1()
        {

            tb_MaPhong = new SqlDataAdapter("select *  from PHONG", cnn);
            tb_MaPhong.Fill(QLKHACHSAN, "PHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
            QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable LoadHoaDon1(string ma)
        {
            tb_HoaDon = new SqlDataAdapter("select * from Hoadon, NHANPHONG where HOADON.MANHANPHONG=NHANPHONG.MANHANPHONG and HOADON.MANHANPHONG='"+ma+"' ", cnn);
            tb_HoaDon.Fill(QLKHACHSAN, "HOADON");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["HOADON"].Columns[0];
            QLKHACHSAN.Tables["HOADON"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["HOADON"];
        }
        public bool SuaTinhTrang(string map)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["PHONG"].Rows.Find(map);
                if (DP_sua != null)
                {
                    DP_sua["TINHTRANG"] = "RONG";
                }
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_LoadLoaiPhong);
                tb_LoadLoaiPhong.Update(QLKHACHSAN, "PHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
