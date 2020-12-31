using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    class HoaDon
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_MaKH;
        SqlDataAdapter tb_MaDV;
        SqlDataAdapter tb_HoaDon;
        SqlDataAdapter tb_TimHoaDon;
        public DataTable LoadHoaDon()
        {
            tb_HoaDon = new SqlDataAdapter("select * from HOADON", cnn);
            tb_HoaDon.Fill(QLKHACHSAN, "HOADON");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["HOADON"].Columns[0];
            QLKHACHSAN.Tables["HOADON"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable loadMaKH()
        {
            tb_MaKH = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            tb_MaKH.Fill(QLKHACHSAN, "KHACHHANG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
            QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable loadMaDV()
        {
            tb_MaDV = new SqlDataAdapter("SELECT * FROM NHANPHONG", cnn);
            tb_MaDV.Fill(QLKHACHSAN, "NHANPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANPHONG"].Columns[0];
            QLKHACHSAN.Tables["NHANPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANPHONG"];
        }
        public bool Them(string pmahd, string ptennvl, string cbkh, string cbdv,float TongTien, DateTime thoigianlap)
        {
            try
            {
                //cnn.Open();
                //string sql = "select DICHVU.MALOAIDV  from DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV ='" + pmaldv + "' ";
                //SqlCommand cmd = new SqlCommand(sql,cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //cnn.Close();
                DataRow HD_them = QLKHACHSAN.Tables["HOADON"].NewRow();
                HD_them["MAHOADON"] = pmahd;
                HD_them["NHANVIENLAP"] = ptennvl;
                HD_them["MAKHACH"] = cbkh;
                HD_them["MANHANPHONG"] = cbdv;
                HD_them["TONGTIEN"] = TongTien;
                HD_them["NGAYLAP"] = thoigianlap;

                QLKHACHSAN.Tables["HOADON"].Rows.Add(HD_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_HoaDon);
                tb_HoaDon.Update(QLKHACHSAN, "HOADON");
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
                DataRow HD_xoa = QLKHACHSAN.Tables["HOADON"].Rows.Find(pmahd);
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
        public bool Sua(string pmahd, string ptennvl, string cbkh, string cbdv, float TongTien, DateTime thoigianlap)
        {
            try
            {
                DataRow HD_sua = QLKHACHSAN.Tables["HOADON"].Rows.Find(pmahd);
                if (HD_sua != null)
                {
                    HD_sua["NHANVIENLAP"] = ptennvl;
                    HD_sua["MAKHACH"] = cbkh;
                    HD_sua["MANHANPHONG"] = cbdv;
                    HD_sua["TONGTIEN"] = TongTien;
                    HD_sua["NGAYLAP"] = thoigianlap;
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
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where MAHOADON='"+txtTK+"'", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable TimTenNVLD(string txtTK)
        {
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where NHANVIENLAP LIKE N'%" + txtTK + "%'", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable TimMaKH(string txtTK)
        {
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where MAKHACH='" + txtTK + "'", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable TimMaDV(string txtTK)
        {
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where MANHANPHONG='" + txtTK + "'", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable TimMaTongTien(float TongTien)
        {
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where TONGTIEN=" + TongTien + "", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
        public DataTable TimNgayLap(string txtTK)
        {
            this.QLKHACHSAN.Tables["HOADON"].Clear();
            tb_TimHoaDon = new SqlDataAdapter("select * from Hoadon where NGAYLAP='" + txtTK + "'", cnn);
            tb_TimHoaDon.Fill(QLKHACHSAN, "HOADON");
            return QLKHACHSAN.Tables["HOADON"];
        }
    }
}
