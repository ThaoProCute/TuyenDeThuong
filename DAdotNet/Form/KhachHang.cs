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
    public partial class KhachHang : Form
    {
        XuLy.KhachHang kh = new XuLy.KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtMK.Focus();
            dataGridView1.DataSource = kh.loadKhachHang();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtMK.Focus();
            txtTK.Text = "";
            txtCMND.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtQT.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dataGridView1.DataSource = kh.loadKhachHang();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kh.loadKhachHang();
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Khach Hang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        string ktGioiTinh(RadioButton Nam, RadioButton Nu)
        {
            string kq;
            if (Nam.Checked)
            {
                kq = "Nam";
            }
            else
                kq = "Nữ";
            return kq;
        }
        private void tsThem_Click(object sender, EventArgs e)
        {
            if (kh.Them(txtMK.Text, txtTK.Text, txtCMND.Text, txtDC.Text, txtSDT.Text, ktGioiTinh(radNam,radNu), txtQT.Text))
            {
                MessageBox.Show("them thanh cong dataset");
            }
            else
            {
                MessageBox.Show("them khong thanh cong");
            }
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            if (kh.Sua(txtMK.Text, txtTK.Text, txtCMND.Text, txtDC.Text, txtSDT.Text, ktGioiTinh(radNam, radNu), txtQT.Text))
            {
                MessageBox.Show("sua thanh cong dataset");
            }
            else
            {
                MessageBox.Show("sua khong thanh cong");
            }
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (kh.Xoa(txtMK.Text))
            {
                MessageBox.Show("xoa thanh cong dataset");
            }
            else
            {
                MessageBox.Show("xoa khong thanh cong");
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (kh.LuuDTB())
            {
                MessageBox.Show("luu thanh cong database");
            }
            else
            {
                MessageBox.Show("xoa khong thanh cong database");
            }
        }

        private void tìmTheoHọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoCMNDToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉToolStripMenuItem.Checked = false;
            tìmTheoHọToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tìm theo Họ tên";
            toolStrip1.Focus();
        }

        private void tìmTheoGiớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = true;
            tìmTheoCMNDToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉToolStripMenuItem.Checked = false;
            tìmTheoHọToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tìm Theo Giới Tính";
            toolStrip1.Focus();
        }

        private void tìmTheoCMNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoCMNDToolStripMenuItem.Checked = true;
            tìmTheoĐịaChỉToolStripMenuItem.Checked = false;
            tìmTheoHọToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tìm Theo CMND";
            toolStrip1.Focus();
        }

        private void tìmTheoĐịaChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoCMNDToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉToolStripMenuItem.Checked = true;
            tìmTheoHọToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tìm Theo Địa chỉ ";
            toolStrip1.Focus();
        }

        private void toolStripTextBoxTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nhấn enter
            {
                if (tìmTheoHọToolStripMenuItem.Checked)
                {
                    dataGridView1.DataSource = kh.TimHoTen(toolStripTextBoxTK.Text);
                }
                else if (tìmTheoGiớiTínhToolStripMenuItem.Checked)
                    dataGridView1.DataSource = kh.timgioitinh(toolStripTextBoxTK.Text);
                else if (tìmTheoCMNDToolStripMenuItem.Checked)
                    dataGridView1.DataSource = kh.TimCNND(toolStripTextBoxTK.Text);
                else
                    dataGridView1.DataSource = kh.timdiachi(toolStripTextBoxTK.Text);
            }
        }

        private void toolStripTextBoxTK_Click(object sender, EventArgs e)
        {
            toolStripTextBoxTK.Text = "";
        }

       
    }
}
