using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P05PrzetwarzanieDanychAsynchroniczne
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWynik_Click(object sender, EventArgs e)
        {
            lblWynik.Text = 
                Convert.ToString(
                Convert.ToInt32(txtLiczba1.Text) + Convert.ToInt32(txtLiczba2.Text));
        }
    }
}