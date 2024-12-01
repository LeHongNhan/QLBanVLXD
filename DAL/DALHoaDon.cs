using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ChiTietDonHang> GetChiTietDonHangs(string id)
        {
            return ql_vlxd.ChiTietDonHangs.Where(e=>e.MaDonHang==id).ToList();
        }


    }
}
