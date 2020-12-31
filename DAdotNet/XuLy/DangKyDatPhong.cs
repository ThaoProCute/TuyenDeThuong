using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAdotNet.XuLy
{
    public class DangKyDatPhong
    {
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-C5S06UT\\SQLEXPRESS;Initial Catalog=QLKHACHSAN1;User ID=sa;Password=123");
        DataSet QLKHACHSAN = new DataSet();
        SqlDataAdapter tb_LoadLoaiPhong;
        SqlDataAdapter tb_LoadKhachHang;
        SqlDataAdapter tb_DatPhong;
        SqlDataAdapter tb_TimDatPhong;
        SqlDataAdapter tb_ThemMaDP;
        SqlDataAdapter tb_TKPhong;
        public DataTable loadDatPhong()
        {
            tb_DatPhong = new SqlDataAdapter("SELECT * FROM CHITIETDATPHONG ", cnn);
            tb_DatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
            DataColumn[] khoachinh = new DataColumn[2];
            khoachinh[0] = QLKHACHSAN.Tables["CHITIETDATPHONG"].Columns[0];
            khoachinh[1] = QLKHACHSAN.Tables["CHITIETDATPHONG"].Columns[1];
            QLKHACHSAN.Tables["CHITIETDATPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        }
        public DataTable loadPhong()
        {
            tb_LoadLoaiPhong = new SqlDataAdapter("SELECT * FROM PHONG", cnn);
            tb_LoadLoaiPhong.Fill(QLKHACHSAN, "PHONG");
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
        public string KiemTraTinhtrang(string map)
        {
            string kq = "";
            tb_TKPhong = new SqlDataAdapter("SELECT TINHTRANG FROM PHONG WHERE MAPHONG='" + map + "'", cnn);
            tb_TKPhong.Fill(QLKHACHSAN, "TT");
            DataTable ds = QLKHACHSAN.Tables["TT"];
            foreach (DataRow row in ds.Rows)
            {
                kq = row[0].ToString();
            }
            return kq;
        }
        public bool SuaTinhTrang(string map)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["PHONG"].Rows.Find(map);
                if (DP_sua != null)
                {
                    DP_sua["TINHTRANG"] = "DANGDANGKY";
                }
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_LoadLoaiPhong);
                tb_LoadLoaiPhong.Update(QLKHACHSAN, "PHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable loadLoaiPThuong()
        {
            tb_LoadLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE MALOAIPHONG LIKE N'%Thuong%'", cnn);
            tb_LoadLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIPHONG"].Columns[0];
            QLKHACHSAN.Tables["LOAIPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable loadLoaiPVip()
        {
            //this.QLKHACHSAN.Tables["LOAIPHONG"].Clear();
            tb_LoadLoaiPhong = new SqlDataAdapter("SELECT * FROM LOAIPHONG WHERE MALOAIPHONG LIKE N'%Vip%'", cnn);
            tb_LoadLoaiPhong.Fill(QLKHACHSAN, "LOAIPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["LOAIPHONG"].Columns[0];
            QLKHACHSAN.Tables["LOAIPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["LOAIPHONG"];
        }
        public DataTable loadKhachHang()
        {
            tb_LoadKhachHang = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            tb_LoadKhachHang.Fill(QLKHACHSAN, "KHACHHANG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["KHACHHANG"].Columns[0];
            QLKHACHSAN.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["KHACHHANG"];
        }
        public DataTable ThemMaDatPhong()
        {
            tb_ThemMaDP = new SqlDataAdapter("SELECT * FROM DATPHONG", cnn);
            tb_ThemMaDP.Fill(QLKHACHSAN, "DATPHONG");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QLKHACHSAN.Tables["DATPHONG"].Columns[0];
            QLKHACHSAN.Tables["DATPHONG"].PrimaryKey = khoachinh;
            return QLKHACHSAN.Tables["DATPHONG"];
        }
        public bool ThemMDP(string pmaDP, string makhach)
        {
            //QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            try
            {
                ThemMaDatPhong();
                DataRow DP_them = QLKHACHSAN.Tables["DATPHONG"].NewRow();
                DP_them["MADAT"] = pmaDP;
                DP_them["MAKHACH"] = makhach;

                QLKHACHSAN.Tables["DATPHONG"].Rows.Add(DP_them);
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_ThemMaDP);
                tb_ThemMaDP.Update(QLKHACHSAN, "DATPHONG");
                loadDatPhong();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void LoadTreeView(TreeView tv)
        {
            tv.CheckBoxes = true;
            tv.NodeMouseClick+=tv_NodeMouseClick;

            TreeNode root= new TreeNode();
            root.Text="Tat Ca";
            tv.Nodes.Add(root);

            TreeNode root1 = new TreeNode();
            root1.Text = "Vip";
            tv.Nodes.Add(root1);

            TreeNode root2 = new TreeNode();
            root2.Text = "Thuong";
            tv.Nodes.Add(root2);

            if (root.Checked)
                root.Checked = false;
            for (int i = 0; i < loadLoaiPhong().Rows.Count; i++)
            {
                root.Nodes.Add(loadLoaiPhong().Rows[i][0].ToString());
            }
            for (int i = 0; i < loadLoaiPThuong().Rows.Count; i++)
            {
                QLKHACHSAN.Tables["LOAIPHONG"].Clear();
                root2.Nodes.Add(loadLoaiPThuong().Rows[i][0].ToString());
            }
            for (int i = 0; i < loadLoaiPVip().Rows.Count; i++)
            {
                QLKHACHSAN.Tables["LOAIPHONG"].Clear();
                root1.Nodes.Add(loadLoaiPVip().Rows[i][0].ToString());
            }
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked= !e.Node.Checked;
        }
        public bool Them(string pmaDP, string maloaip, DateTime ngaydat, DateTime  ngaynhan)
        {
            try
            {
                //cnn.Open();
                //string sql = "select DICHVU.MALOAIDV  from DICHVU,LOAIDICHVU where DICHVU.MALOAIDV=LOAIDICHVU.MALOAIDV AND TENLOAIDV ='" + pmaldv + "' ";
                //SqlCommand cmd = new SqlCommand(sql,cnn);
                //string maloai = cmd.ExecuteScalar().ToString();
                //cnn.Close();
                DataRow DP_them = QLKHACHSAN.Tables["CHITIETDATPHONG"].NewRow();
                DP_them["MADAT"] = pmaDP;
                DP_them["MAPHONG"] = maloaip;
                DP_them["NGAYDANGKI"] = ngaydat;
                DP_them["NGAYNHANDUKIEN"] = ngaynhan;

                QLKHACHSAN.Tables["CHITIETDATPHONG"].Rows.Add(DP_them);
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
                SqlCommandBuilder Build = new SqlCommandBuilder(tb_DatPhong);
                tb_DatPhong.Update(QLKHACHSAN, "CHITIETDATPHONG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Xoa(string pmaDP)
        {
            try
            {
                DataRow DP_xoa = QLKHACHSAN.Tables["CHITIETDATPHONG"].Rows.Find(pmaDP);
                if (DP_xoa != null)
                {
                    DP_xoa.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string pmaDP, string maloaip, DateTime ngaydat, DateTime ngaynhan)
        {
            try
            {
                DataRow DP_sua = QLKHACHSAN.Tables["CHITIETDATPHONG"].Rows.Find(pmaDP);
                if (DP_sua != null)
                {
                    DP_sua["MALOAIPHONG"] = maloaip;
                    DP_sua["NGAYDANGKI"] = ngaydat;
                    DP_sua["NGAYNHANDUKIEN"] = ngaynhan;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable TimMaDat(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            tb_TimDatPhong = new SqlDataAdapter("Select * from CHITIETDATPHONG Where MADAT= '" + txtTK + "'", cnn);
            tb_TimDatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
            return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        }
        public DataTable TimMaLoaiPhong(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            tb_TimDatPhong = new SqlDataAdapter("Select * from CHITIETDATPHONG Where MALOAIPHONG= '" + txtTK + "'", cnn);
            tb_TimDatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
            return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        }
        //public DataTable TimSL(int txtTK)
        //{
        //    this.QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
        //    tb_TimDatPhong = new SqlDataAdapter("Select * from CHITIETDATPHONG Where SL= " + txtTK + "", cnn);
        //    tb_TimDatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
        //    return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        //}
        public DataTable TimNgayDangKi(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            tb_TimDatPhong = new SqlDataAdapter("Select * from CHITIETDATPHONG Where NGAYDANGKI= '" + txtTK + "'", cnn);
            tb_TimDatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
            return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        }
        public DataTable TimNhanDuKien(string txtTK)
        {
            this.QLKHACHSAN.Tables["CHITIETDATPHONG"].Clear();
            tb_TimDatPhong = new SqlDataAdapter("Select * from CHITIETDATPHONG Where NGAYNHANDUKIEN= '" + txtTK + "'", cnn);
            tb_TimDatPhong.Fill(QLKHACHSAN, "CHITIETDATPHONG");
            return QLKHACHSAN.Tables["CHITIETDATPHONG"];
        }
    }
}
