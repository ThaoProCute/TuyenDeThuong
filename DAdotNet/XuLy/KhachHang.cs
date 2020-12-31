using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class KhachHang
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_KhachHang;
        SqlDataAdapter tb_TimKhachHang;
        public DataTable loadKhachHang()
        {
            // load
            tb_KhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            tb_KhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            //kiem tra khoa chinh
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
            QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            //update
            //SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
            //tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public bool Them(string pmakhach, string ptenkhach, string cmnn, string diachi, string sdt, string gioitinh, string quoctich)
        {
            try
            {
                DataRow khach_them = QLKHACHSAN.Tables["KHACHHANG"].NewRow();
                khach_them["MAKHACH"] = pmakhach;
                khach_them["TENKHACH"] = ptenkhach;
                khach_them["CMNN"] = cmnn;
                khach_them["DIACHI"] = diachi;
                khach_them["DIENTHOAI"] = sdt;
                khach_them["GIOITINH"] = gioitinh;
                khach_them["QUOCTICH"] = quoctich;

                QLKHACHSAN.Tables["KHACHHANG"].Rows.Add(khach_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
                tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmakhach)
        {
            try
            {
                DataRow khach_xoa = QLKHACHSAN.Tables["KHACHHANG"].Rows.Find(pmakhach);
                if (khach_xoa != null)
                {
                    khach_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmakhach, string ptenkhach, string cmnn, string diachi, string sdt, string gioitinh, string quoctich)
        {
            try
            {
                DataRow khach_sua = QLKHACHSAN.Tables["KHACHHANG"].Rows.Find(pmakhach);
                if (khach_sua != null)
                {
                    khach_sua["TENKHACH"] = ptenkhach;
                    khach_sua["CMNN"] = cmnn;
                    khach_sua["DIACHI"] = diachi;
                    khach_sua["DIENTHOAI"] = sdt;
                    khach_sua["GIOITINH"] = gioitinh;
                    khach_sua["QUOCTICH"] = quoctich;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public bool TimTheoTen(string ptenkhach)
        //{
        //    try
        //    {
        //        if (cnn.State == System.Data.ConnectionState.Closed)
        //        {
        //            cnn.Open();
        //        }
        //        string CauLenh = "SELECT * FROM KHACHHANG WHERE TENKHACH = '" + ptenkhach + "'";
        //        SqlCommand cmd_khach = new SqlCommand(CauLenh, cnn);
        //        cmd_khach.ExecuteNonQuery();
        //        if (cnn.State == System.Data.ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        //

        public DataTable TimHoTen(string ptenkhach)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM KHACH_HANG WHERE TenKhachHang = @hoten");
            //cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = hoten;
            //ds.Load(cmd);

            //return ds;
            this.QLKHACHSAN.Tables["KHACHHANG"].Clear();
            tb_TimKhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE TENKHACH = N'" + ptenkhach + "'", cnn); 
            tb_TimKhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            //SqlCommandBuilder Build = new SqlCommandBuilder(tb_TimKhachHang);
            //tb_TimKhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable TimCNND(string pCMND)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM KHACH_HANG WHERE TenKhachHang = @hoten");
            //cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = hoten;
            //ds.Load(cmd);

            //return ds;
            this.QLKHACHSAN.Tables["KHACHHANG"].Clear();
            tb_KhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE CMNN = '" + pCMND + "'", cnn);
            tb_KhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
            tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable timgioitinh(string pgioitinh)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM KHACH_HANG WHERE TenKhachHang = @hoten");
            //cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = hoten;
            //ds.Load(cmd);

            //return ds;
            this.QLKHACHSAN.Tables["KHACHHANG"].Clear();
            tb_KhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE GIOITINH = '" + pgioitinh + "'", cnn);
            tb_KhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
            tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable timdiachi(string pdiachi)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM KHACH_HANG WHERE TenKhachHang = @hoten");
            //cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = hoten;
            //ds.Load(cmd);

            //return ds;
            this.QLKHACHSAN.Tables["KHACHHANG"].Clear();
            tb_KhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE DIACHI Like N'%"+ pdiachi+"%'", cnn);
            tb_KhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            SqlCommandBuilder Build = new SqlCommandBuilder(tb_KhachHang);
            tb_KhachHang.Update(QLKHACHSAN, "KHACHHANG");
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        //public void TimTen(string ptenkhach)
        //{
        //    TimHoTen(ptenkhach);
        //}
    }
}
