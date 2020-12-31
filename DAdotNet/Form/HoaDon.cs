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
    public partial class HoaDon : Form
    {
        XuLy.HoaDon hd = new XuLy.HoaDon();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.LoadHoaDon();
            cbMaKH.DataSource = hd.loadMaKH();
            cbMaKH.DisplayMember = "MAKHACH";
            cbMaKH.ValueMember = "MAKHACH";
            cbMNP.DataSource = hd.loadMaDV();
            cbMNP.DisplayMember = "MANHANPHONG";
            cbMNP.ValueMember = "MANHANPHONG";
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "")
            {
                string tongtien = null;

                if (hd.Them(txtMaHD.Text, txtNVL.Text, cbMaKH.Text, cbMNP.Text, float.Parse(tongtien), DateTime.Parse(dateTimePicker1.Value.ToString())))
                {
                    MessageBox.Show("Them Thanh Cong");
                }
                else
                    MessageBox.Show(" Them Khong Thanh Cong");
            }
            else
            {
                if (hd.Them(txtMaHD.Text, txtNVL.Text, cbMaKH.Text, cbMNP.Text, float.Parse(txtTongTien.Text), DateTime.Parse(dateTimePicker1.Value.ToString())))
                {
                    MessageBox.Show("Them Thanh Cong");
                }
                else
                    MessageBox.Show(" Them Khong Thanh Cong");
            }
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (hd.Sua(txtMaHD.Text, txtNVL.Text, cbMaKH.Text, cbMNP.Text, float.Parse(txtTongTien.Text), DateTime.Parse(dateTimePicker1.Value.ToString())))
            {
                MessageBox.Show("Sua Thanh Cong");
            }
            else
                MessageBox.Show(" Sua Khong Thanh Cong");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (hd.Xoa(txtMaHD.Text))
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
                MessageBox.Show(" Xoa Khong Thanh Cong");
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
            if (hd.LuuDTB())
            {
                MessageBox.Show("Luu Thanh Cong");
            }
            else
                MessageBox.Show(" Luu Khong Thanh Cong");

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.LoadHoaDon();
            cbMaKH.DataSource = hd.loadMaKH();
            cbMaKH.DisplayMember = "MAKHACH";
            cbMaKH.ValueMember = "MAKHACH";
            cbMNP.DataSource = hd.loadMaDV();
            cbMNP.DisplayMember = "MaDV";
            cbMNP.ValueMember = "MaDV";
            txtMaHD.Text = "";
            txtNVL.Text = "";
            txtTongTien.Text = "";
        }

        private void mãHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = true;
            tênNhânViênLậpToolStripMenuItem.Checked = false;
            mãKhachHàngToolStripMenuItem.Checked = false;
            mãDịchVụToolStripMenuItem.Checked = false;
            tổngTiềnToolStripMenuItem.Checked=false;
            ngàyLậpToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Hoa Don";
            toolStrip1.Focus();
        }

        private void tênNhânViênLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            tênNhânViênLậpToolStripMenuItem.Checked = true;
            mãKhachHàngToolStripMenuItem.Checked = false;
            mãDịchVụToolStripMenuItem.Checked = false;
            tổngTiềnToolStripMenuItem.Checked = false;
            ngàyLậpToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ten Nhan Vien Lap";
            toolStrip1.Focus();
        }

        private void mãKhachHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            tênNhânViênLậpToolStripMenuItem.Checked = false;
            mãKhachHàngToolStripMenuItem.Checked = true;
            mãDịchVụToolStripMenuItem.Checked = false;
            tổngTiềnToolStripMenuItem.Checked = false;
            ngàyLậpToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Khach Hang";
            toolStrip1.Focus();
        }

        private void mãDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            tênNhânViênLậpToolStripMenuItem.Checked = false;
            mãKhachHàngToolStripMenuItem.Checked = false;
            mãDịchVụToolStripMenuItem.Checked = true;
            tổngTiềnToolStripMenuItem.Checked = false;
            ngàyLậpToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Dich Vu";
            toolStrip1.Focus();
        }

        private void tổngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            tênNhânViênLậpToolStripMenuItem.Checked = false;
            mãKhachHàngToolStripMenuItem.Checked = false;
            mãDịchVụToolStripMenuItem.Checked = false;
            tổngTiềnToolStripMenuItem.Checked = true;
            ngàyLậpToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Tong Tien";
            toolStrip1.Focus();
        }

        private void ngàyLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            tênNhânViênLậpToolStripMenuItem.Checked = false;
            mãKhachHàngToolStripMenuItem.Checked = false;
            mãDịchVụToolStripMenuItem.Checked = false;
            tổngTiềnToolStripMenuItem.Checked = false;
            ngàyLậpToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo Ngay Lap";
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
                if (mãHóaĐơnToolStripMenuItem.Checked)
                    hd.TimMaHD(toolStripTextBoxTK.Text);
                else if (tênNhânViênLậpToolStripMenuItem.Checked)
                    hd.TimTenNVLD(toolStripTextBoxTK.Text);
                else if (mãKhachHàngToolStripMenuItem.Checked)
                    hd.TimMaKH(toolStripTextBoxTK.Text);
                else if (mãDịchVụToolStripMenuItem.Checked)
                    hd.TimMaDV(toolStripTextBoxTK.Text);
                else if (tổngTiềnToolStripMenuItem.Checked)
                    hd.TimMaTongTien(float.Parse(toolStripTextBoxTK.Text));
                else
                    hd.TimNgayLap(toolStripTextBoxTK.Text);
            }
        }

    }
}
