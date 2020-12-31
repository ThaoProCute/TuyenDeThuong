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
    public partial class ThietBi : Form
    {
        XuLy.ThietBi tb = new XuLy.ThietBi();
        public ThietBi()
        {
            InitializeComponent();
        }

        private void ThietBi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb.loadThietBi();
            cbMaP.DisplayMember = "MAPHONG";
            cbMaP.ValueMember = "MAPHONG";
            cbMaP.DataSource = tb.loadPhong();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tb.Them(txtMaTB.Text, txtTenTB.Text, cbMaP.Text, int.Parse(numericUpDown1.Value.ToString())))
            {
                MessageBox.Show("Them Thanh Cong");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (tb.Sua(txtMaTB.Text, txtTenTB.Text, cbMaP.Text, int.Parse(numericUpDown1.Value.ToString())))
            {
                MessageBox.Show("Sua Thanh Cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (tb.Xoa(txtMaTB.Text))
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
                MessageBox.Show("Xoa That Bai");
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Khach Hang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (tb.LuuDTB())
            {
                MessageBox.Show("luu Thanh Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTB.Text="";
            txtTenTB.Text="";
            cbMaP.Text="";
            numericUpDown1.Value=0;
            cbMaP.DataSource = tb.loadPhong();
        }

        private void tìmTheoMãThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãThiếtBịToolStripMenuItem.Checked = true;
            tìmTheoTênThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Thiet bi ";
            toolStripTextBoxTK.Focus();
        }

        private void tìmTheoTênThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoTênThiếtBịToolStripMenuItem.Checked = true;
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Thiet bi ";
            toolStripTextBoxTK.Focus();
        }

        private void tìmTheoMãLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoTênThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = true;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Thiet bi ";
            toolStripTextBoxTK.Focus();
        }

        private void tìmTheoSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoTênThiếtBịToolStripMenuItem.Checked = false;
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Thiet bi ";
            toolStripTextBoxTK.Focus();
        }

        private void toolStripTextBoxTK_Click(object sender, EventArgs e)
        {
            toolStripTextBoxTK.Text = "";
        }

        private void toolStripTextBoxTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tìmTheoMãThiếtBịToolStripMenuItem.Checked)
                    tb.TimMaTB(toolStripTextBoxTK.Text);
                else if (tìmTheoTênThiếtBịToolStripMenuItem.Checked)
                    tb.TimTenTB(toolStripTextBoxTK.Text);
                else if (tìmTheoMãLoạiPhòngToolStripMenuItem.Checked)
                    tb.TimMAP(toolStripTextBoxTK.Text);
                else 
                    tb.TimSL(int.Parse(toolStripTextBoxTK.Text));
            }
        }
    }
}
