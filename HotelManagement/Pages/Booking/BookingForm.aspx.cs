using HotelManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace HotelManagement
{
    public partial class BookingForm : System.Web.UI.Page
    {

        protected global::System.Web.UI.WebControls.Label lblMsg;
        protected global::System.Web.UI.WebControls.DropDownList ddlGuest;
        protected global::System.Web.UI.WebControls.DropDownList ddlRoom;
        protected global::System.Web.UI.WebControls.TextBox txtCheckIn;
        protected global::System.Web.UI.WebControls.TextBox txtCheckOut;
        protected global::System.Web.UI.WebControls.TextBox txtStatus;
        protected global::System.Web.UI.WebControls.DropDownList ddlPayment;
        protected global::System.Web.UI.WebControls.Button btnSave;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindGuests(); BindRooms();
        }

        private void BindGuests()
        {
            ddlGuest.Items.Clear();
            DataTable dt = DataAccess.ExecuteSelect("SELECT GuestID, Name FROM Guests");
            ddlGuest.DataSource = dt;
            ddlGuest.DataTextField = "Name";
            ddlGuest.DataValueField = "GuestID";
            ddlGuest.DataBind();
        }

        private void BindRooms()
        {
            ddlRoom.Items.Clear();
            DataTable dt = DataAccess.ExecuteSelect("SELECT RoomID, RoomNumber, RoomType FROM Rooms");
            ddlRoom.DataSource = dt;
            ddlRoom.DataTextField = "RoomNumber";
            ddlRoom.DataValueField = "RoomID";
            ddlRoom.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DateTime? ci = string.IsNullOrEmpty(txtCheckIn.Text) ? (DateTime?)null : DateTime.Parse(txtCheckIn.Text);
            DateTime? co = string.IsNullOrEmpty(txtCheckOut.Text) ? (DateTime?)null : DateTime.Parse(txtCheckOut.Text);

            string sql = @"INSERT INTO Bookings(GuestID, RoomID, CheckInDate, CheckOutDate, BookingStatus, PaymentMode)
                           VALUES(@g,@r,@ci,@co,@st,@pm)";
            SqlParameter[] ps = {
                new SqlParameter("@g", ddlGuest.SelectedValue),
                new SqlParameter("@r", ddlRoom.SelectedValue),
                new SqlParameter("@ci", (object)ci ?? DBNull.Value),
                new SqlParameter("@co", (object)co ?? DBNull.Value),
                new SqlParameter("@st", txtStatus.Text.Trim()),
                new SqlParameter("@pm", ddlPayment.SelectedValue)
            };
            int rows = DataAccess.ExecuteNonQuery(sql, ps);
            if (rows > 0) lblMsg.Text = "Booking saved.";
        }
    }
}