using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Osoba
    {
        string imie;
        string nazwisko;
        int nr_tel;
        string adres;
        int rok_ur;

        public Osoba(string imie, string nazwisko, int nr_tel, string adres, int rok_ur)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nr_tel = nr_tel;
            this.adres = adres;
            this.rok_ur = rok_ur;
        }

        enum status
        {
            uczestnik, wolontariusz, pracownik
        }      

   
        public static Osoba Create()
        {
            return new Osoba("Jan", "Kowalski", 506213987,"Filipa 3/11 olsztyn", 2000);
        }
    }
}
