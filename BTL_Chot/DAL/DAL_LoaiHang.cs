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
    class DAL_LoaiHang
    {
        private DungChung DungChung;

        public DAL_LoaiHang()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string query = "lay_ds_loaiHang";
                DataTable kq = DungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "Lấy danh sách loại hàng thành công");

                return (kq, "Lấy danh sách loại hàng thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string sMaLH)
        {
            try
            {
                string query = "kiem_tra_ma_loai_hang_ton_tai";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaLH", sMaLH));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy thông tin loại hàng thành công");

                return (kq, "Lấy thông tin loại hàng thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(LoaiHang loaiHang)
        {
            try
            {
                string query = "them_loai_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaLH", loaiHang.SMaLH));
                sqlParameters.Add(new SqlParameter("@sTenLH", loaiHang.STenLH));
                int kq = DungChung.executeInsertQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Thêm loại hàng thành công");

                return (kq, "Thêm loại hàng thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(LoaiHang loaiHang)
        {
            try
            {
                string query = "sua_loai_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaLH", loaiHang.SMaLH));
                sqlParameters.Add(new SqlParameter("@sTenLH", loaiHang.STenLH));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Sửa loại hàng thành công");

                return (kq, "Sửa loại hàng thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(string sMaLH)
        {
            try
            {
                string query = "xoa_loai_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaLH", sMaLH));
                int kq = DungChung.executeDeleteQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Xóa loại hàng thành công");

                return (kq, "Xóa loại hàng thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }
    }
}
