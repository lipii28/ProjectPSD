using project.Controler;
using project.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project.View_Universal
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string nama = Username.Text;
            string email = Email.Text;
            string password = Password.Text;
            string confirm = Confirmpassword.Text;
            string gender = RadioButtonList1.SelectedValue;

            Usercontroler.Validasi(nama, email, password, confirm, gender);
        }
    }
}