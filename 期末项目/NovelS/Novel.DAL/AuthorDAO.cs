using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using User.DAL;

namespace Novel.DAL
{
    public class AuthorDAO
    {
        public static bool GetALogin(Authors authors)
        {
            string sql = $"select * from AuthorInfo where Account={authors.Account}and Pwd={authors.Pwd}";
            DataTable table = Sql.SelectTable(sql);
            return table.Rows.Count == 1;
        }
        public static List<Authors> GetPage(int pageCount, int pgIndex)
        {
            List<Authors> Auts = new List<Authors>();
            string sql = $"select top({pageCount}) * from AuthorInfo where AuthorId not in(select top(({pgIndex}-1)*{pageCount})AuthorId from AuthorInfo) ";
            DataTable table = Sql.SelectTable(sql);
            foreach (DataRow row in table.Rows)
            {
                Authors Aut = new Authors();
                Aut.AuthorId = (int)row["AuthorId"];
                Aut.Account = row["Account"].ToString();
                Aut.Author = row["Author"].ToString();
                Aut.Pwd = row["Pwd"].ToString();
                Auts.Add(Aut);
            }
            return Auts;
        }

        public static List<Authors> GetName(string txt)
        {
            List<Authors> Auts = new List<Authors>();
            string sql = $"select * from AuthorInfo where Author='{txt}'";
            DataTable table = Sql.SelectTable(sql);//执行sql得到数据;
            foreach (DataRow row in table.Rows)
            {
                Authors Aut = new Authors();
                Aut.AuthorId = (int)row["AuthorId"];
                Aut.Account = row["Account"].ToString();
                Aut.Author = row["Author"].ToString();
                Aut.Pwd = row["Pwd"].ToString();
                Auts.Add(Aut);
            }
            return Auts;
        }

        public static int GetNCount(string txt)
        {
            string sql = $"select [count]=COUNT(*) from AuthorInfo where Author='{txt}'";
            DataTable table = Sql.SelectTable(sql);
            return (int)table.Rows[0][0];
        }

        public static int GetCount()
        {
            string sql = "select [count]=COUNT(*) from AuthorInfo";
            DataTable table = Sql.SelectTable(sql);
            return (int)table.Rows[0][0];
        }

        public static void Delete(int id)
        {
            string sql = $"delete AuthorInfo where AuthorId ={id}";
            Sql.ExecuteNonQuery(sql);
        }
    }
}
