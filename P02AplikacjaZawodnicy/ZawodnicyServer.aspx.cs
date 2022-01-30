using P03AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class ZawodnicyServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string coSzukam = Request["filtr"];

            ZawodnicyRepository zr = new ZawodnicyRepository();

            zr.Wczytaj();
            zr.Filtruj(coSzukam);

            //  string wynik = string.Join("\n", zr.Zawodnicy.Select(x => x.ImieNazwisko));

            JavaScriptSerializer js = new JavaScriptSerializer(); // narzedzie, kore pozwala nam na serializacje dowolnyhc obiektow na string w formacie JSON
            string wynik = js.Serialize(zr.Zawodnicy);


            Thread.Sleep(4000);

            Response.Write(wynik);
        }
    }
}