using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    internal class Zawodnik : Osoba, IZawodnika
    {
        protected int nrStartowy;
        protected int liczbaStartow;
        protected bool plec;  
        public Zawodnik(string imie, string nazwisko, string nr_tel, string adres, int rok_ur) : base(imie, nazwisko, nr_tel, adres, rok_ur)
        {
        }
        public void WyswietlDaneOsobowe()
        {
            Console.WriteLine("Moje imie to {0}, nazwisko: {1}, nr telrfonu: {2}, adres {3}", imie, nazwisko, nr_tel, adres);
        }
        public void ZapiszSie()
        {
            Console.WriteLine("Zapisano na zawody");
        }
        public void ZobaczZawody()
        {
            Console.WriteLine("Pokazuje zawody");
        }
        public void IleLat()
        {
            int wiek = DateTime.Now.Year - rok_ur;
            Console.WriteLine("Mam {0} lat", wiek);

        }
    }
}
