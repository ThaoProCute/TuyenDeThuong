using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class LoaiDichVu
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoaiDichVu;
        SqlDataAdapter tb_TimLoaiDichVu;
        public DataTable loaDichVu()
        {
            tb_LoaiDichVu = new SqlDataAdapter("SELECT * FROM LOAIDICHVU", cnn);
            tb_LoaiDichVu.Fill(QLKHACHSAN, "LOAIDICHVU");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIDICHVU"].Columns[0];
            QLKHACHSAN.Tables["LOAIDICHVU"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIDICHVU"];
        }
        public bool Them(string pmaldv, string ptenldv)
        {
            try
            {
                DataRow LDV_them = QLKHACHSAN.Tables["LOAIDICHVU"].NewRow();
                LDV_them["MALOAIDV"] = pmaldv;
                LDV_them["TENLOAIDV"] = ptenldv;

                QLKHACHSAN.Tables["LOAIDICHVU"].Rows.Add(LDV_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_LoaiDichVu);
                tb_LoaiDichVu.Update(QLKHACHSAN, "LOAIDICHVU");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmaldv)
        {
            try
            {
                DataRow LDV_xoa = QLKHACHSAN.Tables["LOAIDICHVU"].Rows.Find(pmaldv);
                if (LDV_xoa != null)
                {
                    LDV_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmaldv, string ptenldv)
        {
            try
            {
                DataRow LDV_sua = QLKHACHSAN.Tables["LOAIDICHVU"].Rows.Find(pmaldv);
                if (LDV_sua != null)
                {
                    LDV_sua["TENLOAIDV"] = ptenldv;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaDV(string madv)
        {
            this.QLKHACHSAN.Tables["LOAIDICHVU"].Clear();
            tb_TimLoaiDichVu = new SqlDataAdapter("SELECT * FROM LOAIDICHVU WHERE MALOAIDV = '" + madv + "'", cnn);
            tb_TimLoaiDichVu.Fill(QLKHACHSAN, "LOAIDICHVU");
            return QLKHACHSAN.Tables["LOAIDICHVU"];
        }
        public DataTable TimMadv(string madv)
        {
            this.QLKHACHSAN.Tables["LOAIDICHVU"].Clear();
            tb_TimLoaiDichVu = new SqlDataAdapter("SELECT * FROM LOAIDICHVU WHERE TENLOAIDV='" + madv + "'", cnn);
            tb_TimLoaiDichVu.Fill(QLKHACHSAN, "LOAIDICHVU");
            return QLKHACHSAN.Tables["LOAIDICHVU"];
        }
    }
}
