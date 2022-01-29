using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01WstepAplikacjaWebowa
{
    public partial class Kalkulator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        protected void btnPrzycisk_Click(object sender, EventArgs e)
        {
             txtWyswietlacz.Text+= ((Button)sender).Text;
        }

        protected void btnRownasie_Click(object sender, EventArgs e)
        {
            Tools.Kalkulator k = new Tools.Kalkulator();
            int wynik= k.PodajWynik(txtWyswietlacz.Text);
            txtWyswietlacz.Text = Convert.ToString(wynik);
        }
    }
}