using HotelManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class GuestForm : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Label lblMsg;
        protected global::System.Web.UI.WebControls.TextBox txtName;
        protected global::System.Web.UI.WebControls.TextBox txtAddress;
        protected global::System.Web.UI.WebControls.TextBox txtPhone;
        protected global::System.Web.UI.WebControls.TextBox txtEmail;
        protected global::System.Web.UI.WebControls.DropDownList ddlGender;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null) Response.Redirect("Login.aspx");
            lblMsg.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Guests(Name, Gender, Address, PhoneNumber, Email)
                           VALUES(@name,@gender,@addr,@phone,@email)";
            SqlParameter[] ps = {
                new SqlParameter("@name", txtName.Text.Trim()),
                new SqlParameter("@gender", ddlGender.SelectedValue),
                new SqlParameter("@addr", txtAddress.Text.Trim()),
                new SqlParameter("@phone", txtPhone.Text.Trim()),
                new SqlParameter("@email", txtEmail.Text.Trim())
            };
            int rows = DataAccess.ExecuteNonQuery(sql, ps);
            if (rows > 0) lblMsg.Text = "Guest added successfully.";
        }
    }
}