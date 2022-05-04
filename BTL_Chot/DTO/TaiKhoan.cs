using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class TaiKhoan
    {
        private string sTenTK;
        private string sMatKhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string sTenTK, string sMatKhau)
        {
            this.sTenTK = sTenTK;
            this.sMatKhau = sMatKhau;
        }

        public string STenTK { get => sTenTK; set => sTenTK = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
    }
}
