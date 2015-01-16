<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDesignation.aspx.cs" Inherits="EmployeeLayerArchitectureApp.Web.AddDesignation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" style="height: 26px" />
        </p>
        <p>
            <asp:TextBox   ID="msgTextBox" runat="server"></asp:TextBox>
            
        </p>
        <asp:Button ID="closeButton" runat="server" OnClick="closeButton_Click" Text="Close" />
    </form>
</body>
</html>
