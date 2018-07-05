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
    public partial class AuthorLogin : System.Web.UI.Page
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
                    Authors authors = new Authors();
                    authors.Account = Account.Text;
                    authors.Pwd = Pwd.Text;
                    if (AuthorManage.GetALogin(authors))
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