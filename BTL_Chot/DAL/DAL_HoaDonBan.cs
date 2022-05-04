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
    class DAL_HoaDonBan
    {
        private DungChung DungChung;

        public DAL_HoaDonBan()
        {
            DungChung = new DungChung();
        }

        public (DataTable, string) get_all()
        {
            try
            {
                string query = "lay_ds_hdBan";
                DataTable kq = DungChung.executeSelectAll(query);

                if (kq != null)
                    return (kq, "Lấy danh sách hóa đơn thành công");

                return (kq, "Lấy danh sách hóa đơn thất bại");
            }
            catch(SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (int, string) create(HoaDonBan hoaDonBan)
        {
            try
            {
                string query = "them_hd_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", hoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@iMaNV", hoaDonBan.IMaNV));
                sqlParameters.Add(new SqlParameter("@iMaKH", hoaDonBan.IMaKH));
                sqlParameters.Add(new SqlParameter("@dNgaymuahang", hoaDonBan.DNgayLap));
                int kq = DungChung.executeInsertQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Thêm hóa đơn bán thành công");

                return (kq, "Thêm hóa đơn bán thất bại");
            }
            catch(SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) update(HoaDonBan hoaDonBan)
        {
            try
            {
                string query = "sua_hd_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", hoaDonBan.ISoHD));
                sqlParameters.Add(new SqlParameter("@iMaNV", hoaDonBan.IMaNV));
                sqlParameters.Add(new SqlParameter("@iMaKH", hoaDonBan.IMaKH));
                sqlParameters.Add(new SqlParameter("@dNgaymuahang", hoaDonBan.DNgayLap));
                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Sửa hóa đơn bán thành công");

                return (kq, "Sửa hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (int, string) delete(int iSoHD)
        {
            try
            {
                string query = "xoa_hd_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                int kq = DungChung.executeDeleteQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq > 0)
                    return (kq, "Xóa hóa đơn bán thành công");

                return (kq, "Xóa hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }

        public (DataTable, string) get_by_query(string maNV, string maKH, DateTime? ngayLap)
        {
            try
            {
                string query = "tim_kiem_cua_hd_ban";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iMaNV", maNV));
                sqlParameters.Add(new SqlParameter("@iMaKH", maKH));
                sqlParameters.Add(new SqlParameter("@dNgayLap", ngayLap));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Tìm kiếm hóa đơn bán thành công");

                return (kq, "Tìm kiếm hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }

        public (DataTable, string) get_by_id(int iSoHD)
        {
            try
            {
                string query = "lay_mot_hd_theo_id";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@iSoHD", iSoHD));
                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray<SqlParameter>());

                if (kq != null)
                    return (kq, "Lấy một hóa đơn bán thành công");

                return (kq, "Lấy một hóa đơn bán thất bại");
            }
            catch (SqlException e)
            {
                return (null, e.Message);
            }
        }
    }
}
