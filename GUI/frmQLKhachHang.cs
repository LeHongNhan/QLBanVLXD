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
    public partial class frmQLKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BLLKhachHang bllkhachhang = new BLLKhachHang();
        bool _them;
        public frmQLKhachHang()
        {
            InitializeComponent();
            _them = false;
            LoadKhachHang();
            gridDS.OptionsBehavior.Editable = false;
            gridDS.Click += GridDS_Click;
        }

        private void GridDS_Click(object sender, EventArgs e)
        {
            if (gridDS.RowCount > 0 && !_them)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                txtMaKhachHang.Text = gridDS.GetFocusedRowCellValue("MaKhachHang").ToString();
                txtTenKhachHang.Text = gridDS.GetFocusedRowCellValue("TenKhachHang").ToString();
                txtDiaChi.Text = gridDS.GetFocusedRowCellValue("DiaChi").ToString();
                txtEmail.Text = gridDS.GetFocusedRowCellValue("Email").ToString();
                txtSoDienThoai.Text = gridDS.GetFocusedRowCellValue("SoDienThoai").ToString();

                
                txtMatKhau.Text = "********";
            }
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            xuLyControl();
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaKhachHang.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtMatKhau.Text = string.Empty;

            txtMaKhachHang.Enabled = false;
        }

        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtMatKhau.Enabled = true;
        }
        void LoadKhachHang()
        {
            List<KhachHang> khachHangs = bllkhachhang.GetKhachHangs();
            gcDS.DataSource = khachHangs;

            gridDS.Columns["MatKhau"].Visible = false;
        }
        private bool KiemTraEmail(string email)
        {
            return email.Contains("@") && email.EndsWith(".com");
        }

        private bool KiemTraSDT(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaKhachHang.Text = "KH" + (bllkhachhang.GetKhachHangs().Count + 1).ToString("D3");
            enableCacControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            enableCacControl();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bllkhachhang.Xoa(txtMaKhachHang.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadKhachHang();
                    xuLyControl();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KiemTraSDT(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng đúng số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_them)
            {
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = txtMaKhachHang.Text,
                    TenKhachHang = txtTenKhachHang.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSoDienThoai.Text,
                    MatKhau = txtMatKhau.Text
                };

                if (bllkhachhang.Them(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!");
                }
            }
            else
            {
                if (bllkhachhang.CapNhat(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại!");
                }
            }

            LoadKhachHang();
            xuLyControl();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
