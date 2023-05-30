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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            // main
            string username = username_txb.Text;
            string email = email_txb.Text;
            string password = password_txb.Text;
            string cpassword = cpassword_txb.Text;
            string gender = gender_btn.SelectedValue;



            status_lbl.Text = UserController.validateUserRegistry(username, email, gender, password, cpassword);
            if (status_lbl.Text.Equals("success!"))
            {
                Response.Redirect("~/View/Login.aspx");
            }
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}