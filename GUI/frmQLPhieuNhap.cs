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

        public frmQLPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmQLPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhapList();
        }

        private void LoadPhieuNhapList()
        {
            gcPhieuNhap.DataSource = bllPhieuNhap.GetPhieuNhapList();
        }

        private void LoadChiTietPhieuNhapList(string maPhieuNhap)
        {
            gcChiTietPhieuNhap.DataSource = bllChiTietPhieuNhap.GetChiTietPhieuNhapList(maPhieuNhap);
        }

        private void gvPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedPhieuNhap = gvPhieuNhap.GetFocusedRow() as PhieuNhap;
            if (selectedPhieuNhap != null)
            {
                txtMaPhieuNhap.Text = selectedPhieuNhap.MaPhieuNhap;
                dtpNgayNhap.EditValue = selectedPhieuNhap.NgayNhap;
                cboNhaCungCap.EditValue = selectedPhieuNhap.MaNhaCungCap;
                txtNhanVienNhap.Text = selectedPhieuNhap.MaNhanVien;
                txtTongTien.Text = selectedPhieuNhap.TongTien.ToString();

                LoadChiTietPhieuNhapList(selectedPhieuNhap.MaPhieuNhap);
            }
        }

        private void UpdateTonKho(string maSanPham, int soLuong, bool isAdding)
        {
            if (isAdding)
            {
                bllChiTietPhieuNhap.IncreaseTonKho(maSanPham, soLuong);
            }
            else
            {
                bllChiTietPhieuNhap.DecreaseTonKho(maSanPham, soLuong);
            }
        }

        private void UpdateTongTien()
        {
            if (gcChiTietPhieuNhap.DataSource is List<ChiTietPhieuNhap> chiTietList)
            {
                txtTongTien.Text = chiTietList.Sum(ct => ct.SoLuong * ct.DonGia).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtMaPhieuNhap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var phieuNhap = new PhieuNhap
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayNhap = (DateTime)dtpNgayNhap.EditValue,
                    MaNhaCungCap = cboNhaCungCap.EditValue.ToString(),
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var phieuNhap = new PhieuNhap
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayNhap = (DateTime)dtpNgayNhap.EditValue,
                    MaNhaCungCap = cboNhaCungCap.EditValue.ToString(),
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            var chiTiet = new ChiTietPhieuNhap
            {
                MaPhieuNhap = txtMaPhieuNhap.Text,
                MaSanPham = cboSanPham.EditValue.ToString(),
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = int.Parse(txtDonGia.Text)
            };

            if (bllChiTietPhieuNhap.AddChiTietPhieuNhap(chiTiet))
            {
                UpdateTonKho(chiTiet.MaSanPham, chiTiet.SoLuong ?? 0, true);
                LoadChiTietPhieuNhapList(chiTiet.MaPhieuNhap);
                UpdateTongTien();
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công.");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại.");
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            var selectedChiTiet = gvChiTietPhieuNhap.GetFocusedRow() as ChiTietPhieuNhap;
            if (selectedChiTiet != null)
            {
                var soLuongCu = selectedChiTiet.SoLuong ?? 0;

                selectedChiTiet.SoLuong = int.Parse(txtSoLuong.Text);
                selectedChiTiet.DonGia = int.Parse(txtDonGia.Text);

                if (bllChiTietPhieuNhap.UpdateChiTietPhieuNhap(selectedChiTiet))
                {
                    UpdateTonKho(selectedChiTiet.MaSanPham, selectedChiTiet.SoLuong ?? 0 - soLuongCu, true);
                    LoadChiTietPhieuNhapList(selectedChiTiet.MaPhieuNhap);
                    UpdateTongTien();
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu nhập thất bại.");
                }
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            var selectedChiTiet = gvChiTietPhieuNhap.GetFocusedRow() as ChiTietPhieuNhap;
            if (selectedChiTiet != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bllChiTietPhieuNhap.DeleteChiTietPhieuNhap(selectedChiTiet.MaPhieuNhap, selectedChiTiet.MaSanPham))
                    {
                        UpdateTonKho(selectedChiTiet.MaSanPham, selectedChiTiet.SoLuong ?? 0, false);
                        LoadChiTietPhieuNhapList(selectedChiTiet.MaPhieuNhap);
                        UpdateTongTien();
                        MessageBox.Show("Xóa chi tiết phiếu nhập thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết phiếu nhập thất bại.");
                    }
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuNhap.Text) ||
                dtpNgayNhap.EditValue == null ||
                cboNhaCungCap.EditValue == null ||
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
            cboNhaCungCap.EditValue = null;
            txtNhanVienNhap.Text = "";
            txtTongTien.Text = "0";
        }
    }
}
