<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="EmployeeLayerArchitectureApp.Web.AddEmployee" %>

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
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Designation"></asp:Label>
            <asp:DropDownList ID="designationDropDownList" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" />
            <asp:TextBox ID="msgTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="closeButton" runat="server" OnClick="closeButton_Click" Text="Close" />
        </p>
    </form>
</body>
</html>
