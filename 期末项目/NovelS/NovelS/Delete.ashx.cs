using Novel.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovelS
{
    /// <summary>
    /// Delete 的摘要说明
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["Id"]);//Request请求
            AuthorManage.Delete(id);
            context.Response.Redirect("AuthorMa.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}