using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    class ChiTietHoaDon
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_MaP;
        SqlDataAdapter tb_CTHoaDon;
        SqlDataAdapter tb_TimCTHoaDon;
        public DataTable LoadCTHoaDon()
        {
            tb_CTHoaDon = new SqlDataAdapter("select * from CHITIETHOADON", cnn);
            tb_CTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLKHACHSAN.Tables["CHITIETHOADON"].Columns[0];
            khoachinh[1] = QLKHACHSAN.Tables["CHITIETHOADON"].Columns[1];
            QLKHACHSAN.Tables["CHITIETHOADON"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable LoadMASDDV()
        {
            tb_CTHoaDon = new SqlDataAdapter("select * from DANHSACHSUDUNGDICHVU", cnn);
            tb_CTHoaDon.Fill(QLKHACHSAN, "DANHSACHSUDUNGDICHVU");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].Columns[0];
            QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DANHSACHSUDUNGDICHVU"];
        }
        public DataTable loadMaP()
        {
            tb_MaP = new SqlDataAdapter("SELECT * FROM PHONG", cnn);
            tb_MaP.Fill(QLKHACHSAN, "PHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
            QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONG"];
        }
        public bool Them(string pmahd, string pmap,string mssdv, float tienp, float tiendv,int giamgiakh,int songay,string hinhthuctt)
        {
            try
            {
                //cnn.Open();
                //string sql = "select DICHVU.MALOAIDV  from DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV ='" + pmaldv + "' ";
                //SqlCommand cmd = new SqlCommand(sql,cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //cnn.Close();
                DataRow HD_them = QLKHACHSAN.Tables["CHITIETHOADON"].NewRow();
                HD_them["MAHOADON"] = pmahd;
                HD_them["MAPHONG"] = pmap;
                HD_them["MASDDV"] = mssdv;
                HD_them["TIENPHONG"] = tienp;
                HD_them["TIENDICHVU"] = tiendv;
                HD_them["GIAMGIAKH"] = giamgiakh;
                HD_them["SONGAY"] = songay;
                HD_them["HINHTHUCTHANHTOAN"] = hinhthuctt;

                QLKHACHSAN.Tables["CHITIETHOADON"].Rows.Add(HD_them);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LuuDTB()
        {
            try
            {
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_CTHoaDon);
                tb_CTHoaDon.Update(QLKHACHSAN, "CHITIETHOADON");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmahd)
        {
            try
            {
                DataRow HD_xoa = QLKHACHSAN.Tables["CHITIETHOADON"].Rows.Find(pmahd);
                if (HD_xoa != null)
                {
                    HD_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmahd, string pmap, string mssdv, float tienp, float tiendv, int giamgiakh, int songay, string hinhthuctt)
        {
            try
            {
                DataRow HD_sua = QLKHACHSAN.Tables["CHITIETHOADON"].Rows.Find(pmahd);
                if (HD_sua != null)
                {
                    HD_sua["MAPHONG"] = pmap;
                    HD_sua["MASDDV"] = mssdv;
                    HD_sua["TIENPHONG"] = tienp;
                    HD_sua["TIENDICHVU"] = tiendv;
                    HD_sua["GIAMGIAKH"] = giamgiakh;
                    HD_sua["SONGAY"] = songay;
                    HD_sua["HINHTHUCTHANHTOAN"] = hinhthuctt;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaHD(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where MAHOADON='" + txtTK + "'", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimMaPhong(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where MAPHONG='" + txtTK + "'", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimTienPhong(float txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where TIENPHONG=" + txtTK + "", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimMaDV(float txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where TIENDICHVU=" + txtTK + "", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimMaChinhSach(float txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where MACHINHSACH=" + txtTK + "", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimGiamGia(int txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where GIAMGIAKH='" + txtTK + "'", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable TimSoNgay(int txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where SONGAY=" + txtTK + "", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
        public DataTable Timhinhthuctt(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETHOADON"].Clear();
            tb_TimCTHoaDon = new SqlDataAdapter("select * from Hoadon where HINHTHUCTHANHTOAN='" + txtTK + "'", cnn);
            tb_TimCTHoaDon.Fill(QLKHACHSAN, "CHITIETHOADON");
            return QLKHACHSAN.Tables["CHITIETHOADON"];
        }
    }
}
