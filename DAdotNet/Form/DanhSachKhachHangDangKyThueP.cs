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
    public partial class DanhSachKhachHangDangKyThueP : Form
    {
        XuLy.DanhSachDangKyThueP dsdk = new XuLy.DanhSachDangKyThueP();
        public DanhSachKhachHangDangKyThueP()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHangDangKyThueP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsdk.loadsDatPhong();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dsdk.Them(dataGridView1))
            {
                MessageBox.Show("Them Thanh Cng");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (dsdk.LuuDTB())
            {
                MessageBox.Show("Luu Thanh Cong");
            }
            else
            {
                MessageBox.Show("Luu That Cong");
            }
        }

    }
}
