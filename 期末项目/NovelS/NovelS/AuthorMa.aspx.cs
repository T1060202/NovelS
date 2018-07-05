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
    public partial class AuthorMa : System.Web.UI.Page
    {
        public void Saz()
        {
            PageCount = 10;
            //求多少业
            pageNumber = (Count + PageCount - 1) / PageCount;
            if (Request["Index"] != null)
            {
                pgIndex = int.Parse(Request["Index"]);
            }
            else
            {
                pgIndex = 1;
            }
        }
        public int Count;    //总条数
        public int PageCount;   //一页多少条
        public int pageNumber;  //总页数
        public int pgIndex;   //当前页数
        public string name="";
        public List<Authors> stus = new List<Authors>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //第一步 查询表中有多少条
              
                Count = AuthorManage.GetCount();
                Saz();
                //获取 数据库数据
                stus = AuthorManage.GetPage(PageCount, pgIndex);
                GridView1.DataSource = stus;     //直接绑定一个集合
                GridView1.DataBind();
                if (Request["txt"] != null)
                {
                    string txt = Request["txt"];
                    Count = AuthorManage.GetNCount(txt);
                    Saz();
                    stus = AuthorManage.GetName(txt);
                    GridView1.DataSource = stus;
                    GridView1.DataBind();
                }
            }

            else
            {
                if (Request["PageIndex"] != null)
                {
                    string index = Request["PageIndex"];
                    Response.Redirect($"AuthorMa.aspx?Index={index}");
                }

            }
           
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            AuthorManage.Delete(int.Parse(Id));
            Response.Redirect("AuthorMa.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string txt = TextBox1.Text;
            Response.Redirect($"AuthorMa.aspx?txt={txt}");
        }
    }
}