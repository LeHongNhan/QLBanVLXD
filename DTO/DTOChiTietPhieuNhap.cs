using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietPhieuNhap
    {
        // Mã phiếu nhập, khóa chính
        public string MaPhieuNhap { get; set; }

        // Mã sản phẩm, khóa chính
        public string MaSanPham { get; set; }

        // Số lượng nhập
        public int SoLuong { get; set; }

        // Đơn giá sản phẩm
        public int DonGia { get; set; }

        // Thành tiền (tính toán: Số lượng * Đơn giá)
        public int ThanhTien
        {
            get
            {
                return SoLuong * DonGia;
            }
        }

        // Hàm khởi tạo mặc định
        public DTOChiTietPhieuNhap()
        {
        }

        // Hàm khởi tạo có tham số
        public DTOChiTietPhieuNhap(string maPhieuNhap, string maSanPham, int soLuong, int donGia)
        {
            MaPhieuNhap = maPhieuNhap;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}

