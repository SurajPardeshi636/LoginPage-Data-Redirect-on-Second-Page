<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPageWithData.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="User Name is required" ControlToValidate="UserName"></asp:RequiredFieldValidator>--%>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required" ControlToValidate="Password"></asp:RequiredFieldValidator>--%>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="LoginButton_Click" />
<%--            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />--%>
        </div>
    </form>
</body>
</html>
