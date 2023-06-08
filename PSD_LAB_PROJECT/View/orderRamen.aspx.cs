using Newtonsoft.Json;
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
    public partial class orderRamen : System.Web.UI.Page
    {
        private static List<Order> ramens = new List<Order>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = "";
            string userRole = "";
            if(Request.Cookies["user_cookie"] != null)
            {
                HttpCookie mycookie = Request.Cookies["user_cookie"];
                username = mycookie["username"].ToString();
                User user = UserController.getUserData(username);
                userRole = user.Role.name;
            }
            else if(Session["username_session"] != null)
            {
                username = Session["username_session"].ToString();
                User user = UserController.getUserData(username);
                userRole = user.Role.name;
            }
            else
            {
                Response.Redirect("~/View/Login.aspx");
            }

            if(Session["order_session"] != null)
            {
                string x = Session["order_session"].ToString();
                ramens = JsonConvert.DeserializeObject<List<Order>>(x);
                if(userRole == "Customer")
                {
                buy_cart_btn.Attributes["style"] = "visibility: visible";
                clear_cart_btn.Attributes["style"] = "visibility: visible";
                }
            }
            if (!IsPostBack)
            {
                // data sources
                RamenView.DataSource = RamenController.datasourceForRamenMenu();
                RamenView.DataBind();

                CartView.DataSource = ramens;
                CartView.DataBind();
            }

        }

        // decrease quantity
        protected void RamenView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rows = RamenView.Rows[e.RowIndex];
            Order ramenOrders = ramens.Where((xo) => xo.ramenName.Equals(rows.Cells[1].Text)).FirstOrDefault();
            if (ramenOrders != null)
            {
                int index = ramens.FindIndex(xz => xz.ramenName.Equals(ramenOrders.ramenName));
                if(ramens[index].ramenQuantity > 1)
                {
                    ramens[index].ramenQuantity--;
                }
                else
                {
                    ramens.RemoveAt(index);
                }
            }
            string x = JsonConvert.SerializeObject(ramens);
            Session["order_session"] = x;
            Response.Redirect("~/View/orderRamen.aspx");
        }

        // increase quantity
        protected void RamenView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow rows = RamenView.Rows[e.NewEditIndex];
            Order ramenOrders = ramens.Where((xo) => xo.ramenName.Equals(rows.Cells[1].Text)).FirstOrDefault();
            if(ramenOrders == null)
            {
                ramenOrders = new Order
                {
                    ramenName = rows.Cells[1].Text,
                    ramenQuantity = 1
                };
                ramens.Add(ramenOrders);
            }
            else
            {
                int index = ramens.FindIndex(xz => xz.ramenName.Equals(ramenOrders.ramenName));
                ramens[index].ramenQuantity++;
            }
            string x = JsonConvert.SerializeObject(ramens);
            Session["order_session"] = x;
            Response.Redirect("~/View/orderRamen.aspx");
        }

        protected void buy_cart_btn_Click(object sender, EventArgs e)
        {

        }

        protected void clear_cart_btn_Click(object sender, EventArgs e)
        {
            ramens.RemoveAll((xo) => xo.ramenQuantity > 0);
        }
    }
    public class Order
    {
        public string ramenName { get; set; }
        public int ramenQuantity { get; set; }
    }
}