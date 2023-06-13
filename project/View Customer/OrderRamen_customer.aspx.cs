using project.Controler;
using project.Model;
using project.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View_Customer
{
    public partial class OrderRamen_customer : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Object> ramenOrder = orderRamenRepo.GetRamens();
            cartGV.DataSource = ramenOrder;
            cartGV.DataBind();
        }

        protected void orderRamenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hompage_customer.aspx");
        }
    }
}