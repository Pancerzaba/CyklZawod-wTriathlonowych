using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Organizator : Osoba
    {
        public Organizator(string imie, string nazwisko, string nr_tel, string adres, int rok_ur) : base(imie, nazwisko, nr_tel, adres, rok_ur)
        {
        }
    }
}
