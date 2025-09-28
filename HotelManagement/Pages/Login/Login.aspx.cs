using HotelManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using HotelManagement.DAL.Utility;

namespace HotelManagement.Pages.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Label lblMsg;
        protected global::System.Web.UI.WebControls.TextBox txtUsername;
        protected global::System.Web.UI.WebControls.TextBox txtPassword;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMsg.Text = "Enter username and password.";
                return;
            }

            string hashed = Utils.ComputeSha256Hash(password);

            string sql = "SELECT UserID, Role FROM Users WHERE Username=@u AND PasswordHash=@p";
            SqlParameter[] ps = {
                new SqlParameter("@u", username),
                new SqlParameter("@p", hashed)
            };

            DataTable dt = DataAccess.ExecuteSelect(sql, ps);
            if (dt.Rows.Count == 1)
            {
                Session["Username"] = username;
                Session["UserID"] = dt.Rows[0]["UserID"];
                Session["Role"] = dt.Rows[0]["Role"];
                Response.Redirect("~/Pages/Dashboard/Dashboard.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid credentials.";
            }
        }
    }
  }