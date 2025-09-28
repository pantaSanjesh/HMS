using HotelManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HotelManagement
{
        public partial class ViewBookings : System.Web.UI.Page
        {
        protected global::System.Web.UI.WebControls.GridView gvBookings;
        protected void Page_Load(object sender, EventArgs e)
            {
                if (Session["Username"] == null) Response.Redirect("Login.aspx");
                if (!IsPostBack) BindGrid();
            }

            private void BindGrid()
            {
                string sql = @"
                SELECT b.BookingID, g.Name AS GuestName, r.RoomNumber, r.RoomType,
                       b.CheckInDate, b.CheckOutDate, b.BookingStatus, b.PaymentMode,
                       ISNULL(s.ServiceList,'') AS Services
                FROM Bookings b
                JOIN Guests g ON b.GuestID = g.GuestID
                JOIN Rooms r ON b.RoomID = r.RoomID
                LEFT JOIN (
                    SELECT BookingID, STRING_AGG(ServiceName + ' (' + CAST(ServiceCost AS VARCHAR(20)) + ')', ', ') AS ServiceList
                    FROM Services
                    GROUP BY BookingID
                ) s ON s.BookingID = b.BookingID
                ORDER BY b.BookingID DESC;
            ";

                // Note: STRING_AGG requires SQL Server 2017+. Replace with subquery if older.
                DataTable dt = DataAccess.ExecuteSelect(sql);
                gvBookings.DataSource = dt;
                gvBookings.DataBind();
            }
        }
  }
