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
    class DAL_HoaDonNhap
    {
        private DungChung dungChung;

        public DAL_HoaDonNhap()
        {
            dungChung = new DungChung();
        }

        public (int, string) create(HoaDonNhap hoaDonNhap)
        {
            try
            {
                string query = "them_hoaDonNhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", hoaDonNhap.ISoHD));
                sqlParameters.Add(new SqlParameter("@iMaNV", hoaDonNhap.IMaNV));
                sqlParameters.Add(new SqlParameter("@dNgaynhaphang", hoaDonNhap.DNgaynhaphang));
                int kq = dungChung.executeInsertQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Thêm hóa đơn nhập thành công");

                return (kq, "Thêm hóa đơn nhập thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(HoaDonNhap hoaDonNhap)
        {
            try
            {
                string query = "sua_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", hoaDonNhap.ISoHD));
                sqlParameters.Add(new SqlParameter("@iMaNV", hoaDonNhap.IMaNV));
                sqlParameters.Add(new SqlParameter("@dNgaynhaphang", hoaDonNhap.DNgaynhaphang));
                int kq = dungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Sửa hóa đơn nhập thành công");

                return (kq, "Sửa hóa đơn thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int iSoHD)
        {
            try
            {
                string query = "xoa_hoa_don_nhap";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                int kq = dungChung.executeDeleteQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Xóa hóa đơn nhập thành công");

                return (kq, "Xóa hóa đơn nhập thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string query = "lay_ds_hoaDonNhap";
                DataTable kq = dungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "Lấy danh sách hóa đơn nhập thành công");

                return (null, "Lấy danh sách hóa đơn nhập thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string maNV, DateTime? ngaylap)
        {
            try
            {
                string query = "proc_timkiemHD";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", maNV));
                sqlParameters.Add(new SqlParameter("@dNgayLap", ngaylap));

                DataTable kq = dungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lọc thành công");

                return (kq, "Không tìm thấy dữ liệu cần lọc");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                string query = "kiem_tra_trung_soHD";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                DataTable kq = dungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lọc thành công");

                return (kq, "Không tìm thấy dữ liệu cần lọc");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }
    }
}
