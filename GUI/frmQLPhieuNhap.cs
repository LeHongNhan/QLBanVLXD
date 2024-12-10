using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmQLPhieuNhap : XtraForm
    {
        private BLLPhieuNhap bllPhieuNhap = new BLLPhieuNhap();
        private BLLChiTietPhieuNhap bllChiTietPhieuNhap = new BLLChiTietPhieuNhap();
        private List<DTOChiTietPhieuNhap> chiTietPhieuNhapList = new List<DTOChiTietPhieuNhap>();
        private BLLSanPham bllSanPham = new BLLSanPham();
        private string currentNhanVien = "NV003"; // Mã nhân viên đăng nhập
        private string selectedMaPhieuNhap; 
        private string selectedMaSanPham;

        public frmQLPhieuNhap()
        {
            InitializeComponent();
            LoadPhieuNhapList();
            LoadNhaCungCapList();
            LoadSanPhamList();
            cboSanPham.SelectedIndexChanged += CboSanPham_SelectedIndexChanged;
            btnThem.Click += btnThem_Click;
            btnThemSanPham.Click += BtnThemSanPham_Click;
            btnXoaSanPham.Click += BtnXoaSanPham_Click;
            gvPhieuNhap.RowClick += GvPhieuNhap_RowClick;
            gvChiTietPhieuNhap.RowClick += GvChiTietPhieuNhap_RowClick;
        }

        private void BtnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaSanPham))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi chi tiết phiếu nhập?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var selectedChiTiet = chiTietPhieuNhapList.FirstOrDefault(ct => ct.MaSanPham == selectedMaSanPham);
                if (selectedChiTiet != null)
                {
                    // Xóa sản phẩm khỏi danh sách
                    chiTietPhieuNhapList.Remove(selectedChiTiet);

                    // Giảm tồn kho sản phẩm
                    if (!bllChiTietPhieuNhap.DecreaseTonKho(selectedChiTiet.MaSanPham, selectedChiTiet.SoLuong))
                    {
                        MessageBox.Show("Cập nhật tồn kho thất bại!");
                    }

                    // Cập nhật lại DataSource
                    gcChiTietPhieuNhap.DataSource = null;
                    gcChiTietPhieuNhap.DataSource = chiTietPhieuNhapList;

                    // Tính lại tổng tiền
                    TinhTongTien();

                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần xóa!");
                }
            }
        }

        private void GvChiTietPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var selectedRow = gvChiTietPhieuNhap.GetFocusedRow() as DTOChiTietPhieuNhap;
                if (selectedRow != null)
                {
                    selectedMaSanPham = selectedRow.MaSanPham; // Lưu mã sản phẩm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn chi tiết phiếu nhập: {ex.Message}");
            }
        }

        private void GvPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var selectedRow = gvPhieuNhap.GetFocusedRow() as PhieuNhap;
                if (selectedRow != null)
                {
                    selectedMaPhieuNhap = selectedRow.MaPhieuNhap;
                    txtMaPhieuNhap.Text = selectedRow.MaPhieuNhap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn phiếu nhập: {ex.Message}");
            }
        }

        private void BtnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            var maSanPham = cboSanPham.SelectedValue.ToString();
            var soLuong = int.Parse(txtSoLuong.Text);
            var donGia = int.Parse(txtDonGia.Text);

            var chiTiet = new DTOChiTietPhieuNhap
            {
                MaSanPham = maSanPham,
                SoLuong = soLuong,
                DonGia = donGia
            };

            chiTietPhieuNhapList.Add(chiTiet);

            // Cập nhật danh sách chi tiết phiếu nhập
            gcChiTietPhieuNhap.DataSource = null;
            gcChiTietPhieuNhap.DataSource = chiTietPhieuNhapList;

            // Tính lại tổng tiền
            TinhTongTien();
        }

        // Hàm tải danh sách phiếu nhập
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

        // Hàm tải danh sách nhà cung cấp
        private void LoadNhaCungCapList()
        {
            try
            {
                var nhaCungCapList = new BLLNhaCungCap().GetNhaCungCaps();
                cboNhaCungCap.DataSource = nhaCungCapList;
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Nhà Cung Cấp: {ex.Message}");
            }
        }

        // Hàm tải danh sách sản phẩm
        private void LoadSanPhamList()
        {
            try
            {
                var sanPhamList = bllSanPham.GetSanPhams();
                cboSanPham.DataSource = sanPhamList;
                cboSanPham.DisplayMember = "TenSanPham";
                cboSanPham.ValueMember = "MaSanPham";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Sản Phẩm: {ex.Message}");
            }
        }

        // Sự kiện thay đổi sản phẩm
        private void CboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                var maSanPham = cboSanPham.SelectedValue.ToString();
                var sanPham = bllSanPham.GetSanPhamById(maSanPham);
                if (sanPham != null)
                {
                    txtDonGia.Text = sanPham.DonGia.ToString();
                }
            }
        }

 

        // Hàm tính tổng tiền
        private void TinhTongTien()
        {
            txtTongTien.Text = chiTietPhieuNhapList.Sum(ct => ct.ThanhTien).ToString("N0");
        }

        // Hàm tạo mã phiếu nhập tự động
        private string GenerateMaPhieuNhap()
        {
            var now = DateTime.Now;
            return $"PN{now:yyyyMMddHHmmss}";
        }

        // Sự kiện khi nhấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtMaPhieuNhap.Text = GenerateMaPhieuNhap(); // Tự động gán mã
            txtMaPhieuNhap.ReadOnly = true; // Không cho phép chỉnh sửa
        }

        // Sự kiện khi nhấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuNhap.Text) || cboNhaCungCap.SelectedValue == null || chiTietPhieuNhapList.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và thêm ít nhất một sản phẩm!");
                return;
            }

            var phieuNhap = new PhieuNhap
            {
                MaPhieuNhap = txtMaPhieuNhap.Text,
                NgayNhap = (DateTime)dtpNgayNhap.EditValue,
                MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString(),
                MaNhanVien = currentNhanVien,
                TongTien = chiTietPhieuNhapList.Sum(ct => ct.ThanhTien)
            };

            if (bllPhieuNhap.AddPhieuNhap(phieuNhap))
            {
                foreach (var chiTiet in chiTietPhieuNhapList)
                {
                    chiTiet.MaPhieuNhap = phieuNhap.MaPhieuNhap;
                    var chiTietPhieuNhap = new ChiTietPhieuNhap
                    {
                        MaPhieuNhap = chiTiet.MaPhieuNhap,
                        MaSanPham = chiTiet.MaSanPham,
                        SoLuong = chiTiet.SoLuong,
                        DonGia = chiTiet.DonGia
                    };
                    bllChiTietPhieuNhap.AddChiTietPhieuNhap(chiTietPhieuNhap);
                    
                    if(!bllChiTietPhieuNhap.IncreaseTonKho(chiTiet.MaSanPham, chiTiet.SoLuong))
                    {
                        MessageBox.Show("Cập nhật số lượng tồn kho thất bại!");
                    }
                }

                MessageBox.Show("Lưu phiếu nhập thành công!");
                ClearInput();
                chiTietPhieuNhapList.Clear();
                gcChiTietPhieuNhap.DataSource = null;
                LoadPhieuNhapList();
            }
            else
            {
                MessageBox.Show("Lưu phiếu nhập thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Chưa cần thực hiện chỉnh sửa chi tiết logic
            MessageBox.Show("Chức năng Sửa chưa được triển khai!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedMaPhieuNhap))
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này cùng các chi tiết liên quan?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Giảm tồn kho trước khi xóa chi tiết phiếu nhập
                if (bllChiTietPhieuNhap.DecreaseTonKhoForDeletedChiTiet(selectedMaPhieuNhap))
                {
                    // Xóa chi tiết phiếu nhập
                    if (bllChiTietPhieuNhap.DeleteAllChiTietPhieuNhap(selectedMaPhieuNhap))
                    {
                        // Xóa phiếu nhập
                        if (bllPhieuNhap.DeletePhieuNhap(selectedMaPhieuNhap))
                        {
                            MessageBox.Show("Xóa phiếu nhập thành công!");
                            ClearInput();
                            LoadPhieuNhapList();
                            gcChiTietPhieuNhap.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu nhập thất bại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết phiếu nhập thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật tồn kho thất bại!");
                }
            }
        }




        // Hàm xóa các trường thông tin
        private void ClearInput()
        {
            txtMaPhieuNhap.Text = "";
            dtpNgayNhap.EditValue = null;
            cboNhaCungCap.SelectedIndex = -1;
            txtNhanVienNhap.Text = currentNhanVien;
            txtTongTien.Text = "0";
            chiTietPhieuNhapList.Clear();
            gcChiTietPhieuNhap.DataSource = null;
        }

    }
}
