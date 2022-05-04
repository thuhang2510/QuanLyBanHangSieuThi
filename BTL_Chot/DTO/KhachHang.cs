using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class KhachHang
    {
        private int iMaKH;
        private string sTenKH;
        private string sDiachi;
        private string sDienthoai;
        private bool bGioiTinh;

        public KhachHang()
        {
        }

        public KhachHang(int iMaKH, string sTenKH, string sDiachi, string sDienthoai, bool bGioiTinh)
        {
            this.iMaKH = iMaKH;
            this.sTenKH = sTenKH;
            this.sDiachi = sDiachi;
            this.sDienthoai = sDienthoai;
            this.bGioiTinh = bGioiTinh;
        }

        public int IMaKH { get => iMaKH; set => iMaKH = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SDiachi { get => sDiachi; set => sDiachi = value; }
        public string SDienthoai { get => sDienthoai; set => sDienthoai = value; }
        public bool BGioiTinh { get => bGioiTinh; set => bGioiTinh = value; }
    }
}
