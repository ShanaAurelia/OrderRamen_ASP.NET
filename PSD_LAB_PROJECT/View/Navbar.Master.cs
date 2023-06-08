using PSD_LAB_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           HttpCookie currCookie = Request.Cookies["user_cookie"];

            string curr_username = "";

            // reading from cookies and session for user info
            if (currCookie != null)
            {
                HttpCookie check_cookie = Request.Cookies["user_cookie"];
                curr_username = check_cookie["username"];
            }
            else if (Session["username_session"] != null)
            {
                curr_username = Session["username_session"].ToString();
            }
            if (curr_username.Equals(""))
            {
                Response.Redirect("~/View/Login.aspx");
            }

            string userRole = UserController.validateUserRole(curr_username);

            if (userRole.Equals("Customer"))
            {
                home_btn.Attributes["style"] = "visibility: visible";
                order_rmn_btn.Attributes["style"] = "visibility: visible";
                history_btn.Attributes["style"] = "visibility: visible";
                profile_btn.Attributes["style"] = "visibility: visible";
                logout_btn.Attributes["style"] = "visibility: visible";
            }
            if (userRole.Equals("Staff"))
            {
                home_btn.Attributes["style"] = "visibility: visible";
                manage_rmn_btn.Attributes["style"] = "visibility: visible";
                order_queue_btn.Attributes["style"] = "visibility: visible";
                profile_btn.Attributes["style"] = "visibility: visible";
                logout_btn.Attributes["style"] = "visibility: visible";
            }
            if (userRole.Equals("Admin"))
            {
                home_btn.Attributes["style"] = "visibility: visible";
                manage_rmn_btn.Attributes["style"] = "visibility: visible";
                order_queue_btn.Attributes["style"] = "visibility: visible";
                profile_btn.Attributes["style"] = "visibility: visible";
                history_btn.Attributes["style"] = "visibility: visible";
                report_btn.Attributes["style"] = "visibility: visible";
                logout_btn.Attributes["style"] = "visibility: visible";
                order_rmn_btn.Attributes["style"] = "visibility: visible";
            }
        
    }
        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }

        protected void manage_rmn_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen.aspx");
        }

        protected void home_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/home.aspx");
        }

        protected void profile_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void order_rmn_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/orderRamen.aspx");
        }
    }
}