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
    public partial class frmQLNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmQLNhaCungCap()
        {
            InitializeComponent();
            _them = false;
        }
        bool _them;
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenNCC.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSPCungCap.Enabled = true;
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSPCungCap.Text = string.Empty;
        }
        private void frmQLNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtTenNCC.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text= string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtSPCungCap.Text = string.Empty;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            enableCacControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            enableCacControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();
        }
    }
}