<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomForm.aspx.cs" Inherits="HotelManagement.RoomForm" %>
<!DOCTYPE html>
<html><head runat="server"><title>Rooms</title>
     <link runat="server" rel="stylesheet" type="text/css" href="~/Style/site.css" />
      </head><body>
    <form id="form1" runat="server">
   <div class="room-form-container">
        <h3>Add Room</h3>

        <label for="txtRoomNumber">Room Number:</label>
        <asp:TextBox ID="txtRoomNumber" runat="server" />

        <label for="txtRoomType">Room Type:</label>
        <asp:TextBox ID="txtRoomType" runat="server" />

        <asp:Button ID="btnAdd" runat="server" Text="Add Room" CssClass="aspNet-Button" OnClick="btnAdd_Click" />
        <asp:Label ID="lblMsg" runat="server" CssClass="message" ForeColor="Green" />
    </div>
    </form>
</body></html>
