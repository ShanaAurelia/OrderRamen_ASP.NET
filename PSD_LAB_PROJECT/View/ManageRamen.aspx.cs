using PSD_LAB_PROJECT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB_PROJECT.View
{
    public partial class ManageRamen1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = RamenController.getRamenData();
            GridView1.DataBind();
        }

        protected void insert_rmn_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertRamen.aspx");
        }

    }
}