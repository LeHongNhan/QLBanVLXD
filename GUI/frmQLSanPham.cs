using DevExpress.XtraEditors;
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
    public partial class frmQLSanPham : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        public frmQLSanPham()
        {
            InitializeComponent();
            _them = false;
            xuLyControl();
        }
        void MaSPTuDong()
        {
            //int soTT = spBLL.layDSSPBLL().Count + 1;
            //string maSPMoi = "SP" + soTT.ToString("D3");
            //txtMaSP.Text = maSPMoi;

        }
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenSP.Enabled = true;
            txtDonGia.Enabled = true;
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaSP.Enabled = false;
            txtDonGia.Enabled = false;
            txtTenSP.Enabled = false;
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            enableCacControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtTenSP.Text = string.Empty;
            txtDonGia.Text = string.Empty;

            MaSPTuDong();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            enableCacControl();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridDS_Click(object sender, EventArgs e)
        {
            if (gridDS.RowCount > 0 && !_them)
            {
                _them = false;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}