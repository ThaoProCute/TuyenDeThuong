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
    public partial class LoaiPhong : Form
    {
        XuLy.LoaiPhong lp = new XuLy.LoaiPhong();
        public LoaiPhong()
        {
            InitializeComponent();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lp.loadLoaiPhong();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (lp.Them(txtMP.Text, txtTenP.Text, float.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString())))
            {
                MessageBox.Show("Them Thanh Cong");
            }
            else
                MessageBox.Show("Them That Bai");
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (lp.Sua(txtMP.Text, txtTenP.Text, float.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString())))
            {
                MessageBox.Show("Sua Thanh Cong");
            }
            else
                MessageBox.Show("Sua That Bai");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (lp.Xoa(txtMP.Text))
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
                MessageBox.Show("xoa That Bai");
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Phong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (lp.LuuDTB())
            {
                MessageBox.Show("Luu Thanh Cong");
            }
            else
                MessageBox.Show("Luu That Bai");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            txtMP.Text = "";
            txtTenP.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            dataGridView1.DataSource = lp.loadLoaiPhong();
        }

        private void tìmTheoMãLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked=true;
            tìmTheoTênLoạiPhòngToolStripMenuItem.Checked=false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked=false;
            tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked=false;
            tìmTheoSốNgườiỞTốiĐaToolStripMenuItem.Checked=false;
            toolStripTextBoxTK.Text = "Tim theo Ma Loai Phong";
            toolStrip1.Focus();

        }

        private void tìmTheoTênLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoTênLoạiPhòngToolStripMenuItem.Checked = true;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞTốiĐaToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ten Loai Phong";
            toolStrip1.Focus();
        }

        private void tìmTheoĐơnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = true;
            tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞTốiĐaToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Don Gia";
            toolStrip1.Focus();
        }

        private void tìmTheoSốNgườiỞChuẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked = true;
            tìmTheoSốNgườiỞTốiĐaToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo So Nguoi O chuan";
            toolStrip1.Focus();
        }

        private void tìmTheoSốNgườiỞTốiĐaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked = false;
            tìmTheoSốNgườiỞTốiĐaToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo So Nguoi O Toi Da";
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
                if (tìmTheoMãLoạiPhòngToolStripMenuItem.Checked)
                    lp.TimMaLP(toolStripTextBoxTK.Text);
                else if (tìmTheoTênLoạiPhòngToolStripMenuItem.Checked)
                    lp.TimTenLP(toolStripTextBoxTK.Text);
                else if (tìmTheoĐơnGiáToolStripMenuItem.Checked)
                    lp.TimDonGia(float.Parse(toolStripTextBoxTK.Text));
                else if (tìmTheoSốNgườiỞChuẩnToolStripMenuItem.Checked)
                    lp.TimSLNgChuan(int.Parse(toolStripTextBoxTK.Text));
                else
                    lp.TimSLNgToiDa(int.Parse(toolStripTextBoxTK.Text));
            }
        }
    }
}
