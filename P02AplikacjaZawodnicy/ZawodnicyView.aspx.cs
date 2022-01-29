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
    public partial class ZawodnicyView : System.Web.UI.Page
    {
        public ZawodnikVM[] ZawodnicyData; 

        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Wczytaj();
            ZawodnicyData = zr.Zawodnicy;

        }
    }
}