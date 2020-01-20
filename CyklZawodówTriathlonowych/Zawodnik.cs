using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    internal class Zawodnik : Osoba
    {
        int nrStartowy;
        int liczbaStartow;
        bool plec;  
        public Zawodnik(string imie, string nazwisko, string nr_tel, string adres, int rok_ur) : base(imie, nazwisko, nr_tel, adres, rok_ur)
        {
        }
    }
}
