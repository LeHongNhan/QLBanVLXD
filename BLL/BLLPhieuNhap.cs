using DTO;
using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class BLLPhieuNhap
    {
        private DALPhieuNhap dalPhieuNhap = new DALPhieuNhap();

        public List<PhieuNhap> GetPhieuNhapList()
        {
            return dalPhieuNhap.GetAllPhieuNhap();
        }

        public PhieuNhap GetPhieuNhapById(string maPhieuNhap)
        {
            return dalPhieuNhap.GetPhieuNhapById(maPhieuNhap);
        }

        public List<PhieuNhap> FilterPhieuNhapByDate(DateTime fromDate, DateTime toDate)
        {
            return dalPhieuNhap.GetPhieuNhapByDateRange(fromDate, toDate);
        }

        public bool AddPhieuNhap(PhieuNhap phieuNhap)
        {
            return dalPhieuNhap.InsertPhieuNhap(phieuNhap);
        }

        public bool UpdatePhieuNhap(PhieuNhap phieuNhap)
        {
            return dalPhieuNhap.UpdatePhieuNhap(phieuNhap);
        }

        public bool DeletePhieuNhap(string maPhieuNhap)
        {
            return dalPhieuNhap.DeletePhieuNhap(maPhieuNhap);
        }
    }
}
