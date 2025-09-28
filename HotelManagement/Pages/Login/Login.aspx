<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HotelManagement.Pages.Login.Login" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <asp:Label runat="server" Text="Username" /><br />
            <asp:TextBox ID="txtUsername" runat="server" /><br />
            <asp:Label runat="server" Text="Password" /><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
