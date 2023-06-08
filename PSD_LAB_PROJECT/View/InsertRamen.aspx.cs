using PSD_LAB_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class InsertRamen1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_rmn_btn_Click(object sender, EventArgs e)
        {
            string name = rmn_name_txb.Text;
            string meat = rmn_meat_opt.SelectedValue;
            string broth = rmn_broth_txb.Text;
            string price = rmn_price_txb.Text;
            status_lbl.Text = RamenController.validateRamenRegistry(name, meat, broth, price);
            if (status_lbl.Text.Equals("success!"))
            {
                Response.Redirect("~/View/ManageRamen.aspx");
            }
        }

        protected void go_back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen.aspx");
        }
    }
}