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
    public partial class NhanPhong : Form
    {
        XuLy.NhanPhong np = new XuLy.NhanPhong(); 
         public NhanPhong()
        {
            InitializeComponent();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (np.KiemTraTinhtrang(cbMaPhong.SelectedValue.ToString()) == "DANGDANGKY")
            {
                if (np.Them(txtMaNP.Text, cbMaPhong.SelectedValue.ToString(), txtTenKhach.Text, txtCMNN.Text, DateTime.Parse(dateTimePicker1.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString())))
                {
                    MessageBox.Show("Them thanh Cong");
                    if (np.SuaTinhTrang(cbMaPhong.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Nhan Phong Thanh Cong");
                    }
                    else
                        MessageBox.Show("Nhan Phong That Bai");
                }
                else
                    MessageBox.Show("Them That Bai");
            }
            else
                MessageBox.Show("Phong Chua Duoc Dang Ky");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (np.Sua(txtMaNP.Text, cbMaPhong.SelectedValue.ToString(), txtTenKhach.Text, txtCMNN.Text, DateTime.Parse(dateTimePicker1.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString())))
            {
                MessageBox.Show("Sua thanh Cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (np.Xoa(txtMaNP.Text))
            {
                MessageBox.Show("Xoa thanh Cong");
            }
            else
                MessageBox.Show("Xoa That Bai");

        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dang Ky Dat Phong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (np.LuuDTB())
            {
                MessageBox.Show("Luu thanh Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = np.loadNhanPhong();

            cbDatPhong.DataSource = np.loadDatPhong();
            cbDatPhong.DisplayMember = "MADAT";
            cbDatPhong.ValueMember = "MADAT";

            cbMaKhach.DataSource = np.loadKhachHang();
            cbMaKhach.DisplayMember = "MAKHACH";
            cbMaKhach.ValueMember = "MAKHACH";

            cbMaPhong.DataSource = np.loadPhong();
            cbMaPhong.DisplayMember = "MAPHONG";
            cbMaPhong.ValueMember = "MAPHONG";

            txtCMNN.Text = "";
            txtMaNP.Text = "";
            txtTenKhach.Text = "";
            txtThemMaNP.Text = "";
        }

        private void tìmKiếmTheoMãĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = true;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Nhan Phong";
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = true;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Phong";
        }

        private void tìmKiếmNgàyĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = true;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Khach";
        }

        private void tìmKiếmNgàyNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = true;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo CMND";
        }

        private void tìmKiếmTheoNgàyNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = true;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ngay Nhan";
        }

        private void tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = true;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ngay Tra Du Kien";
        }

        private void tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked = false;
            tìmKiếmTheoNgàyTrảDựKiếnToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ngay Tra Thuc Te";
        }

        private void toolStripTextBoxTK_Click(object sender, EventArgs e)
        {
            toolStripTextBoxTK.Text = "";
        }

        private void toolStripTextBoxTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked)
                    np.TimMaNhanPhong(toolStripTextBoxTK.Text);
                else if (tìmKiếmToolStripMenuItem.Checked)
                    np.TimMaPhong(toolStripTextBoxTK.Text);
                else if (tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked)
                    np.TimTenKhach(toolStripTextBoxTK.Text);
                else if (tìmKiếmNgàyNhậnToolStripMenuItem.Checked)
                    np.TimCMND(toolStripTextBoxTK.Text);
                else if (tìmKiếmTheoNgàyNhậnToolStripMenuItem.Checked)
                    np.TimNgayNhan(toolStripTextBoxTK.Text);
                else if (tìmKiếmTheoNgàyTrảThựcTếToolStripMenuItem.Checked)
                    np.TimNgayTraDuKien(toolStripTextBoxTK.Text);
                else
                    np.TimNgayTraThucTe(toolStripTextBoxTK.Text);
            }
        }

        private void NhanPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = np.loadNhanPhong();

            cbDatPhong.DataSource = np.loadDatPhong();
            cbDatPhong.DisplayMember = "MADAT";
            cbDatPhong.ValueMember = "MADAT";

            cbMaKhach.DataSource = np.loadKhachHang();
            cbMaKhach.DisplayMember = "MAKHACH";
            cbMaKhach.ValueMember = "MAKHACH";

            cbMaPhong.DataSource = np.loadPhong();
            cbMaPhong.DisplayMember = "MAPHONG";
            cbMaPhong.ValueMember = "MAPHONG";
        }

        private void btnThemMaNP_Click(object sender, EventArgs e)
        {
            if (np.ThemMNP(txtThemMaNP.Text, cbDatPhong.SelectedValue.ToString(), cbMaKhach.SelectedValue.ToString()))
            {
                MessageBox.Show("them Ma Nhan Phong thanh Cong");
                txtMaNP.Text = txtThemMaNP.Text;
                txtThemMaNP.Text = "";
            }
            else
                MessageBox.Show("Them Khong Thanh Cong");
        }
        
    }
}
