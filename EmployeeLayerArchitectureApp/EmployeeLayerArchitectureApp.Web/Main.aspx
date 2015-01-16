<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="EmployeeLayerArchitectureApp.Web.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="addEmployeeButton" runat="server" OnClick="addEmployeeButton_Click" Text="Add Employee" />
        <asp:Button ID="addDesignationButton" runat="server" OnClick="addDesignationButton_Click" Text="Add Designation" />
        <asp:Button ID="FindAndEditButton" runat="server" OnClick="FindAndEditButton_Click" Text="Find And Edit" />
    
    </div>
    </form>
</body>
</html>
