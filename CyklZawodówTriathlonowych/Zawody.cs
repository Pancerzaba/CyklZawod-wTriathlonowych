using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyklZawodówTriathlonowych
{
    class Zawody : Miejsca, IZawody
    {
        protected string nazwaImprezy;
        protected string miejsce;
        protected string data;
        protected int iloscNumerowStartowych;
   
        public Zawody(string adres, string wielkosc, int maxStartujacych, string nazwaImprezy, string miejsce, string data, int iloscNumerowStartowych) : base(adres, wielkosc, maxStartujacych)
        {
            this.nazwaImprezy = nazwaImprezy;
            this.miejsce = miejsce;
            this.data = data;
            this.iloscNumerowStartowych = iloscNumerowStartowych;
        }

  

        public void WyswietlZawodnikow()
        {
            Console.WriteLine("Mamy {0} zawodnikow", iloscNumerowStartowych);

        }
        public void PokazMiejsce()
        {
            Console.WriteLine("Pokazuje miejsce zawodów");
        }


        
    }
}
