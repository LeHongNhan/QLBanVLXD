using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHoaDon
    {
        QL_VLXDDataContext ql_vlxd;

        public DALHoaDon()
        {
            ql_vlxd = new QL_VLXDDataContext();
        }

        public List<DonHang> GetDonHangs()
        {
            return ql_vlxd.DonHangs.ToList();
        }

        public DonHang GetDonHang(string id)
        {
            return ql_vlxd.DonHangs.Where(a => a.MaDonHang == id).FirstOrDefault();
        }
        public List<DTOChiTietDonHang> GetChiTietDonHangs(string id)
        {
            return ql_vlxd.ChiTietDonHangs.Where(e => e.MaDonHang == id)
        .Select(i => new DTOChiTietDonHang
            {
                MaDonHang = i.MaDonHang,
                MaSanPham=i.MaSanPham,
                TenSanPham = i.SanPham.TenSanPham,
                DonGia = (decimal)i.DonGia,
                SoLuong = (int)i.SoLuong

            })
        .ToList();
        }

        public string getNextDonHang()
        {
            string maxId = ql_vlxd.DonHangs
            .OrderByDescending(d => d.MaDonHang)
            .Select(d => d.MaDonHang)
            .FirstOrDefault();

            if (string.IsNullOrEmpty(maxId))
            {
                return "DH001";
            }

            string numericPart = maxId.Substring(2);
            if (int.TryParse(numericPart, out int maxNumber))
            {
                return $"DH{(maxNumber + 1):D3}";
            }

            throw new Exception("Invalid MaDonHang format in the database.");
        }

        public string InsertDonHang(DonHang newDonHang)
        {
            try
            {
                ql_vlxd.DonHangs.InsertOnSubmit(newDonHang);
                ql_vlxd.SubmitChanges();

                return newDonHang.MaDonHang;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting DonHang: " + ex.Message);
            }
        }

        public bool InsertChiTietDonHang(ChiTietDonHang newChiTietDonHang)
        {
            try
            {
                ql_vlxd.ChiTietDonHangs.InsertOnSubmit(newChiTietDonHang);
                ql_vlxd.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
