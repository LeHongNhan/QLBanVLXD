using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DALChiTietPhieuNhap
    {
        private QL_VLXDDataContext vlxd = new QL_VLXDDataContext();

        public List<ChiTietPhieuNhap> GetChiTietByPhieuNhapId(string maPhieuNhap)
        {
            return vlxd.ChiTietPhieuNhaps.Where(ct => ct.MaPhieuNhap == maPhieuNhap).ToList();
        }

        public List<dynamic> GetChiTietPhieuNhapWithProduct(string maPhieuNhap)
        {
            return vlxd.ChiTietPhieuNhaps
                .Where(ct => ct.MaPhieuNhap == maPhieuNhap)
                .Select(ct => new
                {
                    ct.MaSanPham,
                    TenSanPham = ct.SanPham.TenSanPham,
                    ct.SoLuong,
                    ct.DonGia,
                    ThanhTien = ct.SoLuong * ct.DonGia
                }).ToList<dynamic>();
        }

        public bool InsertChiTietPhieuNhap(ChiTietPhieuNhap newChiTiet)
        {
            try
            {
                vlxd.ChiTietPhieuNhaps.InsertOnSubmit(newChiTiet);
                vlxd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateChiTietPhieuNhap(ChiTietPhieuNhap updatedChiTiet)
        {
            try
            {
                var existing = vlxd.ChiTietPhieuNhaps.FirstOrDefault(ct => ct.MaPhieuNhap == updatedChiTiet.MaPhieuNhap && ct.MaSanPham == updatedChiTiet.MaSanPham);
                if (existing != null)
                {
                    existing.SoLuong = updatedChiTiet.SoLuong;
                    existing.DonGia = updatedChiTiet.DonGia;
                    vlxd.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAllChiTietPhieuNhapByMaPhieuNhap(string maPhieuNhap)
        {
            try
            {
                var chiTietList = vlxd.ChiTietPhieuNhaps.Where(ct => ct.MaPhieuNhap == maPhieuNhap).ToList();
                if (chiTietList.Any())
                {
                    vlxd.ChiTietPhieuNhaps.DeleteAllOnSubmit(chiTietList);
                    vlxd.SubmitChanges();
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
