<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="增加图书.aspx.cs" Inherits="Admin_增加图书" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin: 25px auto; text-align: center">
        <br>
        ISBN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>
        书名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;    
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br>
        作者&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;    
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br>
        出版社&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;  
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br>
        进价&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br>
        售价&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br>
        图书数量&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br>
        图片&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;     
         <asp:FileUpload ID="FileUpload1" runat="server" Width="180px" />
        <br>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br>
        <asp:Button ID="Button1" runat="server" Text="确认" Width="60px"
            CssClass="style2" OnClick="Button1_Click" BackColor="#FFFFCC"
            BorderStyle="None" ForeColor="#FF7F50" Height="28px" />
    </div>
</asp:Content>
