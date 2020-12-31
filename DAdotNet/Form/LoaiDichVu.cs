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
    public partial class LoaiDichVu : Form
    {
        XuLy.LoaiDichVu ldv = new XuLy.LoaiDichVu();
        public LoaiDichVu()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (ldv.Them(txtMLDV.Text, txtTLDV.Text))
            {

                MessageBox.Show("Them Thanh  Cong");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ldv.loaDichVu();
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (ldv.Sua(txtMLDV.Text, txtTLDV.Text))
            {

                MessageBox.Show("Sua Thanh  Cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (ldv.Xoa(txtMLDV.Text))
            {

                MessageBox.Show("xoa Thanh  Cong");
            }
            else
                MessageBox.Show("Xoa That Bai");
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dich Vu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (ldv.LuuDTB())
            {

                MessageBox.Show("Luu Thanh  Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButtonLAmMoi_Click(object sender, EventArgs e)
        {
            txtMLDV.Text = "";
            txtTLDV.Text = "";
            dataGridView1.DataSource = ldv.loaDichVu();
        }

        private void tìmTheoMãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = true;
            tìmTheoTênLoạiDịchVụToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma loai dich vu";
            toolStrip1.Focus();
        }

        private void tìmTheoTênLoạiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = false;
            tìmTheoTênLoạiDịchVụToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo Ten loai dich vu";
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
                if (tìmTheoMãToolStripMenuItem.Checked)
                    ldv.TimMaDV(toolStripTextBoxTK.Text);
                else
                    ldv.TimMadv(toolStripTextBoxTK.Text);
            }
        }

    }
}
