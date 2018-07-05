using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Novel.DAL;

namespace Novel.BLL
{
    public class AuthorManage
    {
        public static bool GetALogin(Authors authors)
        {
            return AuthorDAO.GetALogin(authors);
        }

        public static void Delete(int id)
        {
            AuthorDAO.Delete(id);
        }

        public static int GetCount()
        {
            return AuthorDAO.GetCount();
        }

        public static List<Authors> GetPage(int pageCount, int pgIndex)
        {
            return AuthorDAO.GetPage(pageCount, pgIndex);
        }

        public static int GetNCount(string txt)
        {
            return AuthorDAO.GetNCount(txt);
        }

        public static List<Authors> GetName(string txt)
        {
            return AuthorDAO.GetName(txt);
        }
    }
}
