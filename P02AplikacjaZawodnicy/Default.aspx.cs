using P03AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                Odswiez();
        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("SzczegolyView.aspx");
        }

        protected void btnEdytuj_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbDane.SelectedValue);
            Response.Redirect("SzczegolyView.aspx?id="+id);
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int id = Convert.ToInt32(lbDane.SelectedValue);
            zr.Usun(id);
            Odswiez();
        }
        private void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Wczytaj();

            lbDane.DataSource = zr.Zawodnicy;
            lbDane.DataTextField = "ImieNazwisko";
            lbDane.DataValueField = "Id_zawodnika";
            lbDane.DataBind();
        }
    }
}