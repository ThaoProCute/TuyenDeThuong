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
    public partial class DanhSachSuDungDichVu : Form
    {
        XuLy.DanhSachSuDungDichVu dsdv = new XuLy.DanhSachSuDungDichVu();
        public DanhSachSuDungDichVu()
        {
            InitializeComponent();
        }

        private void DanhSachSuDungDichVu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsdv.loadsNHanPhong();
        }

        private void tìmTheoMãNhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = true;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked=false;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Su Dung DV";
        }

        private void tìmTheoMãĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = true;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma  DV";
        }

        private void tìmTheoMãKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = true;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Kiem Theo Ma Nhan Phong";
        }

        private void tìmTheoSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãNhậnPhòngToolStripMenuItem.Checked = false;
            tìmTheoMãĐặtPhòngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = false;
            tìmTheoSốLượngToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Kiem Theo So Luong";
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
                    dsdv.MASDDV(toolStripTextBoxTK.Text);
                else if (tìmTheoMãĐặtPhòngToolStripMenuItem.Checked)
                    dsdv.MADV(toolStripTextBoxTK.Text);
                else if (tìmTheoSốLượngToolStripMenuItem.Checked)
                    dsdv.MANHANPHONG(toolStripTextBoxTK.Text);
                else 
                    dsdv.SL(int.Parse(toolStripTextBoxTK.Text)); 
            }
        }
    }
}
