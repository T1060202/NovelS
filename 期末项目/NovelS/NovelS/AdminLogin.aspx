<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="NovelS.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style>
        #adminlogon{
                position:absolute;
                top:200px;
                left:460px;
                background-color:#dbd4d4;
                width:500px;
                height:300px;
                font-weight:800;
        }
        #Label1{
            position:relative;
            top:30px;
            left:130px;
            font-size:40px;
            color:red;
            font-family:华文行楷;
        }
        #adminAcc{
            position:relative;
            top:50px;
            left:60px;
        }
        #adminPass{
            position:relative;
            top:60px;
            left:60px;
        }
        #test{
            position:relative;
            top:40px;
            left:60px;
        }
        #Image2{
            position:relative;
            top:14px;
        }
        #Button1{
            position:relative;
            top:50px;
            left:120px;
            font-size:18px;
            font-weight:600;
            width:80px;
        }
        #Button2{
            position:relative;
            top:50px;
            left:150px;
            font-size:18px;
            font-weight:600;
            width:80px;
        }
    </style>

</head>
<body style="background-color:#93e0f5;">
    <form id="form1" runat="server">
         <div id="adminlogon" >
             <div ><asp:Label ID="Label1" runat="server" Text="管理员登录"></asp:Label> </div>
            <div id="adminAcc">管理员账号：<asp:TextBox ID="AdminName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="AdminName" EnableClientScript="false" ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空"></asp:RequiredFieldValidator>
            </div><br />
            <div id="adminPass">管理员密码：<asp:TextBox ID="AdminPwd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="AdminPwd" EnableClientScript="false" ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
           </div><br />
            <div id="test">验证码：<asp:TextBox ID="Code" runat="server"></asp:TextBox>
                <asp:Image ID="Image2" runat="server" src="Code.aspx"/>
                <asp:RequiredFieldValidator ControlToValidate="Code" EnableClientScript="false" ID="RequiredFieldValidator3" runat="server" ErrorMessage="验证码不能为空"></asp:RequiredFieldValidator>
            </div><br />
                    <asp:Button ID="Button1" runat="server" Text="登录"/>&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
