using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    class SQLHelper
    {
        //public static readonly string connStr = System.Configuration.ConfigurationSettings.AppSettings["dbconnstr"];
        //获得连接字符串
        //public static readonly string connStr =
        //    ConfigurationManager.ConnectionStrings["dbconnstr"].ConnectionString;
        public static readonly string connStr = @"server=106.15.73.184 ;uid = User_test1; pwd = Usertest1; database = 医院信息系统;";
        /// <summary>
        /// 执行方法ExecuteNonQuery
        /// </summary>
        /// <param name="cmdText">要执行的sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>受影响的行数</returns>
        /// 执行非查询语句（增删改）
        public static int ExecuteNonQuery(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }

        /// <summary>
        /// 执行ExecuteScalar() 返回第一行第一列数据
        /// </summary>
        /// <param name="cmdText">要执行的sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>返回第一行第一列数据</returns>
        /// 查询结果集里的第一个单元格的值（单个值）
        public static object ExecuteScalar(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 执行ExecuteDataTable（）方法
        /// </summary>
        /// <param name="cmdText">要执行的Sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>返回一个DataTable</returns>
        /// 执行查询多行语句 - 返回数据表
        public static DataTable ExecuteDataTable(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 执行ExecuteSqlDataReader()方法
        /// </summary>
        /// <param name="cmdText">要执行的Sql语句</param>
        /// <param name="parameters">参数数组</param>
        /// <returns>返回一个SqlDataReader</returns>

        public static SqlDataReader ExecuteSqlDataReader(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteReader();
                }
            }
        }
    }
}