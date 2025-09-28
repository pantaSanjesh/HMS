<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingForm.aspx.cs" Inherits="HotelManagement.BookingForm" %>
<!DOCTYPE html>
<html><head runat="server"><title>Booking</title>
         <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
        <link rel="stylesheet" href="https://code.jquery.com/ui/1.13.2/themes/base/jquery-ui.css">
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="https://code.jquery.com/ui/1.13.2/jquery-ui.js"></script>
      </head><body>
   <form id="form1" runat="server">
    <div class="service-form-container">
        <h3>Create Booking</h3>

        <label for="ddlGuest">Guest:</label>
        <asp:DropDownList ID="ddlGuest" runat="server" />

        <label for="ddlRoom">Room:</label>
        <asp:DropDownList ID="ddlRoom" runat="server" />

        <label for="txtCheckIn">Check-In:</label>
       <asp:TextBox ID="txtCheckIn" runat="server" TextMode="Date" />

             <label for="txtCheckOut">Check-Out:</label>
             <asp:TextBox ID="txtCheckOut" runat="server" TextMode="Date" />

        <label for="txtStatus">Booking Status:</label>
        <asp:TextBox ID="txtStatus" runat="server" />

        <label for="ddlPayment">Payment Mode:</label>
        <asp:DropDownList ID="ddlPayment" runat="server">
            <asp:ListItem Text="Cash" />
            <asp:ListItem Text="Card" />
            <asp:ListItem Text="Online" />
        </asp:DropDownList>

        <asp:Button ID="btnSave" runat="server" Text="Save Booking" CssClass="aspNet-Button" OnClick="btnSave_Click" />
        <asp:Label ID="lblMsg" runat="server" CssClass="message" ForeColor="Green" />
    </div>
</form>


</body></html>
