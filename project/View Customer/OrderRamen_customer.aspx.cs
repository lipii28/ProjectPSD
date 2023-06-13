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
        private List<orderRamenRepo.Data> getList()
        {
            List<orderRamenRepo.Data> ramen = (List<orderRamenRepo.Data>)Session["Ramen"];
            return ramen;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Object> ramenList = orderRamenRepo.getRamen();
            cartGV.DataSource = ramenList;
            cartGV.DataBind();
        }

        protected void orderRamenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ramen ramen = orderRamenRepo.getRamen(int.Parse(orderRamenGV.SelectedRow.Cells[1].Text));
            ramenNameTxt.Text = ramen.ramenName;
            ramenBorthTxt.Text = ramen.ramenBorth;
            ramenPriceTxt.Text = ramen.ramenPrice;*/
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            List<orderRamenRepo.Data> ramen = (List<orderRamenRepo.Data>)Session["Ramen"];

        }

        protected void selectedBtn_Click(object sender, EventArgs e)
        {

        }
    }
}