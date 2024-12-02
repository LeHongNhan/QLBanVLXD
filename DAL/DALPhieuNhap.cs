using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DALPhieuNhap
    {
        private QL_VLXDDataContext vlxd = new QL_VLXDDataContext();

        public List<PhieuNhap> GetAllPhieuNhap()
        {
            return vlxd.PhieuNhaps.ToList();
        }

        public List<PhieuNhap> GetPhieuNhapByDateRange(DateTime fromDate, DateTime toDate)
        {
            return vlxd.PhieuNhaps.Where(pn => pn.NgayNhap >= fromDate && pn.NgayNhap <= toDate).ToList();
        }

        public List<PhieuNhap> GetPhieuNhapBySupplier(string maNhaCungCap)
        {
            return vlxd.PhieuNhaps.Where(pn => pn.MaNhaCungCap == maNhaCungCap).ToList();
        }

        public PhieuNhap GetPhieuNhapById(string maPhieuNhap)
        {
            return vlxd.PhieuNhaps.FirstOrDefault(pn => pn.MaPhieuNhap == maPhieuNhap);
        }

        public bool InsertPhieuNhap(PhieuNhap newPhieuNhap)
        {
            try
            {
                vlxd.PhieuNhaps.InsertOnSubmit(newPhieuNhap);
                vlxd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePhieuNhap(PhieuNhap updatedPhieuNhap)
        {
            try
            {
                var existing = vlxd.PhieuNhaps.FirstOrDefault(pn => pn.MaPhieuNhap == updatedPhieuNhap.MaPhieuNhap);
                if (existing != null)
                {
                    existing.NgayNhap = updatedPhieuNhap.NgayNhap;
                    existing.MaNhaCungCap = updatedPhieuNhap.MaNhaCungCap;
                    existing.MaNhanVien = updatedPhieuNhap.MaNhanVien;
                    existing.TongTien = updatedPhieuNhap.TongTien;
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

        public bool DeletePhieuNhap(string maPhieuNhap)
        {
            try
            {
                var phieuNhap = vlxd.PhieuNhaps.FirstOrDefault(pn => pn.MaPhieuNhap == maPhieuNhap);
                if (phieuNhap != null)
                {
                    vlxd.PhieuNhaps.DeleteOnSubmit(phieuNhap);
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
    }
}
