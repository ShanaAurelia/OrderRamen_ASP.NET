using PSD_LAB_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string role = "";
            string username = "";
            if (!IsPostBack)
            {
                if (Request.Cookies["user_cookie"] != null)
                {
                    HttpCookie check_cookie = Request.Cookies["user_cookie"];
                    role = UserController.validateUserRole(check_cookie["username"].ToString());
                    username = check_cookie["username"];
                }
                else
                {
                    role = UserController.validateUserRole(Session["username_session"].ToString());
                    username = Session["username_session"].ToString();
                }

                if (role.Equals("Staff"))
                {
                    GV_For_Staff.DataSource = UserController.datasourceForStaff();
                    GV_For_Staff.DataBind();
                }
                else if (role.Equals("Admin"))
                {
                    GV_For_Staff.DataSource = UserController.datasourceForAdmin();
                    GV_For_Staff.DataBind();
                }
                else
                {
                    GV_For_Staff.Attributes["style"] = "visibility: hidden";
                }
            }

            username_label.Text = "Name: " + username;
            role_label.Text = "Role: " + role;
        }
    }
}