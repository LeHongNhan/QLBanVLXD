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
            
        }

        private void loginControl1_SubmitClicked(object sender, EventArgs args)
        {
            //Program.mainForm.NV = nvLogin.MaNhanVien;
            this.Hide();
            Program.mainForm.Show();
            Program.mainForm.FormClosed += (a, s) => this.Close();
            
            //nvLogin = bllNhanVien.checkDangNhap(loginControl1.getUsername(), loginControl1.getPassword());
            
            //if (nvLogin == null)
            //{
            //    MessageBox.Show("Check lại tên đăng nhập, mật khẩu");
            //}
            //else
            //{
            //    Program.mainForm.NV = nvLogin.MaNhanVien;
            //    this.Hide();
            //    Program.mainForm.Show();
            //    Program.mainForm.FormClosed += (a, s) => this.Close();
            //}
        }
    }
}
