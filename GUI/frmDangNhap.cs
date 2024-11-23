using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BLLNhanVien bllNhanVien;
        public static NhanVien nvLogin = null;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            bllNhanVien = new BLLNhanVien();
            NhanVien nvLogin = new NhanVien();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != string.Empty && txtMatKhau.Text != string.Empty)
            {
                nvLogin = bllNhanVien.checkDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if (nvLogin == null)
                {
                    MessageBox.Show("Check lại tên đăng nhập, mật khẩu");
                }
                else
                {
                    this.Hide();
                    Program.mainForm.Show();
                }

            }
        }
    }
}
