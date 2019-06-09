<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="图书退货.aspx.cs" Inherits="Admin_图书退货" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin: 25px auto; text-align: center">
        <br>
        ISBN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;      
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>
        图书数量&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br>
        退货价格&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br>
        <br>
        <asp:Button ID="Button1" runat="server" Text="确认" Width="60px"
            CssClass="style2" OnClick="Button1_Click" BackColor="#FFFFCC"
            BorderStyle="None" ForeColor="#FF7F50" Height="30px" />
    </div>
</asp:Content>
