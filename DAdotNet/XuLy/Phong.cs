using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class Phong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoadnhanVien;
        SqlDataAdapter tb_LoadLoaiPhong;
        SqlDataAdapter tb_Phong;
        SqlDataAdapter tb_TimPhong;
        public DataTable loaPhong()
        {
            if (QLKHACHSAN.Tables["PHONG"] != null)
            {
                QLKHACHSAN.Tables["PHONG"].Clear();
                tb_Phong = new SqlDataAdapter("select MAPHONG,PHONG.MALOAIPHONG,LOAIPHONG.TENLOAIPHONG,PHONG.MANHANVIEN,NHANVIEN.TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN", cnn);
                tb_Phong.Fill(QLKHACHSAN, "PHONG");
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
                QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            }
            else
            {
                tb_Phong = new SqlDataAdapter("select MAPHONG,PHONG.MALOAIPHONG,LOAIPHONG.TENLOAIPHONG,PHONG.MANHANVIEN,NHANVIEN.TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN", cnn);
                tb_Phong.Fill(QLKHACHSAN, "PHONG");
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
                QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            }
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable loaPhong1()
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
            tb_Phong = new SqlDataAdapter("select *  from PHONG", cnn);
            tb_Phong.Fill(QLKHACHSAN, "PHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
            QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable loadLoaiPhong()
        {
            tb_LoadLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG", cnn);
            tb_LoadLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIPHONG"].Columns[0];
            QLKHACHSAN.Tables["LOAIPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable LoadNhanVien()
        {
            tb_LoadnhanVien = new SqlDataAdapter("SELECT * FROM NHANVIEN", cnn);
            tb_LoadnhanVien.Fill(QLKHACHSAN, "NHANVIEN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["NHANVIEN"].Columns[0];
            QLKHACHSAN.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["NHANVIEN"];
        }
        public bool ktKhoaChinh(string map)
        {
            try
            {
                string[] mang = new string[1];
                mang[0] = map;
                DataRow dr = QLKHACHSAN.Tables["PHONG"].Rows.Find(mang);
                if (dr != null)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them(string pmap, string ptenlp, string tennv, string tinhtrang,string ghichu)
        {
            try
            {
                DataRow P_them = QLKHACHSAN.Tables["PHONG"].NewRow();
                P_them["MAPHONG"] = pmap;
                P_them["MALOAIPHONG"] = ptenlp;
                P_them["MANHANVIEN"] = tennv;
                P_them["TINHTRANG"] = tinhtrang;
                P_them["GHICHU"] = ghichu;

                QLKHACHSAN.Tables["PHONG"].Rows.Add(P_them);
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_Phong);
                tb_Phong.Update(QLKHACHSAN, "PHONG");
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_Phong);
                tb_Phong.Update(QLKHACHSAN, "PHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmap)
        {
            try
            {
                DataRow P_xoa = QLKHACHSAN.Tables["PHONG"].Rows.Find(pmap);
                if (P_xoa != null)
                {
                    P_xoa.Delete();
                    SqlCommandBuilder Build = new SqlCommandBuilder(tb_Phong);
                    tb_Phong.Update(QLKHACHSAN, "PHONG");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmap, string ptenlp, string tennv, string tinhtrang, string ghichu)
        {
            try
            {
                DataRow P_sua = QLKHACHSAN.Tables["PHONG"].Rows.Find(pmap);
                if (P_sua != null)
                {
                    P_sua["MALOAIPHONG"] = ptenlp;
                    P_sua["MANHANVIEN"] = tennv;
                    P_sua["TINHTRANG"] = tinhtrang;
                    P_sua["GHICHU"] = ghichu;
                }
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_Phong);
                tb_Phong.Update(QLKHACHSAN, "PHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaPhong(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONG"].Clear();
            tb_TimPhong = new SqlDataAdapter("select MAPHONG,TENLOAIPHONG,TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN and MAPHONG= '"+txtTK+"'", cnn);
            tb_TimPhong.Fill(QLKHACHSAN, "PHONG");
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable TimTenLP(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONG"].Clear();
            tb_TimPhong = new SqlDataAdapter("select MAPHONG,TENLOAIPHONG,TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN and TENLOAIPHONG= '" + txtTK + "'", cnn);
            tb_TimPhong.Fill(QLKHACHSAN, "PHONG");
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable TimTenNhanVien(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONG"].Clear();
            tb_TimPhong = new SqlDataAdapter("select MAPHONG,TENLOAIPHONG,TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN and TENNHANVIEN= '" + txtTK + "'", cnn);
            tb_TimPhong.Fill(QLKHACHSAN, "PHONG");
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable TimTinhTrang(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONG"].Clear();
            tb_TimPhong = new SqlDataAdapter("select MAPHONG,TENLOAIPHONG,TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN and TINHTRANG LIKE N'" + txtTK + "'", cnn);
            tb_TimPhong.Fill(QLKHACHSAN, "PHONG");
            return QLKHACHSAN.Tables["PHONG"];
        }
        public DataTable TimGhiChu(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONG"].Clear();
            tb_TimPhong = new SqlDataAdapter("select MAPHONG,TENLOAIPHONG,TENNHANVIEN,TINHTRANG,GHICHU  from PHONG,LOAIPHONG,NHANVIEN where PHONG.MALOAIPHONG=LOAIPHONG.MALOAIPHONG and PHONG.MANHANVIEN=NHANVIEN.MANHANVIEN and GHICHU LIKE N'" + txtTK + "'", cnn);
            tb_TimPhong.Fill(QLKHACHSAN, "PHONG");
            return QLKHACHSAN.Tables["PHONG"];
        }
    }
}
