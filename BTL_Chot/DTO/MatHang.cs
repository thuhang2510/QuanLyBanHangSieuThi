using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class MatHang
    {
		private string sMaHang;
		private string sTenHang;
		private string sTenNCC;
		private string sMaLH;
		private float fSoLuong;
		private float fGiaHang;

        public MatHang()
        {
        }

        public MatHang(string sMaHang, string sTenHang, string sTenNCC, string sMaLH, float fSoLuong, float fGiaHang)
        {
            this.sMaHang = sMaHang;
            this.sTenHang = sTenHang;
            this.sTenNCC = sTenNCC;
            this.sMaLH = sMaLH;
            this.fSoLuong = fSoLuong;
            this.fGiaHang = fGiaHang;
        }

        public string SMaHang { get => sMaHang; set => sMaHang = value; }
        public string STenHang { get => sTenHang; set => sTenHang = value; }
        public string STenNCC { get => sTenNCC; set => sTenNCC = value; }
        public string SMaLH { get => sMaLH; set => sMaLH = value; }
        public float FSoLuong { get => fSoLuong; set => fSoLuong = value; }
        public float FGiaHang { get => fGiaHang; set => fGiaHang = value; }
    }
}
