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

        }
        public void zapiszSie()
        {

        }
        public void zobaczZawody()
        {

        }
    }
}
