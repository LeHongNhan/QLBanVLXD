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

        public List<ChiTietDonHang> GetChiTietDonHangs(string id)
        {
            return daoHoaDon.GetChiTietDonHangs(id);
        }
    }
}
