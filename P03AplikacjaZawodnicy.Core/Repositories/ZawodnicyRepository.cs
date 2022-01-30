using P03AplikacjaZawodnicy.Core.Domains;
using P03AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Core.Repositories
{
    public class ZawodnicyRepository
    {

        public ZawodnikVM[] Zawodnicy;

        private const int wielkoscStrony = 5;


        public void Wczytaj()
        {
            Wczytaj(null);
        }

        public void Wczytaj(string[] soc)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnicy = db.Zawodnik.Select(x => new ZawodnikVM(x.imie, x.nazwisko, soc)
            {
                Id_zawodnika = x.id_zawodnika,
                Kraj = x.kraj,
                DataUrodzenia = (DateTime)x.data_ur,
                Waga = (int)x.waga,
                Wzrost = (int)x.wzrost,
                DataZatrudnieniaOd = (DateTime)x.dataZatrudnieniaOd,
                DataZatrudnieniaDo = (DateTime)x.dataZatrudnieniaDo

            })
                .ToArray();
        }

        public void Sortuj(string poCzymSortuje)
        {
            if (poCzymSortuje == "Imie i nazwisko")
                Zawodnicy = Zawodnicy.OrderBy(x => x.ImieNazwisko).ToArray();

            if (poCzymSortuje == "Kraj")
                Zawodnicy = Zawodnicy.OrderBy(x => x.Kraj).ToArray();

            if (poCzymSortuje == "Data ur")
                Zawodnicy = Zawodnicy.OrderBy(x => x.DataUrodzenia).ToArray();

            if (poCzymSortuje == "Waga")
                Zawodnicy = Zawodnicy.OrderBy(x => x.Waga).ToArray();

            if (poCzymSortuje == "Wzrost")
                Zawodnicy = Zawodnicy.OrderBy(x => x.Wzrost).ToArray();
        }

        public ZawodnikVM PodajZawodnika(int id)
        {
            return Zawodnicy.FirstOrDefault(x => x.Id_zawodnika == id);
        }

        public void Dodaj(ZawodnikVM z)
        {
            Zawodnik nowy = new Zawodnik()
            {
                imie = z.Imie,
                nazwisko = z.Nazwisko,
                kraj = z.Kraj,
                data_ur = z.DataUrodzenia,
                wzrost = z.Wzrost,
                waga = z.Waga
            };

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            db.Zawodnik.InsertOnSubmit(nowy);
            db.SubmitChanges();
        }

        public void Edytuj(ZawodnikVM z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == z.Id_zawodnika);

            doEdycji.imie = z.Imie;
            doEdycji.nazwisko = z.Nazwisko;
            doEdycji.kraj = z.Kraj;
            doEdycji.data_ur = z.DataUrodzenia;
            doEdycji.waga = z.Waga;
            doEdycji.wzrost = z.Wzrost;

            db.SubmitChanges();
        }

        public void Usun(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            var z = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);

            db.Zawodnik.DeleteOnSubmit(z);
            db.SubmitChanges();
        }

        public void Filtruj(DateTime? dataOd, DateTime? dataDo)
        {
            //Zawodnicy= Zawodnicy.Where(x => x.DataZatrudnieniaOd >= dataOd && x.DataZatrudnieniaDo <= dataDo).ToArray();
            //if (dataOd != null)
            //    Zawodnicy = Zawodnicy.Where(x => x.DataZatrudnieniaOd >= dataOd).ToArray();

            //if (dataDo != null)
            //    Zawodnicy = Zawodnicy.Where(x => x.DataZatrudnieniaDo <= dataDo).ToArray();

            if (dataOd != null)
                Zawodnicy = Zawodnicy.Where(x => x.DataZatrudnieniaOd >= dataOd && x.DataZatrudnieniaOd <= dataDo).ToArray();
        }

        public void Strona(int s)
        {
          
            Zawodnicy = Zawodnicy
                .Skip((s - 1) * wielkoscStrony)
                .Take(wielkoscStrony)
                .ToArray();
        }
        public void Filtruj(string coSzukam)
        {
            coSzukam = coSzukam.ToLower();
           Zawodnicy= Zawodnicy.Where(x =>
                x.Imie.ToLower().Contains(coSzukam) ||
                x.Nazwisko.ToLower().Contains(coSzukam) ||
                x.Kraj.ToLower().Contains(coSzukam) ||
                x.DataUrodzenia.ToString("ddMMyyyy").Contains(coSzukam) ||
                x.Waga.ToString().Contains(coSzukam) ||
                x.Wzrost.ToString().Contains(coSzukam)
                ).ToArray();
        }
    }
}


/* Form1 (UI) 
 * ManagerZawodnikow (CRUD)
 * PolaczenieZBaza
 * Baza danych
 */