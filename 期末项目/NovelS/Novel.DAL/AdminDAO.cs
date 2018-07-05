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
    public class AdminDAO
    {
        public static bool GetALogin(Admins admins)
        {
            string sql = $"select * from [Admin] where AdminName={admins.AdminName}and AdminPwd={admins.AdminPwd}";
            DataTable table = Sql.SelectTable(sql);
            return table.Rows.Count == 1;
        }
    }
}
