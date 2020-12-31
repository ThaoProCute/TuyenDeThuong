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
    public partial class NguoiDung : Form
    {
        XuLy.NguoiDung nd = new XuLy.NguoiDung();
        public NguoiDung()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (nd.DangNhap(textBox1.Text, textBox2.Text, comboBox1.Text))
            {
                MessageBox.Show("Dang Nhap thanh Cong");
            }
            else
            {
                MessageBox.Show("Dang Nhap that bai");
            }
        }

        
    }
}
