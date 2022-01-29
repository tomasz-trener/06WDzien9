using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01WstepAplikacjaWebowa.Tools
{
    class Kalkulator
    {
        public int PodajWynik(string rownanie)
        {     
            rownanie = rownanie.Replace(" ", "");
            string[] tab1 = rownanie.Split('+');   // 23+500
            string[] tab2 = rownanie.Split('-');
            string[] tab3 = rownanie.Split('*');
            string[] tab4 = rownanie.Split('/');
            if (tab1.Length == 2)
                return Convert.ToInt32(tab1[0]) + Convert.ToInt32(tab1[1]);

            if (tab2.Length == 2)
                return Convert.ToInt32(tab2[0]) - Convert.ToInt32(tab2[1]);

            if (tab3.Length == 2)
                return Convert.ToInt32(tab3[0]) * Convert.ToInt32(tab3[1]);

            if (tab4.Length == 2)
                return Convert.ToInt32(tab4[0]) / Convert.ToInt32(tab4[1]);

            throw new Exception("Nieobsluzona operacja");
        }
    }
}
