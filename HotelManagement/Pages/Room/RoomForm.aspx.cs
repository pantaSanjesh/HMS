using HotelManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HotelManagement
{
    public partial class RoomForm : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Label lblMsg;
        protected global::System.Web.UI.WebControls.TextBox txtRoomNumber;
        protected global::System.Web.UI.WebControls.TextBox txtRoomType;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            lblMsg.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Rooms(RoomNumber, RoomType) VALUES(@rn,@rt)";
            SqlParameter[] ps = {
                new SqlParameter("@rn", txtRoomNumber.Text.Trim()),
                new SqlParameter("@rt", txtRoomType.Text.Trim())
            };
            int rows = DataAccess.ExecuteNonQuery(sql, ps);
            if (rows > 0) lblMsg.Text = "Room added.";
        }
    }
}