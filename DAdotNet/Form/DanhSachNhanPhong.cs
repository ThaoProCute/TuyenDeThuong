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
    public partial class DanhSachNhanPhong : Form
    {
        XuLy.DanhSachNhanPhong dsnp = new XuLy.DanhSachNhanPhong();
        public DanhSachNhanPhong()
        {
            InitializeComponent();
        }

        private void tìmTheoMãNhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = true;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãKháchHàngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Theo Ma nhan phong";
            toolStrip1.Focus();
        }

        private void tìmTheoMãĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = true;
            tìmTheoMãKháchHàngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Theo Ma phong";
            toolStrip1.Focus();
        }

        private void tìmTheoMãKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãKháchHàngToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Theo Ma phong";
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
                if (tìmTheoMãNhậnPhòngToolStripMenuItem.Checked)
                    dsnp.TimTheoMaNP(toolStripTextBoxTK.Text);
                else if (tìmTheoMãĐặtPhòngToolStripMenuItem.Checked)
                    dsnp.TimMaDP(toolStripTextBoxTK.Text);
                else
                    dsnp.TimMaKhachHang(toolStripTextBoxTK.Text);
            }
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachNhanPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsnp.loadsNHanPhong();
        }
    }
}
