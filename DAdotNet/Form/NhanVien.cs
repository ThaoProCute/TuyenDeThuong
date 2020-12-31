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
    public partial class NhanVien : Form
    {
        XuLy.NhanVien nv = new XuLy.NhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.loadNhanVien1();
            cbTenPhong.DisplayMember = "TENPB";
            cbTenPhong.ValueMember = "MAPB";
            cbTenPhong.DataSource = nv.loadTenPB();


            //cbMaPB.DisplayMember = "MAPB";
            //cbMaPB.ValueMember = "MAPB";
            //cbMaPB.DataSource = nv.loadTenPB();
        }

        string ktGioiTinh(RadioButton Nam, RadioButton Nu)
        {
            string kq;
            if (Nam.Checked)
            {
                kq = "Nam";
            }
            else
                kq = "Nữ";
            return kq;
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            if (!nv.ktKhoaChinh(txtMNV.Text))
            {
                MessageBox.Show("trung khoa chinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = nv.loadNhanVien();
                if (nv.Them(txtMNV.Text, cbTenPhong.SelectedValue.ToString(), txtTenNV.Text, txtCMNN.Text, ktGioiTinh(radNam, radNu), txtQQ.Text, txtSDT.Text, txtDanToc.Text, txtChucVu.Text, float.Parse(numericUpDown1.Value.ToString())))
                {
                    dataGridView1.DataSource = nv.loadNhanVien1();
                    MessageBox.Show("them thanh cong");
                }
                else
                    MessageBox.Show("Them That bai");
            }
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.loadNhanVien();
            if (nv.Sua(txtMNV.Text, cbTenPhong.SelectedValue.ToString(), txtTenNV.Text, txtCMNN.Text, ktGioiTinh(radNam, radNu), txtQQ.Text, txtSDT.Text, txtDanToc.Text, txtChucVu.Text, float.Parse(numericUpDown1.Value.ToString())))
            {
                dataGridView1.DataSource = nv.loadNhanVien1();
                MessageBox.Show("Sua thanh cong");
            }
            else
                MessageBox.Show("Sua That bai");
        }

        private void toolStripButtonxoa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.loadNhanVien();
            if (nv.Xoa(txtMNV.Text))
            {
                dataGridView1.DataSource = nv.loadNhanVien1();
                MessageBox.Show("Xoa thanh cong");
            }
            else
                MessageBox.Show("xoa That bai");
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.loadNhanVien();
            if (nv.LuuDTB())
            {
                dataGridView1.DataSource = nv.loadNhanVien1();
                MessageBox.Show("Luu thanh cong");
            }
            else
                MessageBox.Show("Luu That bai");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            txtMNV.Text="";
            cbTenPhong.Text="";
            txtTenNV.Text="";
            txtCMNN.Text="";
            radNam.Checked=false;
            radNu.Checked=false;
            txtQQ.Text="";
            txtSDT.Text="";
            txtDanToc.Text="";
            txtChucVu.Text="";
            numericUpDown1.Value = 0;
            dataGridView1.DataSource = nv.loadNhanVien1();
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Khach Hang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void tìmKiếmTheoMãNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = true;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked=false;
            tìmTheoCMNNToolStripMenuItem.Checked=false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked=false;
            tìmTheoQuênQuánToolStripMenuItem.Checked=false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked=false;
            tìmTheoDânTộcToolStripMenuItem.Checked=false;
            tìmTheoChứcVụToolStripMenuItem.Checked=false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void toolStripTextBoxTK_Click(object sender, EventArgs e)
        {
            toolStripTextBoxTK.Text = "";
        }

        private void tìmKiếmTheoTênPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = true;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ten Phong Ban";
            toolStrip1.Focus();
        }

        private void tìmTheoTênNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = true;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoCMNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = true;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoGiớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = true;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoQuênQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = true;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoĐiệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = true;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoDânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = true;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = true;
            tìmTheoLươngToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void tìmTheoLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked = false;
            tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked = false;
            tìmTheoTênNhânViênToolStripMenuItem.Checked = false;
            tìmTheoCMNNToolStripMenuItem.Checked = false;
            tìmTheoGiớiTínhToolStripMenuItem.Checked = false;
            tìmTheoQuênQuánToolStripMenuItem.Checked = false;
            tìmTheoĐiệnThoạiToolStripMenuItem.Checked = false;
            tìmTheoDânTộcToolStripMenuItem.Checked = false;
            tìmTheoChứcVụToolStripMenuItem.Checked = false;
            tìmTheoLươngToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo Ma Nhan Vien";
            toolStrip1.Focus();
        }

        private void toolStripTextBoxTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tìmKiếmTheoMãNhânViênToolStripMenuItem.Checked)
                    nv.TimMaNV(toolStripTextBoxTK.Text);
                else if (tìmKiếmTheoTênPhòngBanToolStripMenuItem.Checked)
                    nv.TimTenPB(toolStripTextBoxTK.Text);
                else if (tìmTheoTênNhânViênToolStripMenuItem.Checked)
                    nv.TimTenNV(toolStripTextBoxTK.Text);
                else if (tìmTheoCMNNToolStripMenuItem.Checked)
                    nv.TimCMND(toolStripTextBoxTK.Text);
                else if (tìmTheoGiớiTínhToolStripMenuItem.Checked)
                    nv.TimGioiTinh(toolStripTextBoxTK.Text);
                else if (tìmTheoQuênQuánToolStripMenuItem.Checked)
                    nv.TimQuenQuan(toolStripTextBoxTK.Text);
                else if (tìmTheoĐiệnThoạiToolStripMenuItem.Checked)
                    nv.TimSDT(toolStripTextBoxTK.Text);
                else if (tìmTheoDânTộcToolStripMenuItem.Checked)
                    nv.TimDanToc(toolStripTextBoxTK.Text);
                else if (tìmTheoChứcVụToolStripMenuItem.Checked)
                    nv.TimChucVu(toolStripTextBoxTK.Text);
                else
                    nv.TimLuong(float.Parse(toolStripTextBoxTK.Text));
                
            }
        }

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows[1].Cells[1].ToString() = cbTenPhong.SelectedIndex.ToString();
            //    nv.loadten(dataGridView1, cbTenPhong.Text);
        }
    }
}
