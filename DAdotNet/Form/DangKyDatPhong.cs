using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DAdotNet
{
    public partial class DangKyDatPhong : Form
    {
        XuLy.DangKyDatPhong dkp = new XuLy.DangKyDatPhong();
        public DangKyDatPhong()
        {
            InitializeComponent();
        }

        private void DangKyDatPhong_Load(object sender, EventArgs e)
        {
            dkp.LoadTreeView(treeView1);


            dataGridView1.DataSource = dkp.loadDatPhong();


            cbTenKhach.DataSource = dkp.loadKhachHang();
            cbTenKhach.DisplayMember = "TENKHACH";
            cbTenKhach.ValueMember = "MAKHACH";

            cbTenLoaiPhong.DataSource = dkp.loadPhong();
            cbTenLoaiPhong.DisplayMember = "MAPHONG";
            cbTenLoaiPhong.ValueMember = "MAPHONG";

            //CbMLP.DataSource = dkp.loadLoaiPhong();
            //CbMLP.DisplayMember = "MALOAIPHONG";
            //CbMLP.ValueMember = "MALOAIPHONG";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dkp.loadDatPhong();
            dkp.loadKhachHang().Clear();
            cbTenKhach.DataSource = dkp.loadKhachHang();
            cbTenKhach.DisplayMember = "TENKHACH";
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (dkp.KiemTraTinhtrang(cbTenLoaiPhong.SelectedValue.ToString()) == "Trong")
            {
                if (dkp.Them(txtMaDatPhong.Text, cbTenLoaiPhong.SelectedValue.ToString(), DateTime.Parse(dateTimePicker1.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString())))
                {

                    MessageBox.Show("Them thanh Cong");
                    if (dkp.SuaTinhTrang(cbTenLoaiPhong.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Sua Tinh Trang thanh Cong");
                    }
                    else
                        MessageBox.Show("Sua Tinh Trang That Bai");
                }
                else
                    MessageBox.Show("Them That Bai");
            }
            else
                MessageBox.Show("Phong Day");
            
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (dkp.LuuDTB())
            {
                MessageBox.Show("Luu thanh Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void btnTMDH_Click(object sender, EventArgs e)
        {
            if(dkp.ThemMDP(txtThemMaDatHang.Text,cbTenKhach.SelectedValue.ToString()))
            {
                MessageBox.Show("them thanh Cong");
                txtMaDatPhong.Text = txtThemMaDatHang.Text;
                txtThemMaDatHang.Text = "";
            }
            else
                MessageBox.Show("Them Khong Thanh Cong");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (dkp.Sua(txtMaDatPhong.Text, cbTenLoaiPhong.SelectedValue.ToString(), DateTime.Parse(dateTimePicker1.Value.ToString()), DateTime.Parse(dateTimePicker2.Value.ToString())))
            {
                MessageBox.Show("Sua Thanh Cong");
            }
            else
            {
                MessageBox.Show("Sua Khong Thanh Cong");
            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (dkp.Xoa(txtMaDatPhong.Text))
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
            {
                MessageBox.Show("Xoa Khong thanh Cong");
            }
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dang Ky Dat Phong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tìmKiếmTheoMãĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = true;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Dat Phong";
            toolStrip1.Focus();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = true;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Loai Phong";
            toolStrip1.Focus();
        }


        private void tìmKiếmNgàyĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = true;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Ngay Dang Ki";
            toolStrip1.Focus();
        }

        private void tìmKiếmNgàyNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmKiếmToolStripMenuItem.Checked = false;
            tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked = false;
            tìmKiếmNgàyNhậnToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo Ma Ngay Nhan";
            toolStrip1.Focus();
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
                    dkp.TimMaDat(toolStripTextBoxTK.Text);
                else if (tìmKiếmTheoMãĐặtPhòngToolStripMenuItem.Checked)
                    dkp.TimMaLoaiPhong(toolStripTextBoxTK.Text);
                else if (tìmKiếmNgàyĐăngKíToolStripMenuItem.Checked)
                    dkp.TimNgayDangKi(toolStripTextBoxTK.Text);
                else
                    dkp.TimNhanDuKien(toolStripTextBoxTK.Text );
            }
        }

    }
}
