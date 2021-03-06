using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class LogowanieView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(Login1.UserName, Login1.Password) == true)
            {
                Login1.Visible = true;
                Session["user"] = User.Identity.Name;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
            }
            else
            {
                Response.Write("Invalid Login");
            }
        }
    }
}