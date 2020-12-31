using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class ThietBi
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_Phong;
        SqlDataAdapter tb_ThietBi;
        SqlDataAdapter tb_TimThietBi;
        public DataTable loadThietBi()
        {
            tb_ThietBi = new SqlDataAdapter("SELECT * FROM THIETBI", cnn);
            tb_ThietBi.Fill(QLKHACHSAN, "THIETBI");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["THIETBI"].Columns[0];
            QLKHACHSAN.Tables["THIETBI"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["THIETBI"];
        }
        public DataTable loadPhong()
        {
            tb_Phong = new SqlDataAdapter("select * from PHONG", cnn);
            tb_Phong.Fill(QLKHACHSAN, "PHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["PHONG"].Columns[0];
            QLKHACHSAN.Tables["PHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["PHONG"];
        }
        public bool Them(string pmatb, string ptentb, string tenphong, int sl)
        {
            try
            {

                DataRow TB_them = QLKHACHSAN.Tables["THIETBI"].NewRow();
                TB_them["MATHIETBI"] = pmatb;
                TB_them["TENTHIETBI"] = ptentb;
                TB_them["MAPHONG"] = tenphong;
                TB_them["SL"] = sl;

                QLKHACHSAN.Tables["THIETBI"].Rows.Add(TB_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_ThietBi);
                tb_ThietBi.Update(QLKHACHSAN, "THIETBI");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmatb)
        {
            try
            {
                DataRow TB_xoa = QLKHACHSAN.Tables["THIETBI"].Rows.Find(pmatb);
                if (TB_xoa != null)
                {
                    TB_xoa.Delete();
                }
                return
                    true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmatb, string ptentb, string tenphong, int sl)
        {
            try
            {
                DataRow TB_sua = QLKHACHSAN.Tables["THIETBI"].Rows.Find(pmatb);
                if (TB_sua != null)
                {
                    TB_sua["TENTHIETBI"] = ptentb;
                    TB_sua["MAPHONG"] = tenphong;
                    TB_sua["SL"] = sl;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaTB(string txtTK)
        {
            this.QLKHACHSAN.Tables["THIETBI"].Clear();
            tb_TimThietBi = new SqlDataAdapter("select *  from THIETBI WHERE MATHIETBI ='" + txtTK + "'", cnn);
            tb_TimThietBi.Fill(QLKHACHSAN, "THIETBI");
            return QLKHACHSAN.Tables["THIETBI"];
        }
        public DataTable TimTenTB(string txtTK)
        {
            this.QLKHACHSAN.Tables["THIETBI"].Clear();
            tb_TimThietBi = new SqlDataAdapter("select *  from THIETBI where  TENTHIETBI ='" + txtTK + "'", cnn);
            tb_TimThietBi.Fill(QLKHACHSAN, "THIETBI");
            return QLKHACHSAN.Tables["THIETBI"];
        }
        public DataTable TimMAP(string txtTK)
        {
            this.QLKHACHSAN.Tables["THIETBI"].Clear();
            tb_TimThietBi = new SqlDataAdapter("select *  from THIETBI where MAPHONG ='" + txtTK + "'", cnn);
            tb_TimThietBi.Fill(QLKHACHSAN, "THIETBI");
            return QLKHACHSAN.Tables["THIETBI"];
        }
        public DataTable TimSL(int txtTK)
        {
            this.QLKHACHSAN.Tables["THIETBI"].Clear();
            tb_TimThietBi = new SqlDataAdapter("select * from THIETBI where SL ='" + txtTK + "'", cnn);
            tb_TimThietBi.Fill(QLKHACHSAN, "THIETBI");
            return QLKHACHSAN.Tables["THIETBI"];
        }
    }
}
