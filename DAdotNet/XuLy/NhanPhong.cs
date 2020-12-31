using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAdotNet.XuLy
{
    public class NhanPhong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoadPhong;
        SqlDataAdapter tb_LoadKhachHang;
        SqlDataAdapter tb_DatPhong;
        SqlDataAdapter tb_NhanPhong;
        SqlDataAdapter tb_TimNhanPhong;
        SqlDataAdapter tb_ThemMaNP;
        SqlDataAdapter tb_KiemTraTinhTrang;
        public DataTable loadNhanPhong()
        {
            tb_NhanPhong = new SqlDataAdapter("SELECT * FROM CHITIETNHANPHONG ", cnn);
            tb_NhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLKHACHSAN.Tables["CHITIETNHANPHONG"].Columns[0];
            khoachinh[1] = QLKHACHSAN.Tables["CHITIETNHANPHONG"].Columns[1];
            QLKHACHSAN.Tables["CHITIETNHANPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable loadPhong()
        {
            tb_LoadPhong = new SqlDataAdapter("SELECT * FROM PHONG", cnn);
            tb_LoadPhong.Fill(QLKHACHSAN, "PHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
            QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable loadKhachHang()
        {
            tb_LoadKhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            tb_LoadKhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
            QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable loadDatPhong()
        {
            tb_DatPhong = new SqlDataAdapter("SELECT * FROM DATPHONG", cnn);
            tb_DatPhong.Fill(QLKHACHSAN, "DATPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DATPHONG"].Columns[0];
            QLKHACHSAN.Tables["DATPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DATPHONG"];
        }
        public DataTable ThemMaNhanPhong()
        {
            tb_ThemMaNP = new SqlDataAdapter("SELECT * FROM NHANPHONG", cnn);
            tb_ThemMaNP.Fill(QLKHACHSAN, "NHANPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANPHONG"].Columns[0];
            QLKHACHSAN.Tables["NHANPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public string KiemTraTinhtrang(string map)
        {
            string kq = "";
            tb_KiemTraTinhTrang = new SqlDataAdapter("SELECT TINHTRANG FROM PHONG WHERE MAPHONG='" + map + "'", cnn);
            tb_KiemTraTinhTrang.Fill(QLKHACHSAN, "TT");
            DataTable ds = QLKHACHSAN.Tables["TT"];
            foreach (DataRow row in ds.Rows)
            {
                kq = row[0].ToString();
            }
            return kq;
        }
        public bool SuaTinhTrang(string map)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["PHONG"].Rows.Find(map);
                if (DP_sua != null)
                {
                    DP_sua["TINHTRANG"] = "DAY";
                }
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_LoadPhong);
                tb_LoadPhong.Update(QLKHACHSAN, "PHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemMNP(string manp, string madat,string makhach)
        {
            //QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            try
            {
                ThemMaNhanPhong();
                DataRow DP_them = QLKHACHSAN.Tables["NHANPHONG"].NewRow();
                DP_them["MANHANPHONG"] = manp;
                DP_them["MADAT"] = madat;
                DP_them["MAKHACH"] = makhach;

                QLKHACHSAN.Tables["NHANPHONG"].Rows.Add(DP_them);
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_ThemMaNP);
                tb_ThemMaNP.Update(QLKHACHSAN, "NHANPHONG");
                loadNhanPhong();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them(string manp, string map,string tenkh,string cmnd,DateTime ngaynhan, DateTime ngaytradukien, DateTime ngaytrathucte)
        {
            try
            {
                //cnn.Open();
                //string sql = "select DICHVU.MALOAIDV  from DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV ='" + pmaldv + "' ";
                //SqlCommand cmd = new SqlCommand(sql,cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //cnn.Close();
                DataRow DP_them = QLKHACHSAN.Tables["CHITIETNHANPHONG"].NewRow();
                DP_them["MANHANPHONG"] = manp;
                DP_them["MAPHONG"] = map;
                DP_them["TENKHACH"] = tenkh;
                DP_them["CMNN"] = cmnd;
                DP_them["NGAYNHAN"] = ngaynhan;
                DP_them["NGAYTRADUKIEN"] = ngaytradukien;
                DP_them["NGAYTRATHUCTE"] = ngaytrathucte;

                QLKHACHSAN.Tables["CHITIETNHANPHONG"].Rows.Add(DP_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_NhanPhong);
                tb_NhanPhong.Update(QLKHACHSAN, "CHITIETNHANPHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmaDP)
        {
            try
            {
                DataRow DP_xoa = QLKHACHSAN.Tables["CHITIETNHANPHONG"].Rows.Find(pmaDP);
                if (DP_xoa != null)
                {
                    DP_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string manp, string map, string tenkh, string cmnd, DateTime ngaynhan, DateTime ngaytradukien, DateTime ngaytrathucte)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["CHITIETNHANPHONG"].Rows.Find(manp);
                if (DP_sua != null)
                {
                    DP_sua["MAPHONG"] = map;
                    DP_sua["TENKHACH"] = tenkh;
                    DP_sua["CMNN"] = cmnd;
                    DP_sua["NGAYNHAN"] = ngaynhan;
                    DP_sua["NGAYTRADUKIEN"] = ngaytradukien;
                    DP_sua["NGAYTRATHUCTE"] = ngaytrathucte;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaNhanPhong(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where MANHANPHONG= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimMaPhong(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where MAPHONG= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimTenKhach(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where TENKHACH LIKE '%" + txtTK + "%'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimCMND(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where CMNN= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimNgayNhan(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where NGAYNHAN= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimNgayTraDuKien(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where NGAYTRADUKIEN= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
        public DataTable TimNgayTraThucTe(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETNHANPHONG"].Clear();
            tb_TimNhanPhong = new SqlDataAdapter("Select * from CHITIETNHANPHONG Where NGAYTRATHUCTE= '" + txtTK + "'", cnn);
            tb_TimNhanPhong.Fill(QLKHACHSAN, "CHITIETNHANPHONG");
            return QLKHACHSAN.Tables["CHITIETNHANPHONG"];
        }
    }
}
