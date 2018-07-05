using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.DAL
{
    public class Sql
    {
        private static string conString = ConfigurationManager.ConnectionStrings["NovelDB"].ConnectionString;
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static SqlCommand GetCommand(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand com = new SqlCommand(sql, con);
            if (isProc)
            {
                com.CommandType = CommandType.StoredProcedure; //指定 com的类型为存储过程
            }
            if (paras.Length > 0)
            {
                com.Parameters.AddRange(paras);  //将参数加入com的参数集合
            }
            return com;

        }
        /// <summary>
        /// 能执行修改，删除，添加
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlCommand command = GetCommand(sql, isProc, paras);
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                SetLog(ex);
                throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable SelectTable(string sql, bool isProc = false, params SqlParameter[] paras)
        {

            //SqlConnection con = new SqlConnection(conString);
            SqlCommand com = GetCommand(sql, isProc, paras);
            SqlDataAdapter dt = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            try
            {
                com.Connection.Open();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                SetLog(ex);
                throw ex;
            }
            finally
            {
                com.Connection.Close();
            }

        }
        private static void SetLog(Exception ex)
        {
            string path = "sqlException.txt";
            File.AppendAllText(path, $"================={DateTime.Now}==========");
            File.AppendAllText(path, $"Source:{ex.Source}");
            File.AppendAllText(path, $"message:{ex.Message}");
            File.AppendAllText(path, $"=========================end=====================");
        }
    }
}
