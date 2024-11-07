namespace GUI
{
    partial class frmQLNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhaCungCap));
            this.gridDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiSanPhamCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinhSanPhamCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDS = new DevExpress.XtraGrid.GridControl();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSPCungCap = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            this.gcDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDS
            // 
            this.gridDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap,
            this.DiaChi,
            this.Email,
            this.SoDienThoai,
            this.LoaiSanPhamCungCap,
            this.DonViTinhSanPhamCungCap});
            this.gridDS.GridControl = this.gcDS;
            this.gridDS.Name = "gridDS";
            this.gridDS.Click += new System.EventHandler(this.gridDS_Click);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Caption = "Mã nhà cung cấp";
            this.MaNhaCungCap.FieldName = "MaNhaCungCap";
            this.MaNhaCungCap.MinWidth = 25;
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Visible = true;
            this.MaNhaCungCap.VisibleIndex = 0;
            this.MaNhaCungCap.Width = 94;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.Caption = "Tên nhà cung cấp";
            this.TenNhaCungCap.FieldName = "TenNhaCungCap";
            this.TenNhaCungCap.MinWidth = 25;
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.Visible = true;
            this.TenNhaCungCap.VisibleIndex = 1;
            this.TenNhaCungCap.Width = 94;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 94;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 94;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.MinWidth = 25;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 4;
            this.SoDienThoai.Width = 94;
            // 
            // LoaiSanPhamCungCap
            // 
            this.LoaiSanPhamCungCap.Caption = "Loại sản phẩm cung cấp";
            this.LoaiSanPhamCungCap.FieldName = "LoaiSanPhamCungCap";
            this.LoaiSanPhamCungCap.MinWidth = 25;
            this.LoaiSanPhamCungCap.Name = "LoaiSanPhamCungCap";
            this.LoaiSanPhamCungCap.Visible = true;
            this.LoaiSanPhamCungCap.VisibleIndex = 5;
            this.LoaiSanPhamCungCap.Width = 94;
            // 
            // DonViTinhSanPhamCungCap
            // 
            this.DonViTinhSanPhamCungCap.Caption = "Đơn vị tính";
            this.DonViTinhSanPhamCungCap.FieldName = "DonViTinhSanPhamCungCap";
            this.DonViTinhSanPhamCungCap.MinWidth = 25;
            this.DonViTinhSanPhamCungCap.Name = "DonViTinhSanPhamCungCap";
            this.DonViTinhSanPhamCungCap.Visible = true;
            this.DonViTinhSanPhamCungCap.VisibleIndex = 6;
            this.DonViTinhSanPhamCungCap.Width = 94;
            // 
            // gcDS
            // 
            this.gcDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDS.Location = new System.Drawing.Point(2, 28);
            this.gcDS.MainView = this.gridDS;
            this.gcDS.Name = "gcDS";
            this.gcDS.Size = new System.Drawing.Size(1140, 545);
            this.gcDS.TabIndex = 0;
            this.gcDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDS});
            this.gcDS.Click += new System.EventHandler(this.gcDS_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(477, 101);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 56);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.Text = "";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(477, 72);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(241, 23);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.txtSoDienThoai);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.txtSPCungCap);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.txtTenNCC);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtMaNCC);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 35);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1144, 165);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Thông tin";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(477, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSPCungCap
            // 
            this.txtSPCungCap.Location = new System.Drawing.Point(131, 107);
            this.txtSPCungCap.Name = "txtSPCungCap";
            this.txtSPCungCap.Size = new System.Drawing.Size(241, 23);
            this.txtSPCungCap.TabIndex = 3;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(131, 71);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(241, 23);
            this.txtTenNCC.TabIndex = 3;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(131, 36);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(241, 23);
            this.txtMaNCC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sản phẩm cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NCC";
            // 
            // btnThoat
            // 
            this.btnThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 32);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.toolStripSeparator1,
            this.btnLuu,
            this.btnThoat,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1144, 35);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 32);
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 32);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Controls.Add(this.gcDS);
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 196);
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1144, 575);
            this.gcDanhSach.TabIndex = 13;
            this.gcDanhSach.Text = "Danh sách nhà cung cấp";
            // 
            // frmQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 771);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gcDanhSach);
            this.Name = "frmQLNhaCungCap";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmQLNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.gcDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridDS;
        private DevExpress.XtraGrid.GridControl gcDS;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSPCungCap;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private DevExpress.XtraEditors.GroupControl gcDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiSanPhamCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinhSanPhamCungCap;
    }
}