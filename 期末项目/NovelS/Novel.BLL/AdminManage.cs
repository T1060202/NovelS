using Model;
using Novel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novel.BLL
{
    public class AdminManage
    {
        public static bool GetALogin(Admins admins)
        {
            return AdminDAO.GetALogin(admins);
        }
    }
}
