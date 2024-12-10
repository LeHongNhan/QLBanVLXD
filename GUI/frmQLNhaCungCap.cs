using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmQLNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        BLLNhaCungCap bllNCC = new BLLNhaCungCap();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
            _them = false;
            loadInfoNCC();
            xuLyControl();
            gridDS.OptionsBehavior.Editable = false;
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
            txtDonViTinh.Enabled = true;
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
            txtTenNCC.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSPCungCap.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
        }
        string MaNCCtudong()
        {
            int soTT = bllNCC.GetNhaCungCaps().Count + 1;
            return "NCC" + soTT.ToString("D3");
        }
        private void frmQLNhaCungCap_Load(object sender, EventArgs e)
        {

        }
        void loadInfoNCC()
        {
            List<NhaCungCap> lstNhaCungCap = bllNCC.GetNhaCungCaps();
            gcDS.DataSource = lstNhaCungCap;
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
                btnHuy.Enabled = true;
                txtMaNCC.Text = gridDS.GetFocusedRowCellValue("MaNhaCungCap").ToString();
                txtTenNCC.Text = gridDS.GetFocusedRowCellValue("TenNhaCungCap").ToString();
                txtSPCungCap.Text = gridDS.GetFocusedRowCellValue("LoaiSanPhamCungCap").ToString();
                txtEmail.Text = gridDS.GetFocusedRowCellValue("Email").ToString();
                txtSoDienThoai.Text = gridDS.GetFocusedRowCellValue("SoDienThoai").ToString();
                txtDiaChi.Text = gridDS.GetFocusedRowCellValue("DiaChi").ToString();
                txtDonViTinh.Text = gridDS.GetFocusedRowCellValue("DonViTinhSanPhamCungCap").ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaNCC.Text = MaNCCtudong();
            txtTenNCC.Text= string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text= string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtSPCungCap.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            MaNCCtudong();
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
            if (MessageBox.Show("Xóa nhà cung cấp " + txtMaNCC.Text + "?", "Xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                bllNCC.Xoa(txtMaNCC.Text);
                loadInfoNCC();
                xuLyControl();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();
        }

        private void gcDS_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = txtMaNCC.Text;
                ncc.TenNhaCungCap = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.Email = txtEmail.Text;
                ncc.SoDienThoai = txtSoDienThoai.Text;
                ncc.LoaiSanPhamCungCap = txtSPCungCap.Text;
                ncc.DonViTinhSanPhamCungCap = txtDonViTinh.Text;
                bllNCC.Them(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công!");
            }
            else
            {
                
                bllNCC.CapNhat(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, txtSPCungCap.Text, txtDonViTinh.Text);
                MessageBox.Show("Cập nhật thành công!");
            }
            xuLyControl();
            loadInfoNCC();
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}