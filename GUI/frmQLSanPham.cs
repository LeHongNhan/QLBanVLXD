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
    public partial class frmQLSanPham : DevExpress.XtraEditors.XtraForm
    {
        bool _them;
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLNhaCungCap bllnhacungcap = new BLLNhaCungCap();
        public frmQLSanPham()
        {
            InitializeComponent();
            _them = false;
            xuLyControl();
            loadSP();
            loadNCC();
            gridDS.OptionsBehavior.Editable = false;
            
        }
        void loadSP()
        {
            gcDS.DataSource = bllSanPham.GetSanPhams();
        }
        void loadNCC()
        {
            cboNhaCungCap.DataSource = bllnhacungcap.GetNhaCungCaps();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "MaNhaCungCap";
        }
        string MaSPTuDong()
        {
            int soTT = bllSanPham.GetSanPhams().Count + 1;
            return "SP" + soTT.ToString("D3");
        }
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtTenSP.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuongTon.Enabled = true;
            txtMoTa.Enabled = true;
            cboNhaCungCap.Enabled = true;
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
            txtSoLuongTon.Enabled = false;
            txtMoTa.Enabled = false;
            cboNhaCungCap.Enabled = false;
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
            txtMaSP.Text = MaSPTuDong();
            txtTenSP.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtSoLuongTon.Text = string.Empty;
            cboNhaCungCap.SelectedIndex = -1;
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
                txtMaSP.Text = gridDS.GetFocusedRowCellValue("MaSanPham").ToString();
                txtTenSP.Text = gridDS.GetFocusedRowCellValue("TenSanPham").ToString();
                txtMoTa.Text = gridDS.GetFocusedRowCellValue("MoTa").ToString();
                txtSoLuongTon.Text = gridDS.GetFocusedRowCellValue("SoLuongTon").ToString();
                txtDonGia.Text = gridDS.GetFocusedRowCellValue("DonGia").ToString();
                cboNhaCungCap.SelectedValue = gridDS.GetFocusedRowCellValue("MaNhaCungCap").ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                SanPham sp = new SanPham();
                sp.MaSanPham = txtMaSP.Text;
                sp.TenSanPham= txtTenSP.Text;
                sp.MoTa = txtMoTa.Text;
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString();
                sp.SoLuongTon = int.Parse(txtSoLuongTon.Text);
                bllSanPham.Them(sp);
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else
            {
                //SanPham sp = bllSanPham.TimKiemSPTheoMa(txtMaSP.Text);
                //sp.TenSanPham = txtTenSP.Text;
                //sp.MoTa = txtMoTa.Text;
                //sp.DonGia = int.Parse(txtDonGia.Text);
                //sp.MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString();
                //sp.SoLuongTon = int.Parse(txtSoLuongTon.Text);
                //bllSanPham.CapNhat(sp);
                int gia = int.Parse(txtDonGia.Text);
                int soLuongTon = int.Parse(txtSoLuongTon.Text);
                bllSanPham.CapNhat(txtMaSP.Text, txtTenSP.Text, gia, soLuongTon, txtMoTa.Text, cboNhaCungCap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công!");
            }
            xuLyControl();
            loadSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa sản phẩm "+ txtTenSP.Text+"?","Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            { 
                bllSanPham.Xoa(txtMaSP.Text);
                loadSP();
                xuLyControl();
            }
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}