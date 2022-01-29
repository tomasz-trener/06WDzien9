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
    public partial class SzczegolyNowe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            string idString = Request["id"];
            if (!Page.IsPostBack)  // jezeli to nie jest postback czyli jest to pierwsze zaladowanie strony
            {
                if (!string.IsNullOrEmpty(idString)) // i jednoczesnie jestesmy w trybie edycji 
                {
                    int id = Convert.ToInt32(idString);

                    ZawodnicyRepository zr = new ZawodnicyRepository();
                    zr.Wczytaj();
                    var z = zr.PodajZawodnika(id);

                    txtImie.Text = z.Imie;
                    txtNazwisko.Text = z.Nazwisko;
                    txtKraj.Text = z.Kraj;
                    txtDataUr.Text = z.DataUrodzenia.ToString("dd-MM-yyyy");
                    txtWaga.Text = z.Waga.ToString();
                    txtWzrost.Text = z.Wzrost.ToString();
                    lblImieNazwisko.Text = z.ImieNazwisko;
                }
                else // jestesmy w trybie dodwania nowego zawodnika 
                {
                    btnUsun.Visible = false;
                }
               
            }

        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            string idString = Request["id"];

            ZawodnicyRepository zr = new ZawodnicyRepository();

            ZawodnikVM z = new ZawodnikVM();
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
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

            Response.Redirect("ZawodnicyView.aspx");
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            string idString = Request["id"];
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Usun(Convert.ToInt32(idString));
            Response.Redirect("ZawodnicyView.aspx");
        }
    }
}