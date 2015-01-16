<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchAndEdit.aspx.cs" Inherits="EmployeeLayerArchitectureApp.Web.SearchAndEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" />
        <asp:Button ID="closeButton" runat="server" OnClick="closeButton_Click" Text="Close" />
        <br />
        <asp:GridView ID="searchGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="273px" Width="302px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        
    </div>
    </form>
</body>
</html>
