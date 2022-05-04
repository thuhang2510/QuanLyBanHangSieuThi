using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DTO
{
    class NhanVien
    {
        private int maNV;
        private string tenNV;
        private string diaChi;
        private string dienThoai;
        private DateTime ngaySinh;
        private DateTime ngayVaoLam;
        private float luongCoBan;

        public NhanVien()
        {
        }

        public NhanVien(int maNV, string tenNV, string diaChi, string dienThoai, DateTime ngaySinh, DateTime ngayVaoLam, float luongCoBan)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.ngaySinh = ngaySinh;
            this.ngayVaoLam = ngayVaoLam;
            this.luongCoBan = luongCoBan;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
    }
}
