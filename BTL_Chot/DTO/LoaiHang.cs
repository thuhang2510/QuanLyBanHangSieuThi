using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class LoaiHang
    {
        private string sMaLH;
        private string sTenLH;

        public LoaiHang()
        {
        }

        public LoaiHang(string sMaLH, string sTenLH)
        {
            this.sMaLH = sMaLH;
            this.sTenLH = sTenLH;
        }

        public string SMaLH { get => sMaLH; set => sMaLH = value; }
        public string STenLH { get => sTenLH; set => sTenLH = value; }
    }
}
