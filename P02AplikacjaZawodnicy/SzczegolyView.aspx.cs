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
            string idString = Request["id"];
            if (!Page.IsPostBack && !string.IsNullOrEmpty(idString))
            {
                int id = Convert.ToInt32(idString);

                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.Wczytaj();
                var z = zr.PodajZawodnika(id);

                txtImie.Text = z.Imie;
                txtNazwisko.Text = z.Nazwisko;
                txtKraj.Text = z.Kraj;
                calDataUrodzenia.SelectedDate = calDataUrodzenia.VisibleDate = z.DataUrodzenia;
                txtWaga.Text = z.Waga.ToString();
                txtWzrost.Text = z.Wzrost.ToString();
            }

           

        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            string idString = Request["id"];

            ZawodnicyRepository zr = new ZawodnicyRepository();
           
            ZawodnikVM z = new ZawodnikVM();
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj= txtKraj.Text;
            z.DataUrodzenia = calDataUrodzenia.SelectedDate;
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);

            if (string.IsNullOrEmpty(idString)) // jestesmy w trybie dodwania bo id w request jest puste 
                zr.Dodaj(z);
            else // jezeli id nie jest puste to jestesmy w trybie edycji 
            {
                int id = Convert.ToInt32(idString);
                z.Id_zawodnika = id;
                zr.Edytuj(z);
            }
           
            Response.Redirect("Default.aspx");
        }
    }
}