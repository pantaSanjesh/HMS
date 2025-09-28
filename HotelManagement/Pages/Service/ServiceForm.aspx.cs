using System;
using System.Data;
using System.Data.SqlClient;
using HotelManagement.DAL;

namespace HotelManagement
{
    public partial class ServiceForm : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Label lblMsg;
        protected global::System.Web.UI.WebControls.DropDownList ddlBooking;
        protected global::System.Web.UI.WebControls.TextBox txtCost;
        protected global::System.Web.UI.WebControls.TextBox txtServiceName;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) BindBookings();
        }

        private void BindBookings()
        {
            DataTable dt = DataAccess.ExecuteSelect("SELECT BookingID, BookingID FROM Bookings");
            ddlBooking.DataSource = dt;
            ddlBooking.DataTextField = "BookingID";
            ddlBooking.DataValueField = "BookingID";
            ddlBooking.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            decimal.TryParse(txtCost.Text.Trim(), out cost);

            string sql = "INSERT INTO Services(BookingID, ServiceName, ServiceCost) VALUES(@b,@s,@c)";
            SqlParameter[] ps = {
                new SqlParameter("@b", ddlBooking.SelectedValue),
                new SqlParameter("@s", txtServiceName.Text.Trim()),
                new SqlParameter("@c", cost)
            };
            int rows = DataAccess.ExecuteNonQuery(sql, ps);
            if (rows > 0) lblMsg.Text = "Service added.";
        }
    }
}
