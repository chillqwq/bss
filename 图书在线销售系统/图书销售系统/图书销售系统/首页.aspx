<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="首页.aspx.cs" Inherits="首页" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin: 25px auto; text-align:center">
        <asp:DataList ID="DataList1" runat="server" CellPadding="4"
            ForeColor="#333333" RepeatColumns="3" Style="margin: 0 auto; text-align: center;">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl='<%#Eval("图片") %>' NavigateUrl='<%#"~/图书详情.aspx?ISBN="+ Eval("ISBN") %>'>HyperLink</asp:HyperLink>
                <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("书名") %>'></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("售价") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div style="margin:100px auto;"><br /></div>
</asp:Content>

