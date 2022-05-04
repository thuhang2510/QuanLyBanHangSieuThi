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
    class DAL_TaiKhoan
    {
        private DungChung DungChung;

        public DAL_TaiKhoan()
        {
            DungChung = new DungChung();
        }

        public (string , string) dangNhap(TaiKhoan taiKhoan)
        {
            try
            {
                string query = "layTaiKhoan";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sTenTK", taiKhoan.STenTK));
                sqlParameters.Add(new SqlParameter("@sMatKhau", taiKhoan.SMatKhau));

                DataTable kq = DungChung.executeSelectQuery(query, sqlParameters.ToArray());

                if (kq.Rows.Count > 0)
                    return (kq.Rows[0]["sTenTK"].ToString(), kq.Rows[0]["sMatKhau"].ToString());

                return (null, null);
            }
            catch(SqlException e)
            {
                return (null, null);
            }
        }

        public (int, string) update(TaiKhoan taiKhoan)
        {
            try
            {
                string query = "doimatkhau";
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@sTenTK", taiKhoan.STenTK));
                sqlParameters.Add(new SqlParameter("@sMatKhau", taiKhoan.SMatKhau));

                int kq = DungChung.executeUpdateQuery(query, sqlParameters.ToArray());

                if (kq > 0)
                    return (kq, "update thành công");

                return (kq, "update thất bại");
            }
            catch (SqlException e)
            {
                return (-1, e.Message);
            }
        }
    }
}
