using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_Chot.DTO;

namespace BTL_Chot.DAL
{
    class DAL_NhanVien
    {
        private DungChung dungChung;

        public DAL_NhanVien()
        {
            dungChung = new DungChung();
        }

        public (int, string) create(NhanVien nhanvien)
        {
            try
            {
                string name_proc = "them_nhan_vien";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", nhanvien.MaNV));
                sqlParameters.Add(new SqlParameter("@sTenNV", nhanvien.TenNV));
                sqlParameters.Add(new SqlParameter("@sDiachi", nhanvien.DiaChi));
                sqlParameters.Add(new SqlParameter("@sDienthoai", nhanvien.DienThoai));
                sqlParameters.Add(new SqlParameter("@dNgaysinh", nhanvien.NgaySinh));
                sqlParameters.Add(new SqlParameter("@dNgayvaolam", nhanvien.NgayVaoLam));
                sqlParameters.Add(new SqlParameter("@fLuongcoban", nhanvien.LuongCoBan));

                int kq = dungChung.executeInsertQuery(name_proc, sqlParameters.ToArray<SqlParameter>());
                if (kq > 0)
                    return (kq, "Thêm 1 nhân viên vào thành công");
                return (kq, "Thêm nhân viên thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }


        }

        public (int, string) update(NhanVien nhanvien)
        {
            try
            {
                string name_proc = "sua_nhanvien";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", nhanvien.MaNV));
                sqlParameters.Add(new SqlParameter("@sTenNV", nhanvien.TenNV));
                sqlParameters.Add(new SqlParameter("@sDiachi", nhanvien.DiaChi));
                sqlParameters.Add(new SqlParameter("@sDienthoai", nhanvien.DienThoai));
                sqlParameters.Add(new SqlParameter("@dNgaysinh", nhanvien.NgaySinh));
                sqlParameters.Add(new SqlParameter("@dNgayvaolam", nhanvien.NgayVaoLam));
                sqlParameters.Add(new SqlParameter("@fLuongcoban", nhanvien.LuongCoBan));

                int kq = dungChung.executeUpdateQuery(name_proc, sqlParameters.ToArray<SqlParameter>());
                if (kq > 0)
                    return (kq, "Cập nhật thông tin nhân viên thành công");
                return (kq, "Cập nhật thông tin nhân viên thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int maNV)
        {
            try
            {
                string name_proc = "xoa_nhanvien";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", maNV));

                int kq = dungChung.executeDeleteQuery(name_proc, sqlParameters.ToArray<SqlParameter>());
                if (kq > 0)
                    return (kq, "Xóa 1 nhân viên thành công");
                return (kq, "Xóa nhân viên thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_id(int maNV)
        {
            try
            {
                string name_proc = "ktra_ma_nhanvien";

                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", maNV));

                DataTable kq = dungChung.executeSelectQuery(name_proc, sqlParameters.ToArray<SqlParameter>());
                if (kq != null)
                    return (kq, "Lấy thông tin 1 nhân viên thành công");
                return (kq, "Không thể lấy thông tin");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string name_proc = "lay_ds_nhanvien";
                DataTable kq = dungChung.executeSelectAll(name_proc);
                if (kq != null)
                    return (kq, "Lấy thông tin các nhân viên thành công");
                return (kq, "Không thể lấy thông tin");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_all_have_description()
        {
            try
            {
                string name_proc = "lay_dsNV_den_combox";
                DataTable kq = dungChung.executeSelectAll(name_proc);
                if (kq != null)
                    return (kq, "Lấy thông tin các nhân viên thành công");
                return (kq, "Không thể lấy thông tin");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string tenNV, string diaChi, string sdt, DateTime? ngaySinh, DateTime? ngayVaoLam)
        {
            try
            {
                string name_proc = "proc_timkiemNV";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sTenNV", tenNV));
                sqlParameters.Add(new SqlParameter("@sDiachi", diaChi));
                sqlParameters.Add(new SqlParameter("@sDienthoai", sdt));
                sqlParameters.Add(new SqlParameter("@dNgaysinh", ngaySinh));
                sqlParameters.Add(new SqlParameter("@dNgayvaolam", ngayVaoLam));

                DataTable kq = dungChung.executeSelectQuery(name_proc, sqlParameters.ToArray<SqlParameter>());
                if (kq != null)
                    return (kq, "Lấy thông tin các nhân viên thỏa mãn điều kiện thành công");
                return (kq, "Không thể lấy thông tin");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }
    }
}
