<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="会员查找.aspx.cs" Inherits="会员查找" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style2 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br>
    <div style="margin: 25px auto; text-align: center">
        <asp:TextBox ID="txtSearch" runat="server" Width="200px" CssClass="style2" BorderStyle="None"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="搜索" Width="60px"
            CssClass="style2" OnClick="btnSearch_Click" BackColor="#FFFFCC"
            BorderStyle="None" ForeColor="#FF7F50" Height="23px" />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" HorizontalAlign="Center"
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="编号">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="编号" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="密码" HeaderText="密码" />
                <asp:BoundField DataField="身份证" HeaderText="身份证" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" />
                <asp:BoundField DataField="有效期" HeaderText="有效期" />
                <asp:BoundField DataField="会员等级" HeaderText="会员等级" />
                <asp:BoundField DataField="积分" HeaderText="积分" />
                <asp:BoundField DataField="余额" HeaderText="余额" />
                <asp:BoundField DataField="是否挂失" HeaderText="是否挂失" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#D3D7E2" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#D3D7E2" />
        </asp:GridView>
        <br />
        <asp:Button ID="button1" runat="server" Text="积分提现" Width="89px"
            CssClass="style2" OnClick="button1_Click" BackColor="#FFFFCC"
            BorderStyle="None" ForeColor="#FF7F50" Height="25px" ToolTip="2级会员积分/10转为余额，3级会员积分/8转为余额，4级会员积分/5转为余额" />
    </div>
</asp:Content>
