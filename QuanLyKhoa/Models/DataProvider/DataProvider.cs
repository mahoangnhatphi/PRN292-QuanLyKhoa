using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyKhoa.Models.DataProvider
{
    public class DataProvider
    {

        private static string cnStr = ConfigurationManager.ConnectionStrings["QLSVien"].ConnectionString;

        public static DataTable ExecuteQuery(string Sql, params object[] parameters)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(Sql, cn);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public static bool ExecuteNonQuery(string Sql, params object[] parameters)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand(Sql, cn);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            bool result = cmd.ExecuteNonQuery() > 0;
            cn.Close();
            return result;
        }

        public static SqlDataReader ExecuteDataReader(string Sql, params object[] parameters)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = Sql;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}