<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="HotelManagement.Pages.Dashboard.Dashboard" %>
<!DOCTYPE html>
<html><head runat="server"><title>Dashboard</title>
    <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
      </head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h2>Hotel Dashboard</h2>
           <div class="dashboard-user">Welcome: <asp:Label ID="lblUser" runat="server"  /></div> 
            <br />
            <a href="../Guest/GuestForm.aspx">Manage Guests</a>
            <a href="../Room/RoomForm.aspx">Manage Rooms</a>
            <a href="../Booking/BookingForm.aspx">Create Booking</a>
            <a href="../Service/ServiceForm.aspx">Add Service</a>
            <a href="../ViewBookings/ViewBookings.aspx">View Bookings</a>
            <a href="../Logout/Logout.aspx">Logout</a>
        </div>
    </form>
</body>
</html>
