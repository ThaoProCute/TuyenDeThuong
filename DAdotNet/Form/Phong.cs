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
    public partial class Phong : Form
    {
        XuLy.Phong p = new XuLy.Phong(); 
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.loaPhong();
            cbTLP.DisplayMember = "TENLOAIPHONG";
            cbTLP.ValueMember = "MALOAIPHONG";
            cbTLP.DataSource = p.loadLoaiPhong();
            cbTNV.DisplayMember = "TENNHANVIEN";
            cbTNV.ValueMember = "MANHANVIEN";
            cbTNV.DataSource = p.LoadNhanVien();
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (!p.ktKhoaChinh(txtMP.Text))
            {
                MessageBox.Show("trung khoa chinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtMP.Text=="" || cbTLP.Text== "" || cbTNV.Text=="" || txtTT.Text=="" || txtGC.Text== "")
            {
                MessageBox.Show("Thong Tin Them Khong Du", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = p.loaPhong1();
                if (p.Them(txtMP.Text, cbTLP.SelectedValue.ToString(), cbTNV.SelectedValue.ToString(), txtTT.Text, txtGC.Text))
                {
                    dataGridView1.DataSource = p.loaPhong();
                    MessageBox.Show("Them Thanh cong");
                }
                else
                    MessageBox.Show("Them That bai");
            }
        }

        private void toolStripButtonsua_Click(object sender, EventArgs e)
        {
            if (txtMP.Text == "")
            {
                MessageBox.Show("chua nhap ma de thay doi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbTLP.Text == "" || cbTNV.Text == "" || txtTT.Text == "" || txtGC.Text == "")
            {
                MessageBox.Show("Thong Tin Them Khong Du", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = p.loaPhong1();
                if (p.Sua(txtMP.Text, cbTLP.SelectedValue.ToString(), cbTNV.SelectedValue.ToString(), txtTT.Text, txtGC.Text))
                {
                    dataGridView1.DataSource = p.loaPhong();
                    MessageBox.Show("Sua Thanh cong");
                }
                else
                    MessageBox.Show("Sua That bai");
            }
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.loaPhong1();
            if (p.Xoa(txtMP.Text))
            {
                dataGridView1.DataSource = p.loaPhong();
                MessageBox.Show("xoa Thanh cong");
            }
            else
                MessageBox.Show("Xoa That bai");
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
            if (p.LuuDTB())
            {
                MessageBox.Show("Luu Thanh cong");
            }
            else
                MessageBox.Show("Luu That bai");
        }

        private void toolStripButtonLammoi_Click(object sender, EventArgs e)
        {
            txtMP.Text = "";
            cbTLP.Text = ""; 
            cbTNV.Text = ""; 
            txtTT.Text = ""; 
            txtGC.Text = "";
            dataGridView1.DataSource = p.loaPhong();
        }

        private void tìmKiếmTheoMãPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãPhòngToolStripMenuItem.Checked = true;
            tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked = false;
            tìmKiếmTheoGhiChúToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Phong";
            toolStrip1.Focus();

        }

        private void tìmKiếmTênLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked = true;
            tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked = false;
            tìmKiếmTheoGhiChúToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Phong";
            toolStrip1.Focus();
        }

        private void tìmKiếmTheoNhânViênPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked = true;
            tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked = false;
            tìmKiếmTheoGhiChúToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Phong";
            toolStrip1.Focus();
        }

        private void tìmKiếmTheoTìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked = true;
            tìmKiếmTheoGhiChúToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Phong";
            toolStrip1.Focus();
        }

        private void tìmKiếmTheoGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked = false;
            tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked = false;
            tìmKiếmTheoGhiChúToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo Ma Phong";
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
                if (tìmKiếmTheoMãPhòngToolStripMenuItem.Checked)
                    p.TimMaPhong("toolStripTextBoxTK.Text");
                else if (tìmKiếmTênLoạiPhòngToolStripMenuItem.Checked)
                    p.TimTenLP("toolStripTextBoxTK.Text");
                else if (tìmKiếmTheoNhânViênPhòngToolStripMenuItem.Checked)
                    p.TimTenNhanVien("toolStripTextBoxTK.Text");
                else if (tìmKiếmTheoTìnhTrạngToolStripMenuItem.Checked)
                    p.TimTinhTrang("toolStripTextBoxTK.Text");
                else
                    p.TimGhiChu("toolStripTextBoxTK.Text");
                    
            }
        }

    }
}
