using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class ChiTietHoaDonNhap
    {
        private int iSoHD;
        private string sMaHang;
        private float fGiaNhap;
        private float fSoLuongNhap;

        public ChiTietHoaDonNhap()
        {
        }

        public ChiTietHoaDonNhap(int iSoHD, string sMaHang)
        {
            this.iSoHD = iSoHD;
            this.sMaHang = sMaHang;
        }

        public ChiTietHoaDonNhap(int iSoHD, string sMaHang, float fGiaNhap, float fSoLuongNhap)
        {
            this.iSoHD = iSoHD;
            this.sMaHang = sMaHang;
            this.fGiaNhap = fGiaNhap;
            this.fSoLuongNhap = fSoLuongNhap;
        }

        public int ISoHD { get => iSoHD; set => iSoHD = value; }
        public string SMaHang { get => sMaHang; set => sMaHang = value; }
        public float FGiaNhap { get => fGiaNhap; set => fGiaNhap = value; }
        public float FSoLuongNhap { get => fSoLuongNhap; set => fSoLuongNhap = value; }
    }
}
