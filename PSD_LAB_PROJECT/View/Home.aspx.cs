using PSD_LAB_PROJECT.Controller;
using PSD_LAB_PROJECT.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string role = "";
                if (Response.Cookies.Equals("user_cookie"))
                {
                    HttpCookie check_cookie = Request.Cookies["user_cookie"];
                    role = UserController.validateUserRole(check_cookie["username"]);
                }
                else
                {
                    role = UserController.validateUserRole(Session["username_session"].ToString());
                }

                if (role.Equals("Staff"))
                {
                    GV_For_Staff.DataSource = UserController.datasourceForStaff();
                    GV_For_Staff.DataBind();
                }else if (role.Equals("Admin"))
                {
                    GV_For_Staff.DataSource = UserController.datasourceForAdmin();
                    GV_For_Staff.DataBind();
                }
                else
                {
                    GV_For_Staff.Attributes["style"] = "visibility: hidden";
                }
            }

            // reading from cookies and session for user info
            if (Request.Cookies.Equals("check_cookie"))
            {
                HttpCookie check_cookie = Request.Cookies["user_cookie"];
                username_label.Text = check_cookie["username"].ToString();
            }
            if (Session["username_session"] != null)
            {
                username_label.Text = Session["username_session"].ToString();
            }
            else
            {
                Response.Redirect("~/View/Login.aspx");
            }

            string userRole = UserController.validateUserRole(username_label.Text);
            username_label.Text = "Name: " + username_label.Text;
            role_label.Text = "Role: " + userRole;

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



        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddHours(-2);
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }

        protected void manage_rmn_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen.aspx");
        }
    }
}