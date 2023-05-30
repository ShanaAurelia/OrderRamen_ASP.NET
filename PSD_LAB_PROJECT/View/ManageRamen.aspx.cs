using PSD_LAB_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = "";

            if (Request.Cookies.Equals("check_cookie"))
            {
                HttpCookie check_cookie = Request.Cookies["user_cookie"];
                username = check_cookie["username"].ToString();
            }
            if (Session["username_session"] != null)
            {
                username = Session["username_session"].ToString();
            }
            else
            {
                Response.Redirect("~/View/Login.aspx");
            }

            string userRole = UserController.validateUserRole(username);


            if (userRole.Equals("Customer"))
            {
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
                manage_rmn_btn.Attributes["style"] = "visibility: visible";
                order_queue_btn.Attributes["style"] = "visibility: visible";
                profile_btn.Attributes["style"] = "visibility: visible";
                history_btn.Attributes["style"] = "visibility: visible";
                report_btn.Attributes["style"] = "visibility: visible";
                logout_btn.Attributes["style"] = "visibility: visible";
            }

        }


    }
}