using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class HoaDonNhap
    {
        private int iSoHD;
        private int iMaNV;
        private DateTime dNgaynhaphang;

        public HoaDonNhap()
        {
        }

        public HoaDonNhap(int iSoHD, int iMaNV, DateTime dNgaynhaphang)
        {
            this.iSoHD = iSoHD;
            this.iMaNV = iMaNV;
            this.dNgaynhaphang = dNgaynhaphang;
        }

        public int ISoHD { get => iSoHD; set => iSoHD = value; }
        public int IMaNV { get => iMaNV; set => iMaNV = value; }
        public DateTime DNgaynhaphang { get => dNgaynhaphang; set => dNgaynhaphang = value; }
    }
}
