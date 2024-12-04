using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALDonHang
    {
        QL_VLXDDataContext vlxd = new QL_VLXDDataContext();
        public DALDonHang()
        {

        }

        public List<DonHang> LoadDonHang()
        {
            return vlxd.DonHangs.ToList();
        }
        public List<dynamic> loadDonHangGC()
        {
            return vlxd.DonHangs.Select(x => new {x.MaDonHang, x.KhachHang.TenKhachHang, x.NhanVien.TenNhanVien, x.TongTien, x.NgayLap}).ToList<dynamic>();
        }
        public List<DoanhThuNgay> GetTongTienTheoNgay()
        {
            return vlxd.DonHangs
                .GroupBy(x => x.NgayLap.Value.Date) // Nhóm theo ngày lập
                .Select(g => new DoanhThuNgay
                {
                    NgayLap = g.Key,                 // Ngày lập
                    TongTien = g.Sum(x => x.TongTien) // Tổng tiền theo ngày
                })
                .ToList();
        }
        public decimal GetTongDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                return vlxd.DonHangs
                .Where(x => x.NgayLap >= tuNgay && x.NgayLap <= denNgay && x.TongTien.HasValue)
                .Sum(x => (decimal)x.TongTien.Value);
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
    }
}
