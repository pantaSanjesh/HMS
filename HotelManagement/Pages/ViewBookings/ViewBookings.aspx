<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBookings.aspx.cs" Inherits="HotelManagement.ViewBookings" %>
<!DOCTYPE html>
<html><head runat="server"><title>View Bookings</title>
         <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
      </head>
<body>
    <form id="form1" runat="server">
        <div class ="booking-grid-container">
            <h3>Bookings</h3>
            <asp:GridView ID="gvBookings" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body></html>
