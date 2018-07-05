<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorLogin.aspx.cs" Inherits="NovelS.AuthorLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             账号：<asp:TextBox ID="Account" runat="server"></asp:TextBox>
             密码：<asp:TextBox ID="Pwd" runat="server"></asp:TextBox>
            <asp:Image ID="Image2" runat="server" src="Code.aspx"/>
            验证码：<asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="登陆" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
