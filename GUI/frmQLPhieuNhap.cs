using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmQLPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private BLLPhieuNhap bllPhieuNhap = new BLLPhieuNhap();
        private BLLChiTietPhieuNhap bllChiTietPhieuNhap = new BLLChiTietPhieuNhap();
        private string currentNhanVien; 

        public frmQLPhieuNhap()
        {
            InitializeComponent();
            LoadPhieuNhapList();
            LoadNhaCungCapList();
            LoadSanPhamList();
            cboSanPham.SelectedIndexChanged += CboSanPham_SelectedIndexChanged;
            dtpNgayNhap.EditValueChanged += DtpNgayNhap_EditValueChanged;
            SetNhanVienNhap();
        }

        private void DtpNgayNhap_EditValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate;
            if (DateTime.TryParse(dtpNgayNhap.EditValue.ToString(), out selectedDate))
            {
                MessageBox.Show($"Ngày nhập đã chọn: {selectedDate.ToString("dd-MM-yyyy")}");
            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ!");
            }
        }


        private void SetNhanVienNhap()
        {
            txtNhanVienNhap.Text = currentNhanVien; // Gán tên hoặc mã nhân viên
            txtNhanVienNhap.ReadOnly = true; // Không cho phép chỉnh sửa
        }

        private void CboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                var maSanPham = cboSanPham.SelectedValue.ToString();
                var sanPham = new BLLSanPham().GetSanPhamById(maSanPham);
                if (sanPham != null)
                {
                    txtDonGia.Text = sanPham.DonGia.ToString(); // Hiển thị đơn giá
                }
            };
        }

        // Load danh sách Nhà Cung Cấp
        private void LoadNhaCungCapList()
        {
            try
            {
                var nhaCungCapList = new BLLNhaCungCap().GetNhaCungCaps();
                cboNhaCungCap.DataSource = nhaCungCapList;
                cboNhaCungCap.DisplayMember = "TenNhaCungCap"; // Tên hiển thị
                cboNhaCungCap.ValueMember = "MaNhaCungCap";   // Giá trị thực
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Nhà Cung Cấp: {ex.Message}");
            }
        }
        private void LoadSanPhamList()
        {
            try
            {
                var sanPhamList = new BLLSanPham().GetSanPhams();
                cboSanPham.DataSource = sanPhamList;
                cboSanPham.DisplayMember = "TenSanPham"; // Tên hiển thị
                cboSanPham.ValueMember = "MaSanPham";   // Giá trị thực
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Sản Phẩm: {ex.Message}");
            }
        } 
            // Load danh sách Phiếu Nhập lên GridControl
         private void LoadPhieuNhapList()
        {
            try
            {
                var phieuNhapList = bllPhieuNhap.GetPhieuNhapList();
                gcPhieuNhap.DataSource = phieuNhapList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Phiếu Nhập: {ex.Message}");
            }
        }

        // Load Chi Tiết Phiếu Nhập
        private void LoadChiTietPhieuNhapList(string maPhieuNhap)
        {
            try
            {
                var chiTietList = bllChiTietPhieuNhap.GetChiTietPhieuNhapList(maPhieuNhap);
                gcChiTietPhieuNhap.DataSource = chiTietList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Chi Tiết Phiếu Nhập: {ex.Message}");
            }
        }

        // Xử lý sự kiện RowClick của gcPhieuNhap
        private void gvPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var selectedPhieuNhap = gvPhieuNhap.GetFocusedRow() as PhieuNhap;
                if (selectedPhieuNhap != null)
                {
                    txtMaPhieuNhap.Text = selectedPhieuNhap.MaPhieuNhap;
                    dtpNgayNhap.EditValue = selectedPhieuNhap.NgayNhap;
                    cboNhaCungCap.SelectedValue = selectedPhieuNhap.MaNhaCungCap;
                    txtNhanVienNhap.Text = selectedPhieuNhap.MaNhanVien;
                    txtTongTien.Text = selectedPhieuNhap.TongTien.ToString();

                    LoadChiTietPhieuNhapList(selectedPhieuNhap.MaPhieuNhap);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý chọn Phiếu Nhập: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuNhap.Text) ||
                dtpNgayNhap.EditValue == null ||
                cboNhaCungCap.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtNhanVienNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }
            return true;
        }

        private void ClearInput()
        {
            txtMaPhieuNhap.Text = "";
            dtpNgayNhap.EditValue = null;
            cboNhaCungCap.SelectedIndex = -1;
            txtNhanVienNhap.Text = "";
            txtTongTien.Text = "0";
        }

        // Hàm tạo mã phiếu nhập tự động
        private string GenerateMaPhieuNhap()
        {
            var now = DateTime.Now;
            return $"PN{now:yyyyMMddHHmmss}";
        }

        // Load form, gán mã tự động khi nhấn "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtMaPhieuNhap.Text = GenerateMaPhieuNhap(); // Tự động gán mã
            txtMaPhieuNhap.ReadOnly = true; // Không cho phép chỉnh sửa
            txtMaPhieuNhap.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var phieuNhap = new PhieuNhap
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayNhap = (DateTime)dtpNgayNhap.EditValue,
                    MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString(),
                    MaNhanVien = txtNhanVienNhap.Text,
                    TongTien = int.Parse(txtTongTien.Text)
                };

                if (bllPhieuNhap.AddPhieuNhap(phieuNhap))
                {
                    MessageBox.Show("Thêm phiếu nhập thành công.");
                    LoadPhieuNhapList();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập thất bại.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var phieuNhap = new PhieuNhap
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayNhap = (DateTime)dtpNgayNhap.EditValue,
                    MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString(),
                    MaNhanVien = txtNhanVienNhap.Text,
                    TongTien = int.Parse(txtTongTien.Text)
                };

                if (bllPhieuNhap.UpdatePhieuNhap(phieuNhap))
                {
                    MessageBox.Show("Cập nhật phiếu nhập thành công.");
                    LoadPhieuNhapList();
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu nhập thất bại.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maPhieuNhap = txtMaPhieuNhap.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bllPhieuNhap.DeletePhieuNhap(maPhieuNhap))
                {
                    MessageBox.Show("Xóa phiếu nhập thành công.");
                    LoadPhieuNhapList();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại.");
                }
            }
        }
    }
}
