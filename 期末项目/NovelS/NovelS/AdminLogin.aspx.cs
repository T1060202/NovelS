using Model;
using Novel.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovelS
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (Session["yzm"].ToString().ToLower() == Code.Text.ToLower())
                {
                    Admins admins = new Admins();
                    admins.AdminName = AdminName.Text;
                    admins.AdminPwd = AdminPwd.Text;
                    if (AdminManage.GetALogin(admins))
                    {

                    }
                    else
                    {
                       
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}