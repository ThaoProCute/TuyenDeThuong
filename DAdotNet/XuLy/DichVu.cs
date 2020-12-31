using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class DichVu
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoaiDichVu;
        SqlDataAdapter tb_DichVu;
        SqlDataAdapter tb_TimDichVu;
        public DataTable loaDichVu()
        {
            tb_DichVu = new SqlDataAdapter("select * from dichvu", cnn);
            tb_DichVu.Fill(QLKHACHSAN, "DICHVU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DICHVU"].Columns[0];
            QLKHACHSAN.Tables["DICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DICHVU"];
        }
        //public DataTable loaTEN()
        //{
        //    tb_LoaiDichVu = new SqlDataAdapter(" SELECT * FROM DICHVU", cnn);
        //    tb_LoaiDichVu.Fill(QLKHACHSAN, "DICHVU");
        //    DataColumn[] khoachinh = new DataColumn[1];
        //    khoachinh[0] = QLKHACHSAN.Tables["DICHVU"].Columns[0];
        //    QLKHACHSAN.Tables["DICHVU"].PrimaryKey = khoachinh;
        //    return QLKHACHSAN.Tables["DICHVU"];
        //}
        //TENLOAIDV MADV,TENLOAIDV,DONVI,DONGIA FROM
        public DataTable loadLoaiDV()
        {
            tb_LoaiDichVu = new SqlDataAdapter("SELECT * FROM LOAIDICHVU", cnn);
            tb_LoaiDichVu.Fill(QLKHACHSAN, "LOAIDICHVU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIDICHVU"].Columns[0];
            QLKHACHSAN.Tables["LOAIDICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIDICHVU"];
        }
        public bool Them(string pmadv, string pmaldv, string donvi,float DonGia)
        {
            try
            {
                //cnn.Open();
                //string sql = "select DICHVU.MALOAIDV  from DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV ='" + pmaldv + "' ";
                //SqlCommand cmd = new SqlCommand(sql,cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //cnn.Close();
                DataRow DV_them = QLKHACHSAN.Tables["DICHVU"].NewRow();
                DV_them["MADV"] = pmadv;
                DV_them["MALOAIDV"] = pmaldv;
                DV_them["DONVI"] = donvi;
                DV_them["DONGIA"] = DonGia;

                QLKHACHSAN.Tables["DICHVU"].Rows.Add(DV_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_DichVu);
                tb_DichVu.Update(QLKHACHSAN, "DICHVU");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmadv)
        {
            try
            {
                DataRow DV_xoa = QLKHACHSAN.Tables["DICHVU"].Rows.Find(pmadv);
                if (DV_xoa != null)
                {
                    DV_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmadv, string pmaldv, string donvi, float DonGia)
        {
            try
            {
                DataRow DV_sua = QLKHACHSAN.Tables["DICHVU"].Rows.Find(pmadv);
                if (DV_sua != null)
                {
                    DV_sua["TENLOAIDV"] = pmaldv;
                    DV_sua["DONVI"] = donvi;
                    DV_sua["DONGIA"] = DonGia;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimDonGia(float DonGia)
        {
            this.QLKHACHSAN.Tables["DICHVU"].Clear();
            tb_TimDichVu = new SqlDataAdapter("SELECT MADV,TENLOAIDV,DONVI,DONGIA FROM DICHVU,LOAIDICHVU WHERE DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV and DONGIA = " + DonGia + "", cnn);
            tb_TimDichVu.Fill(QLKHACHSAN, "DICHVU");
            return QLKHACHSAN.Tables["DICHVU"];
        }
        public DataTable TimMadv(string madv)
        {
            this.QLKHACHSAN.Tables["DICHVU"].Clear();
            tb_TimDichVu = new SqlDataAdapter("SELECT MADV,TENLOAIDV,DONVI,DONGIA FROM DICHVU,LOAIDICHVU WHERE DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV and MADV = '" + madv + "'", cnn);
            tb_TimDichVu.Fill(QLKHACHSAN, "DICHVU");
            return QLKHACHSAN.Tables["DICHVU"];
        }
        public DataTable TimMLDV(string tenldv)
        {
            this.QLKHACHSAN.Tables["DICHVU"].Clear();
            tb_TimDichVu = new SqlDataAdapter("SELECT MADV,TENLOAIDV,DONVI,DONGIA FROM DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV LIKE N'%" + tenldv + "%'", cnn);
            tb_TimDichVu.Fill(QLKHACHSAN, "DICHVU");
            return QLKHACHSAN.Tables["DICHVU"];
        }
        public DataTable TimDONVI(string donvi)
        {
            this.QLKHACHSAN.Tables["DICHVU"].Clear();
            tb_TimDichVu = new SqlDataAdapter("SELECT MADV,TENLOAIDV,DONVI,DONGIA FROM DICHVU,LOAIDICHVU WHERE DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND DONVI like N'%" + donvi + "%'", cnn);
            tb_TimDichVu.Fill(QLKHACHSAN, "DICHVU");
            return QLKHACHSAN.Tables["DICHVU"];
        }
    }
}
