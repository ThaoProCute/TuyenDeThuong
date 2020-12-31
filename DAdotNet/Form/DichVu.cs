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
    public partial class 
        DichVu : Form
    {
        XuLy.DichVu dv = new XuLy.DichVu();
        public DichVu()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dv.Them(txtMDV.Text, cbMLDV.SelectedValue.ToString(), txtDonVi.Text,float.Parse(numericUpDown1.Value.ToString())))
            {
                MessageBox.Show("Them Thanh Cong");
            }
            else
                MessageBox.Show(" Them Khong Thanh Cong");
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            cbMLDV.DataSource = dv.loadLoaiDV();
            cbMLDV.DisplayMember = "TENLOAIDV";
            cbMLDV.ValueMember = "MALOAIDV";
            dataGridView1.DataSource = dv.loaDichVu();
            //dataGridView1.DataSource = dv.loaTEN();
        }

        private void toolStripButtonSua_Click(object sender, EventArgs e)
        {
            if (dv.Sua(txtMDV.Text, cbMLDV.SelectedValue.ToString(), txtDonVi.Text, float.Parse(numericUpDown1.Value.ToString())))
            {
                MessageBox.Show("Sua Thanh Cong");
            }
            else
                MessageBox.Show(" Sua Khong Thanh Cong");
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (dv.Xoa(txtMDV.Text))
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
            else
                MessageBox.Show(" Xoa Khong Thanh Cong");
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
            if (dv.LuuDTB())
            {
                MessageBox.Show("Lưu Thành Công");
            }
            else
                MessageBox.Show("Lưu Thất Bại");
        }

        private void toolStripButtonLamMoi_Click(object sender, EventArgs e)
        {
            txtMDV.Text="";
            cbMLDV.Text = "";
            txtDonVi.Text ="" ;
            numericUpDown1.Value= 0;
            dataGridView1.DataSource = dv.loaDichVu();
        }

        private void tìmTheoMãDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãDịchVụToolStripMenuItem.Checked = true;
            tìmTheoTênDịchVụToolStripMenuItem.Checked = false;
            tìmTheoĐơnVịToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ma Dich Vu";
            toolStrip1.Focus();
        }

        private void tìmTheoTênDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãDịchVụToolStripMenuItem.Checked = false;
            tìmTheoTênDịchVụToolStripMenuItem.Checked = true;
            tìmTheoĐơnVịToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Ten Loai Dich Vu";
            toolStrip1.Focus();
        }

        private void tìmTheoĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãDịchVụToolStripMenuItem.Checked = false;
            tìmTheoTênDịchVụToolStripMenuItem.Checked = false;
            tìmTheoĐơnVịToolStripMenuItem.Checked = true;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = false;
            toolStripTextBoxTK.Text = "Tim theo Don Vi";
            toolStrip1.Focus();
        }

        private void tìmTheoĐơnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tìmTheoMãDịchVụToolStripMenuItem.Checked = false;
            tìmTheoTênDịchVụToolStripMenuItem.Checked = false;
            tìmTheoĐơnVịToolStripMenuItem.Checked = false;
            tìmTheoĐơnGiáToolStripMenuItem.Checked = true;
            toolStripTextBoxTK.Text = "Tim theo don gia";
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
                if (tìmTheoMãDịchVụToolStripMenuItem.Checked)
                    dv.TimMadv(toolStripTextBoxTK.Text);
                else if (tìmTheoTênDịchVụToolStripMenuItem.Checked)
                    dv.TimMLDV(toolStripTextBoxTK.Text);
                else if (tìmTheoĐơnVịToolStripMenuItem.Checked)
                    dv.TimDONVI(toolStripTextBoxTK.Text);
                else
                    dv.TimDonGia(float.Parse(toolStripTextBoxTK.Text));
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                //txtMDV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txtDonVi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //cbMLDV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != null)
                //{
                //    decimal a = decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                //    numericUpDown1.Value = a;
                //}
                //else
                //{
                //    numericUpDown1.Value = 0;
                //}
            }
        }



    }
}
