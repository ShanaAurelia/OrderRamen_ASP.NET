using PSD_LAB_PROJECT.Controller;
using PSD_LAB_PROJECT.Handler;
using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["user_cookie"];
            if(myCookie != null)
            {
            User user = UserController.getUserData(myCookie["username"].ToString());
            if(user != null)
            {
                curr_username_lbl.Text = user.Username;
                curr_email_lbl.Text = "Current Email: " + user.Email;
                curr_password_lbl.Text = "Current Password: " + user.Password;
                curr_gender_lbl.Text = "Current Gender: " + user.Gender;
            }
            }
            else if(Session["username_session"] != null)
            {
                User user = UserController.getUserData(Session["username_session"].ToString());
                if (user != null)
                {
                    curr_username_lbl.Text = user.Username;
                    curr_email_lbl.Text += "Current Email: " + user.Email;
                    curr_password_lbl.Text = "Current Password: " + user.Password;
                    curr_gender_lbl.Text = "Current Gender: " + user.Gender;
                }
            }
            else
            {
                Response.Redirect("~/View/Login.aspx");
            }

        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            string username = new_username_txb.Text;
            string password = new_password_txb.Text;
            string email = new_email_txb.Text;
            string gender = gender_btn.SelectedValue;

            string status = UserController.updateUserRegistry(curr_username_lbl.Text ,username, gender, email, password);
            
            // replacing cookies and sessions
            if(Request.Cookies["user_cookie"] != null)
            {
            HttpCookie myCookie = Request.Cookies["user_cookie"];

                Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);

                HttpCookie user_cookie = new HttpCookie("user_cookie");
            DateTime currentTime = DateTime.Now;
            user_cookie.Expires = currentTime.AddDays(1);
            user_cookie["username"] = username;
            user_cookie["password"] = password;
            Response.Cookies.Add(user_cookie);

            }
            Session["username_session"] = username;

            if (status.Equals("success!")){
                Response.Redirect("~/View/Profile.aspx");
            }
        }
    }
}