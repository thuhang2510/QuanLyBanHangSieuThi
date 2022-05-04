using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Chot.DAL
{
    class DungChung
    {
        private SqlConnection conn;

        public DungChung()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private SqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Connecting)
            {
                conn.Close();
            }
            return conn;
        }

        public int executeInsertQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = conn;
                myCommand.CommandText = _query;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                conn = openConnection();
                return myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return -1;
            }
            finally
            {
                conn = closeConnection();
            }
        }

        public int executeUpdateQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = conn;
                myCommand.CommandText = _query;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                conn = openConnection();
                return myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return -1;
            }
            finally
            {
                conn = closeConnection();
            }
        }

        public int executeDeleteQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = conn;
                myCommand.CommandText = _query;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                conn = openConnection();
                return myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeDeleteQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return -1;
            }
            finally
            {
                conn = closeConnection();
            }
        }

        public DataTable executeSelectQuery(string _query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = _query;
                sqlDataAdapter.SelectCommand.Parameters.AddRange(sqlParameter);
                sqlDataAdapter.SelectCommand.Connection = openConnection();
                sqlDataAdapter.Fill(dt);

                return dt;
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn = closeConnection();
            }
        }

        public DataTable executeSelectAll(string _query)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.CommandText = _query;
                sqlDataAdapter.SelectCommand.Connection = openConnection();
                sqlDataAdapter.Fill(dt);

                return dt;
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectAll" + " \nException: \n" + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn = closeConnection();
            }
        }
    }
}
