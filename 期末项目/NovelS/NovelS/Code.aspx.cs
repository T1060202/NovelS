using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovelS
{
    public partial class Code : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJGLMNQRSTUVWXYWZ";
            //这个是用来生成验证码图片的
            Bitmap img = new Bitmap(120, 40);//创建一个80*40的图片
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, 120, 40);
            Random random = new Random();
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                s += str.Substring(random.Next(0, str.Length), 1);
            }
            g.DrawString(s, new Font("黑体", 30), new SolidBrush(Color.Aqua), 5, 3);
            Session["yzm"] = s;
            MemoryStream stream = new MemoryStream();//这是一个内存流
            img.Save(stream, ImageFormat.Jpeg);  //保存在内存流里
            Response.ContentType = "Image/Jpeg";
            Response.BinaryWrite(stream.ToArray());
            Response.End();
        }
    }
}