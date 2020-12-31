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
    public partial class TraPhong : Form
    {
        
        public TraPhong()
        {
            InitializeComponent();
        }
        XuLy.TraPhong tp = new XuLy.TraPhong();
        private void TraPhong_Load(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "MANHANPHONG";
            comboBox2.ValueMember = "MANHANPHONG";
            comboBox2.DataSource = tp.ThemMaNhanPhong();

            comboBox1.DisplayMember = "TENKHACH";
            comboBox1.ValueMember = "MAKHACH";
            comboBox1.DataSource = tp.loadKhachHang();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text=tp.LayTheoNhanPhong(comboBox2.SelectedValue.ToString());
            textBox1.Text = tp.LayTheoNhanPhong1(comboBox2.SelectedValue.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tp.LoadHoaDon1(comboBox2.SelectedValue.ToString());

            tp.SuaTinhTrang(textBox1.Text);
        }
    }
}
