using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderRamen_customer.aspx");
        }

        protected void history_Click(object sender, EventArgs e)
        {
            Response.Redirect("History_customer.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile_customer.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}