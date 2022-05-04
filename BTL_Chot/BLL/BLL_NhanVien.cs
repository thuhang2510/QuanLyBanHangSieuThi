using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_Chot.DAL;
using BTL_Chot.DTO;

namespace BTL_Chot.BLL
{
    class BLL_NhanVien
    {
        private DAL_NhanVien dal_NhanVien;

        public BLL_NhanVien()
        {
            dal_NhanVien = new DAL_NhanVien();
        }

        public (int, string) create(NhanVien nhanvien)
        {
            try
            {
                return dal_NhanVien.create(nhanvien);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (int, string) update(NhanVien nhanvien)
        {
            try
            {
                return dal_NhanVien.update(nhanvien);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (int, string) delete(int maNV)
        {
            try
            {
                return dal_NhanVien.delete(maNV);
            }
            catch (Exception e)
            {
                return (-1, "occurred:" + e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                return dal_NhanVien.get_all();
            }
            catch (Exception e)
            {
                return (null, "occurred:" + e.Message);
            }
        }

        public (DataTable, string) get_all_have_description()
        {
            try
            {
                return dal_NhanVien.get_all_have_description();
            }
            catch (Exception e)
            {
                return (null, "occurred:" + e.Message);
            }
        }

        public (DataTable, string) get_by_query(string tenNV, string diaChi, string sdt, DateTime? ngaySinh, DateTime? ngayVaoLam)
        {
            try
            {
                return dal_NhanVien.get_by_query(tenNV, diaChi, sdt, ngaySinh, ngayVaoLam);
            }
            catch (Exception e)
            {
                return (null, "occurred:" + e.Message);
            }
        }

        public string get_name(int maNV)
        {
            try
            {
                (DataTable dataTable, string msg) = dal_NhanVien.get_by_id(maNV);

                foreach (DataRow row in dataTable.Rows)
                    return (string)row["sTenNV"];

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
