<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite1.Master" AutoEventWireup="true" CodeBehind="AuthorMa.aspx.cs" Inherits="NovelS.AuthorMa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="position:relative;left:700px;top:20px;">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" />
    </div>
    <div style="width:800px;height:300px; margin:auto;background-color:aquamarine;position:relative;top:50px;">
        <div style="position:relative;left:200px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="作者编号" SortExpression="AuthorId"></asp:BoundField>
                <asp:BoundField DataField="Author" HeaderText="作者姓名" SortExpression="Author"></asp:BoundField>
                <asp:BoundField DataField="Account" HeaderText="作者账号" SortExpression="Account"></asp:BoundField>
                <asp:BoundField DataField="Pwd" HeaderText="作者密码" SortExpression="Pwd"></asp:BoundField>

                <asp:ButtonField CommandName="Delete" Text="删除" ShowHeader="True" HeaderText="删除"></asp:ButtonField>

                <asp:ButtonField CommandName="Update" Text="修改" ShowHeader="True" HeaderText="修改"></asp:ButtonField>
            </Columns>
        </asp:GridView>
            <label>总条数：<%=Count%></label>
        <%
            int statui = 1;//开始
            int endi = 1; //结束
            if (pgIndex<=7/2)
            {
                statui = 1;   //开始当前 小于一半的时候从1开始
                endi = pageNumber + 1 > 8 ? 8 : pageNumber + 1;
            }
            else if (pageNumber-pgIndex<7/2)
            {
                statui = pageNumber - 6>0?pageNumber - 6:1;
                endi = pageNumber + 1;
            }
            else
            {
                statui = pgIndex - 3;
                endi = pgIndex + 3;
            }
            %>

    <%for (int i = statui; i < endi; i++)
        {%>
    <%if (i==pgIndex)
        {%>
         <input type="submit" name="PageIndex" value="<%=i%>" style="background-color:#ff6a00" />
       <% } else{%>
         <input type="submit" name="PageIndex" value="<%=i%>" />
        <%}%>
    <%}%>
        </div>
    </div>
</asp:Content>
