using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAdotNet
{
    public partial class QuanLiKhachSan : Form
    {
        public QuanLiKhachSan()
        {
            InitializeComponent();
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyDinh qd = new QuyDinh();
            qd.MdiParent = this;
            qd.Show();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe qd = new LienHe();
            qd.MdiParent = this;
            qd.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanSuDung qd = new HuongDanSuDung();
            qd.MdiParent = this;
            qd.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu qd = new DoanhThu();
            qd.MdiParent = this;
            qd.Show();
        }

        private void chiếtKhấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang qd = new KhachHang();
            qd.MdiParent = this;
            qd.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu qd = new DichVu();
            qd.MdiParent = this;
            qd.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong qd = new Phong();
            qd.MdiParent = this;
            qd.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyDatPhong qd = new DangKyDatPhong();
            qd.MdiParent = this;
            qd.Show();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NhanPhong qd = new NhanPhong();
            //qd.MdiParent = this;
            //qd.Show();
        }

        private void danhSáchKháchHÀngĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangDangKyThueP qd = new DanhSachKhachHangDangKyThueP();
            qd.MdiParent = this;
            qd.Show();
        }

        private void danhSáchKháchHàngNhậnTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DanhSachNhanTraPhong qd = new DanhSachNhanTraPhong();
            //qd.MdiParent = this;
            //qd.Show();
        }


        private void thiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThietBi qd = new ThietBi();
            qd.MdiParent = this;
            qd.Show();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhong qd = new LoaiPhong();
            qd.MdiParent = this;
            qd.Show();
        }

        private void loạiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiDichVu qd = new LoaiDichVu();
            qd.MdiParent = this;
            qd.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien qd = new NhanVien();
            qd.MdiParent = this;
            qd.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon qd = new HoaDon();
            qd.MdiParent = this;
            qd.Show();
        }

        private void CTHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon qd = new ChiTietHoaDon();
            qd.MdiParent = this;
            qd.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            pb.MdiParent = this;
            pb.Show();
        }

        private void nhậnPhòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NhanPhong np = new NhanPhong();
            np.MdiParent = this;
            np.Show();
        }

        private void danhSáchKháchHàngNhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanPhong dsnp = new DanhSachNhanPhong();
            dsnp.MdiParent = this;
            dsnp.Show();
        }

        private void danhSáchSửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSuDungDichVu dsnp = new DanhSachSuDungDichVu();
            dsnp.MdiParent = this;
            dsnp.Show();
        }

        private void trảPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraPhong dsnp = new TraPhong();
            dsnp.MdiParent = this;
            dsnp.Show();

        }

       
    }
}
