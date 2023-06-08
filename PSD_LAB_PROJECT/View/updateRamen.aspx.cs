using PSD_LAB_PROJECT.Controller;
using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class updateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            Raman ramen = new Raman();
            ramen = RamenController.checkExistence(id);
            if(ramen != null)
            {
                curr_name_lbl.Text += ramen.Name;
                curr_broth_lbl.Text += ramen.Broth;
                curr_price_lbl.Text += ramen.Price;
                curr_meat_lbl.Text += ramen.Meat.name;
            }
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            string name = edited_name_txb.Text;
            string meat = rmn_meat_opt.SelectedValue;
            string broth = edited_broth_txb.Text;
            string price = edited_price_txb.Text;

            int id = int.Parse(Request.QueryString["ID"]);

            string status = RamenController.ramenUpdate(id, name, meat, broth, price);
            
            if (status.Equals("success!"))
            {
                Response.Redirect("~/View/ManageRamen.aspx");
            }
        }
        protected void GoBack_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageRamen.aspx");
        }
    }
}