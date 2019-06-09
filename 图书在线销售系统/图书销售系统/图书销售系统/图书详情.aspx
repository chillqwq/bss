<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="图书详情.aspx.cs" Inherits="图书详情" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style9 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
        CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="50px" Style="margin: 0 auto; text-align: center;"
        Width="286px" CssClass="style5" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center">
        <FooterStyle BackColor="#CCCC99" />
        <RowStyle BackColor="#F7F7DE" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <Fields>
            <asp:BoundField DataField="书名" HeaderText="书名" />
            <asp:ImageField HeaderText="图片" DataImageUrlField="图片">
            </asp:ImageField>
            <asp:BoundField DataField="作者" HeaderText="作者" />
            <asp:BoundField DataField="出版社" HeaderText="出版社" />
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
            <asp:BoundField DataField="售价" HeaderText="售价" />
            <asp:BoundField DataField="库存" HeaderText="库存" />
        </Fields>
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:DetailsView>

    <div style="width: 65%; margin: 25px auto; text-align: center">

        <asp:Label ID="Labe1" runat="server" BackColor="White" Height="24px" Text="付款方式" Width="100px" ForeColor="Coral"></asp:Label>

        &nbsp;&nbsp;
      
       <asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" Width="73px" Font-Bold="False" ForeColor="Coral" Height="24px">
           <asp:ListItem>现金</asp:ListItem>
           <asp:ListItem>会员卡</asp:ListItem>
       </asp:DropDownList>

        <br>
        <asp:Label ID="Label1" runat="server" BackColor="White" Height="24px" Text="数量" ForeColor="Coral" Width="100px"></asp:Label>

        &nbsp;

    <asp:TextBox ID="txtQuantity" runat="server" Width="73px"></asp:TextBox>
        <br>

        <asp:Button ID="btnshop" runat="server" Text="购买"
            OnClick="btnShop_Click" BackColor="#FFFFCC" BorderStyle="None"
            ForeColor="#FF7F50" Height="30px" />
    </div>
</asp:Content>
