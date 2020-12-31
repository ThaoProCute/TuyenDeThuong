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
    public partial class QuyDinh : Form
    {
        XuLy.QuyDinh qd = new XuLy.QuyDinh();
        public QuyDinh()
        {
            InitializeComponent();
        }

        private void QuyDinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qd.loadQuyDinh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (qd.Them(txtten.Text, txtmota.Text))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
                MessageBox.Show("Thêm Thất Bại");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txtmota.Text="";
            dataGridView1.DataSource = qd.loadQuyDinh();
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (qd.LuuDTB())
            {
                MessageBox.Show("Lưu Thành Công");
            }
            else
                MessageBox.Show("Lưu Thất Bại");
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Quy Định", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (qd.Xoa(txtten.Text))
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else
                MessageBox.Show("Xóa Thất Bại");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (qd.Sua(txtten.Text,txtmota.Text))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        private void toolStripTextBoxTK_Click(object sender, EventArgs e)
        {
            toolStripTextBoxTK.Text = "";
        }

        private void tìmTheoHọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoHọToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim Theo Ten Quy Dinh ";
            toolStrip1.Focus();
        }

        private void tìmTheoGiớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoGiớiTínhToolStripMenuItem.Checked = true;
            tìmTheoHọToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim Theo Mo Ta Quy Dinh ";
            toolStrip1.Focus();
        }

        private void toolStripTextBoxTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tìmTheoHọToolStripMenuItem.Checked)
                {
                    qd.TimTenQD(toolStripTextBoxTK.Text);
                }
                else
                    qd.TimMoTaQD(toolStripTextBoxTK.Text);
            }
        }

    }
}
