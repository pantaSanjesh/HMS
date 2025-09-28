using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagement.DAL
{
    public static class DataAccess
    {
        private static string GetConn() => ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public static DataTable ExecuteSelect(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(GetConn()))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                da.Fill(dt);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(GetConn()))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(GetConn()))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
