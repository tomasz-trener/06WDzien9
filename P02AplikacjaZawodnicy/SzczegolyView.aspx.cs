using P03AplikacjaZawodnicy.Core.Repositories;
using P03AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class SzczegolyView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request["id"]);

                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.Wczytaj();
                var z = zr.PodajZawodnika(id);

                txtImie.Text = z.Imie;
                txtNazwisko.Text = z.Nazwisko;
                txtKraj.Text = z.Kraj;
                calDataUrodzenia.SelectedDate = z.DataUrodzenia;
                txtWaga.Text = z.Waga.ToString();
                txtWzrost.Text = z.Wzrost.ToString();
            }

           

        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int id = Convert.ToInt32(Request["id"]);
            ZawodnikVM z = new ZawodnikVM();
            z.Id_zawodnika = id;
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj= txtKraj.Text;
            z.DataUrodzenia = calDataUrodzenia.SelectedDate;
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);

            zr.Edytuj(z);

            Response.Redirect("Default.aspx");
        }
    }
}