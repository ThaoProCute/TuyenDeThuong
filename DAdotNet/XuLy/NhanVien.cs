using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAdotNet.XuLy
{
    public class NhanVien
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_PhongBan;
        SqlDataAdapter tb_NhanVien;
        SqlDataAdapter tb_TimNhanVien;
        public DataTable loadNhanVien1()
        {
            if (QLKHACHSAN.Tables["NHANVIEN"] != null)
            {
                QLKHACHSAN.Tables["NHANVIEN"].Clear();
                tb_NhanVien = new SqlDataAdapter("select MANHANVIEN,NHANVIEN.MAPB,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB", cnn);
                tb_NhanVien.Fill(QLKHACHSAN, "NHANVIEN");
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = QLKHACHSAN.Tables["NHANVIEN"].Columns[0];
                QLKHACHSAN.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            }
            else
            {
                tb_NhanVien = new SqlDataAdapter("select MANHANVIEN,NHANVIEN.MAPB,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB", cnn);
                tb_NhanVien.Fill(QLKHACHSAN, "NHANVIEN");
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = QLKHACHSAN.Tables["NHANVIEN"].Columns[0];
                QLKHACHSAN.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            }
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable loadNhanVien()
        {
            tb_NhanVien = new SqlDataAdapter("select * from NHANVIEN", cnn);
            tb_NhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANVIEN"].Columns[0];
            QLKHACHSAN.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable loadTenPB()
        {
            tb_PhongBan = new SqlDataAdapter("select * from PHONGBAN", cnn);
            tb_PhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONGBAN"].Columns[0];
            QLKHACHSAN.Tables["PHONGBAN"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
        public bool ktKhoaChinh(string manv)
        {
            try
            {
                string[] mang = new string[1];
                mang[0] = manv;
                DataRow dr = QLKHACHSAN.Tables["NHANVIEN"].Rows.Find(mang);
                if (dr != null)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them(string pmanv, string mapb, string tennv, string pcmnn, string gioitinh, string quequan, string sdt, string dantoc, string chucvu, float Luong)
        {
            try
            {

                DataRow NV_them = QLKHACHSAN.Tables["NHANVIEN"].NewRow();
                NV_them["MANHANVIEN"] = pmanv;
                NV_them["MAPB"] = mapb;
                //NV_them["TENPB"] = ptenpb;
                NV_them["TENNHANVIEN"] = tennv;
                NV_them["CMNN"] = pcmnn;
                NV_them["GIOITINH"] = gioitinh;
                NV_them["QUENQUAN"] = quequan;
                NV_them["DIENTHOAI"] = sdt;
                NV_them["DANTOC"] = dantoc;
                NV_them["CHUCVU"] = chucvu;
                NV_them["LUONG"] = Luong;

                QLKHACHSAN.Tables["NHANVIEN"].Rows.Add(NV_them);
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_NhanVien);
                tb_NhanVien.Update(QLKHACHSAN, "NHANVIEN");
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
                //string mapb;
                //if (dtv.CurrentRow != null)
                //{
                //    mapb = dtv.CurrentRow.Cells[1].Value.ToString();
                //    tb_NhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and TENPB ='" + mapb + "'", cnn);
                //}
                //cnn.Open();
                //string sql = "select NHANVIEN.MAPB  from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB AND TENPB ='" + ptenpb + "' ";
                //SqlCommand cmd = new SqlCommand(sql, cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //dtv.Rows[1].Cells[1].Value=maloai;
                //cnn.Close();
                //tb_NhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB", cnn);
                //tb_NhanVien.Fill(QLKHACHSAN, "NHANVIEN");
                //DataColumn[] khoachinh = new DataColumn[1];
                //khoachinh[0] = QLKHACHSAN.Tables["NHANVIEN"].Columns[0];
                //QLKHACHSAN.Tables["NHANVIEN"].PrimaryKey = khoachinh;
                //return QLKHACHSAN.Tables["NHANVIEN"];
                //QLKHACHSAN.Tables["NHANVIEN"].Clear();
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_NhanVien);
                tb_NhanVien.Update(QLKHACHSAN, "NHANVIEN");
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmanv)
        {
            try
            {
                DataRow NV_xoa = QLKHACHSAN.Tables["NHANVIEN"].Rows.Find(pmanv);
                if (NV_xoa != null)
                {
                    NV_xoa.Delete();
                    SqlCommandBuilder Build = new SqlCommandBuilder(tb_NhanVien);
                    tb_NhanVien.Update(QLKHACHSAN, "NHANVIEN");
                }
                return
                    true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmanv, string ptenpb, string tennv, string pcmnn, string gioitinh, string quequan, string sdt, string dantoc, string chucvu, float Luong)
        {
            try
            {
                DataRow NV_sua = QLKHACHSAN.Tables["NHANVIEN"].Rows.Find(pmanv);
                if (NV_sua != null)
                {
                    NV_sua["MAPB"] = ptenpb;
                    NV_sua["TENNHANVIEN"] = tennv;
                    NV_sua["CMNN"] = pcmnn;
                    NV_sua["GIOITINH"] = gioitinh;
                    NV_sua["QUENQUAN"] = quequan;
                    NV_sua["DIENTHOAI"] = sdt;
                    NV_sua["DANTOC"] = dantoc;
                    NV_sua["CHUCVU"] = chucvu;
                    NV_sua["LUONG"] = Luong;
                }
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_NhanVien);
                tb_NhanVien.Update(QLKHACHSAN, "NHANVIEN");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaNV(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and MANHANVIEN ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimTenPB(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and TENPB LIKE N'%" + txtTK + "%'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimTenNV(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and MANHANVIEN ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimCMND(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and CMNN ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimGioiTinh(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and GIOITINH ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimQuenQuan(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and QUENQUAN Like N'" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimSDT(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and DIENTHOAI ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimDanToc(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and DANTOC ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimChucVu(string txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and CHUCVU ='" + txtTK + "'", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public DataTable TimLuong(float txtTK)
        {
            this.QLKHACHSAN.Tables["NHANVIEN"].Clear();
            tb_TimNhanVien = new SqlDataAdapter("select MANHANVIEN,TENPB,TENNHANVIEN,CMNN,GIOITINH,QUENQUAN,DIENTHOAI,DANTOC,CHUCVU,LUONG from NHANVIEN,PHONGBAN where NHANVIEN.MAPB=PHONGBAN.MAPB and LUONG =" + txtTK + "", cnn);
            tb_TimNhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
    }
}
