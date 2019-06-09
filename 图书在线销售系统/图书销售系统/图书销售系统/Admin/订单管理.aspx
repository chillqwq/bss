<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="订单管理.aspx.cs" Inherits="Admin_订单管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <div style="margin: 25px auto; text-align: center">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" HorizontalAlign="Center"
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="流水号">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="流水号" HeaderText="流水号" ReadOnly="True" />
                <asp:BoundField DataField="图书" HeaderText="ISBN" />
                <asp:BoundField DataField="书名" HeaderText="书名" ReadOnly="True" />
                <asp:BoundField DataField="会员编号" HeaderText="会员编号" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" ReadOnly="True" />
                <asp:BoundField DataField="数量" HeaderText="数量" />
                <asp:BoundField DataField="金额" HeaderText="金额" />
                <asp:BoundField DataField="积分" HeaderText="积分" />
                <asp:BoundField DataField="时间" HeaderText="时间" />
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
