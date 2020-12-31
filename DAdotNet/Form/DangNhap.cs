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
    public partial class DangNhap : Form
    {

        XuLy.DangNhap xl = new XuLy.DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }
        

        public string kt(RadioButton Us, RadioButton Admin)
        {
            string kq;
            if (Us.Checked)
            {
                kq = "User";
            }
            else
                kq = "Admin";
            return kq;
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            if (xl.LoadCTHoaDon1(txtTK.Text,txtMK.Text,kt(radu,radA))== 1)
            {
                MessageBox.Show("Dang nhap thanh cong");
                QuanLiKhachSan qd = new QuanLiKhachSan();
                this.Hide();
                qd.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }
    }
}
