using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using DTO;

namespace BLL
{
    public class BLLHoaDon
    {
        DALHoaDon daoHoaDon = new DALHoaDon();
        public BLLHoaDon()
        {

        }

        public List<DonHang> GetDonHangs()
        {
            return daoHoaDon.GetDonHangs();
        }

        public List<DTOChiTietDonHang> GetChiTietDonHangs(string id)
        {
            return daoHoaDon.GetChiTietDonHangs(id);
        }

        public DonHang GetDonHang(string id)
        {
            return daoHoaDon.GetDonHang(id);
        }

        public string GetNextMDH()
        {
            return daoHoaDon.getNextDonHang();
        }

        public string InsertDH(DonHang donHang)
        {
            return daoHoaDon.InsertDonHang(donHang);
        }

        public bool InsertChiTietDonHang(ChiTietDonHang newChiTietDonHang)
        {
            return daoHoaDon.InsertChiTietDonHang(newChiTietDonHang);
        }
    }
}
