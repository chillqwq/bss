<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="我的信息.aspx.cs" Inherits="我的信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 65%; margin: 25px auto; text-align: center">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333"
            GridLines="None" AutoGenerateColumns="False" Style="margin: 0 auto; text-align: center;"
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="编号" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="密码" HeaderText="密码" />
                <asp:BoundField DataField="身份证" HeaderText="身份证" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" />
                <asp:BoundField DataField="是否挂失" HeaderText="是否挂失" />
                <asp:BoundField DataField="积分" HeaderText="积分" ReadOnly="True" />
                <asp:BoundField DataField="会员等级" HeaderText="会员等级" ReadOnly="True" />
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
    </div>
</asp:Content>

