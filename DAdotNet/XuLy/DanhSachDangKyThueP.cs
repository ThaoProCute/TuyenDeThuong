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
    public class DanhSachDangKyThueP
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_DSDatPhong;
        SqlDataAdapter Tim_DStbDatPhong;
        public DataTable loadsDatPhong()
        {
            tb_DSDatPhong = new SqlDataAdapter("select * from DATPHONG", cnn);
            tb_DSDatPhong.Fill(QLKHACHSAN, "DATPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DATPHONG"].Columns[0];
            QLKHACHSAN.Tables["DATPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DATPHONG"];
        }
        //public DataTable loadKH()
        //{
        //    tb_LoadKhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
        //    tb_LoadKhachHang.Fill(QLKHACHSAN, "KHACHHANG");
        //    DataColumn[] khoachinh = new DataColumn[1];
        //    khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
        //    QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
        //    return QLKHACHSAN.Tables["KHACHHANG"];
        //}
        public bool Them(DataGridView dgv)
        {
            try
            {
                dgv.AllowUserToAddRows = true;
                dgv.ReadOnly = false;
                //for (int i = 0; i < dgv.Rows.Count; i++)
                //{
                //    dgv.Rows[i].ReadOnly = true;
                //}
                //dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                DataRow DV_them = QLKHACHSAN.Tables["DATPHONG"].NewRow();
                DV_them["MADAT"] = dgv.Rows[dgv.Rows.Count-1].Cells[0];
                DV_them["MAKHACH"] = dgv.Rows[dgv.Rows.Count-1].Cells[1];

                QLKHACHSAN.Tables["DATPHONG"].Rows.Add(DV_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_DSDatPhong);
                tb_DSDatPhong.Update(QLKHACHSAN, "DATPHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmadp)
        {
            try
            {
                DataRow DV_xoa = QLKHACHSAN.Tables["DATPHONG"].Rows.Find(pmadp);
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
        public bool Sua(string pmadat, string makhach)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["DATPHONG"].Rows.Find(pmadat);
                if (DP_sua != null)
                {
                    DP_sua["MAKHACH"] = makhach;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimTheoMaDP(string txttk)
        {
            this.QLKHACHSAN.Tables["DATPHONG"].Clear();
            Tim_DStbDatPhong = new SqlDataAdapter("SELECT * FROM DATPHONG WHERE MADAT = '" + txttk + "'", cnn);
            Tim_DStbDatPhong.Fill(QLKHACHSAN, "DATPHONG");
            return QLKHACHSAN.Tables["DATPHONG"];
        }
        public DataTable TimMaKhachHang(string txttk)
        {
            this.QLKHACHSAN.Tables["DATPHONG"].Clear();
            Tim_DStbDatPhong = new SqlDataAdapter("SELECT * FROM DATPHONG WHERE MADAT = '" + txttk + "'", cnn);
            Tim_DStbDatPhong.Fill(QLKHACHSAN, "DATPHONG");
            return QLKHACHSAN.Tables["DATPHONG"];
        }
    }
}
