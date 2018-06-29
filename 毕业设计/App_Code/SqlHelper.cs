using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// 封装数据库的增删改查
/// </summary>
public static class SqlHelper
{
    //public SqlHelper()
    //{
    //    //
    //    // TODO: 在此处添加构造函数逻辑
    //    //
    //}
    private static readonly string constr = ConfigurationManager.ConnectionStrings["mssqlsever"].ConnectionString;
    /// <summary>
    /// 增删改
    /// </summary>
    /// <param name="SQL查询语句"></param>
    /// <param name="参数数组"></param>
    /// <returns></returns>
    public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
    /// <summary>
    ///   查，返回单个值
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="pms"></param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                con.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
    /// <summary>
    /// 查，返回多行多列
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="pms"></param>
    /// <returns></returns>
    public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
    {
        SqlConnection con = new SqlConnection(constr);
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
            cmd.CommandType = cmdType;
            if (pms != null)
            {
                cmd.Parameters.AddRange(pms);
            }
            try
            {
                con.Open();
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch
            {
                con.Close();
                con.Dispose();
                throw; //把异常抛上去，把异常上报。
            }
        }
    }

    /// <summary>
    /// 封装DataTable，使用dataAdapter
    /// </summary>
    /// <param name="SQL查询语句"></param>
    /// <param name="参数数组"></param>
    /// <returns></returns>
    public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
    {
        DataTable dt = new DataTable();
        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, constr))
        {
            adapter.SelectCommand.CommandType = cmdType;
            if (pms != null)
            {
                adapter.SelectCommand.Parameters.AddRange(pms);
            }
            adapter.Fill(dt);
        }
        return dt;
    }




    public static DataRow ExecuteDataSet(string sql, CommandType cmdType, params SqlParameter[] pms)
    {
        DataSet ds = new DataSet();
        using (SqlConnection con = new SqlConnection(constr))
        {

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    //adapter.SelectCommand.CommandType = cmdType;
                    //if (pms != null)
                    //{
                    //    adapter.SelectCommand.Parameters.AddRange(pms);
                    //}
                    con.Open();
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                        return ds.Tables[0].Rows[0];
                    else
                        return null;
                }

            }
        }
    }





    public static int Login_customized(string sql, CommandType cmdType, string loginPwd, params SqlParameter[] pms)
    {
        int r = -1;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            string Pwd = reader.GetString(2);
                            if (Pwd == loginPwd)
                            {
                                r = 0;
                                //name = reader.GetString(1);
                            }
                            else
                            {
                                r = 1;
                            }
                        }
                    }
                    else
                    {
                        r = 2;
                    }
                }
            }
        }
        return r;
    }










}