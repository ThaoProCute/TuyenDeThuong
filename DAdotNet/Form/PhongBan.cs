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
    public partial class PhongBan : Form
    {
        XuLy.PhongBan pb = new XuLy.PhongBan();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pb.loadPhongBan();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (pb.Them(txtMaPB.Text, txtTenPB.Text, txtDC.Text,txtSDT.Text))
            {
                MessageBox.Show("Them Thanh cong");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (pb.Sua(txtMaPB.Text, txtTenPB.Text, txtDC.Text, txtSDT.Text))
            {
                MessageBox.Show("Sua Thanh cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (pb.Xoa(txtMaPB.Text))
            {
                MessageBox.Show("Xoa Thanh cong");
            }
            else
                MessageBox.Show("Xoa That Bai");
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Phong Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (pb.LuuDTB())
            {
                MessageBox.Show("Luu Thanh cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButtonLammoi_Click(object sender, EventArgs e)
        {
            txtMaPB.Text="";
            txtTenPB.Text="";
            txtDC.Text="";
            txtSDT.Text = "";
            dataGridView1.DataSource = pb.loadPhongBan();
        }

        private void tìmTheoMãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = true;
            tìmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉPhòngBanToolStripMenuItem.Checked=false;
            tìmTheoSốToolStripMenuItem.Checked=false;
            toolStripTextBoxTK.Text="Tim Theo Ma Phong Ban";
            toolStrip1.Focus();
        }

        private void tìmTheoTênPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = false;
            tìmTheoTênPhòngBanToolStripMenuItem.Checked = true;
            tìmTheoĐịaChỉPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoSốToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Theo ten Phong Ban";
            toolStrip1.Focus();
        }

        private void tìmTheoĐịaChỉPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = false;
            tìmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉPhòngBanToolStripMenuItem.Checked = true;
            tìmTheoSốToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Theo dia chi Phong Ban";
            toolStrip1.Focus();
        }

        private void tìmTheoSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãToolStripMenuItem.Checked = false;
            tìmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoĐịaChỉPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoSốToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Theo so dien thoai Phong Ban";
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
                    pb.TimMaPB(toolStripTextBoxTK.Text);
                else if (tìmTheoTênPhòngBanToolStripMenuItem.Checked)
                    pb.TimTenPB(toolStripTextBoxTK.Text);
                else if (tìmTheoĐịaChỉPhòngBanToolStripMenuItem.Checked)
                    pb.TimDC(toolStripTextBoxTK.Text);
                else 
                    pb.TimSDT(toolStripTextBoxTK.Text);
            }
        }

    }
}
