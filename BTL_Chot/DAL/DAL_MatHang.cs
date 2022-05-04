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
    class DAL_MatHang
    {
        private DungChung DungChung;

        public DAL_MatHang()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string query = "lay_ds_mathang";
                DataTable kq = DungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "lấy danh sách mặt hàng thành công");

                return (kq, "lấy danh sách mặt hàng thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(MatHang matHang)
        {
            try
            {
                string query = "them_mat_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaHang", matHang.SMaHang));
                sqlParameters.Add(new SqlParameter("@sTenHang", matHang.STenHang));
                sqlParameters.Add(new SqlParameter("@sTenNCC", matHang.STenNCC));
                sqlParameters.Add(new SqlParameter("@sMaLH", matHang.SMaLH));
                sqlParameters.Add(new SqlParameter("@fSoLuong", matHang.FSoLuong));
                sqlParameters.Add(new SqlParameter("@fGiaHang", matHang.FGiaHang));
                int kq = DungChung.executeInsertQuery(query, sqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "Thêm thành công");

                return (kq, "Thêm thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(MatHang matHang)
        {
            try
            {
                string query = "sua_mat_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaHang", matHang.SMaHang));
                sqlParameters.Add(new SqlParameter("@sTenHang", matHang.STenHang));
                sqlParameters.Add(new SqlParameter("@sTenNCC", matHang.STenNCC));
                sqlParameters.Add(new SqlParameter("@sMaLH", matHang.SMaLH));
                sqlParameters.Add(new SqlParameter("@fSoLuong", matHang.FSoLuong));
                sqlParameters.Add(new SqlParameter("@fGiaHang", matHang.FGiaHang));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "Sửa thành công");

                return (kq, "Sửa thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(string sMaHang)
        {
            try
            {
                string query = "xoa_mat_hang";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaHang", sMaHang));
                int kq = DungChung.executeDeleteQuery(query, sqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "Xóa thành công");

                return (kq, "Xóa thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_id(string sMaHang)
        {
            try
            {
                string query = "lay_mat_hang_id";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sMaHang", sMaHang));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray());

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
