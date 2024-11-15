using BLL;
using DevExpress.XtraEditors;
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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void tabDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void tabChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainerControl1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTheoDoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSonguoi_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            bllDonHang = new BLLDonHang();
            loadDSDonHang();
        }
        BLLDonHang bllDonHang;
        void loadDSDonHang()
        {
            List<dynamic>  donHangList = bllDonHang.loadDonHangGC();
            gcDanhSach.DataSource = donHangList;
        }
        bool _them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            enableCacControl();
            btnIn.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            tabDanhSach.SelectedTabPage = pageChiTiet;
        }
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboKhachHang.Enabled = true;
            cboTrangThai.Enabled = true;
            dtpNgayLap.Enabled = true;
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboKhachHang.Enabled = false;
            cboTrangThai.Enabled = false;
            dtpNgayLap.Enabled = false;
            btnThemMoi.Text = string.Empty;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();
        }
    }
}