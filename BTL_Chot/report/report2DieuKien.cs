using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_Chot.BLL;

namespace BTL_Chot.report
{
    public partial class report2DieuKien : Form
    {
        public report2DieuKien()
        {
            InitializeComponent();
        }

        private void layDSNV()
        {
            BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
            cbTenNV.DataSource = bLL_NhanVien.get_all_have_description().Item1;
            cbTenNV.DisplayMember = "Description";
            cbTenNV.ValueMember = "iMaNV";
            cbTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTenNV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void report2DieuKien_Load(object sender, EventArgs e)
        {
            layDSNV();
            taidulieu();
        }

        private void taidulieu()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = "laynhanvienvahoadon";
                sqlDataAdapter.SelectCommand.Connection = conn;
                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không thể lấy dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private DataTable locDuLieu()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.CommandText = "doanhThuNVTheoNgay";
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@iMaNV", cbTenNV.SelectedValue.ToString());
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dNgayNhapMin", dateTimeMin.Value);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dNgayNhapMax", dateTimeMax.Value);
            sqlDataAdapter.SelectCommand.Connection = conn;
            sqlDataAdapter.Fill(dt);
            conn.Close();

            return dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = locDuLieu();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            gui_report2dieukien gui_Report2Dieukien = new gui_report2dieukien(int.Parse(cbTenNV.SelectedValue.ToString()), dateTimeMin.Value, dateTimeMax.Value);
            gui_Report2Dieukien.Show();
        }
    }
}
