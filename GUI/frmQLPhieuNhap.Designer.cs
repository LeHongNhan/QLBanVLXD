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
        private System.Windows.Forms.ComboBox  cboNhaCungCap;
        private System.Windows.Forms.ComboBox cboSanPham;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtNhanVienNhap;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl lblMaPhieuNhap;
        private DevExpress.XtraEditors.LabelControl lblNgayNhap;
        private DevExpress.XtraEditors.LabelControl lblNhaCungCap;
        private DevExpress.XtraEditors.LabelControl lblNhanVienNhap;
        private DevExpress.XtraEditors.LabelControl lblTongTien;
        private DevExpress.XtraEditors.LabelControl lblSanPham;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.LabelControl lblDonGia;
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
            this.txtMaPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
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
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lblSanPham = new DevExpress.XtraEditors.LabelControl();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTiet)).BeginInit();
            this.groupControlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
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
            this.groupControlInfo.Size = new System.Drawing.Size(800, 120);
            this.groupControlInfo.TabIndex = 2;
            this.groupControlInfo.Text = "Thông Tin Phiếu Nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(120, 30);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(150, 22);
            this.txtMaPhieuNhap.TabIndex = 0;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.EditValue = new System.DateTime(2024, 12, 6, 0, 0, 0, 0);
            this.dtpNgayNhap.Location = new System.Drawing.Point(120, 60);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(150, 22);
            this.dtpNgayNhap.TabIndex = 1;

            this.dtpNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"; // Định dạng ngày hiển thị
            this.dtpNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayNhap.Properties.EditFormat.FormatString = "dd-MM-yyyy"; // Định dạng ngày lưu trữ
            this.dtpNgayNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayNhap.Properties.Mask.EditMask = "dd-MM-yyyy"; // Định dạng mặt nạ nhập


            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Location = new System.Drawing.Point(120, 90);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(150, 22);
            this.cboNhaCungCap.TabIndex = 2;
            // 
            // txtNhanVienNhap
            // 
            this.txtNhanVienNhap.Location = new System.Drawing.Point(426, 27);
            this.txtNhanVienNhap.Name = "txtNhanVienNhap";
            this.txtNhanVienNhap.Size = new System.Drawing.Size(150, 22);
            this.txtNhanVienNhap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(400, 60);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(85, 16);
            this.lblMaPhieuNhap.TabIndex = 5;
            this.lblMaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Location = new System.Drawing.Point(30, 60);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(61, 16);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày Nhập";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.Location = new System.Drawing.Point(30, 90);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(81, 16);
            this.lblNhaCungCap.TabIndex = 7;
            this.lblNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lblNhanVienNhap
            // 
            this.lblNhanVienNhap.Location = new System.Drawing.Point(320, 30);
            this.lblNhanVienNhap.Name = "lblNhanVienNhap";
            this.lblNhanVienNhap.Size = new System.Drawing.Size(91, 16);
            this.lblNhanVienNhap.TabIndex = 8;
            this.lblNhanVienNhap.Text = "Nhân Viên Nhập";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(320, 60);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(58, 16);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(600, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(600, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(600, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(700, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(700, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            // 
            // groupControlChiTiet
            // 
            this.groupControlChiTiet.Controls.Add(this.cboSanPham);
            this.groupControlChiTiet.Controls.Add(this.txtSoLuong);
            this.groupControlChiTiet.Controls.Add(this.txtDonGia);
            this.groupControlChiTiet.Controls.Add(this.lblSanPham);
            this.groupControlChiTiet.Controls.Add(this.lblSoLuong);
            this.groupControlChiTiet.Controls.Add(this.lblDonGia);
            this.groupControlChiTiet.Controls.Add(this.gcChiTietPhieuNhap);
            this.groupControlInfo.Controls.Add(this.cboNhaCungCap);
            this.groupControlChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlChiTiet.Location = new System.Drawing.Point(0, 320);
            this.groupControlChiTiet.Name = "groupControlChiTiet";
            this.groupControlChiTiet.Size = new System.Drawing.Size(800, 280);
            this.groupControlChiTiet.TabIndex = 0;
            this.groupControlChiTiet.Text = "Chi Tiết Phiếu Nhập";
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(100, 30);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(150, 22);
            this.cboSanPham.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(332, 31);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(150, 22);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(561, 31);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 22);
            this.txtDonGia.TabIndex = 2;
            // 
            // lblSanPham
            // 
            this.lblSanPham.Location = new System.Drawing.Point(30, 30);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(58, 16);
            this.lblSanPham.TabIndex = 3;
            this.lblSanPham.Text = "Sản Phẩm";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(262, 31);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(54, 16);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(491, 31);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(45, 16);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(2, 78);
            this.gcChiTietPhieuNhap.MainView = this.gvChiTietPhieuNhap;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(796, 200);
            this.gcChiTietPhieuNhap.TabIndex = 6;
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
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 120);
            this.gcPhieuNhap.MainView = this.gvPhieuNhap;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(800, 200);
            this.gcPhieuNhap.TabIndex = 1;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNhap});
            // 
            // gvPhieuNhap
            // 
            this.gvPhieuNhap.GridControl = this.gcPhieuNhap;
            this.gvPhieuNhap.Name = "gvPhieuNhap";
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQLPhieuNhap
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTiet)).EndInit();
            this.groupControlChiTiet.ResumeLayout(false);
            this.groupControlChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
