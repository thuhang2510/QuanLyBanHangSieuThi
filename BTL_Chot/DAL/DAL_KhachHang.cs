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
    class DAL_KhachHang
    {
        private DungChung DungChung;

        public DAL_KhachHang()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_all_have_description()
        {
            try
            {
                string query = "lay_dsKH_den_combox";
                DataTable kq = DungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "Lấy ds khách hàng thành công");

                return (kq, "Lấy ds khách hàng thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string query = "lay_ds_khach_hang";
                DataTable kq = DungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "Lấy ds khách hàng thành công");

                return (kq, "Lấy ds khách hàng thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(KhachHang khachHang)
        {
            try
            {
                string query = "them_khach_hang";
                List<SqlParameter> SqlParameters = new List<SqlParameter>();
                SqlParameters.Add(new SqlParameter("@iMaKH", khachHang.IMaKH));
                SqlParameters.Add(new SqlParameter("@sTenKH", khachHang.STenKH));
                SqlParameters.Add(new SqlParameter("@sDiachi", khachHang.SDiachi));
                SqlParameters.Add(new SqlParameter("@sDienthoai", khachHang.SDienthoai));
                SqlParameters.Add(new SqlParameter("@bGioiTinh", khachHang.BGioiTinh));
                int kq = DungChung.executeInsertQuery(query, SqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "thêm thành công");

                return (kq, "Thêm thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(KhachHang khachHang)
        {
            try
            {
                string query = "sua_khach_hang";
                List<SqlParameter> SqlParameters = new List<SqlParameter>();
                SqlParameters.Add(new SqlParameter("@iMaKH", khachHang.IMaKH));
                SqlParameters.Add(new SqlParameter("@sTenKH", khachHang.STenKH));
                SqlParameters.Add(new SqlParameter("@sDiachi", khachHang.SDiachi));
                SqlParameters.Add(new SqlParameter("@sDienthoai", khachHang.SDienthoai));
                SqlParameters.Add(new SqlParameter("@bGioiTinh", khachHang.BGioiTinh));
                int kq = DungChung.executeUpdateQuery(query, SqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "sửa thành công");

                return (kq, "Sửa thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int maKH)
        {
            try
            {
                string query = "xoa_khach_hang";
                List<SqlParameter> SqlParameters = new List<SqlParameter>();
                SqlParameters.Add(new SqlParameter("@iMaKH", maKH));
                int kq = DungChung.executeDeleteQuery(query, SqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "Xóa thành công");

                return (kq, "Xóa thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_id(int iMaKH)
        {
            try
            {
                string query = "lay_khach_hang_theo_id";
                List<SqlParameter> SqlParameters = new List<SqlParameter>();
                SqlParameters.Add(new SqlParameter("@iMaKH", iMaKH));
                DataTable kq = DungChung.executeSelectQuery(query, SqlParameters.ToArray());

                if (kq != null)
                    return (kq, "Lấy thành công");

                return (kq, "Lấy thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) tim_kiem(string sTenKH, string sDiaChi, string sSDT, bool? bGioiTinh)
        {
            try
            {
                string query = "proc_timkiemKH";
                List<SqlParameter> SqlParameters = new List<SqlParameter>();
                SqlParameters.Add(new SqlParameter("@sTenKH", sTenKH));
                SqlParameters.Add(new SqlParameter("@sDiachi", sDiaChi));
                SqlParameters.Add(new SqlParameter("@sDienthoai", sSDT));
                SqlParameters.Add(new SqlParameter("@bGioiTinh", bGioiTinh));
                DataTable kq = DungChung.executeSelectQuery(query, SqlParameters.ToArray());

                if (kq != null)
                    return (kq, "Lấy thành công");

                return (kq, "Lấy thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }
    }
}
