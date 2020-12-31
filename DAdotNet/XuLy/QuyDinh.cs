using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAdotNet.XuLy
{
    public class QuyDinh
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_QuyDinh;
        SqlDataAdapter tb_TimQuyDinh;
        public DataTable loadQuyDinh()
        {
            // load
            tb_QuyDinh = new SqlDataAdapter("SELECT * FROM QUYDINH", cnn);
            tb_QuyDinh.Fill(QLKHACHSAN, "QUYDINH");
            //kiem tra khoa chinh
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["QUYDINH"].Columns[0];
            QLKHACHSAN.Tables["QUYDINH"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["QUYDINH"];
        }
        public bool Them(string tenqd, string mota)
        {
            try
            {
                DataRow qd_them = QLKHACHSAN.Tables["QUYDINH"].NewRow();
                qd_them["TENQUYDINH"] = tenqd;
                qd_them["MOTA"] = mota;

                QLKHACHSAN.Tables["QUYDINH"].Rows.Add(qd_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_QuyDinh);
                tb_QuyDinh.Update(QLKHACHSAN, "QUYDINH");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string tenqd)
        {
            try
            {
                DataRow qd_xoa = QLKHACHSAN.Tables["QUYDINH"].Rows.Find(tenqd);
                if (qd_xoa != null)
                {
                    qd_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string tenqd, string mota)
        {
            try
            {
                DataRow qd_sua = QLKHACHSAN.Tables["QUYDINH"].Rows.Find(tenqd);
                if (qd_sua != null)
                {
                    qd_sua["MOTA"] = mota;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimTenQD(string ptenqd)
        {
            this.QLKHACHSAN.Tables["QUYDINH"].Clear();
            tb_TimQuyDinh = new SqlDataAdapter("SELECT * FROM QUYDINH WHERE TENQUYDINH LIKE N'%" + ptenqd + "%'", cnn);
            tb_TimQuyDinh.Fill(QLKHACHSAN, "QUYDINH");
            return QLKHACHSAN.Tables["QUYDINH"];
        }
        public DataTable TimMoTaQD(string pmota)
        {
            this.QLKHACHSAN.Tables["QUYDINH"].Clear();
            tb_TimQuyDinh = new SqlDataAdapter("SELECT * FROM QUYDINH WHERE MOTA LIKE N'%" + pmota + "%'", cnn);
            tb_TimQuyDinh.Fill(QLKHACHSAN, "QUYDINH");
            return QLKHACHSAN.Tables["QUYDINH"];
        }
    }
}
