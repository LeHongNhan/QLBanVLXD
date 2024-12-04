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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;

namespace GUI
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public string NV { get; set; }
        BLLHoaDon bllHoaDon = new BLLHoaDon();
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLKhachHang bllKhachHang = new BLLKhachHang();

        private string selectedSP;
        private object draggedValue;

        public frmHoaDon()
        {
            InitializeComponent();
            LoadHD();
            LoadSP();
            LoadKH();
            xuLyControl();

            gcSanPham.AllowDrop = false;
            gcSanPhamHD.AllowDrop = false;

            gridDS.OptionsSelection.MultiSelect = false;
            gvSanPham.OptionsBehavior.Editable = false;
            gvSanPham.OptionsSelection.MultiSelect = true;

        }

        public int GetTotalThanhTien(List<DTOChiTietDonHang> source)
        {
            int total = 0;

            foreach (var item in source)
            {
                total += (int)item.DonGia * item.SoLuong;
            }

            return total;
        }

        public void LoadKH()
        {
            cboKhachHang.DataSource = bllKhachHang.GetKhachHangs();
            cboKhachHang.DisplayMember = "SoDienThoai";
            cboKhachHang.ValueMember = "MaKhachHang";
        }

        public void LoadHD()
        {
            List<DonHang> source = bllHoaDon.GetDonHangs();
            gcDanhSach.DataSource = source;
        }

        public void LoadSP()
        {
            List<SanPham> source = bllSanPham.GetSanPhams();
            gcSanPham.DataSource = source;
        }

        public void LoadCTSP(string MaHD)
        {
            List<DTOChiTietDonHang> source = bllHoaDon.GetChiTietDonHangs(MaHD);
            gcSanPhamHD.DataSource = source;

            DonHang donhang = bllHoaDon.GetDonHang(MaHD);

            string MaKH = donhang.MaKhachHang;

            cboKhachHang.SelectedValue = MaKH;

            dtpNgayLap.Value = (DateTime)donhang.NgayLap;

            label8.Text = "THÀNH TIỀN: " + GetTotalThanhTien(source).ToString();
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
            List<dynamic> donHangList = bllDonHang.loadDonHangGC();
            gcDanhSach.DataSource = donHangList;
        }
        bool _them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            enableCacControl();
            btnIn.Enabled = true;
            btnXoa.Enabled = true;

            gcSanPham.AllowDrop = true;
            gcSanPhamHD.AllowDrop = true;
            gvSanPham.GridControl.DoDragDrop(gvSanPham.GetFocusedRow(), DragDropEffects.Copy);

            tabDanhSach.SelectedTabPage = pageChiTiet;
            gcSanPhamHD.DataSource = null;
            dtpNgayLap.Value = dtpNgayLap.Value = DateTime.Now;
            label8.Text = "THÀNH TIỀN";
        }
        void enableCacControl()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboKhachHang.Enabled = true;
            dtpNgayLap.Enabled = true;
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormClosed += (s, a) => LoadKH();
            f.ShowDialog();
        }
        void xuLyControl()
        {
            _them = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboKhachHang.Enabled = false;
            dtpNgayLap.Enabled = false;
            gcSanPhamHD.Enabled = false;
            gcSanPhamHD.DataSource = null;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyControl();

            gcSanPham.AllowDrop = false;
            gcSanPhamHD.AllowDrop = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gridDS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                object value = view.GetRowCellValue(e.RowHandle, view.Columns[0]);
                if (value != null)
                {
                    gcSanPhamHD.Enabled = true;
                    LoadCTSP(value.ToString());
                    tabDanhSach.SelectedTabPage = pageChiTiet;
                }
            }
        }

        private void gridDS_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && e.RowHandle >= 0)
            {
                object value = view.GetRowCellValue(e.RowHandle, view.Columns[0]);
                if (value != null)
                {
                    gcSanPhamHD.Enabled = true;
                    LoadCTSP(value.ToString());
                    tabDanhSach.SelectedTabPage = pageChiTiet;
                }
            }
        }

        private void groupControl1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void gvSanPham_MouseDown(object sender, MouseEventArgs e)
        {
            var hitInfo = gvSanPham.CalcHitInfo(e.Location);
            if (hitInfo.InRow)
            {
                int rowHandle = hitInfo.RowHandle;
                draggedValue = gvSanPham.GetRowCellValue(rowHandle, gvSanPham.Columns[0]);

                gvSanPham.GridControl.DoDragDrop(draggedValue, DragDropEffects.Copy);
            }
        }

        private void gridView2_GridControl_DragDrop(object sender, DragEventArgs e)
        {

        }


        private void groupControl4_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void gcSanPhamHD_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(string)) || e.Data.GetDataPresent(typeof(object)))
            {
                string droppedValue = e.Data.GetData(typeof(string)).ToString();


                addSP(droppedValue);
            }
        }

        private void addSP(string id)
        {
            SanPham sp = bllSanPham.TimKiemSPTheoMa(id);

            if (sp == null)
            {
                MessageBox.Show("Không tìm được sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newMHD = bllHoaDon.GetNextMDH();

            DTOChiTietDonHang addedValue = new DTOChiTietDonHang()
            {
                MaDonHang = newMHD,
                MaSanPham=id,
                TenSanPham = sp.TenSanPham,
                DonGia = (decimal)sp.DonGia,
                SoLuong = 0,
            };

            MessageBox.Show(sp.TenSanPham);

            var sanPhamHDList = gcSanPhamHD.DataSource as List<DTOChiTietDonHang>;
            if (sanPhamHDList == null)
            {
                sanPhamHDList = new List<DTOChiTietDonHang>();
                gcSanPhamHD.DataSource = sanPhamHDList;
            }

            sanPhamHDList.Add(addedValue);

            gcSanPhamHD.RefreshDataSource();
        }

        private void gcSanPhamHD_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)) || e.Data.GetDataPresent(typeof(object)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gvSanPhamHD_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoLuong")
            {
                var sanPhamHDList = gcSanPhamHD.DataSource as List<DTOChiTietDonHang>;

                int total = GetTotalThanhTien(sanPhamHDList);

                label8.Text = "THÀNH TIỀN: " + total;
            }
        }

        private void AddHD()
        {
            string newMHD = bllHoaDon.GetNextMDH();
            var sanPhamHDList = gcSanPhamHD.DataSource as List<DTOChiTietDonHang>;

            if (sanPhamHDList == null || sanPhamHDList.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong đơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DonHang donhang = new DonHang
            {
                MaDonHang = newMHD,
                MaKhachHang = cboKhachHang.SelectedValue.ToString(),
                MaNhanVien = NV,
                TongTien = GetTotalThanhTien(sanPhamHDList),
                NgayLap = dtpNgayLap.Value
            };

            bllHoaDon.InsertDH(donhang);

            AddCTDH(newMHD, sanPhamHDList);
        }

        private void AddCTDH(string id, List<DTOChiTietDonHang> source)
        {
            foreach (DTOChiTietDonHang item in source)
            {
                MessageBox.Show(item.MaSanPham);
                ChiTietDonHang ctdon = new ChiTietDonHang()
                {
                    MaDonHang = id,
                    MaSanPham = item.MaSanPham,
                    DonGia = (int)item.DonGia,
                    SoLuong = item.SoLuong,
                };

                try
                {
                    bllHoaDon.InsertChiTietDonHang(ctdon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm {item.TenSanPham}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Chi tiết đơn hàng đã được thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            AddHD();
            LoadHD();

            gcSanPham.AllowDrop = false;
            gcSanPhamHD.AllowDrop = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gvSanPhamHD.GetSelectedRows();
            if (selectedRowHandles.Length > 0)
            {
                int selectedRowHandle = selectedRowHandles[0];

                DTOChiTietDonHang selectedItem = gvSanPhamHD.GetRow(selectedRowHandle) as DTOChiTietDonHang;

                if (selectedItem != null)
                {
                    var dataSource = gcSanPhamHD.DataSource as List<DTOChiTietDonHang>;

                    if (dataSource != null)
                    {
                        dataSource.Remove(selectedItem);

                        gvSanPhamHD.RefreshData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào được chọn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}