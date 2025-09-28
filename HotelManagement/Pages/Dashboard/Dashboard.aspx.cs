using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Pages.Dashboard
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Label lblUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            lblUser.Text = Session["Username"].ToString();
        }
    }
}