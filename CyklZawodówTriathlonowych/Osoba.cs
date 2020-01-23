using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string nr_tel;
        protected string adres;
        protected int rok_ur;

        public Osoba(string imie, string nazwisko, string nr_tel, string adres, int rok_ur)
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

        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
           
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }

        }
        public string Adrea
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }

        }
        public string NrTel
        {
            get
            {
                return nr_tel;
            }
            set
            {
                nr_tel = value;
            }

        }
        public int Wiek
        {
            get
            {
                int wiek=2020-rok_ur;
                return wiek;
            }
            set
            {
                Wiek = value;
            }

        }




        /*public static Osoba Create()
         {
             return new Osoba("Jan", "Kowalski", 506213987","Filipa 3/11 olsztyn", 2000);
         }*/
    }
}
