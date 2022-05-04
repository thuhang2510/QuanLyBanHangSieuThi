using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class ChiTietHoaDonBan
    {
        private int iSoHD;
        private string sMaHang;
        private float fGiaban;
        private float fSoluongmua;

        public ChiTietHoaDonBan()
        {
        }

        public ChiTietHoaDonBan(int iSoHD, string sMaHang)
        {
            this.iSoHD = iSoHD;
            this.sMaHang = sMaHang;
        }

        public ChiTietHoaDonBan(int iSoHD, string sMaHang, float fGiaban, float fSoluongmua)
        {
            this.iSoHD = iSoHD;
            this.sMaHang = sMaHang;
            this.fGiaban = fGiaban;
            this.fSoluongmua = fSoluongmua;
        }

        public int ISoHD { get => iSoHD; set => iSoHD = value; }
        public string SMaHang { get => sMaHang; set => sMaHang = value; }
        public float FGiaban { get => fGiaban; set => fGiaban = value; }
        public float FSoluongmua { get => fSoluongmua; set => fSoluongmua = value; }
    }
}
