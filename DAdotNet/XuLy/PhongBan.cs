using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class PhongBan
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_PhongBan;
        SqlDataAdapter tb_TimPhongBan;
        public DataTable loadPhongBan()
        {
            tb_PhongBan = new SqlDataAdapter("SELECT * FROM PHONGBAN", cnn);
            tb_PhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONGBAN"].Columns[0];
            QLKHACHSAN.Tables["PHONGBAN"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
        public bool Them(string pmapb, string ptenpb, string dcpb, string sdt)
        {
            try
            {
                DataRow PB_them = QLKHACHSAN.Tables["PHONGBAN"].NewRow();
                PB_them["MAPB"] = pmapb;
                PB_them["TENPB"] = ptenpb;
                PB_them["DIACHI"] = dcpb;
                PB_them["SDT"] = sdt;

                QLKHACHSAN.Tables["PHONGBAN"].Rows.Add(PB_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_PhongBan);
                tb_PhongBan.Update(QLKHACHSAN, "PHONGBAN");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmapb)
        {
            try
            {
                DataRow PB_xoa = QLKHACHSAN.Tables["PHONGBAN"].Rows.Find(pmapb);
                if (PB_xoa != null)
                {
                    PB_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmapb, string ptenpb, string dcpb, string sdt)
        {
            try
            {
                DataRow PB_sua = QLKHACHSAN.Tables["PHONGBAN"].Rows.Find(pmapb);
                if (PB_sua != null)
                {
                    PB_sua["TENPB"] = ptenpb;
                    PB_sua["DIACHI"] = dcpb;
                    PB_sua["SDT"] = sdt;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaPB(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONGBAN"].Clear();
            tb_TimPhongBan = new SqlDataAdapter("SELECT * FROM PHONGBAN WHERE MAPB = '" + txtTK + "'", cnn);
            tb_TimPhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
        public DataTable TimTenPB(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONGBAN"].Clear();
            tb_TimPhongBan = new SqlDataAdapter("SELECT * FROM PHONGBAN WHERE MAPB LIKE N'" + txtTK + "'", cnn);
            tb_TimPhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
        public DataTable TimDC(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONGBAN"].Clear();
            tb_TimPhongBan = new SqlDataAdapter("SELECT * FROM PHONGBAN WHERE MAPB LIKE N'" + txtTK + "'", cnn);
            tb_TimPhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
        public DataTable TimSDT(string txtTK)
        {
            this.QLKHACHSAN.Tables["PHONGBAN"].Clear();
            tb_TimPhongBan = new SqlDataAdapter("SELECT * FROM PHONGBAN WHERE MAPB = '" + txtTK + "'", cnn);
            tb_TimPhongBan.Fill(QLKHACHSAN, "PHONGBAN");
            return QLKHACHSAN.Tables["PHONGBAN"];
        }
    }
}
