<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceForm.aspx.cs" Inherits="HotelManagement.ServiceForm" %>
<!DOCTYPE html>
<html><head runat="server"><title>Service</title>
     <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
      </head>
<body>
    <form id="form1" runat="server">
        <div class="service-form-container">
        <h3>Add Service</h3>

        <label for="ddlBooking">Booking:</label>
        <asp:DropDownList ID="ddlBooking" runat="server" />

        <label for="txtServiceName">Service Name:</label>
        <asp:TextBox ID="txtServiceName" runat="server" />

        <label for="txtCost">Cost:</label>
        <asp:TextBox ID="txtCost" runat="server" />

        <asp:Button ID="btnAdd" runat="server" Text="Add Service" CssClass="aspNet-Button" OnClick="btnAdd_Click" />
        <asp:Label ID="lblMsg" runat="server" CssClass="message" ForeColor="Green" />
    </div>
    </form>
</body></html>
