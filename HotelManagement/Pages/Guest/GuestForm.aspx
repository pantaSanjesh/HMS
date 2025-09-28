<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestForm.aspx.cs" Inherits="HotelManagement.GuestForm" %>
<!DOCTYPE html>
<html><head runat="server"><title>Guests</title>
       <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
   

      </head>
<body>
  <form id="form2" runat="server">
    <div class="guest-form-container">
        <h3>Add Guest</h3>

        <label for="txtName">Name:</label>
        <asp:TextBox ID="txtName" runat="server" />

        <label for="ddlGender">Gender:</label>
        <asp:DropDownList ID="ddlGender" runat="server">
            <asp:ListItem Text="Female" />
            <asp:ListItem Text="Male" />
            <asp:ListItem Text="Other" />
        </asp:DropDownList>

        <label for="txtAddress">Address:</label>
        <asp:TextBox ID="txtAddress" runat="server" />

        <label for="txtPhone">Phone:</label>
        <asp:TextBox ID="txtPhone" runat="server" />

        <label for="txtEmail">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server" />

        <asp:Button ID="btnAdd" runat="server" Text="Add Guest" CssClass="aspNet-Button" OnClick="btnAdd_Click" />
        <asp:Label ID="lblMsg" runat="server" CssClass="message" ForeColor="Green" />
    </div>
</form>

</body>
</html>
