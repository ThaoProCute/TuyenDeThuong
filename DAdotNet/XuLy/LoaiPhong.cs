using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class LoaiPhong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoadLoaiPhong;
        SqlDataAdapter tb_TimLoaiPhong;
        public DataTable loadLoaiPhong()
        {
            tb_LoadLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG", cnn);
            tb_LoadLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIPHONG"].Columns[0];
            QLKHACHSAN.Tables["LOAIPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public bool Them(string pmalp, string ptenlp, float dongia, int slngchuan, int slngtoida)
        {
            try
            {
                DataRow LP_them = QLKHACHSAN.Tables["LOAIPHONG"].NewRow();
                LP_them["MALOAIPHONG"] = pmalp;
                LP_them["TENLOAIPHONG"] = ptenlp;
                LP_them["DONGIA"] = dongia;
                LP_them["SONGUOICHUAN"] = slngchuan;
                LP_them["SONGUOITOIDA"] = slngtoida;

                QLKHACHSAN.Tables["LOAIPHONG"].Rows.Add(LP_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_LoadLoaiPhong);
                tb_LoadLoaiPhong.Update(QLKHACHSAN, "LOAIPHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmalp)
        {
            try
            {
                DataRow LP_xoa = QLKHACHSAN.Tables["LOAIPHONG"].Rows.Find(pmalp);
                if (LP_xoa != null)
                {
                    LP_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmalp, string ptenlp, float dongia, int slngchuan, int slngtoida)
        {
            try
            {
                DataRow LP_sua = QLKHACHSAN.Tables["LOAIPHONG"].Rows.Find(pmalp);
                if (LP_sua != null)
                {
                    LP_sua["TENLOAIPHONG"] = ptenlp;
                    LP_sua["DONGIA"] = dongia;
                    LP_sua["SONGUOICHUAN"] = slngchuan;
                    LP_sua["SONGUOITOIDA"] = slngtoida;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaLP(string TxtTK)
        {
            this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_TimLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE MALOAIPHONG = '" + TxtTK + "'", cnn);
            tb_TimLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable TimTenLP(string TxtTK)
        {
            this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_TimLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE TENLOAIPHONG LIKE N'" + TxtTK + "'", cnn);
            tb_TimLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable TimDonGia(float TxtTK)
        {
            this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_TimLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE DONGIA = '" + TxtTK + "'", cnn);
            tb_TimLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable TimSLNgChuan(int TxtTK)
        {
            this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_TimLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE SONGUOICHUAN='" + TxtTK + "'", cnn);
            tb_TimLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable TimSLNgToiDa(int TxtTK)
        {
            this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_TimLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE SONGUOITOIDA='" + TxtTK + "'", cnn);
            tb_TimLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
    }
}
