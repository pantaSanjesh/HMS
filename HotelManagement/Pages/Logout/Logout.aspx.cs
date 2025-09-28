using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("/");
        }
    }
}