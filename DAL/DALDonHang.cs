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
    }
}
