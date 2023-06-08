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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie currCookie = Request.Cookies["user_cookie"];
            if (currCookie != null)
            {
                HttpCookie check_cookie = Request.Cookies["user_cookie"];
                username_txb.Text = check_cookie["username"];
                password_txb.Text = check_cookie["password"];
            }
            

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            
            string username = username_txb.Text;
            string password = password_txb.Text;

            status_lbl.Text =  UserController.validateUserLogin(username, password);
            if (status_lbl.Text.Equals("success!"))
            {
                    if (remember_me_chck.Checked)
                    {
                        HttpCookie user_cookie = new HttpCookie("user_cookie");
                        DateTime currentTime = DateTime.Now;
                        user_cookie.Expires = currentTime.AddDays(1);
                        user_cookie["username"] = username;
                        user_cookie["password"] = password;
                        Response.Cookies.Add(user_cookie);

                    }

                Session["username_session"] = username;

                // redirect
                Response.Redirect("~/View/home.aspx");
            }
            }

        

        protected void register_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }
    }
}