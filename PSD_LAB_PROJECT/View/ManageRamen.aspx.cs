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


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rows = GridView1.Rows[e.RowIndex];
            int Id = int.Parse(rows.Cells[1].Text) ;
            RamenController.ramenDelete(Id);
            Response.Redirect("~/View/ManageRamen.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow rows = GridView1.Rows[e.NewEditIndex];
            string Id = rows.Cells[1].Text;
            Response.Redirect("~/View/updateRamen.aspx?ID=" + Id);
        }
    }
}