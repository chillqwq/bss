<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="出账管理.aspx.cs" Inherits="Admin_出账管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin: 25px auto; text-align: center">
        <table>
            <tr>
                <td width="50%" valign="top">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="5" HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#D3D7E2" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#D3D7E2" />
                    </asp:GridView>
                </td>
                <td width="50%" valign="top">
                    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="5" HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#ffcc33" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#D3D7E2" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#D3D7E2" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td width="20%" align="center">
                    <asp:Label ID="Labe1" runat="server" BackColor="White" Height="24px" Text="图书销售总额" Width="130px" ForeColor="Coral"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Labe2" runat="server" BackColor="White" Height="24px" Text="图书进货支出" Width="130px" ForeColor="Coral"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
        
          <asp:Label ID="Labe3" runat="server" BackColor="White" Height="24px" Text="图书退货收入" Width="130px" ForeColor="Coral"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
       
          <asp:Label ID="Labe4" runat="server" BackColor="White" Height="24px" Text="图书退货亏损" Width="130px" ForeColor="Coral"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
        
          <asp:Label ID="Labe5" runat="server" BackColor="White" Height="24px" Text="图书销售盈利" Width="130px" ForeColor="Coral"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td width="20%" align="center">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Height="24px" Width="130px" ForeColor="Black"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label2" runat="server" BackColor="White" Height="24px" Width="130px" ForeColor="Black"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label3" runat="server" BackColor="White" Height="24px" Width="130px" ForeColor="Black"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label4" runat="server" BackColor="White" Height="24px" Width="130px" ForeColor="Black"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label5" runat="server" BackColor="White" Height="24px" Width="130px" ForeColor="Black"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;     
                </td>
            </tr>
        </table>

        <asp:Button ID="button1" runat="server" Text="查询" Width="60px"
            CssClass="style2" OnClick="button1_Click" BackColor="#FFFFCC"
            BorderStyle="None" ForeColor="#FF7F50" Height="23px" />
        <br />
    </div>
</asp:Content>
