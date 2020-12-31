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
    public partial class ChiTietHoaDon : Form
    {
        XuLy.ChiTietHoaDon cthd = new XuLy.ChiTietHoaDon();
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cthd.LoadCTHoaDon();
            comboBox1.DataSource = cthd.LoadMASDDV();
            comboBox1.DisplayMember = "MASDDV";
            comboBox1.ValueMember = "MASDDV";

            cbMaPhong.DataSource = cthd.loadMaP();
            cbMaPhong.DisplayMember = "MAPHONG";
            cbMaPhong.ValueMember = "MAPHONG";
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (cthd.Them(txtMHD.Text,cbMaPhong.SelectedValue.ToString(),comboBox1.SelectedValue.ToString(),float.Parse(txtTienP.Text),float.Parse(txtDV.Text),int.Parse(txtGiamGiaKH.Text),int.Parse(numericUpDown1.Value.ToString()),txtThanhToan.Text))
            {
                MessageBox.Show("Them thanh Cong");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (cthd.Sua(txtMHD.Text, cbMaPhong.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), float.Parse(txtTienP.Text), float.Parse(txtDV.Text), int.Parse(txtGiamGiaKH.Text), int.Parse(numericUpDown1.Value.ToString()), txtThanhToan.Text))
            {
                MessageBox.Show("Sua thanh Cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (cthd.Xoa(txtMHD.Text))
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
            if (cthd.LuuDTB())
            {
                MessageBox.Show("Luu thanh Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            cbMaPhong.DataSource = cthd.loadMaP();
            cbMaPhong.DisplayMember = "MAPHONG";
            cbMaPhong.ValueMember = "MAPHONG";
            txtMHD.Text = "";
            txtDV.Text = "";
            txtGiamGiaKH.Text = "";
            comboBox1.Text = "";
            txtThanhToan.Text = "";
            txtTienP.Text = "";
        }

        private void mãHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = true;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Ma Hoa Don";
            toolStrip1.Focus();

        }

        private void mãPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = true;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Ma Phong";
            toolStrip1.Focus();
        }

        private void tiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = true;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Tien Phong";
            toolStrip1.Focus();
        }

        private void tiềnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = true;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Tien Dich Vu";
            toolStrip1.Focus();
        }

        private void giảmGiáKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = true;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Giam Gia Khach Hang";
            toolStrip1.Focus();
        }

        private void sốNgàyỞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = true;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "So Ngay O";
            toolStrip1.Focus();
        }

        private void hìnhThứcThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = true;
            thànhTiềnToolStripMenuItem.Checked = false;
            toolStripTextBox1.Text = "Hinh Thuc Thanh Toan";
            toolStrip1.Focus();
        }

        private void thànhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mãHóaĐơnToolStripMenuItem.Checked = false;
            mãPhòngToolStripMenuItem.Checked = false;
            tiềnPhòngToolStripMenuItem.Checked = false;
            tiềnDịchVụToolStripMenuItem.Checked = false;
            giảmGiáKHToolStripMenuItem.Checked = false;
            sốNgàyỞToolStripMenuItem.Checked = false;
            hìnhThứcThanhToánToolStripMenuItem.Checked = false;
            thànhTiềnToolStripMenuItem.Checked = true;
            toolStripTextBox1.Text = "Tim Ma Chinh Sach";
            toolStrip1.Focus();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "";
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mãHóaĐơnToolStripMenuItem.Checked)
                cthd.TimMaHD(toolStripTextBox1.Text);
            else if (mãPhòngToolStripMenuItem.Checked)
                cthd.TimMaPhong(toolStripTextBox1.Text);
            else if (tiềnPhòngToolStripMenuItem.Checked)
                cthd.TimTienPhong(float.Parse(toolStripTextBox1.Text));
            else if (tiềnDịchVụToolStripMenuItem.Checked)
                cthd.TimMaDV(float.Parse(toolStripTextBox1.Text));
            else if (giảmGiáKHToolStripMenuItem.Checked)
                cthd.TimGiamGia(int.Parse(toolStripTextBox1.Text));
            else if (sốNgàyỞToolStripMenuItem.Checked)
                cthd.TimSoNgay(int.Parse(toolStripTextBox1.Text));
            else if(thànhTiềnToolStripMenuItem.Checked)
                cthd.TimMaChinhSach(float.Parse(toolStripTextBox1.Text));
            else
                cthd.Timhinhthuctt(toolStripTextBox1.Text);
        }
    }
}
