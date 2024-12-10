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
    public partial class frmQLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BLLNhanVien bllnhanvien = new BLLNhanVien();
        bool _them;
        public frmQLNhanVien()
        {
            InitializeComponent();
            _them = false;
            LoadNhanVien();
            xuLyControl();
            gridDS.OptionsBehavior.Editable = false;
            gridDS.Click += GridDS_Click;
        }

        private void GridDS_Click(object sender, EventArgs e)
        {
            if (gridDS.RowCount > 0 && !_them)
            {
                _them = false;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;

                txtMaNhanVien.Text = gridDS.GetFocusedRowCellValue("MaNhanVien").ToString();
                txtTenNhanVien.Text = gridDS.GetFocusedRowCellValue("TenNhanVien").ToString();
                txtChucVu.Text = gridDS.GetFocusedRowCellValue("ChucVu").ToString();
                txtEmail.Text = gridDS.GetFocusedRowCellValue("Email").ToString();
                txtSoDienThoai.Text = gridDS.GetFocusedRowCellValue("SoDienThoai").ToString();
                txtDiaChi.Text = gridDS.GetFocusedRowCellValue("DiaChi").ToString();

                txtMatKhau.Text = "********";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtMatKhau.Enabled = false;
            txtChucVu.Enabled = false;

            txtTenNhanVien.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtTenNhanVien.Enabled = true;
            txtChucVu.Enabled = true;
            txtMatKhau.Enabled = true;
            txtEmail.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;

            
        }

        private bool KiemTraEmail(string email)
        {
            return email.Contains("@") && email.EndsWith(".com");
        }

        private bool KiemTraSDT(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
        private string SinhMatKhauNgauNhien()
        {
            Random random = new Random();
            StringBuilder matKhau = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int soNgauNhien = random.Next(0, 10);
                matKhau.Append(soNgauNhien);
            }
            return matKhau.ToString();
        }

        void LoadNhanVien()
        {
            List<NhanVien> nhanViens = bllnhanvien.GetNhanViens();
            gcDS.DataSource = nhanViens;

            gridDS.Columns["MatKhau"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaNhanVien.Text = "NV" + (bllnhanvien.GetNhanViens().Count + 1).ToString("D3");
            txtMatKhau.Text = SinhMatKhauNgauNhien();
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bllnhanvien.Xoa(txtMaNhanVien.Text);
                MessageBox.Show("Xóa thành công!");
                LoadNhanVien();
                xuLyControl();
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
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = txtMaNhanVien.Text,
                    TenNhanVien = txtTenNhanVien.Text,
                    ChucVu = txtChucVu.Text,
                    MatKhau = txtMatKhau.Text,
                    Email = txtEmail.Text,
                    SoDienThoai = txtSoDienThoai.Text,
                    DiaChi = txtDiaChi.Text
                };

                if (bllnhanvien.Them(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                }
            }
            else
            {
                if (bllnhanvien.CapNhat(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, txtEmail.Text, txtChucVu.Text, txtSoDienThoai.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!");
                }
            }

            LoadNhanVien();
            xuLyControl();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}