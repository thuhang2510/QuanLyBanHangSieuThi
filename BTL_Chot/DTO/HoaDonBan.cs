using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class HoaDonBan
    {
        private int iSoHD;
        private int iMaNV;
        private int iMaKH;
        private DateTime dNgayLap;

        public HoaDonBan()
        {
        }

        public HoaDonBan(int iSoHD, int iMaNV, int iMaKH, DateTime dNgayLap)
        {
            this.iSoHD = iSoHD;
            this.iMaNV = iMaNV;
            this.iMaKH = iMaKH;
            this.dNgayLap = dNgayLap;
        }

        public int ISoHD { get => iSoHD; set => iSoHD = value; }
        public int IMaNV { get => iMaNV; set => iMaNV = value; }
        public int IMaKH { get => iMaKH; set => iMaKH = value; }
        public DateTime DNgayLap { get => dNgayLap; set => dNgayLap = value; }
    }
}
