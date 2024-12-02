namespace GUI
{
    partial class frmQLPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.GroupControl groupControlChiTiet;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuNhap;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietPhieuNhap;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuNhap;
        private DevExpress.XtraEditors.DateEdit dtpNgayNhap;
        private DevExpress.XtraEditors.LookUpEdit cboNhaCungCap;
        private DevExpress.XtraEditors.LookUpEdit cboSanPham;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtNhanVienNhap;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl lblMaPhieuNhap;
        private DevExpress.XtraEditors.LabelControl lblNgayNhap;
        private DevExpress.XtraEditors.LabelControl lblNhaCungCap;
        private DevExpress.XtraEditors.LabelControl lblNhanVienNhap;
        private DevExpress.XtraEditors.LabelControl lblTongTien;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.cboNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNhanVienNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lblMaPhieuNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblNhaCungCap = new DevExpress.XtraEditors.LabelControl();
            this.lblNhanVienNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblTongTien = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.textSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.textEditDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lblTenSanPham = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.btnExportReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTiet)).BeginInit();
            this.groupControlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.btnExportReport);
            this.groupControlInfo.Controls.Add(this.textEditTenSanPham);
            this.groupControlInfo.Controls.Add(this.lblTenSanPham);
            this.groupControlInfo.Controls.Add(this.textEditDonGia);
            this.groupControlInfo.Controls.Add(this.lblDonGia);
            this.groupControlInfo.Controls.Add(this.textSoLuong);
            this.groupControlInfo.Controls.Add(this.lblSoLuong);
            this.groupControlInfo.Controls.Add(this.btnImportExcel);
            this.groupControlInfo.Controls.Add(this.txtMaPhieuNhap);
            this.groupControlInfo.Controls.Add(this.dtpNgayNhap);
            this.groupControlInfo.Controls.Add(this.cboNhaCungCap);
            this.groupControlInfo.Controls.Add(this.txtNhanVienNhap);
            this.groupControlInfo.Controls.Add(this.txtTongTien);
            this.groupControlInfo.Controls.Add(this.lblMaPhieuNhap);
            this.groupControlInfo.Controls.Add(this.lblNgayNhap);
            this.groupControlInfo.Controls.Add(this.lblNhaCungCap);
            this.groupControlInfo.Controls.Add(this.lblNhanVienNhap);
            this.groupControlInfo.Controls.Add(this.lblTongTien);
            this.groupControlInfo.Controls.Add(this.btnThem);
            this.groupControlInfo.Controls.Add(this.btnSua);
            this.groupControlInfo.Controls.Add(this.btnXoa);
            this.groupControlInfo.Controls.Add(this.btnLuu);
            this.groupControlInfo.Controls.Add(this.btnHuy);
            this.groupControlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(918, 170);
            this.groupControlInfo.TabIndex = 2;
            this.groupControlInfo.Text = "Thông Tin Phiếu Nhập";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(771, 90);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(94, 29);
            this.btnImportExcel.TabIndex = 15;
            this.btnImportExcel.Text = "Nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(114, 40);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieuNhap.TabIndex = 0;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.EditValue = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dtpNgayNhap.Location = new System.Drawing.Point(100, 70);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Location = new System.Drawing.Point(107, 100);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(200, 22);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // txtNhanVienNhap
            // 
            this.txtNhanVienNhap.Location = new System.Drawing.Point(429, 40);
            this.txtNhanVienNhap.Name = "txtNhanVienNhap";
            this.txtNhanVienNhap.Size = new System.Drawing.Size(200, 22);
            this.txtNhanVienNhap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(429, 70);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(200, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(20, 43);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(85, 16);
            this.lblMaPhieuNhap.TabIndex = 5;
            this.lblMaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Location = new System.Drawing.Point(20, 73);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(61, 16);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.Location = new System.Drawing.Point(20, 103);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(81, 16);
            this.lblNhaCungCap.TabIndex = 7;
            this.lblNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lblNhanVienNhap
            // 
            this.lblNhanVienNhap.Location = new System.Drawing.Point(320, 43);
            this.lblNhanVienNhap.Name = "lblNhanVienNhap";
            this.lblNhanVienNhap.Size = new System.Drawing.Size(91, 16);
            this.lblNhanVienNhap.TabIndex = 8;
            this.lblNhanVienNhap.Text = "Nhân Viên Nhập";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(320, 73);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(58, 16);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(650, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(650, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(650, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(771, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(771, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            // 
            // groupControlChiTiet
            // 
            this.groupControlChiTiet.Controls.Add(this.gcChiTietPhieuNhap);
            this.groupControlChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlChiTiet.Location = new System.Drawing.Point(0, 320);
            this.groupControlChiTiet.Name = "groupControlChiTiet";
            this.groupControlChiTiet.Size = new System.Drawing.Size(918, 280);
            this.groupControlChiTiet.TabIndex = 0;
            this.groupControlChiTiet.Text = "Chi Tiết Phiếu Nhập";
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(2, 28);
            this.gcChiTietPhieuNhap.MainView = this.gvChiTietPhieuNhap;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(914, 250);
            this.gcChiTietPhieuNhap.TabIndex = 0;
            this.gcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietPhieuNhap});
            // 
            // gvChiTietPhieuNhap
            // 
            this.gvChiTietPhieuNhap.GridControl = this.gcChiTietPhieuNhap;
            this.gvChiTietPhieuNhap.Name = "gvChiTietPhieuNhap";
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 170);
            this.gcPhieuNhap.MainView = this.gvPhieuNhap;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(918, 150);
            this.gcPhieuNhap.TabIndex = 1;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNhap});
            // 
            // gvPhieuNhap
            // 
            this.gvPhieuNhap.GridControl = this.gcPhieuNhap;
            this.gvPhieuNhap.Name = "gvPhieuNhap";
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(0, 0);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(125, 25);
            this.cboSanPham.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(330, 106);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(54, 16);
            this.lblSoLuong.TabIndex = 16;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(390, 103);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(58, 22);
            this.textSoLuong.TabIndex = 17;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(463, 106);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(45, 16);
            this.lblDonGia.TabIndex = 18;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // textEditDonGia
            // 
            this.textEditDonGia.Location = new System.Drawing.Point(514, 103);
            this.textEditDonGia.Name = "textEditDonGia";
            this.textEditDonGia.Size = new System.Drawing.Size(115, 22);
            this.textEditDonGia.TabIndex = 19;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Location = new System.Drawing.Point(20, 135);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(54, 16);
            this.lblTenSanPham.TabIndex = 20;
            this.lblTenSanPham.Text = "Số Lượng";
            // 
            // textEditTenSanPham
            // 
            this.textEditTenSanPham.Location = new System.Drawing.Point(100, 132);
            this.textEditTenSanPham.Name = "textEditTenSanPham";
            this.textEditTenSanPham.Size = new System.Drawing.Size(529, 22);
            this.textEditTenSanPham.TabIndex = 21;
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(650, 125);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(215, 29);
            this.btnExportReport.TabIndex = 22;
            this.btnExportReport.Text = "Xuất Phiếu Nhập";
            // 
            // frmQLPhieuNhap
            // 
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.groupControlChiTiet);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "frmQLPhieuNhap";
            this.Text = "Quản Lý Phiếu Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTiet)).EndInit();
            this.groupControlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.TextEdit textSoLuong;
        private DevExpress.XtraEditors.TextEdit textEditDonGia;
        private DevExpress.XtraEditors.LabelControl lblDonGia;
        private DevExpress.XtraEditors.TextEdit textEditTenSanPham;
        private DevExpress.XtraEditors.LabelControl lblTenSanPham;
        private DevExpress.XtraEditors.SimpleButton btnExportReport;
    }
}
