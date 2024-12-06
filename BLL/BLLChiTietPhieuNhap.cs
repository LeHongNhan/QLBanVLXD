using DTO;
using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class BLLChiTietPhieuNhap
    {
        private DALChiTietPhieuNhap dalChiTietPhieuNhap = new DALChiTietPhieuNhap();
        private DALSanPham dalSanPham = new DALSanPham();

        public List<dynamic> GetChiTietPhieuNhapList(string maPhieuNhap)
        {
            return dalChiTietPhieuNhap.GetChiTietPhieuNhapWithProduct(maPhieuNhap);
        }

        public bool AddChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            return dalChiTietPhieuNhap.InsertChiTietPhieuNhap(chiTiet);
        }

        public bool UpdateChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            return dalChiTietPhieuNhap.UpdateChiTietPhieuNhap(chiTiet);
        }

        public bool DeleteAllChiTietPhieuNhap(string maPhieuNhap)
        {
            return dalChiTietPhieuNhap.DeleteAllChiTietPhieuNhapByMaPhieuNhap(maPhieuNhap);
        }

        // Tăng tồn kho sản phẩm khi thêm chi tiết phiếu nhập
        public bool IncreaseTonKho(string maSanPham, int soLuong)
        {
            // Lấy sản phẩm từ database
            var sanPham = dalSanPham.GetSanPham(maSanPham);
            if (sanPham == null)
                return false;

            // Cập nhật số lượng tồn kho
            sanPham.SoLuongTon += soLuong;
            return dalSanPham.UpdateSanPham(sanPham);
        }

        // Giảm tồn kho sản phẩm khi xóa chi tiết phiếu nhập
        public bool DecreaseTonKho(string maSanPham, int soLuong)
        {
            // Lấy sản phẩm từ database
            var sanPham = dalSanPham.GetSanPham(maSanPham);
            if (sanPham == null)
                return false;

            // Đảm bảo tồn kho không bị âm
            if (sanPham.SoLuongTon < soLuong)
                return false;

            // Cập nhật số lượng tồn kho
            sanPham.SoLuongTon -= soLuong;
            return dalSanPham.UpdateSanPham(sanPham);
        }
        public bool DecreaseTonKhoForDeletedChiTiet(string maPhieuNhap)
        {
            try
            {
                var chiTietList = dalChiTietPhieuNhap.GetChiTietByPhieuNhapId(maPhieuNhap);
                foreach (var chiTiet in chiTietList)
                {
                    if (!DecreaseTonKho(chiTiet.MaSanPham, chiTiet.SoLuong ?? 0))
                    {
                        return false; // Nếu giảm tồn kho thất bại
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
    

