using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DTO;
namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string NV { get; set; }
        BLLSanPham bllsp;
        
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bllsp = new BLLSanPham();
            loadDSSP();

        }
        void loadDSSP()
        {
            List<SanPham> lstSP = bllsp.GetSanPhams();
            galControl.Gallery.ShowItemText = true;
            galControl.Gallery.ShowGroupCaption = true;
            var galleryItemGroup = new GalleryItemGroup { Caption = "Danh sách sản phẩm", CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch };

            foreach (SanPham sp in lstSP)
            {
                var gc_item = new GalleryItem();
                gc_item.Caption = sp.TenSanPham.ToString();
                gc_item.ImageOptions.Image = imageList1.Images[0];
                string giaTienText = string.Format("Giá: {0} VND", sp.DonGia.ToString());
                var labelGiaTien = new LabelControl();
                labelGiaTien.Text = sp.DonGia.ToString();
                labelGiaTien.Location = new Point(0, 25);
                gc_item.Caption = $"{sp.TenSanPham} \n {giaTienText}";
                galleryItemGroup.Items.Add(gc_item);
            }
            galControl.Gallery.Groups.Add(galleryItemGroup);
        }
        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnQLSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLSanPham frm = new frmQLSanPham();
            frm.ShowDialog();
        }

        private void btnQLNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLNhaCungCap f = new frmQLNhaCungCap();
            f.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.ShowDialog();
        }
        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLPhieuNhap f = new frmQLPhieuNhap();
            f.ShowDialog();
        }
        private void btnDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.NV = NV;
            frmHoaDon.ShowDialog();
        }
    }
}
